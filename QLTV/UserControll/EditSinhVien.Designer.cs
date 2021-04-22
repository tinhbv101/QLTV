
namespace QLTV.UserControll
{
    partial class EditSinhVien
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLuu = new Guna.UI.WinForms.GunaButton();
            this.label17 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TextBox_mssv = new Guna.UI.WinForms.GunaTextBox();
            this.groupBox2 = new Guna.UI.WinForms.GunaGroupBox();
            this.btnUpload = new Guna.UI.WinForms.GunaButton();
            this.pic_avt = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBox_diachi = new Guna.UI.WinForms.GunaTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBox_sdt = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmNgaySinh = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cboGioiTinh = new Guna.UI.WinForms.GunaComboBox();
            this.TextBox_ten = new Guna.UI.WinForms.GunaTextBox();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).BeginInit();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.AnimationHoverSpeed = 0.07F;
            this.btnLuu.AnimationSpeed = 0.03F;
            this.btnLuu.BackColor = System.Drawing.Color.Transparent;
            this.btnLuu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(53)))));
            this.btnLuu.BorderColor = System.Drawing.Color.Black;
            this.btnLuu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLuu.FocusedColor = System.Drawing.Color.Empty;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = null;
            this.btnLuu.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLuu.Location = new System.Drawing.Point(133, 682);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnLuu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLuu.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLuu.OnHoverImage = null;
            this.btnLuu.OnPressedColor = System.Drawing.Color.Black;
            this.btnLuu.Radius = 20;
            this.btnLuu.Size = new System.Drawing.Size(221, 63);
            this.btnLuu.TabIndex = 62;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(38, 57);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 25);
            this.label17.TabIndex = 58;
            this.label17.Text = "MSSV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 25);
            this.label4.TabIndex = 56;
            this.label4.Text = "Giới tính: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(38, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 25);
            this.label7.TabIndex = 57;
            this.label7.Text = "Tên SV:";
            // 
            // TextBox_mssv
            // 
            this.TextBox_mssv.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_mssv.BaseColor = System.Drawing.Color.White;
            this.TextBox_mssv.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_mssv.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_mssv.Enabled = false;
            this.TextBox_mssv.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_mssv.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_mssv.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_mssv.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_mssv.ForeColor = System.Drawing.Color.Black;
            this.TextBox_mssv.Location = new System.Drawing.Point(178, 45);
            this.TextBox_mssv.Name = "TextBox_mssv";
            this.TextBox_mssv.PasswordChar = '\0';
            this.TextBox_mssv.Radius = 10;
            this.TextBox_mssv.SelectedText = "";
            this.TextBox_mssv.Size = new System.Drawing.Size(160, 37);
            this.TextBox_mssv.TabIndex = 59;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.groupBox2.BorderColor = System.Drawing.Color.Maroon;
            this.groupBox2.Controls.Add(this.btnUpload);
            this.groupBox2.Controls.Add(this.pic_avt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.TextBox_diachi);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.TextBox_sdt);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtmNgaySinh);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cboGioiTinh);
            this.groupBox2.Controls.Add(this.TextBox_ten);
            this.groupBox2.Controls.Add(this.btnLuu);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.TextBox_mssv);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.groupBox2.Location = new System.Drawing.Point(298, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Radius = 10;
            this.groupBox2.Size = new System.Drawing.Size(467, 771);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.Text = "Thông tin sinh viên";
            this.groupBox2.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnUpload
            // 
            this.btnUpload.AnimationHoverSpeed = 0.07F;
            this.btnUpload.AnimationSpeed = 0.03F;
            this.btnUpload.BackColor = System.Drawing.Color.Transparent;
            this.btnUpload.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnUpload.BorderColor = System.Drawing.Color.Black;
            this.btnUpload.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpload.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpload.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.Image = null;
            this.btnUpload.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpload.Location = new System.Drawing.Point(204, 626);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpload.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpload.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpload.OnHoverImage = null;
            this.btnUpload.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpload.Radius = 5;
            this.btnUpload.Size = new System.Drawing.Size(200, 22);
            this.btnUpload.TabIndex = 73;
            this.btnUpload.Text = "Upload";
            this.btnUpload.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // pic_avt
            // 
            this.pic_avt.BaseColor = System.Drawing.Color.White;
            this.pic_avt.Image = global::QLTV.Properties.Resources.avt_defaule;
            this.pic_avt.Location = new System.Drawing.Point(204, 424);
            this.pic_avt.Name = "pic_avt";
            this.pic_avt.Size = new System.Drawing.Size(200, 200);
            this.pic_avt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_avt.TabIndex = 72;
            this.pic_avt.TabStop = false;
            this.pic_avt.UseTransfarantBackground = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(38, 445);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 25);
            this.label5.TabIndex = 71;
            this.label5.Text = "Ảnh đại diện: ";
            // 
            // TextBox_diachi
            // 
            this.TextBox_diachi.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_diachi.BaseColor = System.Drawing.Color.White;
            this.TextBox_diachi.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_diachi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_diachi.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_diachi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_diachi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_diachi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_diachi.ForeColor = System.Drawing.Color.Black;
            this.TextBox_diachi.Location = new System.Drawing.Point(178, 376);
            this.TextBox_diachi.Name = "TextBox_diachi";
            this.TextBox_diachi.PasswordChar = '\0';
            this.TextBox_diachi.Radius = 10;
            this.TextBox_diachi.SelectedText = "";
            this.TextBox_diachi.Size = new System.Drawing.Size(253, 37);
            this.TextBox_diachi.TabIndex = 70;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 388);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 69;
            this.label3.Text = "Địa chỉ: ";
            // 
            // TextBox_sdt
            // 
            this.TextBox_sdt.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_sdt.BaseColor = System.Drawing.Color.White;
            this.TextBox_sdt.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_sdt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_sdt.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_sdt.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_sdt.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_sdt.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_sdt.ForeColor = System.Drawing.Color.Black;
            this.TextBox_sdt.Location = new System.Drawing.Point(178, 303);
            this.TextBox_sdt.Name = "TextBox_sdt";
            this.TextBox_sdt.PasswordChar = '\0';
            this.TextBox_sdt.Radius = 10;
            this.TextBox_sdt.SelectedText = "";
            this.TextBox_sdt.Size = new System.Drawing.Size(253, 37);
            this.TextBox_sdt.TabIndex = 68;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(38, 315);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 67;
            this.label2.Text = "SĐT: ";
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.BackColor = System.Drawing.Color.Transparent;
            this.dtmNgaySinh.BaseColor = System.Drawing.Color.White;
            this.dtmNgaySinh.BorderColor = System.Drawing.Color.Silver;
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmNgaySinh.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmNgaySinh.ForeColor = System.Drawing.Color.Black;
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(178, 241);
            this.dtmNgaySinh.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmNgaySinh.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmNgaySinh.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmNgaySinh.OnPressedColor = System.Drawing.Color.Black;
            this.dtmNgaySinh.Radius = 10;
            this.dtmNgaySinh.Size = new System.Drawing.Size(160, 30);
            this.dtmNgaySinh.TabIndex = 66;
            this.dtmNgaySinh.Text = "22/04/2021";
            this.dtmNgaySinh.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Ngày sinh: ";
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.cboGioiTinh.BaseColor = System.Drawing.Color.White;
            this.cboGioiTinh.BorderColor = System.Drawing.Color.Silver;
            this.cboGioiTinh.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FocusedColor = System.Drawing.Color.Empty;
            this.cboGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboGioiTinh.ForeColor = System.Drawing.Color.Black;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cboGioiTinh.Location = new System.Drawing.Point(178, 177);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboGioiTinh.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboGioiTinh.Radius = 10;
            this.cboGioiTinh.Size = new System.Drawing.Size(160, 30);
            this.cboGioiTinh.TabIndex = 64;
            // 
            // TextBox_ten
            // 
            this.TextBox_ten.BackColor = System.Drawing.Color.Transparent;
            this.TextBox_ten.BaseColor = System.Drawing.Color.White;
            this.TextBox_ten.BorderColor = System.Drawing.Color.Silver;
            this.TextBox_ten.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TextBox_ten.FocusedBaseColor = System.Drawing.Color.White;
            this.TextBox_ten.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.TextBox_ten.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBox_ten.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.TextBox_ten.ForeColor = System.Drawing.Color.Black;
            this.TextBox_ten.Location = new System.Drawing.Point(178, 113);
            this.TextBox_ten.Name = "TextBox_ten";
            this.TextBox_ten.PasswordChar = '\0';
            this.TextBox_ten.Radius = 10;
            this.TextBox_ten.SelectedText = "";
            this.TextBox_ten.Size = new System.Drawing.Size(253, 37);
            this.TextBox_ten.TabIndex = 63;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(255)))), ((int)(((byte)(253)))));
            this.gunaElipsePanel1.Controls.Add(this.groupBox2);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 50;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1063, 777);
            this.gunaElipsePanel1.TabIndex = 51;
            // 
            // EditSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.Controls.Add(this.gunaElipsePanel1);
            this.Name = "EditSinhVien";
            this.Size = new System.Drawing.Size(1063, 777);
            this.Load += new System.EventHandler(this.EditSinhVien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_avt)).EndInit();
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnLuu;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaTextBox TextBox_mssv;
        private Guna.UI.WinForms.GunaGroupBox groupBox2;
        private Guna.UI.WinForms.GunaTextBox TextBox_ten;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaComboBox cboGioiTinh;
        private Guna.UI.WinForms.GunaDateTimePicker dtmNgaySinh;
        private Guna.UI.WinForms.GunaTextBox TextBox_sdt;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox TextBox_diachi;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnUpload;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_avt;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
    }
}
