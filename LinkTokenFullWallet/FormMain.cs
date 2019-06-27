using LinkTokenFullWallet.WinFormEx;
using Nethereum.Web3.Accounts;
using Newtonsoft.Json;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LinkTokenFullWallet
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            SplashForm.Show();
            InitializeComponent();
            this.Size = new Size(730, 410);
            Thread.Sleep(500);
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = $"{typeof(Program).Assembly.GetName().Name} - 全节点版  V{Application.ProductVersion}      © 币合区块链";
            AnimateWindows.ShowAnimateWindow(this, 500, WinFormEx.AnimateWindows.AW_BLEND);
            wbAnalysis.Url = new Uri(Program.analysisUrl, UriKind.Absolute);

            plBlockInfo.Dock = DockStyle.Fill;
            plShowLog.Dock = DockStyle.Fill;
            plSetting.Dock = DockStyle.Fill;
            plAbout.Dock = DockStyle.Fill;
            plSend.Dock = DockStyle.Fill;
            btnBlockInfo.PerformClick();
            //btnShowLog.PerformClick();

            //加载完成关闭启动窗体
            SplashForm.Close();
            if (!Program.isUpdate)
                this.Activate();

            if (ihslib.FileHandle.FileHelper.IsExistFile(GlobalVar.lock_file))
            {
                btnInit.Enabled = false;
            }
            else
            {
                btnInit.Enabled = true;
            }
            GetStateDB();
            cBoxRpc.SelectedIndex = 0;
            BindAccount();
        }

        private void BindAccount()
        {
            cboxAccount.Items.Clear();
            DirectoryInfo folder = new DirectoryInfo(GlobalVar.keystore_path);
            var accounts = folder.GetFiles();
            foreach (FileInfo file in accounts)
            {
                if (KeyStoreEx.IsRealAddress(file.Name))
                    cboxAccount.Items.Add(file.Name);
            }
            if (cboxAccount.Items.Count > 0)
            {
                cboxAccount.SelectedIndex = 0;
            }
        }

        private void GetStateDB()
        {
            if (ihslib.FileHandle.FileHelper.IsExistFile(GlobalVar.lock_file))
            {
                return;
            }
            if (ihslib.FileHandle.FileHelper.IsExistFile(GlobalVar.state_db_local_path))
            {
                plShowLog.BringToFront();
                LogMessage("正在初始化，请稍后......");
                btnInit.PerformClick();
                return;
            }

            plDownLoad.BringToFront();
            //计算大小
            lbFileSize.Text += DownloadHelper.DownFileSize(GlobalVar.state_db_download_url);

            //开始下载
            Thread td = new Thread(DownLoad);
            td.Start();

            //计算用时
            #region 计算用时
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            lbUsedTime.Text = "已用时间：00:00";
            tm.Interval = 1000;
            tm.Enabled = true;
            int ms = 0;
            int fz = 0;
            tm.Tick += (a, x) =>
            {
                ms = ms + 1;
                if (ms == 60)
                {
                    ms = 0;
                    fz = fz + 1;
                }
                lbUsedTime.Text = "已用时间：0" + fz + ":" + (ms < 10 ? "0" + ms.ToString() : ms.ToString());
                plDownLoad.BringToFront();
                if (progressBar1.Value == progressBar1.Maximum)
                {
                    tm.Enabled = false;
                    plShowLog.BringToFront();
                    LogMessage("下载初始区块数据完成！");
                    LogMessage("正在初始化，请稍后......");
                    btnInit.PerformClick();
                }
            };
            #endregion

            //开始计算下载速度

            DownloadHelper.WebLoad(progressBar1, lbDownSpeed);
        }

        private void DownLoad()
        {

            DownloadHelper.DownloadFile(GlobalVar.state_db_download_url, GlobalVar.state_db_local_path, progressBar1, lbProgress, lbDownSize, lbRemainSize);
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //LKCLI.Stop();
            //this.FormBorderStyle = FormBorderStyle.None; 
            WinFormEx.AnimateWindows.HideAnimateWindowBlend(this, 300, WinFormEx.AnimateWindows.AW_CENTER);
        }

        void RunAction(Action action)
        {
            new Thread(new ThreadStart(action)).Start();
        }

        void UpdateUI(Action action)
        {
            if (!IsDisposed)
                BeginInvoke(action);
        }

        #region 日志记录
        private delegate void LogAppendDelegate(Color color, string msg);

        private void LogAppendMethod(Color color, string msg)
        {
            if (!richTextBox1.ReadOnly)
                richTextBox1.ReadOnly = true;

            var str = DateTime.Now.ToString("[yyyy-MM-dd HH:mm:ss] ") + msg + "\r\n";
            richTextBox1.SelectionColor = color;
            richTextBox1.AppendText(str);
            richTextBox1.Select(richTextBox1.TextLength, 0);
            richTextBox1.ScrollToCaret();
        }

        public void LogError(string msg)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppendMethod);
            richTextBox1.Invoke(la, Color.Red, msg);
        }
        public void LogMessage(string msg)
        {
            LogAppendDelegate la = new LogAppendDelegate(LogAppendMethod);
            richTextBox1.Invoke(la, Color.Green, msg);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Lines.Length > 20)
            {
                richTextBox1.Text = richTextBox1.Text.Substring(richTextBox1.Lines[0].Length + 1);
            }
        }
        #endregion


        private void btnBlockInfo_Click(object sender, EventArgs e)
        {
            plBlockInfo.BringToFront();
        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            plShowLog.BringToFront();
        }

        private void Start()
        {

        }

        private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            DataGridView myDataGridView = (DataGridView)sender;

            if (myDataGridView.Rows.Count > 0)
            {
                int i = myDataGridView.ColumnHeadersHeight;//标题行高
                int j = myDataGridView.Rows.GetRowsHeight(DataGridViewElementStates.Visible); //所有可见行总高
                int k = myDataGridView.Height; //控件高度
                int l = myDataGridView.Rows.GetLastRow(DataGridViewElementStates.Visible);//最后一行索引
                int count = myDataGridView.Columns.Count;//列总数
                int width = 0;

                //当网格未充满控件时才画线
                if (i + j < k)
                {
                    using (Brush gridBrush = new SolidBrush(myDataGridView.GridColor))
                    {
                        using (Pen gridLinePen = new Pen(gridBrush))
                        {
                            //处理标题列
                            if (myDataGridView.RowHeadersVisible)
                            {
                                width = myDataGridView.RowHeadersWidth;
                                e.Graphics.DrawLine(gridLinePen, width, i + j, width, k);
                            }
                            else
                            {
                                width = 1;
                            }

                            //处理正常列
                            for (int index = 0; index < count; index++)
                            {
                                if (myDataGridView.Columns[index].Visible)
                                {
                                    width += myDataGridView.Columns[index].Width;

                                    e.Graphics.DrawLine(gridLinePen, width, i + j, width, k);
                                }
                            }
                        }
                    }
                }
            }

        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            plShowLog.BringToFront();
            LKCLI.Init();
            LKCLI.InitEthermint();
            LKCLI.InitTendermint();
            ihslib.FileHandle.FileHelper.CreateFile(GlobalVar.lock_file);
            LogMessage("迅雷链初始化完成，正在启动，请稍后......");
            btnStart.PerformClick();
            //NewBlockInfos.GetBlockByNumber(200000);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            LKCLI.Start();
            LogMessage("迅雷链数据节点启动成功，开始同步数据......");
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            LKCLI.Stop();
            LogMessage("迅雷链数据节点已停止运行......");
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            plSetting.BringToFront();
        }

        private async void timerUpdateBlockInfo_TickAsync(object sender, EventArgs e)
        {
            if (!LKCLI.IsRunning())
            {
                return;
            }
            if (!Methods.Common.RPCServerTest())
            {
                return;
            }
            var newBlockNum = await GlobalVar.web3_local.GetBlockNumberAsync();
            lbBlockHeight.Text = newBlockNum;
            lbMainHeight.Text = await GlobalVar.web3_main.GetBlockNumberAsync();
            webNewBlock.DocumentText = await NewBlockInfos.GetNewBlockHtmlAsync(newBlockNum);
            //lbOnlineNode.Text = await GlobalVar.local_web3.GetPeerCountAsync();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            LKCLI.Restart();
            LogMessage("迅雷链数据节点重启完成，开始同步数据......");
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            plAbout.BringToFront();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            plSend.BringToFront();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSnedTransaction_Click(object sender, EventArgs e)
        {
            var keyPath = GlobalVar.keystore_path + "\\" + cboxAccount.Text;
            var keyPwd = txtKeyPwd.Text;
            Account account;
            try
            {
                account = TransactionEx.UnlockAccountFromKeyStoreFile(keyPath, keyPwd);
            }
            catch (Exception)
            {
                account = null;
            }
            if (account == null)
            {
                EasyMsg.ShowTips("密码错误！");
                return;
            }
            var trans = new TransactionEx(cBoxRpc.Text);
            var nonce = trans.GetTransactionCount(account.Address);
            var sign = trans.SignTransaction(account.PrivateKey, txtReciveAddress.Text, decimal.Parse(txtAmount.Text), nonce, account.Address);
            var msg = trans.SendRawTransaction(sign);
            if (string.IsNullOrEmpty(msg))
            {
                EasyMsg.ShowTips("网络异常，请重新尝试！");
                return;
            }
            if (msg.IndexOf("0x") == 0)
            {
                EasyMsg.ShowTips("转赠成功！\r\nhash值：" + msg);
                var balance = decimal.Parse(txtBalance.Text);
                var amount = decimal.Parse(txtAmount.Text);
                txtBalance.Text = (balance - amount).ToString();
            }
            else
            {
                EasyMsg.ShowTips("转赠失败：" + msg);
                return;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            FormPassword pwd = new FormPassword();
            pwd.ShowDialog(this);
        }

        public void AddNewAccount(string address)
        {
            cboxAccount.Items.Add(address);
            cboxAccount.SelectedItem = address;
            LogMessage("新建账户成功：\r\n" + address);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "钱包文件|*.*";
            Stream myStream = null;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = dialog.OpenFile()) != null)
                    {
                        StreamReader st = new StreamReader(dialog.FileName);
                        string str = st.ReadLine();
                        var resultJson = JsonConvert.DeserializeObject<dynamic>(str);
                        string address = "0x" + resultJson.address;
                        var targetFile = GlobalVar.keystore_path + "\\" + address;
                        var UTF8NoBom = new UTF8Encoding(false);
                        StreamWriter sw = new StreamWriter(targetFile, false, UTF8NoBom);
                        sw.Write(str);
                        sw.Close();
                        cboxAccount.Items.Add(address);
                        cboxAccount.SelectedItem = address;
                        LogMessage("导入账户成功：\r\n" + address);
                    }
                }
                catch (Exception ex)
                {
                    EasyMsg.ShowTips("导入账户失败！");
                }
            }
        }

        private void cboxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            var trans = new TransactionEx(cBoxRpc.Text);
            txtBalance.Text = trans.GetBalance(cboxAccount.Text).ToString();
        }
    }
}
