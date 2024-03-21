namespace Apteka
{
    partial class AdminClassifUC
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddAptekapanel = new System.Windows.Forms.Panel();
            this.NameAptekaCB = new System.Windows.Forms.ComboBox();
            this.NameClassifCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ClassifpictureBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddClassifbutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Infopanel.SuspendLayout();
            this.AddAptekapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassifpictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Infopanel
            // 
            this.Infopanel.AutoScroll = true;
            this.Infopanel.Controls.Add(this.label4);
            this.Infopanel.Controls.Add(this.label3);
            this.Infopanel.Controls.Add(this.label2);
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Infopanel.Location = new System.Drawing.Point(0, 0);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(950, 195);
            this.Infopanel.TabIndex = 2;
            this.Infopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Infopanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(462, 59);
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
            this.label2.Size = new System.Drawing.Size(369, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Управление классификациями";
            // 
            // AddAptekapanel
            // 
            this.AddAptekapanel.Controls.Add(this.NameAptekaCB);
            this.AddAptekapanel.Controls.Add(this.NameClassifCB);
            this.AddAptekapanel.Controls.Add(this.label6);
            this.AddAptekapanel.Controls.Add(this.label5);
            this.AddAptekapanel.Controls.Add(this.ClassifpictureBox);
            this.AddAptekapanel.Controls.Add(this.label7);
            this.AddAptekapanel.Controls.Add(this.AddClassifbutton);
            this.AddAptekapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAptekapanel.Location = new System.Drawing.Point(0, 195);
            this.AddAptekapanel.Name = "AddAptekapanel";
            this.AddAptekapanel.Size = new System.Drawing.Size(950, 335);
            this.AddAptekapanel.TabIndex = 3;
            // 
            // NameAptekaCB
            // 
            this.NameAptekaCB.FormattingEnabled = true;
            this.NameAptekaCB.Location = new System.Drawing.Point(69, 125);
            this.NameAptekaCB.Name = "NameAptekaCB";
            this.NameAptekaCB.Size = new System.Drawing.Size(266, 37);
            this.NameAptekaCB.TabIndex = 8;
            // 
            // NameClassifCB
            // 
            this.NameClassifCB.FormattingEnabled = true;
            this.NameClassifCB.Items.AddRange(new object[] {
            "Таблетки",
            "Мази",
            "Антибиотики"});
            this.NameClassifCB.Location = new System.Drawing.Point(69, 42);
            this.NameClassifCB.Name = "NameClassifCB";
            this.NameClassifCB.Size = new System.Drawing.Size(266, 37);
            this.NameClassifCB.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Аптека";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Название";
            // 
            // ClassifpictureBox
            // 
            this.ClassifpictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClassifpictureBox.Location = new System.Drawing.Point(547, 42);
            this.ClassifpictureBox.Name = "ClassifpictureBox";
            this.ClassifpictureBox.Size = new System.Drawing.Size(307, 154);
            this.ClassifpictureBox.TabIndex = 3;
            this.ClassifpictureBox.TabStop = false;
            this.ClassifpictureBox.Click += new System.EventHandler(this.ClassifpictureBox_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 29);
            this.label7.TabIndex = 2;
            this.label7.Text = "Фото";
            // 
            // AddClassifbutton
            // 
            this.AddClassifbutton.Location = new System.Drawing.Point(341, 121);
            this.AddClassifbutton.Name = "AddClassifbutton";
            this.AddClassifbutton.Size = new System.Drawing.Size(182, 75);
            this.AddClassifbutton.TabIndex = 0;
            this.AddClassifbutton.Text = "Добавить";
            this.AddClassifbutton.UseVisualStyleBackColor = true;
            this.AddClassifbutton.Click += new System.EventHandler(this.AddClassifbutton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // AdminClassifUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddAptekapanel);
            this.Controls.Add(this.Infopanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminClassifUC";
            this.Size = new System.Drawing.Size(950, 530);
            this.Load += new System.EventHandler(this.AdminClassifUC_Load);
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            this.AddAptekapanel.ResumeLayout(false);
            this.AddAptekapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassifpictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel AddAptekapanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox ClassifpictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddClassifbutton;
        private System.Windows.Forms.ComboBox NameAptekaCB;
        private System.Windows.Forms.ComboBox NameClassifCB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
