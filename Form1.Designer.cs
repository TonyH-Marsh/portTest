namespace portTest
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.fdUrl = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fdUser = new System.Windows.Forms.TextBox();
            this.fdPw = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fdProxy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.fdResp = new System.Windows.Forms.TextBox();
            this.fdUseProxy = new System.Windows.Forms.CheckBox();
            this.fdUseCred = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fdUrl
            // 
            this.fdUrl.Location = new System.Drawing.Point(88, 28);
            this.fdUrl.Name = "fdUrl";
            this.fdUrl.Size = new System.Drawing.Size(421, 20);
            this.fdUrl.TabIndex = 1;
            this.fdUrl.Text = "https://digitalpost03.docpoint.dk:8081/lasernet";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Url:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "User";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "PW";
            // 
            // fdUser
            // 
            this.fdUser.Location = new System.Drawing.Point(88, 110);
            this.fdUser.Name = "fdUser";
            this.fdUser.Size = new System.Drawing.Size(176, 20);
            this.fdUser.TabIndex = 5;
            // 
            // fdPw
            // 
            this.fdPw.Location = new System.Drawing.Point(88, 149);
            this.fdPw.Name = "fdPw";
            this.fdPw.PasswordChar = '*';
            this.fdPw.Size = new System.Drawing.Size(176, 20);
            this.fdPw.TabIndex = 6;
            this.fdPw.TextChanged += new System.EventHandler(this.fdPw_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Proxy";
            // 
            // fdProxy
            // 
            this.fdProxy.Location = new System.Drawing.Point(88, 71);
            this.fdProxy.Name = "fdProxy";
            this.fdProxy.Size = new System.Drawing.Size(421, 20);
            this.fdProxy.TabIndex = 8;
            this.fdProxy.Text = "gbexez03prb01-vip.mgd.mrshmc.com:8888";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Response";
            // 
            // fdResp
            // 
            this.fdResp.Location = new System.Drawing.Point(88, 193);
            this.fdResp.Multiline = true;
            this.fdResp.Name = "fdResp";
            this.fdResp.Size = new System.Drawing.Size(529, 153);
            this.fdResp.TabIndex = 10;
            // 
            // fdUseProxy
            // 
            this.fdUseProxy.AutoSize = true;
            this.fdUseProxy.Location = new System.Drawing.Point(524, 73);
            this.fdUseProxy.Name = "fdUseProxy";
            this.fdUseProxy.Size = new System.Drawing.Size(74, 17);
            this.fdUseProxy.TabIndex = 11;
            this.fdUseProxy.Text = "Use Proxy";
            this.fdUseProxy.UseVisualStyleBackColor = true;
            // 
            // fdUseCred
            // 
            this.fdUseCred.AutoSize = true;
            this.fdUseCred.Location = new System.Drawing.Point(524, 112);
            this.fdUseCred.Name = "fdUseCred";
            this.fdUseCred.Size = new System.Drawing.Size(97, 17);
            this.fdUseCred.TabIndex = 12;
            this.fdUseCred.Text = "UseCredentials";
            this.fdUseCred.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 367);
            this.Controls.Add(this.fdUseCred);
            this.Controls.Add(this.fdUseProxy);
            this.Controls.Add(this.fdResp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.fdProxy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.fdPw);
            this.Controls.Add(this.fdUser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fdUrl);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fdUrl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fdUser;
        private System.Windows.Forms.TextBox fdPw;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fdProxy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fdResp;
        private System.Windows.Forms.CheckBox fdUseProxy;
        private System.Windows.Forms.CheckBox fdUseCred;
    }
}

