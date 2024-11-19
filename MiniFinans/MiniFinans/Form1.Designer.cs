namespace MiniFinans
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dateTimePicker1 = new DateTimePicker();
            dataGridView2 = new DataGridView();
            btnekle = new Button();
            btnlistele = new Button();
            btnkategoriekle = new Button();
            dataGridView1 = new DataGridView();
            btnGelirListele = new Button();
            btnGelir = new Button();
            label6 = new Label();
            label7 = new Label();
            label8Toplam = new Label();
            btnTopla = new Button();
            btnSil = new Button();
            lblDolar = new Label();
            lblEuro = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label8 = new Label();
            label9 = new Label();
            lblSterlin = new Label();
            btnTarihGetir = new Button();
            label1 = new Label();
            label2 = new Label();
            label10 = new Label();
            btnRaporlar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(318, 29);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(170, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Gray;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Dock = DockStyle.Left;
            dataGridView2.Location = new Point(0, 0);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(274, 450);
            dataGridView2.TabIndex = 2;
            // 
            // btnekle
            // 
            btnekle.Location = new Point(318, 144);
            btnekle.Name = "btnekle";
            btnekle.Size = new Size(75, 41);
            btnekle.TabIndex = 3;
            btnekle.Text = "Gider Ekle";
            btnekle.UseVisualStyleBackColor = true;
            btnekle.Click += btnekle_Click;
            // 
            // btnlistele
            // 
            btnlistele.Location = new Point(295, 191);
            btnlistele.Name = "btnlistele";
            btnlistele.Size = new Size(75, 41);
            btnlistele.TabIndex = 10;
            btnlistele.Text = "Gider Listele";
            btnlistele.UseVisualStyleBackColor = true;
            btnlistele.Click += btnlistele_Click;
            // 
            // btnkategoriekle
            // 
            btnkategoriekle.Location = new Point(359, 97);
            btnkategoriekle.Name = "btnkategoriekle";
            btnkategoriekle.Size = new Size(75, 41);
            btnkategoriekle.TabIndex = 11;
            btnkategoriekle.Text = "Kategori Ekle";
            btnkategoriekle.UseVisualStyleBackColor = true;
            btnkategoriekle.Click += btnkategoriekle_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Gray;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(528, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(272, 450);
            dataGridView1.TabIndex = 12;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnGelirListele
            // 
            btnGelirListele.Location = new Point(435, 191);
            btnGelirListele.Name = "btnGelirListele";
            btnGelirListele.Size = new Size(72, 40);
            btnGelirListele.TabIndex = 13;
            btnGelirListele.Text = "Gelir Listele";
            btnGelirListele.UseVisualStyleBackColor = true;
            btnGelirListele.Click += btnGelirListele_Click;
            // 
            // btnGelir
            // 
            btnGelir.Location = new Point(397, 144);
            btnGelir.Name = "btnGelir";
            btnGelir.Size = new Size(75, 41);
            btnGelir.TabIndex = 14;
            btnGelir.Text = "Gelir Ekle";
            btnGelir.UseVisualStyleBackColor = true;
            btnGelir.Click += btnGider_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(392, 255);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(392, 270);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 21;
            // 
            // label8Toplam
            // 
            label8Toplam.AutoSize = true;
            label8Toplam.Location = new Point(392, 320);
            label8Toplam.Name = "label8Toplam";
            label8Toplam.Size = new Size(0, 15);
            label8Toplam.TabIndex = 22;
            label8Toplam.Click += label8Toplam_Click;
            // 
            // btnTopla
            // 
            btnTopla.Location = new Point(372, 291);
            btnTopla.Name = "btnTopla";
            btnTopla.Size = new Size(53, 23);
            btnTopla.TabIndex = 23;
            btnTopla.Text = "Topla";
            btnTopla.UseVisualStyleBackColor = true;
            btnTopla.Click += btnTopla_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(477, 385);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(45, 23);
            btnSil.TabIndex = 24;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Location = new Point(355, 6);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(0, 15);
            lblDolar.TabIndex = 25;
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Location = new Point(448, 6);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(0, 15);
            lblEuro.TabIndex = 26;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(313, 6);
            label8.Name = "label8";
            label8.Size = new Size(41, 15);
            label8.TabIndex = 28;
            label8.Text = "Dolar :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(410, 6);
            label9.Name = "label9";
            label9.Size = new Size(37, 15);
            label9.TabIndex = 29;
            label9.Text = "Euro :";
            // 
            // lblSterlin
            // 
            lblSterlin.AutoSize = true;
            lblSterlin.Location = new Point(397, 55);
            lblSterlin.Name = "lblSterlin";
            lblSterlin.Size = new Size(0, 15);
            lblSterlin.TabIndex = 27;
            // 
            // btnTarihGetir
            // 
            btnTarihGetir.Location = new Point(435, 59);
            btnTarihGetir.Name = "btnTarihGetir";
            btnTarihGetir.Size = new Size(53, 23);
            btnTarihGetir.TabIndex = 30;
            btnTarihGetir.Text = "Getir";
            btnTarihGetir.UseVisualStyleBackColor = true;
            btnTarihGetir.Click += btnTarihGetir_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(351, 255);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 31;
            label1.Text = "Gelir :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 269);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 32;
            label2.Text = "Gider :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(336, 320);
            label10.Name = "label10";
            label10.Size = new Size(52, 15);
            label10.TabIndex = 33;
            label10.Text = "Toplam :";
            // 
            // btnRaporlar
            // 
            btnRaporlar.Location = new Point(364, 427);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(75, 23);
            btnRaporlar.TabIndex = 34;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.UseVisualStyleBackColor = true;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRaporlar);
            Controls.Add(label10);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTarihGetir);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(lblSterlin);
            Controls.Add(lblEuro);
            Controls.Add(lblDolar);
            Controls.Add(btnSil);
            Controls.Add(btnTopla);
            Controls.Add(label8Toplam);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnGelir);
            Controls.Add(btnGelirListele);
            Controls.Add(dataGridView1);
            Controls.Add(btnkategoriekle);
            Controls.Add(btnlistele);
            Controls.Add(btnekle);
            Controls.Add(dataGridView2);
            Controls.Add(dateTimePicker1);
            KeyPreview = true;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView2;
        private Button btnekle;
        private Button btnlistele;
        private Button btnkategoriekle;
        private DataGridView dataGridView1;
        private Button btnGelirListele;
        private Button btnGelir;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8Toplam;
        private Button btnTopla;
        private Button btnSil;
        private Label lblDolar;
        private Label lblEuro;
        private System.Windows.Forms.Timer timer1;
        private Label label8;
        private Label label9;
        private Label lblSterlin;
        private Button btnTarihGetir;
        private Label label1;
        private Label label2;
        private Label label10;
        private Button btnRaporlar;
    }
}
