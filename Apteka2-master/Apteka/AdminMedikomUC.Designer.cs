namespace Apteka
{
    partial class AdminMedikomUC
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Infopanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAptekapanel = new System.Windows.Forms.Panel();
            this.NamemedicTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.NameClassifCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.MedicpictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddMedicbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Infopanel.SuspendLayout();
            this.AddAptekapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Infopanel
            // 
            this.Infopanel.AutoScroll = true;
            this.Infopanel.Controls.Add(this.label1);
            this.Infopanel.Controls.Add(this.label4);
            this.Infopanel.Controls.Add(this.label3);
            this.Infopanel.Controls.Add(this.label2);
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Infopanel.Location = new System.Drawing.Point(0, 0);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(965, 196);
            this.Infopanel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(578, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Классификация";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Аптека";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Управление медикаментами";
            // 
            // AddAptekapanel
            // 
            this.AddAptekapanel.Controls.Add(this.NamemedicTB);
            this.AddAptekapanel.Controls.Add(this.label8);
            this.AddAptekapanel.Controls.Add(this.NameClassifCB);
            this.AddAptekapanel.Controls.Add(this.label5);
            this.AddAptekapanel.Controls.Add(this.MedicpictureBox);
            this.AddAptekapanel.Controls.Add(this.label7);
            this.AddAptekapanel.Controls.Add(this.AddMedicbutton);
            this.AddAptekapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAptekapanel.Location = new System.Drawing.Point(0, 196);
            this.AddAptekapanel.Name = "AddAptekapanel";
            this.AddAptekapanel.Size = new System.Drawing.Size(965, 331);
            this.AddAptekapanel.TabIndex = 4;
            // 
            // NamemedicTB
            // 
            this.NamemedicTB.Location = new System.Drawing.Point(23, 35);
            this.NamemedicTB.Name = "NamemedicTB";
            this.NamemedicTB.Size = new System.Drawing.Size(281, 34);
            this.NamemedicTB.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(194, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Классификация";
            // 
            // NameClassifCB
            // 
            this.NameClassifCB.FormattingEnabled = true;
            this.NameClassifCB.Items.AddRange(new object[] {
            "Таблетки",
            "Мази",
            "Антибиотики"});
            this.NameClassifCB.Location = new System.Drawing.Point(23, 104);
            this.NameClassifCB.Name = "NameClassifCB";
            this.NameClassifCB.Size = new System.Drawing.Size(395, 37);
            this.NameClassifCB.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Название";
            // 
            // MedicpictureBox
            // 
            this.MedicpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MedicpictureBox.Location = new System.Drawing.Point(583, 46);
            this.MedicpictureBox.Name = "MedicpictureBox";
            this.MedicpictureBox.Size = new System.Drawing.Size(307, 154);
            this.MedicpictureBox.TabIndex = 3;
            this.MedicpictureBox.TabStop = false;
            this.MedicpictureBox.Click += new System.EventHandler(this.MedicpictureBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(578, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Фото";
            // 
            // AddMedicbutton
            // 
            this.AddMedicbutton.Location = new System.Drawing.Point(335, 147);
            this.AddMedicbutton.Name = "AddMedicbutton";
            this.AddMedicbutton.Size = new System.Drawing.Size(182, 75);
            this.AddMedicbutton.TabIndex = 0;
            this.AddMedicbutton.Text = "Добавить";
            this.AddMedicbutton.UseVisualStyleBackColor = true;
            this.AddMedicbutton.Click += new System.EventHandler(this.AddMedicbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // AdminMedikomUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddAptekapanel);
            this.Controls.Add(this.Infopanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminMedikomUC";
            this.Size = new System.Drawing.Size(965, 527);
            this.Load += new System.EventHandler(this.AdminMedikomUC_Load);
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            this.AddAptekapanel.ResumeLayout(false);
            this.AddAptekapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MedicpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel AddAptekapanel;
        private System.Windows.Forms.ComboBox NameClassifCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox MedicpictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddMedicbutton;
        private System.Windows.Forms.TextBox NamemedicTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
