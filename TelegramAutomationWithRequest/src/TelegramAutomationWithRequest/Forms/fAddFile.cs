using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TelegramAutomationWithRequest.Helper;
using TelegramAutomationWithRequest.Services.Interfaces;

namespace TelegramAutomationWithRequest.Forms
{
    public partial class fAddFile : Form
    {
        private readonly IFilesService _filesService;
        internal static bool add = false;
        internal static string folderName = string.Empty;

        public fAddFile(IFilesService filesService)
        {
            InitializeComponent();
            _filesService = filesService;
            CommonMethods.WireUpMouseEvents(bunifuCustomLabel1, btnCancel);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CommonMethods.CloseForm(this);
        }

        private void fAddFile_Load(object sender, EventArgs e)
        {
            //try
            //{
            //    txtNameFolder.Text = jsonHelper.GetValuesFromInputString("txtNameFolder");
            //}
            //catch
            //{
            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var nameFolder = txtNameFolder.Text.Trim();
            if (nameFolder.Length == 0)
            {
                MessageCommon.ShowMessageBox("Please enter folder name!", 3);
                txtNameFolder.Focus();
            }
            else if (checkName(nameFolder))
            {
                MessageCommon.ShowMessageBox("Directory name already exists!", 3);
                txtNameFolder.Focus();
            }
            else if (_filesService.Create(nameFolder))
            {
                folderName = nameFolder;
                add = true;
                CommonMethods.CloseForm(this);
            }
            else
            {
                MessageCommon.ShowMessageBox("Error adding folder!", 4);
            }


        }
        private bool checkName(string name)
        {
            var check = _filesService.GetByName(name);
            if (check == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
