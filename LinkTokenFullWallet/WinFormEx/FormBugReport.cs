using System;
using System.Text;
using System.Windows.Forms;
using ihslib.Utils;

namespace LinkTokenFullWallet.WinFormEx
{
    public partial class FormBugReport : Form
    {
        #region 全局变量
        Exception _bugInfo;
        #endregion

        /// <summary>
        /// Bug发送窗体
        /// </summary>
        /// <param name="bugInfo">Bug信息</param>
        public FormBugReport(Exception bugInfo)
        {
            InitializeComponent();
            _bugInfo = bugInfo;
            lbErrNo.Text = Guid.NewGuid().ToString();
        }

        /// <summary>
        /// 提示Bug
        /// </summary>
        /// <param name="bugInfo">Bug信息</param>
        public static void ShowBug(Exception bugInfo)
        {
            new FormBugReport(bugInfo).ShowDialog();
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("错误信息： " + _bugInfo.Message + "\r\n错误跟踪报告：\r\n" + _bugInfo.StackTrace);

            MessageBox.Show(GetBugInfo(), "系统异常");
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (chkSend.Checked)
            {
                var email = new EMailUtil("iHomeSoft@163.com", "cc9SOL1sgdNp", "smtp.163.com");
                email.mailToList.Add("iHomeSoft@163.com");
                string head = $"软件异常报告：【{Program.softname}】-【{_bugInfo.Message}】";
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("【上报时间】：" + DateTime.Now.ToString());
                sb.AppendLine("【异常编号】:" + lbErrNo.Text);
                sb.AppendLine("【信息描述】：" + txtMsg.Text.Trim());
                sb.AppendLine("【联系方式】：" + txtPhone.Text.Trim());
                sb.AppendLine(GetBugInfo());
                string body = sb.ToString();
                email.Send(head, body, false);
            }
            if (chkRebot.Checked)
                Application.Restart();
            this.Close();
        }

        private void FormBugReport_Load(object sender, EventArgs e)
        {

        }

        private string GetBugInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("**************************异常详细信息**************************");
            sb.AppendLine("【出现时间】：" + DateTime.Now.ToString());
            sb.AppendLine("【异常类型】：" + _bugInfo.GetType().Name);
            sb.AppendLine("【异常信息】：" + _bugInfo.Message);
            sb.AppendLine("【异常方法】：" + _bugInfo.TargetSite);
            sb.AppendLine("【堆栈调用】：\r\n" + _bugInfo.StackTrace);
            sb.AppendLine("***************************************************************");
            return sb.ToString();
        }
    }
}
