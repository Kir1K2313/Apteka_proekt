namespace Apteka
{
    partial class AdminUserControl
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
            this.Aptekabutton = new System.Windows.Forms.Button();
            this.Classifbutton = new System.Windows.Forms.Button();
            this.Medicombutton = new System.Windows.Forms.Button();
            this.Usersbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Aptekabutton
            // 
            this.Aptekabutton.Location = new System.Drawing.Point(388, 180);
            this.Aptekabutton.Name = "Aptekabutton";
            this.Aptekabutton.Size = new System.Drawing.Size(413, 64);
            this.Aptekabutton.TabIndex = 0;
            this.Aptekabutton.Text = "Управление аптеками";
            this.Aptekabutton.UseVisualStyleBackColor = true;
            // 
            // Classifbutton
            // 
            this.Classifbutton.Location = new System.Drawing.Point(388, 250);
            this.Classifbutton.Name = "Classifbutton";
            this.Classifbutton.Size = new System.Drawing.Size(413, 62);
            this.Classifbutton.TabIndex = 1;
            this.Classifbutton.Text = "Управление классификациями";
            this.Classifbutton.UseVisualStyleBackColor = true;
            // 
            // Medicombutton
            // 
            this.Medicombutton.Location = new System.Drawing.Point(388, 318);
            this.Medicombutton.Name = "Medicombutton";
            this.Medicombutton.Size = new System.Drawing.Size(413, 62);
            this.Medicombutton.TabIndex = 2;
            this.Medicombutton.Text = "Управление медикоментами";
            this.Medicombutton.UseVisualStyleBackColor = true;
            // 
            // Usersbutton
            // 
            this.Usersbutton.Location = new System.Drawing.Point(390, 386);
            this.Usersbutton.Name = "Usersbutton";
            this.Usersbutton.Size = new System.Drawing.Size(411, 67);
            this.Usersbutton.TabIndex = 3;
            this.Usersbutton.Text = "Управление пользователями";
            this.Usersbutton.UseVisualStyleBackColor = true;
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Usersbutton);
            this.Controls.Add(this.Medicombutton);
            this.Controls.Add(this.Classifbutton);
            this.Controls.Add(this.Aptekabutton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(1199, 667);
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Aptekabutton;
        private System.Windows.Forms.Button Classifbutton;
        private System.Windows.Forms.Button Medicombutton;
        private System.Windows.Forms.Button Usersbutton;
    }
}
