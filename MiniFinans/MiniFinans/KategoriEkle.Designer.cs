namespace MiniFinans
{
    partial class KategoriEkle
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
            btnGiderkategoriekle = new Button();
            label1 = new Label();
            txtGiderKategori = new TextBox();
            txtGelirKategori = new TextBox();
            label2 = new Label();
            btnGelirKategoriEkle = new Button();
            SuspendLayout();
            // 
            // btnGiderkategoriekle
            // 
            btnGiderkategoriekle.Location = new Point(38, 91);
            btnGiderkategoriekle.Name = "btnGiderkategoriekle";
            btnGiderkategoriekle.Size = new Size(75, 23);
            btnGiderkategoriekle.TabIndex = 0;
            btnGiderkategoriekle.Text = "Ekle";
            btnGiderkategoriekle.UseVisualStyleBackColor = true;
            btnGiderkategoriekle.Click += btnkategoriekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 35);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 1;
            label1.Text = "Gider Kategorisi Ekle";
            // 
            // txtGiderKategori
            // 
            txtGiderKategori.Location = new Point(11, 62);
            txtGiderKategori.Name = "txtGiderKategori";
            txtGiderKategori.Size = new Size(122, 23);
            txtGiderKategori.TabIndex = 2;
            // 
            // txtGelirKategori
            // 
            txtGelirKategori.Location = new Point(179, 62);
            txtGelirKategori.Name = "txtGelirKategori";
            txtGelirKategori.Size = new Size(122, 23);
            txtGelirKategori.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 35);
            label2.Name = "label2";
            label2.Size = new Size(110, 15);
            label2.TabIndex = 4;
            label2.Text = "Gelir Kategorisi Ekle";
            // 
            // btnGelirKategoriEkle
            // 
            btnGelirKategoriEkle.Location = new Point(206, 91);
            btnGelirKategoriEkle.Name = "btnGelirKategoriEkle";
            btnGelirKategoriEkle.Size = new Size(75, 23);
            btnGelirKategoriEkle.TabIndex = 3;
            btnGelirKategoriEkle.Text = "Ekle";
            btnGelirKategoriEkle.UseVisualStyleBackColor = true;
            btnGelirKategoriEkle.Click += btnGelirKategoriEkle_Click;
            // 
            // KategoriEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 173);
            Controls.Add(txtGelirKategori);
            Controls.Add(label2);
            Controls.Add(btnGelirKategoriEkle);
            Controls.Add(txtGiderKategori);
            Controls.Add(label1);
            Controls.Add(btnGiderkategoriekle);
            Name = "KategoriEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "KategoriEkle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiderkategoriekle;
        private Label label1;
        private TextBox txtGiderKategori;
        private TextBox txtGelirKategori;
        private Label label2;
        private Button btnGelirKategoriEkle;
    }
}