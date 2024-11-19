namespace MiniFinans
{
    partial class Raporlar
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
            dateTimePicker1 = new DateTimePicker();
            btnGelirRapor = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dataGridView2 = new DataGridView();
            dateTimePicker3 = new DateTimePicker();
            btnGiderRapor = new Button();
            dateTimePicker4 = new DateTimePicker();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(64, 35);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(110, 23);
            dateTimePicker1.TabIndex = 0;
            // 
            // btnGelirRapor
            // 
            btnGelirRapor.Location = new Point(228, 64);
            btnGelirRapor.Name = "btnGelirRapor";
            btnGelirRapor.Size = new Size(61, 23);
            btnGelirRapor.TabIndex = 1;
            btnGelirRapor.Text = "Sorgula";
            btnGelirRapor.UseVisualStyleBackColor = true;
            btnGelirRapor.Click += btnGelirRapor_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(379, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(350, 193);
            dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 299);
            label1.Name = "label1";
            label1.Size = new Size(37, 15);
            label1.TabIndex = 3;
            label1.Text = "Gelir :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 314);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 4;
            label2.Text = "Gider :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(313, 347);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 5;
            label3.Text = "Toplam :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(365, 299);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(365, 314);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(365, 348);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 8;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(180, 35);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(109, 23);
            dateTimePicker2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(2, 93);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(350, 193);
            dataGridView2.TabIndex = 10;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(557, 35);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(109, 23);
            dateTimePicker3.TabIndex = 13;
            // 
            // btnGiderRapor
            // 
            btnGiderRapor.Location = new Point(605, 64);
            btnGiderRapor.Name = "btnGiderRapor";
            btnGiderRapor.Size = new Size(61, 23);
            btnGiderRapor.TabIndex = 12;
            btnGiderRapor.Text = "Sorgula";
            btnGiderRapor.UseVisualStyleBackColor = true;
            btnGiderRapor.Click += btnGiderRapor_Click;
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(441, 35);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(110, 23);
            dateTimePicker4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(144, 13);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 14;
            label7.Text = "Gelir Listele";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(517, 13);
            label8.Name = "label8";
            label8.Size = new Size(71, 15);
            label8.TabIndex = 15;
            label8.Text = "Gider Listele";
            // 
            // Raporlar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(741, 383);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(dateTimePicker3);
            Controls.Add(btnGiderRapor);
            Controls.Add(dateTimePicker4);
            Controls.Add(dataGridView2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(btnGelirRapor);
            Controls.Add(dateTimePicker1);
            Name = "Raporlar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Raporlar";
            Load += Raporlar_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker1;
        private Button btnGelirRapor;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker dateTimePicker2;
        private DataGridView dataGridView2;
        private DateTimePicker dateTimePicker3;
        private Button btnGiderRapor;
        private DateTimePicker dateTimePicker4;
        private Label label7;
        private Label label8;
    }
}