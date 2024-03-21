namespace Apteka
{
    partial class AdminAptekUCcs
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
            this.label1 = new System.Windows.Forms.Label();
            this.Infopanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAptekapanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AdressAptekaTB = new System.Windows.Forms.TextBox();
            this.AptekapictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameAptekaTB = new System.Windows.Forms.TextBox();
            this.AddAptekabutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.Infopanel.SuspendLayout();
            this.AddAptekapanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AptekapictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Управление аптеками";
            // 
            // Infopanel
            // 
            this.Infopanel.AutoScroll = true;
            this.Infopanel.Controls.Add(this.label4);
            this.Infopanel.Controls.Add(this.label3);
            this.Infopanel.Controls.Add(this.label1);
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Infopanel.Location = new System.Drawing.Point(0, 0);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(983, 274);
            this.Infopanel.TabIndex = 1;
            this.Infopanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Infopanel_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(322, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Название";
            // 
            // AddAptekapanel
            // 
            this.AddAptekapanel.Controls.Add(this.label6);
            this.AddAptekapanel.Controls.Add(this.label5);
            this.AddAptekapanel.Controls.Add(this.AdressAptekaTB);
            this.AddAptekapanel.Controls.Add(this.AptekapictureBox);
            this.AddAptekapanel.Controls.Add(this.label2);
            this.AddAptekapanel.Controls.Add(this.NameAptekaTB);
            this.AddAptekapanel.Controls.Add(this.AddAptekabutton);
            this.AddAptekapanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddAptekapanel.Location = new System.Drawing.Point(0, 274);
            this.AddAptekapanel.Name = "AddAptekapanel";
            this.AddAptekapanel.Size = new System.Drawing.Size(983, 343);
            this.AddAptekapanel.TabIndex = 2;
            this.AddAptekapanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Addpanel_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(133, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 29);
            this.label6.TabIndex = 6;
            this.label6.Text = "Адрес";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(133, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Название";
            // 
            // AdressAptekaTB
            // 
            this.AdressAptekaTB.Location = new System.Drawing.Point(138, 116);
            this.AdressAptekaTB.Name = "AdressAptekaTB";
            this.AdressAptekaTB.Size = new System.Drawing.Size(266, 34);
            this.AdressAptekaTB.TabIndex = 4;
            // 
            // AptekapictureBox
            // 
            this.AptekapictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AptekapictureBox.Location = new System.Drawing.Point(547, 42);
            this.AptekapictureBox.Name = "AptekapictureBox";
            this.AptekapictureBox.Size = new System.Drawing.Size(307, 154);
            this.AptekapictureBox.TabIndex = 3;
            this.AptekapictureBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(542, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фото";
            // 
            // NameAptekaTB
            // 
            this.NameAptekaTB.Location = new System.Drawing.Point(138, 42);
            this.NameAptekaTB.Name = "NameAptekaTB";
            this.NameAptekaTB.Size = new System.Drawing.Size(266, 34);
            this.NameAptekaTB.TabIndex = 1;
            // 
            // AddAptekabutton
            // 
            this.AddAptekabutton.Location = new System.Drawing.Point(199, 182);
            this.AddAptekabutton.Name = "AddAptekabutton";
            this.AddAptekabutton.Size = new System.Drawing.Size(182, 75);
            this.AddAptekabutton.TabIndex = 0;
            this.AddAptekabutton.Text = "Добавить";
            this.AddAptekabutton.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // AdminAptekUCcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.AddAptekapanel);
            this.Controls.Add(this.Infopanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminAptekUCcs";
            this.Size = new System.Drawing.Size(983, 617);
            this.Load += new System.EventHandler(this.AdminAptekUCcs_Load);
            this.Infopanel.ResumeLayout(false);
            this.Infopanel.PerformLayout();
            this.AddAptekapanel.ResumeLayout(false);
            this.AddAptekapanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AptekapictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Panel AddAptekapanel;
        private System.Windows.Forms.Button AddAptekabutton;
        private System.Windows.Forms.TextBox NameAptekaTB;
        private System.Windows.Forms.PictureBox AptekapictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox AdressAptekaTB;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
    }
}
