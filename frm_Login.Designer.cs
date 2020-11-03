namespace MTsystem_win
{
    partial class frm_Login
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Username = new System.Windows.Forms.TextBox();
            this.txt_Userpwd = new System.Windows.Forms.TextBox();
            this.btn_Login = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码:";
            // 
            // txt_Username
            // 
            this.helpProvider1.SetHelpString(this.txt_Username, "输入用户名");
            this.txt_Username.Location = new System.Drawing.Point(132, 70);
            this.txt_Username.Name = "txt_Username";
            this.helpProvider1.SetShowHelp(this.txt_Username, true);
            this.txt_Username.Size = new System.Drawing.Size(182, 26);
            this.txt_Username.TabIndex = 2;
            this.txt_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Username_KeyPress);
            // 
            // txt_Userpwd
            // 
            this.helpProvider1.SetHelpString(this.txt_Userpwd, "输入用户密码");
            this.txt_Userpwd.Location = new System.Drawing.Point(132, 111);
            this.txt_Userpwd.Name = "txt_Userpwd";
            this.txt_Userpwd.PasswordChar = '*';
            this.helpProvider1.SetShowHelp(this.txt_Userpwd, true);
            this.txt_Userpwd.Size = new System.Drawing.Size(182, 26);
            this.txt_Userpwd.TabIndex = 3;
            this.txt_Userpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Userpwd_KeyPress);
            // 
            // btn_Login
            // 
            this.helpProvider1.SetHelpString(this.btn_Login, "提交用户登录验证");
            this.btn_Login.Location = new System.Drawing.Point(108, 164);
            this.btn_Login.Name = "btn_Login";
            this.helpProvider1.SetShowHelp(this.btn_Login, true);
            this.btn_Login.Size = new System.Drawing.Size(75, 31);
            this.btn_Login.TabIndex = 4;
            this.btn_Login.Text = "登  录";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // btn_Cancel
            // 
            this.helpProvider1.SetHelpString(this.btn_Cancel, "取消登录");
            this.btn_Cancel.Location = new System.Drawing.Point(190, 164);
            this.btn_Cancel.Name = "btn_Cancel";
            this.helpProvider1.SetShowHelp(this.btn_Cancel, true);
            this.btn_Cancel.Size = new System.Drawing.Size(75, 31);
            this.btn_Cancel.TabIndex = 5;
            this.btn_Cancel.Text = "取  消";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.txt_Userpwd);
            this.Controls.Add(this.txt_Username);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Login";
            this.helpProvider1.SetShowHelp(this, true);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "登录窗口";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Username;
        private System.Windows.Forms.TextBox txt_Userpwd;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.HelpProvider helpProvider1;
    }
}

