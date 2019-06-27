namespace LinkTokenFullWallet
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.wbAnalysis = new System.Windows.Forms.WebBrowser();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnConsole = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.btnShowLog = new System.Windows.Forms.Button();
            this.btnBlockInfo = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.plBlockInfo = new System.Windows.Forms.Panel();
            this.webNewBlock = new System.Windows.Forms.WebBrowser();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbMainHeight = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbBlockHeight = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.plShowLog = new System.Windows.Forms.Panel();
            this.plMain = new System.Windows.Forms.Panel();
            this.plSend = new System.Windows.Forms.Panel();
            this.btnSnedTransaction = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnImport = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboxAccount = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtReciveAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKeyPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxRpc = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.plAbout = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.plDownLoad = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lbProgress = new System.Windows.Forms.Label();
            this.lbRemainSize = new System.Windows.Forms.Label();
            this.lbDownSize = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lbDownSpeed = new System.Windows.Forms.Label();
            this.lbUsedTime = new System.Windows.Forms.Label();
            this.lbFileSize = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.plSetting = new System.Windows.Forms.Panel();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.timerUpdateBlockInfo = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.plBlockInfo.SuspendLayout();
            this.panel5.SuspendLayout();
            this.plShowLog.SuspendLayout();
            this.plMain.SuspendLayout();
            this.plSend.SuspendLayout();
            this.plAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.plDownLoad.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.plSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(200, 100);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // wbAnalysis
            // 
            this.wbAnalysis.Location = new System.Drawing.Point(700, 5);
            this.wbAnalysis.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbAnalysis.Name = "wbAnalysis";
            this.wbAnalysis.Size = new System.Drawing.Size(30, 30);
            this.wbAnalysis.TabIndex = 3;
            this.wbAnalysis.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAbout);
            this.panel1.Controls.Add(this.btnSetting);
            this.panel1.Controls.Add(this.btnConsole);
            this.panel1.Controls.Add(this.btnSend);
            this.panel1.Controls.Add(this.btnShowLog);
            this.panel1.Controls.Add(this.btnBlockInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(142, 562);
            this.panel1.TabIndex = 5;
            // 
            // btnAbout
            // 
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbout.Font = new System.Drawing.Font("宋体", 13F);
            this.btnAbout.Image = global::LinkTokenFullWallet.Properties.Resources.More_48px;
            this.btnAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAbout.Location = new System.Drawing.Point(1, 256);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(140, 50);
            this.btnAbout.TabIndex = 9;
            this.btnAbout.Text = "关于钱包";
            this.btnAbout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSetting.Font = new System.Drawing.Font("宋体", 13F);
            this.btnSetting.Image = global::LinkTokenFullWallet.Properties.Resources.Gears_48px;
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(1, 205);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(140, 50);
            this.btnSetting.TabIndex = 8;
            this.btnSetting.Text = "参数设置";
            this.btnSetting.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSetting.UseVisualStyleBackColor = true;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnConsole
            // 
            this.btnConsole.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsole.Font = new System.Drawing.Font("宋体", 13F);
            this.btnConsole.Image = global::LinkTokenFullWallet.Properties.Resources.Console_48px;
            this.btnConsole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsole.Location = new System.Drawing.Point(1, 154);
            this.btnConsole.Name = "btnConsole";
            this.btnConsole.Size = new System.Drawing.Size(140, 50);
            this.btnConsole.TabIndex = 7;
            this.btnConsole.Text = "高级命令";
            this.btnConsole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConsole.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSend.Font = new System.Drawing.Font("宋体", 13F);
            this.btnSend.Image = global::LinkTokenFullWallet.Properties.Resources.Refund_48px;
            this.btnSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSend.Location = new System.Drawing.Point(1, 52);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(140, 50);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "发送交易";
            this.btnSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnShowLog
            // 
            this.btnShowLog.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnShowLog.Font = new System.Drawing.Font("宋体", 13F);
            this.btnShowLog.Image = global::LinkTokenFullWallet.Properties.Resources.Microsoft_Excel_48px;
            this.btnShowLog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowLog.Location = new System.Drawing.Point(1, 103);
            this.btnShowLog.Name = "btnShowLog";
            this.btnShowLog.Size = new System.Drawing.Size(140, 50);
            this.btnShowLog.TabIndex = 5;
            this.btnShowLog.Text = "运行日志";
            this.btnShowLog.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowLog.UseVisualStyleBackColor = true;
            this.btnShowLog.Click += new System.EventHandler(this.btnShowLog_Click);
            // 
            // btnBlockInfo
            // 
            this.btnBlockInfo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBlockInfo.Font = new System.Drawing.Font("宋体", 13F);
            this.btnBlockInfo.Image = global::LinkTokenFullWallet.Properties.Resources.Module_48px1;
            this.btnBlockInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlockInfo.Location = new System.Drawing.Point(1, 1);
            this.btnBlockInfo.Name = "btnBlockInfo";
            this.btnBlockInfo.Size = new System.Drawing.Size(140, 50);
            this.btnBlockInfo.TabIndex = 4;
            this.btnBlockInfo.Text = "区块信息";
            this.btnBlockInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBlockInfo.UseVisualStyleBackColor = true;
            this.btnBlockInfo.Click += new System.EventHandler(this.btnBlockInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 624);
            this.panel2.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 62);
            this.panel3.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("华文新魏", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "链克钱包";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plBlockInfo
            // 
            this.plBlockInfo.Controls.Add(this.webNewBlock);
            this.plBlockInfo.Controls.Add(this.panel5);
            this.plBlockInfo.Location = new System.Drawing.Point(403, 318);
            this.plBlockInfo.Name = "plBlockInfo";
            this.plBlockInfo.Size = new System.Drawing.Size(570, 317);
            this.plBlockInfo.TabIndex = 9;
            // 
            // webNewBlock
            // 
            this.webNewBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webNewBlock.Location = new System.Drawing.Point(0, 62);
            this.webNewBlock.MinimumSize = new System.Drawing.Size(20, 20);
            this.webNewBlock.Name = "webNewBlock";
            this.webNewBlock.ScrollBarsEnabled = false;
            this.webNewBlock.Size = new System.Drawing.Size(570, 255);
            this.webNewBlock.TabIndex = 1;
            this.webNewBlock.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.lbMainHeight);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lbBlockHeight);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(570, 62);
            this.panel5.TabIndex = 0;
            // 
            // lbMainHeight
            // 
            this.lbMainHeight.AutoSize = true;
            this.lbMainHeight.Font = new System.Drawing.Font("宋体", 15F);
            this.lbMainHeight.Location = new System.Drawing.Point(425, 21);
            this.lbMainHeight.Name = "lbMainHeight";
            this.lbMainHeight.Size = new System.Drawing.Size(99, 20);
            this.lbMainHeight.TabIndex = 3;
            this.lbMainHeight.Text = "000000000";
            this.lbMainHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(285, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "主网区块高度：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbBlockHeight
            // 
            this.lbBlockHeight.AutoSize = true;
            this.lbBlockHeight.Font = new System.Drawing.Font("宋体", 15F);
            this.lbBlockHeight.Location = new System.Drawing.Point(165, 21);
            this.lbBlockHeight.Name = "lbBlockHeight";
            this.lbBlockHeight.Size = new System.Drawing.Size(99, 20);
            this.lbBlockHeight.TabIndex = 1;
            this.lbBlockHeight.Text = "000000000";
            this.lbBlockHeight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "本地区块高度：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plShowLog
            // 
            this.plShowLog.Controls.Add(this.richTextBox1);
            this.plShowLog.Location = new System.Drawing.Point(32, 29);
            this.plShowLog.Name = "plShowLog";
            this.plShowLog.Size = new System.Drawing.Size(200, 100);
            this.plShowLog.TabIndex = 0;
            // 
            // plMain
            // 
            this.plMain.Controls.Add(this.plSend);
            this.plMain.Controls.Add(this.plAbout);
            this.plMain.Controls.Add(this.plDownLoad);
            this.plMain.Controls.Add(this.plSetting);
            this.plMain.Controls.Add(this.plShowLog);
            this.plMain.Controls.Add(this.plBlockInfo);
            this.plMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plMain.Location = new System.Drawing.Point(142, 0);
            this.plMain.Name = "plMain";
            this.plMain.Padding = new System.Windows.Forms.Padding(2);
            this.plMain.Size = new System.Drawing.Size(855, 624);
            this.plMain.TabIndex = 10;
            // 
            // plSend
            // 
            this.plSend.Controls.Add(this.btnSnedTransaction);
            this.plSend.Controls.Add(this.btnRefresh);
            this.plSend.Controls.Add(this.btnImport);
            this.plSend.Controls.Add(this.btnCreate);
            this.plSend.Controls.Add(this.txtBalance);
            this.plSend.Controls.Add(this.label11);
            this.plSend.Controls.Add(this.cboxAccount);
            this.plSend.Controls.Add(this.txtAmount);
            this.plSend.Controls.Add(this.label9);
            this.plSend.Controls.Add(this.txtReciveAddress);
            this.plSend.Controls.Add(this.label8);
            this.plSend.Controls.Add(this.txtKeyPwd);
            this.plSend.Controls.Add(this.label7);
            this.plSend.Controls.Add(this.label6);
            this.plSend.Controls.Add(this.cBoxRpc);
            this.plSend.Controls.Add(this.label4);
            this.plSend.Location = new System.Drawing.Point(158, 151);
            this.plSend.Name = "plSend";
            this.plSend.Size = new System.Drawing.Size(769, 349);
            this.plSend.TabIndex = 3;
            // 
            // btnSnedTransaction
            // 
            this.btnSnedTransaction.Image = global::LinkTokenFullWallet.Properties.Resources.Forward_25px;
            this.btnSnedTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSnedTransaction.Location = new System.Drawing.Point(420, 195);
            this.btnSnedTransaction.Name = "btnSnedTransaction";
            this.btnSnedTransaction.Size = new System.Drawing.Size(90, 35);
            this.btnSnedTransaction.TabIndex = 17;
            this.btnSnedTransaction.Text = "发送交易";
            this.btnSnedTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSnedTransaction.UseVisualStyleBackColor = true;
            this.btnSnedTransaction.Click += new System.EventHandler(this.btnSnedTransaction_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = global::LinkTokenFullWallet.Properties.Resources.Add_File_25px;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(534, 8);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(90, 35);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "刷新余额";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnImport
            // 
            this.btnImport.Image = global::LinkTokenFullWallet.Properties.Resources.Import_25px;
            this.btnImport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImport.Location = new System.Drawing.Point(420, 84);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(90, 35);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "导入钱包";
            this.btnImport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Image = global::LinkTokenFullWallet.Properties.Resources.Add_File_25px;
            this.btnCreate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCreate.Location = new System.Drawing.Point(320, 84);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 35);
            this.btnCreate.TabIndex = 14;
            this.btnCreate.Text = "新建钱包";
            this.btnCreate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBalance.Location = new System.Drawing.Point(106, 92);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(208, 23);
            this.txtBalance.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(30, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 14);
            this.label11.TabIndex = 12;
            this.label11.Text = "钱包余额：";
            // 
            // cboxAccount
            // 
            this.cboxAccount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboxAccount.FormattingEnabled = true;
            this.cboxAccount.Location = new System.Drawing.Point(106, 57);
            this.cboxAccount.Name = "cboxAccount";
            this.cboxAccount.Size = new System.Drawing.Size(404, 21);
            this.cboxAccount.TabIndex = 11;
            this.cboxAccount.SelectedIndexChanged += new System.EventHandler(this.cboxAccount_SelectedIndexChanged);
            // 
            // txtAmount
            // 
            this.txtAmount.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAmount.Location = new System.Drawing.Point(106, 201);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(308, 23);
            this.txtAmount.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(30, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 14);
            this.label9.TabIndex = 8;
            this.label9.Text = "转账金额：";
            // 
            // txtReciveAddress
            // 
            this.txtReciveAddress.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReciveAddress.Location = new System.Drawing.Point(106, 166);
            this.txtReciveAddress.Name = "txtReciveAddress";
            this.txtReciveAddress.Size = new System.Drawing.Size(404, 23);
            this.txtReciveAddress.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(30, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 14);
            this.label8.TabIndex = 6;
            this.label8.Text = "接收地址：";
            // 
            // txtKeyPwd
            // 
            this.txtKeyPwd.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtKeyPwd.Location = new System.Drawing.Point(106, 131);
            this.txtKeyPwd.Name = "txtKeyPwd";
            this.txtKeyPwd.Size = new System.Drawing.Size(404, 23);
            this.txtKeyPwd.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(30, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 14);
            this.label7.TabIndex = 4;
            this.label7.Text = "钱包密码：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(30, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "链克钱包：";
            // 
            // cBoxRpc
            // 
            this.cBoxRpc.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cBoxRpc.FormattingEnabled = true;
            this.cBoxRpc.Items.AddRange(new object[] {
            "http://127.0.0.1:44000",
            "https://linktoken.bihe.wrbug.cn"});
            this.cBoxRpc.Location = new System.Drawing.Point(106, 22);
            this.cBoxRpc.Name = "cBoxRpc";
            this.cBoxRpc.Size = new System.Drawing.Size(404, 21);
            this.cBoxRpc.TabIndex = 1;
            this.cBoxRpc.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(30, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "节点地址：";
            // 
            // plAbout
            // 
            this.plAbout.Controls.Add(this.label3);
            this.plAbout.Controls.Add(this.pictureBox1);
            this.plAbout.Location = new System.Drawing.Point(37, 308);
            this.plAbout.Name = "plAbout";
            this.plAbout.Size = new System.Drawing.Size(521, 297);
            this.plAbout.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(455, 108);
            this.label3.TabIndex = 1;
            this.label3.Text = "这是一款由 币合区块链 开发的链克数据节点全量钱包。\r\n链克开源地址：https://github.com/lianxiangcloud/lk-chain\r\n钱包" +
    "开源地址：https://github.com/biheBlockChain/LinkTokenFullWallet";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = ".\\币合区块链.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(3, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 225);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // plDownLoad
            // 
            this.plDownLoad.Controls.Add(this.progressBar1);
            this.plDownLoad.Controls.Add(this.panel6);
            this.plDownLoad.Controls.Add(this.panel4);
            this.plDownLoad.Controls.Add(this.label10);
            this.plDownLoad.Location = new System.Drawing.Point(6, 84);
            this.plDownLoad.Name = "plDownLoad";
            this.plDownLoad.Size = new System.Drawing.Size(440, 200);
            this.plDownLoad.TabIndex = 12;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(18, 165);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(406, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lbProgress);
            this.panel6.Controls.Add(this.lbRemainSize);
            this.panel6.Controls.Add(this.lbDownSize);
            this.panel6.Location = new System.Drawing.Point(224, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 100);
            this.panel6.TabIndex = 2;
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbProgress.Location = new System.Drawing.Point(10, 70);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(68, 15);
            this.lbProgress.TabIndex = 2;
            this.lbProgress.Text = "  进度：";
            // 
            // lbRemainSize
            // 
            this.lbRemainSize.AutoSize = true;
            this.lbRemainSize.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbRemainSize.Location = new System.Drawing.Point(10, 40);
            this.lbRemainSize.Name = "lbRemainSize";
            this.lbRemainSize.Size = new System.Drawing.Size(68, 15);
            this.lbRemainSize.TabIndex = 1;
            this.lbRemainSize.Text = "  剩余：";
            // 
            // lbDownSize
            // 
            this.lbDownSize.AutoSize = true;
            this.lbDownSize.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDownSize.Location = new System.Drawing.Point(10, 10);
            this.lbDownSize.Name = "lbDownSize";
            this.lbDownSize.Size = new System.Drawing.Size(67, 15);
            this.lbDownSize.TabIndex = 0;
            this.lbDownSize.Text = "已传送：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lbDownSpeed);
            this.panel4.Controls.Add(this.lbUsedTime);
            this.panel4.Controls.Add(this.lbFileSize);
            this.panel4.Location = new System.Drawing.Point(18, 52);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 1;
            // 
            // lbDownSpeed
            // 
            this.lbDownSpeed.AutoSize = true;
            this.lbDownSpeed.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbDownSpeed.Location = new System.Drawing.Point(10, 70);
            this.lbDownSpeed.Name = "lbDownSpeed";
            this.lbDownSpeed.Size = new System.Drawing.Size(82, 15);
            this.lbDownSpeed.TabIndex = 2;
            this.lbDownSpeed.Text = "下载速度：";
            // 
            // lbUsedTime
            // 
            this.lbUsedTime.AutoSize = true;
            this.lbUsedTime.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbUsedTime.Location = new System.Drawing.Point(10, 40);
            this.lbUsedTime.Name = "lbUsedTime";
            this.lbUsedTime.Size = new System.Drawing.Size(82, 15);
            this.lbUsedTime.TabIndex = 1;
            this.lbUsedTime.Text = "已用时间：";
            // 
            // lbFileSize
            // 
            this.lbFileSize.AutoSize = true;
            this.lbFileSize.Font = new System.Drawing.Font("宋体", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbFileSize.Location = new System.Drawing.Point(10, 10);
            this.lbFileSize.Name = "lbFileSize";
            this.lbFileSize.Size = new System.Drawing.Size(82, 15);
            this.lbFileSize.TabIndex = 0;
            this.lbFileSize.Text = "更新大小：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(15, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "正在下载初始区块数据，请稍后......";
            // 
            // plSetting
            // 
            this.plSetting.Controls.Add(this.btnRestart);
            this.plSetting.Controls.Add(this.btnStop);
            this.plSetting.Controls.Add(this.btnStart);
            this.plSetting.Controls.Add(this.btnInit);
            this.plSetting.Location = new System.Drawing.Point(270, 29);
            this.plSetting.Name = "plSetting";
            this.plSetting.Size = new System.Drawing.Size(355, 100);
            this.plSetting.TabIndex = 10;
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(223, 15);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(106, 34);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "重启链克节点";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(111, 55);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(106, 34);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "停止链克节点";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(111, 15);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(106, 34);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "启动链克节点";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(20, 15);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(85, 34);
            this.btnInit.TabIndex = 0;
            this.btnInit.Text = "初始化";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // timerUpdateBlockInfo
            // 
            this.timerUpdateBlockInfo.Enabled = true;
            this.timerUpdateBlockInfo.Interval = 10000;
            this.timerUpdateBlockInfo.Tick += new System.EventHandler(this.timerUpdateBlockInfo_TickAsync);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 624);
            this.Controls.Add(this.plMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.wbAnalysis);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.plBlockInfo.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.plShowLog.ResumeLayout(false);
            this.plMain.ResumeLayout(false);
            this.plSend.ResumeLayout(false);
            this.plSend.PerformLayout();
            this.plAbout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.plDownLoad.ResumeLayout(false);
            this.plDownLoad.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.plSetting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser wbAnalysis;
        private System.Windows.Forms.Button btnBlockInfo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnShowLog;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel plBlockInfo;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbMainHeight;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbBlockHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel plShowLog;
        private System.Windows.Forms.Panel plMain;
        private System.Windows.Forms.Button btnConsole;
        private System.Windows.Forms.Button btnSetting;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.WebBrowser webNewBlock;
        private System.Windows.Forms.Panel plSetting;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerUpdateBlockInfo;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Panel plAbout;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel plSend;
        private System.Windows.Forms.ComboBox cBoxRpc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtReciveAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtKeyPwd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel plDownLoad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label lbRemainSize;
        private System.Windows.Forms.Label lbDownSize;
        private System.Windows.Forms.Label lbDownSpeed;
        private System.Windows.Forms.Label lbUsedTime;
        private System.Windows.Forms.Label lbFileSize;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboxAccount;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Button btnSnedTransaction;
        private System.Windows.Forms.Button btnRefresh;
    }
}