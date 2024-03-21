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
            this.label1 = new System.Windows.Forms.Label();
            this.Aptekabutton = new System.Windows.Forms.Button();
            this.Classifbutton = new System.Windows.Forms.Button();
            this.Medicombutton = new System.Windows.Forms.Button();
            this.Usersbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель Админа";
            // 
            // Aptekabutton
            // 
            this.Aptekabutton.Location = new System.Drawing.Point(191, 73);
            this.Aptekabutton.Name = "Aptekabutton";
            this.Aptekabutton.Size = new System.Drawing.Size(530, 62);
            this.Aptekabutton.TabIndex = 1;
            this.Aptekabutton.Text = "Управления аптеками";
            this.Aptekabutton.UseVisualStyleBackColor = true;
            this.Aptekabutton.Click += new System.EventHandler(this.Aptekabutton_Click);
            // 
            // Classifbutton
            // 
            this.Classifbutton.Location = new System.Drawing.Point(191, 141);
            this.Classifbutton.Name = "Classifbutton";
            this.Classifbutton.Size = new System.Drawing.Size(530, 65);
            this.Classifbutton.TabIndex = 2;
            this.Classifbutton.Text = "Управление классификациями";
            this.Classifbutton.UseVisualStyleBackColor = true;
            this.Classifbutton.Click += new System.EventHandler(this.Classifbutton_Click);
            // 
            // Medicombutton
            // 
            this.Medicombutton.Location = new System.Drawing.Point(191, 212);
            this.Medicombutton.Name = "Medicombutton";
            this.Medicombutton.Size = new System.Drawing.Size(530, 78);
            this.Medicombutton.TabIndex = 3;
            this.Medicombutton.Text = "Управление медикомент";
            this.Medicombutton.UseVisualStyleBackColor = true;
            this.Medicombutton.Click += new System.EventHandler(this.Medicombutton_Click);
            // 
            // Usersbutton
            // 
            this.Usersbutton.Location = new System.Drawing.Point(191, 296);
            this.Usersbutton.Name = "Usersbutton";
            this.Usersbutton.Size = new System.Drawing.Size(530, 80);
            this.Usersbutton.TabIndex = 4;
            this.Usersbutton.Text = "Упраление пользователями";
            this.Usersbutton.UseVisualStyleBackColor = true;
            this.Usersbutton.Click += new System.EventHandler(this.Usersbutton_Click);
            // 
            // AdminUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Usersbutton);
            this.Controls.Add(this.Medicombutton);
            this.Controls.Add(this.Classifbutton);
            this.Controls.Add(this.Aptekabutton);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "AdminUserControl";
            this.Size = new System.Drawing.Size(1159, 612);
            this.Load += new System.EventHandler(this.AdminUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Aptekabutton;
        private System.Windows.Forms.Button Classifbutton;
        private System.Windows.Forms.Button Medicombutton;
        private System.Windows.Forms.Button Usersbutton;
    }
}
