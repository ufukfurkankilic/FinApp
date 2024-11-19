namespace MiniFinans
{
    partial class AktiviteEkle
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
            comboBoxGiderEkle = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerGiderekle = new DateTimePicker();
            txtGiderekleTutar = new TextBox();
            btnGiderekle = new Button();
            lblgideraçıklama = new Label();
            txtGiderAçıklama = new TextBox();
            SuspendLayout();
            // 
            // comboBoxGiderEkle
            // 
            comboBoxGiderEkle.FormattingEnabled = true;
            comboBoxGiderEkle.Location = new Point(118, 64);
            comboBoxGiderEkle.Name = "comboBoxGiderEkle";
            comboBoxGiderEkle.Size = new Size(121, 23);
            comboBoxGiderEkle.TabIndex = 14;
            comboBoxGiderEkle.SelectedIndexChanged += comboBoxGiderEkle_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 132);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 13;
            label3.Text = "Gider Tutarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 67);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 12;
            label2.Text = "Gider Kategorisi";
            // 
            // dateTimePickerGiderekle
            // 
            dateTimePickerGiderekle.Location = new Point(58, 12);
            dateTimePickerGiderekle.Name = "dateTimePickerGiderekle";
            dateTimePickerGiderekle.Size = new Size(164, 23);
            dateTimePickerGiderekle.TabIndex = 11;
            // 
            // txtGiderekleTutar
            // 
            txtGiderekleTutar.Location = new Point(118, 129);
            txtGiderekleTutar.Multiline = true;
            txtGiderekleTutar.Name = "txtGiderekleTutar";
            txtGiderekleTutar.Size = new Size(121, 23);
            txtGiderekleTutar.TabIndex = 10;
            txtGiderekleTutar.TextChanged += txtGiderekleTutar_TextChanged;
            // 
            // btnGiderekle
            // 
            btnGiderekle.Location = new Point(195, 158);
            btnGiderekle.Name = "btnGiderekle";
            btnGiderekle.Size = new Size(44, 23);
            btnGiderekle.TabIndex = 8;
            btnGiderekle.Text = "Ekle";
            btnGiderekle.UseVisualStyleBackColor = true;
            btnGiderekle.Click += btnGiderekle_Click;
            // 
            // lblgideraçıklama
            // 
            lblgideraçıklama.AutoSize = true;
            lblgideraçıklama.Location = new Point(21, 100);
            lblgideraçıklama.Name = "lblgideraçıklama";
            lblgideraçıklama.Size = new Size(95, 15);
            lblgideraçıklama.TabIndex = 16;
            lblgideraçıklama.Text = "Gider Açıklaması";
            // 
            // txtGiderAçıklama
            // 
            txtGiderAçıklama.Location = new Point(118, 97);
            txtGiderAçıklama.Multiline = true;
            txtGiderAçıklama.Name = "txtGiderAçıklama";
            txtGiderAçıklama.Size = new Size(121, 23);
            txtGiderAçıklama.TabIndex = 15;
            // 
            // AktiviteEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 195);
            Controls.Add(lblgideraçıklama);
            Controls.Add(txtGiderAçıklama);
            Controls.Add(comboBoxGiderEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerGiderekle);
            Controls.Add(txtGiderekleTutar);
            Controls.Add(btnGiderekle);
            Name = "AktiviteEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gelir Ekle";
            Load += AktiviteEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGiderEkle;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerGiderekle;
        private TextBox txtGiderekleTutar;
        private Button btnGiderekle;
        private Label lblgideraçıklama;
        private TextBox txtGiderAçıklama;
    }
}