using LinkTokenFullWallet.WinFormEx;
using System;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    public partial class FormPassword : Form
    {
        public FormPassword()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var pwd1 = txtPassword1.Text.Trim();
            var pwd2 = txtPassword2.Text.Trim();
            if (pwd1.Length < 8 || pwd2.Length < 8)
            {
                EasyMsg.ShowTips("密码长度不能小于8位！");
                return;
            }
            if (pwd1 != pwd2)
            {
                EasyMsg.ShowTips("两次密码输入不一致！");
                return;
            }
            string address = KeyStoreEx.GenerateKeyStore(pwd1, GlobalVar.keystore_path);
            FormMain main = (FormMain)this.Owner;
            main.AddNewAccount(address);
            this.Close();
        }
    }
}
