namespace Apteka
{
    partial class ClasificatsiaUserControl
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
            this.meduclabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Vievpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Vievpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // meduclabel
            // 
            this.meduclabel.AutoSize = true;
            this.meduclabel.Location = new System.Drawing.Point(93, 10);
            this.meduclabel.Margin = new System.Windows.Forms.Padding(9, 0, 9, 0);
            this.meduclabel.Name = "meduclabel";
            this.meduclabel.Size = new System.Drawing.Size(79, 29);
            this.meduclabel.TabIndex = 3;
            this.meduclabel.Text = "label1";
            this.meduclabel.Click += new System.EventHandler(this.meduclabel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(98, 48);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(355, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Vievpanel
            // 
            this.Vievpanel.Controls.Add(this.meduclabel);
            this.Vievpanel.Controls.Add(this.pictureBox1);
            this.Vievpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vievpanel.Location = new System.Drawing.Point(0, 0);
            this.Vievpanel.Name = "Vievpanel";
            this.Vievpanel.Size = new System.Drawing.Size(1172, 854);
            this.Vievpanel.TabIndex = 4;
            // 
            // ClasificatsiaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Vievpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ClasificatsiaUserControl";
            this.Size = new System.Drawing.Size(1172, 854);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Vievpanel.ResumeLayout(false);
            this.Vievpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label meduclabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Vievpanel;
    }
}
