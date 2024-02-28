using Serilog;
using System.Diagnostics;
using System.Windows.Input;

namespace TelegramAutomationWithRequest.Helper
{
    public class InstallerHelper
    {

        public static bool IsDotnet7SDKInstalled()
        {
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "dotnet";
                process.StartInfo.Arguments = "--version";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();

                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                if (!string.IsNullOrEmpty(output) && output.Contains("7.")) // Kiểm tra nếu phiên bản 7.x
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (ví dụ: "dotnet" không được tìm thấy)
                Log.Error("An error occurred: " + ex.Message);
            }

            return false;
        }

        public static bool InstallDotnetSDK(string DotnetSDKInstallerPath)
        {
            try
            {
                if (!File.Exists(DotnetSDKInstallerPath))
                {
                    Log.Error("Installer file does not exist.");
                    return false;
                }

                string folder = Path.Combine(Environment.CurrentDirectory, "Environment");
                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.WorkingDirectory = folder;
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.Verb = "runas";
                process.StartInfo = processStartInfo;
                process.Start();

                // Chạy trình cài đặt .NET SDK
                process.StandardInput.WriteLine(DotnetSDKInstallerPath);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Log.Information(".NET SDK installed successfully.");
                    return true;
                }
                else
                {
                    Log.Error(".NET SDK installation failed with exit code: " + process.ExitCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred: " + ex.Message);
                return false;
            }
        }
        public static bool IsSqlLocalDBInstalled()
        {
            bool result = false;
            try
            {
                Process process = new Process();
                process.StartInfo.FileName = "sqllocaldb";
                process.StartInfo.Arguments = "v";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;
                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Kiểm tra phiên bản LocalDB
                if (output.Contains("Microsoft SQL Server 2019"))
                {
                    result = true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred: " + ex.Message);
                // Có thể xử lý ngoại lệ ở đây hoặc ghi lại lỗi
                result = false;
            }

            return result;
        }

        public static bool InstallSqlLocalDB(string SqlLocalDBInstallerPath)
        {
            try
            {
                if (!File.Exists(SqlLocalDBInstallerPath))
                {
                    Console.WriteLine("Installer file does not exist.");
                    return false;
                }

                string folder = Path.Combine(Environment.CurrentDirectory, "Environment");
                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.WorkingDirectory = folder;
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.Verb = "runas";
                process.StartInfo = processStartInfo;
                process.Start();

                // Chạy trình cài đặt SQL Server LocalDB
                process.StandardInput.WriteLine(SqlLocalDBInstallerPath);
                process.StandardInput.Flush();
                process.StandardInput.Close();
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Log.Information("SQL Server LocalDB installed successfully.");
                    return true;
                }
                else
                {
                    Log.Error("SQL Server LocalDB installation failed with exit code: " + process.ExitCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred: " + ex.Message);
                // Có thể xử lý ngoại lệ ở đây hoặc ghi lại lỗi
                return false;
            }
        }
        public static bool IsVCRedistInstalled()
        {
            try
            {
                // Kiểm tra xem lệnh "reg" có tồn tại trên hệ thống hay không
                string systemRoot = Environment.GetEnvironmentVariable("SystemRoot");
                string regPath = Path.Combine(systemRoot, "System32", "reg.exe");

                if (!File.Exists(regPath))
                {
                    Log.Error("The 'reg' command is not available on this system.");
                    return false;
                }

                Process process = new Process();
                process.StartInfo.FileName = "reg";
                process.StartInfo.Arguments = "query \"HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\VisualStudio\\14.0\\VC\\Runtimes\\x64\" /reg:32";
                process.StartInfo.UseShellExecute = false;
                process.StartInfo.RedirectStandardOutput = true;
                process.StartInfo.CreateNoWindow = true;

                process.Start();
                string output = process.StandardOutput.ReadToEnd();
                process.WaitForExit();

                // Kiểm tra đầu ra để xác định tính chính xác
                if (output.Contains("Version"))
                {
                    Log.Information("Visual C++ Redistributable is installed.");
                    return true;
                }
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred: " + ex.Message);
                // Có thể xử lý ngoại lệ ở đây hoặc ghi lại lỗi
            }

            return false;
        }

        public static bool InstallVCRedist(string VCRedistInstallerPath)
        {
            try
            {
                if (!File.Exists(VCRedistInstallerPath))
                {
                    Log.Error("Installer file does not exist.");
                    return false;
                }

                string folder = Path.Combine(Environment.CurrentDirectory, "Environment");
                Process process = new Process();
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.WorkingDirectory = folder;
                processStartInfo.FileName = "cmd.exe";
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.RedirectStandardInput = true;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.Verb = "runas";
                process.StartInfo = processStartInfo;
                process.Start();

                // Chạy trình cài đặt VC++ Redistributable
                process.StandardInput.WriteLine(VCRedistInstallerPath);
                process.StandardInput.Flush();
                process.StandardInput.Close();

                // Chờ đợi quá trình cmd.exe hoàn thành và kiểm tra mã thoát
                process.WaitForExit();

                if (process.ExitCode == 0)
                {
                    Log.Information("VC++ Redistributable installed successfully.");
                    return true;
                }
                else
                {
                    Log.Error("VC++ Redistributable installation failed with exit code: " + process.ExitCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                Log.Error("An error occurred: " + ex.Message);
                // Có thể xử lý ngoại lệ ở đây hoặc ghi lại lỗi
                return false;
            }
        }

    }
}
