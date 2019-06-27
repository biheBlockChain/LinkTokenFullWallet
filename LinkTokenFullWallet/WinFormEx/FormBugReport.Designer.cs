namespace LinkTokenFullWallet.WinFormEx
{
    partial class FormBugReport
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbErr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbErrNo = new System.Windows.Forms.Label();
            this.chkSend = new System.Windows.Forms.CheckBox();
            this.chkRebot = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMsg = new System.Windows.Forms.TextBox();
            this.btnMore = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LinkTokenFullWallet.Properties.Resources.FormMsg_Info;
            this.pictureBox1.Location = new System.Drawing.Point(25, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbErr
            // 
            this.lbErr.Font = new System.Drawing.Font("新宋体", 9.5F);
            this.lbErr.Location = new System.Drawing.Point(100, 20);
            this.lbErr.Name = "lbErr";
            this.lbErr.Size = new System.Drawing.Size(301, 72);
            this.lbErr.TabIndex = 1;
            this.lbErr.Text = "非常抱歉！程序遇到了未知的异常。\r\n\r\n我们已经生成了一个关于此异常的报告，这并不包含您的任何隐私信息，希望您能选择发送此报告给我们以帮助解决此异常。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "异常编号：";
            // 
            // lbErrNo
            // 
            this.lbErrNo.AutoSize = true;
            this.lbErrNo.Location = new System.Drawing.Point(94, 100);
            this.lbErrNo.Name = "lbErrNo";
            this.lbErrNo.Size = new System.Drawing.Size(41, 12);
            this.lbErrNo.TabIndex = 3;
            this.lbErrNo.Text = "label3";
            // 
            // chkSend
            // 
            this.chkSend.AutoSize = true;
            this.chkSend.Checked = true;
            this.chkSend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSend.Location = new System.Drawing.Point(151, 272);
            this.chkSend.Name = "chkSend";
            this.chkSend.Size = new System.Drawing.Size(96, 16);
            this.chkSend.TabIndex = 4;
            this.chkSend.Text = "发送异常报告";
            this.chkSend.UseVisualStyleBackColor = true;
            // 
            // chkRebot
            // 
            this.chkRebot.AutoSize = true;
            this.chkRebot.Checked = true;
            this.chkRebot.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRebot.Location = new System.Drawing.Point(250, 272);
            this.chkRebot.Name = "chkRebot";
            this.chkRebot.Size = new System.Drawing.Size(72, 16);
            this.chkRebot.TabIndex = 5;
            this.chkRebot.Text = "重启程序";
            this.chkRebot.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "这个异常是如何出现的？";
            // 
            // txtMsg
            // 
            this.txtMsg.Location = new System.Drawing.Point(25, 140);
            this.txtMsg.Multiline = true;
            this.txtMsg.Name = "txtMsg";
            this.txtMsg.Size = new System.Drawing.Size(376, 65);
            this.txtMsg.TabIndex = 7;
            // 
            // btnMore
            // 
            this.btnMore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMore.Location = new System.Drawing.Point(25, 265);
            this.btnMore.Name = "btnMore";
            this.btnMore.Size = new System.Drawing.Size(111, 23);
            this.btnMore.TabIndex = 8;
            this.btnMore.Text = ">> 异常详细信息";
            this.btnMore.UseVisualStyleBackColor = true;
            this.btnMore.Click += new System.EventHandler(this.btnMore_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Location = new System.Drawing.Point(324, 265);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(77, 23);
            this.btnOK.TabIndex = 9;
            this.btnOK.Text = "确 定";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "您的联系方式：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(25, 230);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(376, 21);
            this.txtPhone.TabIndex = 11;
            // 
            // FormBugReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 307);
            this.ControlBox = false;
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnMore);
            this.Controls.Add(this.txtMsg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.chkRebot);
            this.Controls.Add(this.chkSend);
            this.Controls.Add(this.lbErrNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbErr);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormBugReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "异常报告";
            this.Load += new System.EventHandler(this.FormBugReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbErr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbErrNo;
        private System.Windows.Forms.CheckBox chkSend;
        private System.Windows.Forms.CheckBox chkRebot;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMsg;
        private System.Windows.Forms.Button btnMore;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPhone;
    }
}