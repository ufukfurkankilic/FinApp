namespace MiniFinans
{
    partial class GelirEkle
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
            comboBoxGelirEkle = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            dateTimePickerGiderekle = new DateTimePicker();
            txtGelirekleTutar = new TextBox();
            btnGelirekle = new Button();
            label1 = new Label();
            txtGelirAçıklama = new TextBox();
            SuspendLayout();
            // 
            // comboBoxGelirEkle
            // 
            comboBoxGelirEkle.FormattingEnabled = true;
            comboBoxGelirEkle.Location = new Point(127, 60);
            comboBoxGelirEkle.Name = "comboBoxGelirEkle";
            comboBoxGelirEkle.Size = new Size(121, 23);
            comboBoxGelirEkle.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(54, 121);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 20;
            label3.Text = "Gelir Tutarı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 63);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 19;
            label2.Text = "Gelir Kategorisi";
            // 
            // dateTimePickerGiderekle
            // 
            dateTimePickerGiderekle.Location = new Point(70, 12);
            dateTimePickerGiderekle.Name = "dateTimePickerGiderekle";
            dateTimePickerGiderekle.Size = new Size(164, 23);
            dateTimePickerGiderekle.TabIndex = 18;
            // 
            // txtGelirekleTutar
            // 
            txtGelirekleTutar.Location = new Point(127, 118);
            txtGelirekleTutar.Multiline = true;
            txtGelirekleTutar.Name = "txtGelirekleTutar";
            txtGelirekleTutar.Size = new Size(121, 23);
            txtGelirekleTutar.TabIndex = 17;
            // 
            // btnGelirekle
            // 
            btnGelirekle.Location = new Point(204, 148);
            btnGelirekle.Name = "btnGelirekle";
            btnGelirekle.Size = new Size(44, 23);
            btnGelirekle.TabIndex = 15;
            btnGelirekle.Text = "Ekle";
            btnGelirekle.UseVisualStyleBackColor = true;
            btnGelirekle.Click += btnGelirekle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 92);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 23;
            label1.Text = "Gelir Açıklama";
            // 
            // txtGelirAçıklama
            // 
            txtGelirAçıklama.Location = new Point(127, 89);
            txtGelirAçıklama.Multiline = true;
            txtGelirAçıklama.Name = "txtGelirAçıklama";
            txtGelirAçıklama.Size = new Size(121, 23);
            txtGelirAçıklama.TabIndex = 22;
            // 
            // GelirEkle
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(324, 183);
            Controls.Add(label1);
            Controls.Add(txtGelirAçıklama);
            Controls.Add(comboBoxGelirEkle);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dateTimePickerGiderekle);
            Controls.Add(txtGelirekleTutar);
            Controls.Add(btnGelirekle);
            Name = "GelirEkle";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GelirEkle";
            Load += GelirEkle_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxGelirEkle;
        private Label label3;
        private Label label2;
        private DateTimePicker dateTimePickerGiderekle;
        private TextBox txtGelirekleTutar;
        private Button btnGelirekle;
        private Label label1;
        private TextBox txtGelirAçıklama;
    }
}