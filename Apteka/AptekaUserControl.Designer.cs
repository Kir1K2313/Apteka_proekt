namespace Apteka
{
    partial class AptekaUserControl
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infopanel = new System.Windows.Forms.Panel();
            this.Vievpanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.infopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(24, 43);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Аптека";
            // 
            // infopanel
            // 
            this.infopanel.Controls.Add(this.pictureBox1);
            this.infopanel.Controls.Add(this.label1);
            this.infopanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.infopanel.Location = new System.Drawing.Point(0, 0);
            this.infopanel.Name = "infopanel";
            this.infopanel.Size = new System.Drawing.Size(1302, 314);
            this.infopanel.TabIndex = 9;
            // 
            // Vievpanel
            // 
            this.Vievpanel.AutoScroll = true;
            this.Vievpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Vievpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Vievpanel.Location = new System.Drawing.Point(0, 314);
            this.Vievpanel.Name = "Vievpanel";
            this.Vievpanel.Size = new System.Drawing.Size(1302, 373);
            this.Vievpanel.TabIndex = 10;
            // 
            // AptekaUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Vievpanel);
            this.Controls.Add(this.infopanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AptekaUserControl";
            this.Size = new System.Drawing.Size(1302, 687);
            this.Load += new System.EventHandler(this.AptekaUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.infopanel.ResumeLayout(false);
            this.infopanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel infopanel;
        private System.Windows.Forms.Panel Vievpanel;
    }
}
