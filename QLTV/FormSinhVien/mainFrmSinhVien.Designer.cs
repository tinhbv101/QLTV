
namespace QLTV
{
    partial class mainFrmSinhVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTra = new Guna.UI.WinForms.GunaButton();
            this.btnMuon = new Guna.UI.WinForms.GunaButton();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaElipsePanel2 = new Guna.UI.WinForms.GunaElipsePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaElipsePanel1 = new Guna.UI.WinForms.GunaElipsePanel();
            this.usMuonSach1 = new QLTV.UserControll.USMuonSachSV();
            this.usTraSachSV1 = new QLTV.UserControll.USTraSachSV();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.gunaElipsePanel2.SuspendLayout();
            this.gunaElipsePanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTra);
            this.panel1.Controls.Add(this.btnMuon);
            this.panel1.Controls.Add(this.gunaCirclePictureBox1);
            this.panel1.Controls.Add(this.gunaElipsePanel2);
            this.panel1.Location = new System.Drawing.Point(9, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 800);
            this.panel1.TabIndex = 0;
            // 
            // btnTra
            // 
            this.btnTra.AnimationHoverSpeed = 0.07F;
            this.btnTra.AnimationSpeed = 0.03F;
            this.btnTra.BackColor = System.Drawing.Color.Transparent;
            this.btnTra.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnTra.BorderColor = System.Drawing.Color.Black;
            this.btnTra.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnTra.FocusedColor = System.Drawing.Color.Empty;
            this.btnTra.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnTra.ForeColor = System.Drawing.Color.White;
            this.btnTra.Image = null;
            this.btnTra.ImageSize = new System.Drawing.Size(20, 20);
            this.btnTra.Location = new System.Drawing.Point(-64, 511);
            this.btnTra.Margin = new System.Windows.Forms.Padding(0);
            this.btnTra.Name = "btnTra";
            this.btnTra.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnTra.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnTra.OnHoverForeColor = System.Drawing.Color.White;
            this.btnTra.OnHoverImage = null;
            this.btnTra.OnPressedColor = System.Drawing.Color.Black;
            this.btnTra.Radius = 40;
            this.btnTra.Size = new System.Drawing.Size(343, 89);
            this.btnTra.TabIndex = 4;
            this.btnTra.Text = "Trả Sách";
            this.btnTra.TextOffsetX = 120;
            this.btnTra.Click += new System.EventHandler(this.btnTra_Click);
            // 
            // btnMuon
            // 
            this.btnMuon.AnimationHoverSpeed = 0.07F;
            this.btnMuon.AnimationSpeed = 0.03F;
            this.btnMuon.BackColor = System.Drawing.Color.Transparent;
            this.btnMuon.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnMuon.BorderColor = System.Drawing.Color.Black;
            this.btnMuon.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnMuon.FocusedColor = System.Drawing.Color.Empty;
            this.btnMuon.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnMuon.ForeColor = System.Drawing.Color.White;
            this.btnMuon.Image = null;
            this.btnMuon.ImageSize = new System.Drawing.Size(20, 20);
            this.btnMuon.Location = new System.Drawing.Point(-64, 422);
            this.btnMuon.Margin = new System.Windows.Forms.Padding(0);
            this.btnMuon.Name = "btnMuon";
            this.btnMuon.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnMuon.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnMuon.OnHoverForeColor = System.Drawing.Color.White;
            this.btnMuon.OnHoverImage = null;
            this.btnMuon.OnPressedColor = System.Drawing.Color.Black;
            this.btnMuon.Radius = 40;
            this.btnMuon.Size = new System.Drawing.Size(343, 89);
            this.btnMuon.TabIndex = 3;
            this.btnMuon.Text = "Mượn Sách";
            this.btnMuon.TextOffsetX = 120;
            this.btnMuon.Click += new System.EventHandler(this.btnMuon_Click);
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(89, 12);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(120, 120);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 2;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaElipsePanel2
            // 
            this.gunaElipsePanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(32)))), ((int)(((byte)(105)))));
            this.gunaElipsePanel2.Controls.Add(this.label1);
            this.gunaElipsePanel2.Location = new System.Drawing.Point(58, 138);
            this.gunaElipsePanel2.Name = "gunaElipsePanel2";
            this.gunaElipsePanel2.Radius = 20;
            this.gunaElipsePanel2.Size = new System.Drawing.Size(182, 46);
            this.gunaElipsePanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tính";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gunaElipsePanel1
            // 
            this.gunaElipsePanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaElipsePanel1.BaseColor = System.Drawing.Color.White;
            this.gunaElipsePanel1.Controls.Add(this.usTraSachSV1);
            this.gunaElipsePanel1.Controls.Add(this.usMuonSach1);
            this.gunaElipsePanel1.Location = new System.Drawing.Point(309, 12);
            this.gunaElipsePanel1.Margin = new System.Windows.Forms.Padding(9);
            this.gunaElipsePanel1.Name = "gunaElipsePanel1";
            this.gunaElipsePanel1.Radius = 50;
            this.gunaElipsePanel1.Size = new System.Drawing.Size(1063, 777);
            this.gunaElipsePanel1.TabIndex = 1;
            // 
            // usMuonSach1
            // 
            this.usMuonSach1.Location = new System.Drawing.Point(0, 0);
            this.usMuonSach1.Name = "usMuonSach1";
            this.usMuonSach1.Size = new System.Drawing.Size(1063, 777);
            this.usMuonSach1.TabIndex = 0;
            this.usMuonSach1.Load += new System.EventHandler(this.usMuonSach1_Load);
            // 
            // usTraSachSV1
            // 
            this.usTraSachSV1.Location = new System.Drawing.Point(0, -3);
            this.usTraSachSV1.Name = "usTraSachSV1";
            this.usTraSachSV1.Size = new System.Drawing.Size(1063, 777);
            this.usTraSachSV1.TabIndex = 1;
            this.usTraSachSV1.Load += new System.EventHandler(this.usTraSachSV1_Load);
            // 
            // mainFrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(45)))), ((int)(((byte)(125)))));
            this.ClientSize = new System.Drawing.Size(1384, 801);
            this.Controls.Add(this.gunaElipsePanel1);
            this.Controls.Add(this.panel1);
            this.Name = "mainFrmSinhVien";
            this.Text = "Sinh Viên";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.gunaElipsePanel2.ResumeLayout(false);
            this.gunaElipsePanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel2;
        private Guna.UI.WinForms.GunaElipsePanel gunaElipsePanel1;
        private Guna.UI.WinForms.GunaButton btnMuon;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnTra;
        private UserControll.USMuonSachSV usMuonSach1;
        private UserControll.USTraSachSV usTraSachSV1;
    }
}

