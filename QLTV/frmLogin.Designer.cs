
namespace QLTV
{
    partial class frmLogin
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
            this.panel = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.TextBox_Password = new Guna.UI.WinForms.GunaLineTextBox();
            this.TextBox_Username = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.btnDangNhap = new Guna.UI.WinForms.GunaGradientButton();
            this.rdoSinhVien = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoGiaoVien = new Guna.UI.WinForms.GunaRadioButton();
            this.rdoAdmin = new Guna.UI.WinForms.GunaRadioButton();
            this.CheckBox_HienThiMK = new Guna.UI.WinForms.GunaCheckBox();
            this.panel.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.gunaElipsePanel1);
            this.panel.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(78)))), ((int)(((byte)(192)))));
            this.panel.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(203)))), ((int)(((byte)(224)))));
            this.panel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.panel.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.panel.Location = new System.Drawing.Point(1, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(1046, 738);
            this.panel.TabIndex = 2;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.CheckBox_HienThiMK);
            this.gunaElipsePanel1.Controls.Add(this.rdoAdmin);
            this.gunaElipsePanel1.Controls.Add(this.rdoGiaoVien);
            this.gunaElipsePanel1.Controls.Add(this.rdoSinhVien);
            this.gunaElipsePanel1.Controls.Add(this.btnDangNhap);
            this.gunaElipsePanel1.Controls.Add(this.TextBox_Password);
            this.gunaElipsePanel1.Controls.Add(this.TextBox_Username);
            this.gunaElipsePanel1.Controls.Add(this.gunaLabel1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(289, 49);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 20;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(467, 640);
            this.gunaElipsePanel1.TabIndex = 0;
            // 
            // TextBox_Password
            // 
            this.TextBox_Password.BackColor = System.Drawing.Color.White;
            this.TextBox_Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Password.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_Password.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Password.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_Password.Location = new System.Drawing.Point(21, 245);
            this.TextBox_Password.Name = "TextBox_Password";
            this.TextBox_Password.PasswordChar = '\0';
            this.TextBox_Password.SelectedText = "";
            this.TextBox_Password.Size = new System.Drawing.Size(425, 37);
            this.TextBox_Password.TabIndex = 2;
            this.TextBox_Password.Text = "Password";
            this.TextBox_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Password.Enter += new System.EventHandler(this.TextBox_Password_Enter);
            this.TextBox_Password.Leave += new System.EventHandler(this.TextBox_Password_Leave);
            // 
            // TextBox_Username
            // 
            this.TextBox_Username.BackColor = System.Drawing.Color.White;
            this.TextBox_Username.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_Username.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_Username.Font = new System.Drawing.Font("Yu Gothic UI Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox_Username.LineColor = System.Drawing.Color.Gainsboro;
            this.TextBox_Username.Location = new System.Drawing.Point(21, 185);
            this.TextBox_Username.Name = "TextBox_Username";
            this.TextBox_Username.PasswordChar = '\0';
            this.TextBox_Username.SelectedText = "";
            this.TextBox_Username.Size = new System.Drawing.Size(425, 37);
            this.TextBox_Username.TabIndex = 1;
            this.TextBox_Username.Text = "Username";
            this.TextBox_Username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBox_Username.TextChanged += new System.EventHandler(this.TextBox_Username_TextChanged);
            this.TextBox_Username.Enter += new System.EventHandler(this.TextBox_Username_Enter);
            this.TextBox_Username.Leave += new System.EventHandler(this.TextBox_Username_Leave);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semilight", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(100, 78);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(266, 62);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "Login Form";
            // 
            // btnDangNhap
            // 
            this.btnDangNhap.AnimationHoverSpeed = 0.07F;
            this.btnDangNhap.AnimationSpeed = 0.03F;
            this.btnDangNhap.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.btnDangNhap.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.btnDangNhap.BorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnDangNhap.FocusedColor = System.Drawing.Color.Empty;
            this.btnDangNhap.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangNhap.ForeColor = System.Drawing.Color.White;
            this.btnDangNhap.Image = null;
            this.btnDangNhap.ImageSize = new System.Drawing.Size(20, 20);
            this.btnDangNhap.Location = new System.Drawing.Point(21, 485);
            this.btnDangNhap.Name = "btnDangNhap";
            this.btnDangNhap.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnDangNhap.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnDangNhap.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnDangNhap.OnHoverForeColor = System.Drawing.Color.White;
            this.btnDangNhap.OnHoverImage = null;
            this.btnDangNhap.OnPressedColor = System.Drawing.Color.Black;
            this.btnDangNhap.Radius = 10;
            this.btnDangNhap.Size = new System.Drawing.Size(425, 58);
            this.btnDangNhap.TabIndex = 3;
            this.btnDangNhap.Text = "Đăng nhập";
            this.btnDangNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnDangNhap.Click += new System.EventHandler(this.btnDangNhap_Click);
            // 
            // rdoSinhVien
            // 
            this.rdoSinhVien.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoSinhVien.Checked = true;
            this.rdoSinhVien.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoSinhVien.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoSinhVien.FillColor = System.Drawing.Color.White;
            this.rdoSinhVien.Location = new System.Drawing.Point(86, 406);
            this.rdoSinhVien.Name = "rdoSinhVien";
            this.rdoSinhVien.Size = new System.Drawing.Size(76, 20);
            this.rdoSinhVien.TabIndex = 4;
            this.rdoSinhVien.Text = "Sinh viên";
            // 
            // rdoGiaoVien
            // 
            this.rdoGiaoVien.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoGiaoVien.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoGiaoVien.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoGiaoVien.FillColor = System.Drawing.Color.White;
            this.rdoGiaoVien.Location = new System.Drawing.Point(199, 406);
            this.rdoGiaoVien.Name = "rdoGiaoVien";
            this.rdoGiaoVien.Size = new System.Drawing.Size(78, 20);
            this.rdoGiaoVien.TabIndex = 5;
            this.rdoGiaoVien.Text = "Giáo viên";
            // 
            // rdoAdmin
            // 
            this.rdoAdmin.BaseColor = System.Drawing.SystemColors.Control;
            this.rdoAdmin.CheckedOffColor = System.Drawing.Color.Gray;
            this.rdoAdmin.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.rdoAdmin.FillColor = System.Drawing.Color.White;
            this.rdoAdmin.Location = new System.Drawing.Point(322, 406);
            this.rdoAdmin.Name = "rdoAdmin";
            this.rdoAdmin.Size = new System.Drawing.Size(62, 20);
            this.rdoAdmin.TabIndex = 6;
            this.rdoAdmin.Text = "Admin";
            // 
            // CheckBox_HienThiMK
            // 
            this.CheckBox_HienThiMK.BaseColor = System.Drawing.Color.White;
            this.CheckBox_HienThiMK.CheckedOffColor = System.Drawing.Color.Gray;
            this.CheckBox_HienThiMK.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.CheckBox_HienThiMK.FillColor = System.Drawing.Color.White;
            this.CheckBox_HienThiMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox_HienThiMK.Location = new System.Drawing.Point(21, 310);
            this.CheckBox_HienThiMK.Name = "CheckBox_HienThiMK";
            this.CheckBox_HienThiMK.Size = new System.Drawing.Size(192, 27);
            this.CheckBox_HienThiMK.TabIndex = 67;
            this.CheckBox_HienThiMK.Text = "Hiển thị mật khẩu";
            this.CheckBox_HienThiMK.CheckedChanged += new System.EventHandler(this.CheckBox_HienThiMK_CheckedChanged);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 738);
            this.Controls.Add(this.panel);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.panel.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.gunaElipsePanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel panel;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_Password;
        private Guna.UI.WinForms.GunaLineTextBox TextBox_Username;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaGradientButton btnDangNhap;
        private Guna.UI.WinForms.GunaRadioButton rdoSinhVien;
        private Guna.UI.WinForms.GunaRadioButton rdoAdmin;
        private Guna.UI.WinForms.GunaRadioButton rdoGiaoVien;
        private Guna.UI.WinForms.GunaCheckBox CheckBox_HienThiMK;
    }
}