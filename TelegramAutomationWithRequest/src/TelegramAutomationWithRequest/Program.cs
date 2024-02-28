using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Win32;
using Serilog;
using System.Diagnostics;
using System.Net;
using System.Security.Principal;
using TelegramAutomationWithRequest.AutoMapper;
using TelegramAutomationWithRequest.Data;
using TelegramAutomationWithRequest.Forms;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Repositories;
using TelegramAutomationWithRequest.Repositories.Interfaces;
using TelegramAutomationWithRequest.Services;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        private static readonly IHost _host = CreateHostBuilder();
        /// </summary>
        [STAThread]
        static void Main()
        {
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(MyHandler);
            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.File("logsapp/myapp.txt", rollingInterval: RollingInterval.Day)
                .CreateLogger();
            try
            {
               
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(defaultValue: false);
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                if (!new WindowsPrincipal(WindowsIdentity.GetCurrent()).IsInRole(WindowsBuiltInRole.Administrator))
                {
                    MessageCommon.ShowMessageBox("Please Run Aplication As Administrator!", 3);
                    Environment.Exit(0);
                }
                if (string.IsNullOrEmpty((string)Properties.Settings.Default["SetupEnvironment"]))
                {
                    try
                    {
                        CheckAndInstallDependencies();
                    }
                    catch (Exception)
                    {

                    }
                    Properties.Settings.Default["SetupEnvironment"] = "Done";
                    Properties.Settings.Default.Save();
                }
                _host.Start();
                Log.Information("Application start");
                try
                {
                    var form1 = _host.Services.GetRequiredService<fLogin>();
                    Application.Run(form1);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, ex.Message);
                    if (ex.InnerException != null)
                    {
                        Log.Error(ex.InnerException.Message);
                    }
                    MessageCommon.ShowMessageBox($"Error: {ex.Message}", 4);
                    Log.Error(ex, ex.Message);
                }
                _host.StopAsync().GetAwaiter().GetResult();
                _host.Dispose();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox($"Error: {ex.Message}", 4);
                if (ex.InnerException != null)
                {
                    Log.Error(ex.InnerException.Message);
                    MessageCommon.ShowMessageBox($"Error: {ex.Message}", 4);
                }
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        static void MyHandler(object sender, UnhandledExceptionEventArgs args)
        {
            Exception e = (Exception)args.ExceptionObject;
            Log.Error("MyHandler caught : " + e.Message);
            MessageCommon.ShowMessageBox($"Error: {e.Message}", 4);
            Application.Restart();
        }
        static IHost CreateHostBuilder()
        {
            try
            {
                return Host.CreateDefaultBuilder()
                    .ConfigureServices((context, services) =>
                    {
                        services.AddScoped<fLogin>();
                        services.AddScoped<fMain>();
                        services.AddTransient<IScriptService, ScriptService>();
                        services.AddTransient<IActionsService, ActionsService>();
                        services.AddTransient<IFilesService, FilesService>();
                        services.AddTransient<IAccountsService, AccountsService>();
                        services.AddTransient<Func<IActionsService>>(provider => provider.GetService<IActionsService>);
                        services.AddTransient<IUnitOfWork, UnitOfWork>();
                        services.AddAutoMapper(cfg => cfg.AddProfile(new AutoMapperProfile()));
                        services.AddDbContext<ApplicationDbContext>(options =>
                        {
                            options.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename={Path.Combine(Environment.CurrentDirectory, "Database\\Local\\LocalDB.mdf")};Integrated Security=True");
                            options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
                            options.EnableSensitiveDataLogging();
                        }, ServiceLifetime.Transient);
                    }).Build();
            }
            catch (Exception ex)
            {
                Log.Error(ex, ex.Message);
                MessageCommon.ShowMessageBox($"Error: {ex.Message}", 4);
                return null;
            }
        }
        private static void CheckAndInstallDependencies()
        {
            // Kiểm tra .NET 7
            if (!IsDotNet7Installed())
            {
                // Nếu chưa cài đặt, tự động tải và cài đặt
                DownloadAndInstallDotNet7();
            }

            // Kiểm tra SQL LocalDB
            if (!IsSqlLocalDBInstalled())
            {
                // Nếu chưa cài đặt, tự động tải và cài đặt
                DownloadAndInstallSqlLocalDB();
            }

            // Kiểm tra Visual C++ Redistributable
            if (!IsVisualCRedistributableInstalled())
            {
                // Nếu chưa cài đặt, tự động tải và cài đặt
                DownloadAndInstallVisualCRedistributable();
            }
        }
        private static bool IsDotNet7Installed()
        {
            return IsDotNet7Installed("x86") || IsDotNet7Installed("x64");
        }

        private static bool IsDotNet7Installed(string platform)
        {
            try
            {
                // Kiểm tra xem SubKey "Full" có tồn tại không
                RegistryKey dotnetKey = Registry.LocalMachine.OpenSubKey($@"SOFTWARE\dotnet\Setup\InstalledVersions\{platform}\Full");
                if (dotnetKey != null)
                {
                    string version = dotnetKey.GetValue("Version") as string;
                    return !string.IsNullOrEmpty(version) && version.StartsWith("7");
                }
                else
                {
                    // Nếu không, kiểm tra trong SubKey "sharedhost"
                    dotnetKey = Registry.LocalMachine.OpenSubKey($@"SOFTWARE\dotnet\Setup\InstalledVersions\{platform}\sharedhost");
                    if (dotnetKey != null)
                    {
                        string version = dotnetKey.GetValue("Version") as string;
                        return !string.IsNullOrEmpty(version) && version.StartsWith("7");
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error checking .NET 7 installation: {ex.Message}");
            }

            return false;
        }
        private static void DownloadAndInstallDotNet7()
        {
            // Tự động tải và cài đặt .NET 7
            // Sử dụng WebClient để tải về từ trang chủ của Microsoft
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Thay đổi URL tải về dựa trên trang chủ của Microsoft
                    string dotnetDownloadUrl = "https://download.visualstudio.microsoft.com/download/pr/03a5170a-a4cd-458c-b5d0-e5149ee4fdcf/e9026f6fe3c3fec4a774e034d4f98ead/dotnet-sdk-7.0.404-win-x64.exe";
                    string dotnetInstallerPath = Path.Combine(Path.GetTempPath(), "dotnet7_installer.exe");

                    // Tải về
                    client.DownloadFile(dotnetDownloadUrl, dotnetInstallerPath);

                    // Chạy bộ cài đặt
                    Process.Start(dotnetInstallerPath);

                    // Đợi quá trình cài đặt kết thúc (hoặc bạn có thể kiểm tra tự động)
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error downloading/installing .NET 7: {ex.Message}");
            }
        }

        private static bool IsSqlLocalDBInstalled()
        {
            // Kiểm tra SQL LocalDB có được cài đặt không
            // Sử dụng Registry hoặc kiểm tra thông tin version trong Command Prompt

            // Ví dụ sử dụng Registry:
            try
            {
                RegistryKey sqlKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server Local DB\Installed Versions");
                if (sqlKey != null)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error checking SQL LocalDB installation: {ex.Message}");
            }

            return false;
        }

        private static void DownloadAndInstallSqlLocalDB()
        {
            // Tự động tải và cài đặt SQL LocalDB
            // Sử dụng WebClient để tải về từ trang chủ của Microsoft
            try
            {
                // Thay đổi URL tải về dựa trên trang chủ của Microsoft
                string sqlDownloadUrl = "https://download.microsoft.com/download/7/c/1/7c14e92e-bdcb-4f89-b7cf-93543e7112d1/SqlLocalDB.msi";
                string sqlInstallerPath = Path.Combine(Path.GetTempPath(), "SqlLocalDB.msi");

                // Tải về
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(sqlDownloadUrl, sqlInstallerPath);
                }

                // Chạy bộ cài đặt
                Process.Start(sqlInstallerPath);

                // Đợi quá trình cài đặt kết thúc (hoặc bạn có thể kiểm tra tự động)
            }
            catch (Exception ex)
            {
                Log.Error($"Error downloading/installing SQL LocalDB: {ex.Message}");
            }
        }

        public static bool IsVisualCRedistributableInstalled()
        {
            return IsVisualCRedistributableInstalled("x64") || IsVisualCRedistributableInstalled("x86");
        }

        private static bool IsVisualCRedistributableInstalled(string platform)
        {
            try
            {
                // Kiểm tra xem SubKey có tồn tại không
                using (RegistryKey vcKey = Registry.LocalMachine.OpenSubKey($@"SOFTWARE\Microsoft\VisualStudio\14.0\VC\Runtimes\{platform}"))
                {
                    if (vcKey != null)
                    {
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                Log.Error($"Error checking Visual C++ Redistributable installation: {ex.Message}");
            }

            return false;
        }

        private static void DownloadAndInstallVisualCRedistributable()
        {
            // Tự động tải và cài đặt Visual C++ Redistributable
            // Sử dụng WebClient để tải về từ trang chủ của Microsoft
            try
            {
                // Thay đổi URL tải về dựa trên trang chủ của Microsoft
                string vcDownloadUrl = "https://download.microsoft.com/download/9/3/F/93FCF1E7-E6A4-478B-96E7-D4B285925B00/vc_redist.x64.exe";
                string vcInstallerPath = Path.Combine(Path.GetTempPath(), "vc_redist_installer.exe");

                // Tải về
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(vcDownloadUrl, vcInstallerPath);
                }

                // Chạy bộ cài đặt
                Process.Start(vcInstallerPath);

                // Đợi quá trình cài đặt kết thúc (hoặc bạn có thể kiểm tra tự động)
            }
            catch (Exception ex)
            {
                Log.Error($"Error downloading/installing Visual C++ Redistributable: {ex.Message}");
            }
        }
    }
}