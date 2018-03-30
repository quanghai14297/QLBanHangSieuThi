namespace QLBanHangSieuThi
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.minimize = new System.Windows.Forms.Panel();
            this.btexit = new System.Windows.Forms.Panel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btlogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tfpass = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.tfuser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.line1 = new DevComponents.DotNetBar.Controls.Line();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // minimize
            // 
            this.minimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimize.BackgroundImage")));
            this.minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimize.Location = new System.Drawing.Point(734, 12);
            this.minimize.Name = "minimize";
            this.minimize.Size = new System.Drawing.Size(30, 30);
            this.minimize.TabIndex = 3;
            this.minimize.Click += new System.EventHandler(this.btminimize);
            // 
            // btexit
            // 
            this.btexit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btexit.BackgroundImage")));
            this.btexit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btexit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btexit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btexit.Location = new System.Drawing.Point(766, 12);
            this.btexit.Name = "btexit";
            this.btexit.Size = new System.Drawing.Size(30, 30);
            this.btexit.TabIndex = 4;
            this.btexit.Click += new System.EventHandler(this.btexit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand Medium", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(274, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "SIÊU THỊ";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btlogin);
            this.bunifuGradientPanel1.Controls.Add(this.tfpass);
            this.bunifuGradientPanel1.Controls.Add(this.label5);
            this.bunifuGradientPanel1.Controls.Add(this.tfuser);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.label3);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(9)))), ((int)(((byte)(121)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(106)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(447, 48);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(325, 372);
            this.bunifuGradientPanel1.TabIndex = 7;
            // 
            // btlogin
            // 
            this.btlogin.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btlogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btlogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btlogin.BorderRadius = 0;
            this.btlogin.ButtonText = "LOGIN";
            this.btlogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btlogin.DisabledColor = System.Drawing.Color.Gray;
            this.btlogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btlogin.Iconimage = null;
            this.btlogin.Iconimage_right = null;
            this.btlogin.Iconimage_right_Selected = null;
            this.btlogin.Iconimage_Selected = null;
            this.btlogin.IconMarginLeft = 0;
            this.btlogin.IconMarginRight = 0;
            this.btlogin.IconRightVisible = true;
            this.btlogin.IconRightZoom = 0D;
            this.btlogin.IconVisible = true;
            this.btlogin.IconZoom = 90D;
            this.btlogin.IsTab = false;
            this.btlogin.Location = new System.Drawing.Point(34, 296);
            this.btlogin.Name = "btlogin";
            this.btlogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.btlogin.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(69)))), ((int)(((byte)(126)))));
            this.btlogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btlogin.selected = false;
            this.btlogin.Size = new System.Drawing.Size(263, 48);
            this.btlogin.TabIndex = 14;
            this.btlogin.Text = "LOGIN";
            this.btlogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btlogin.Textcolor = System.Drawing.Color.White;
            this.btlogin.TextFont = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btlogin.Click += new System.EventHandler(this.btlogin_Click);
            // 
            // tfpass
            // 
            this.tfpass.BackColor = System.Drawing.Color.White;
            this.tfpass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfpass.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tfpass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfpass.HintForeColor = System.Drawing.Color.Empty;
            this.tfpass.HintText = "Password";
            this.tfpass.isPassword = true;
            this.tfpass.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.tfpass.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tfpass.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.tfpass.LineThickness = 3;
            this.tfpass.Location = new System.Drawing.Point(34, 218);
            this.tfpass.Margin = new System.Windows.Forms.Padding(4);
            this.tfpass.Name = "tfpass";
            this.tfpass.Size = new System.Drawing.Size(263, 33);
            this.tfpass.TabIndex = 13;
            this.tfpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "Mật khẩu";
            // 
            // tfuser
            // 
            this.tfuser.BackColor = System.Drawing.Color.White;
            this.tfuser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfuser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tfuser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tfuser.HintForeColor = System.Drawing.Color.Empty;
            this.tfuser.HintText = "Username";
            this.tfuser.isPassword = false;
            this.tfuser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.tfuser.LineIdleColor = System.Drawing.Color.DarkGray;
            this.tfuser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(105)))), ((int)(((byte)(189)))));
            this.tfuser.LineThickness = 3;
            this.tfuser.Location = new System.Drawing.Point(34, 128);
            this.tfuser.Margin = new System.Windows.Forms.Padding(4);
            this.tfuser.Name = "tfuser";
            this.tfuser.Size = new System.Drawing.Size(263, 33);
            this.tfuser.TabIndex = 11;
            this.tfuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand Medium", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(73, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "QUẢN LÝ BÁN HÀNG";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 15;
            this.bunifuElipse2.TargetControl = this.bunifuGradientPanel1;
            // 
            // line1
            // 
            this.line1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.line1.Location = new System.Drawing.Point(361, 32);
            this.line1.Name = "line1";
            this.line1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.line1.Size = new System.Drawing.Size(75, 399);
            this.line1.TabIndex = 8;
            this.line1.Text = "line1";
            this.line1.VerticalLine = true;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 15;
            this.bunifuElipse3.TargetControl = this.btlogin;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(814, 462);
            this.Controls.Add(this.line1);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.minimize);
            this.Controls.Add(this.btexit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel minimize;
        private System.Windows.Forms.Panel btexit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private DevComponents.DotNetBar.Controls.Line line1;
        private Bunifu.Framework.UI.BunifuFlatButton btlogin;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tfpass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tfuser;
    }
}