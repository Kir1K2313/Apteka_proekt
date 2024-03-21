namespace Apteka
{
    partial class RegForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ConfirtextBox = new System.Windows.Forms.TextBox();
            this.FamaletextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PasttextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрационная форма";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(286, 29);
            this.label7.TabIndex = 25;
            this.label7.Text = "Подтверждение пароля";
            // 
            // ConfirtextBox
            // 
            this.ConfirtextBox.Location = new System.Drawing.Point(17, 437);
            this.ConfirtextBox.Name = "ConfirtextBox";
            this.ConfirtextBox.Size = new System.Drawing.Size(505, 34);
            this.ConfirtextBox.TabIndex = 24;
            // 
            // FamaletextBox
            // 
            this.FamaletextBox.Location = new System.Drawing.Point(17, 196);
            this.FamaletextBox.Name = "FamaletextBox";
            this.FamaletextBox.Size = new System.Drawing.Size(500, 34);
            this.FamaletextBox.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 29);
            this.label5.TabIndex = 22;
            this.label5.Text = "Пароль";
            // 
            // PasttextBox
            // 
            this.PasttextBox.Location = new System.Drawing.Point(17, 356);
            this.PasttextBox.Name = "PasttextBox";
            this.PasttextBox.Size = new System.Drawing.Size(505, 34);
            this.PasttextBox.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 29);
            this.label4.TabIndex = 20;
            this.label4.Text = "Логин";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(17, 276);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(505, 34);
            this.LogintextBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 29);
            this.label3.TabIndex = 18;
            this.label3.Text = "Фамилия";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 29);
            this.label2.TabIndex = 17;
            this.label2.Text = "Имя";
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(17, 104);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(505, 34);
            this.NametextBox.TabIndex = 16;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 510);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(543, 123);
            this.button1.TabIndex = 15;
            this.button1.Text = "Зарегистрироваться";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 734);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ConfirtextBox);
            this.Controls.Add(this.FamaletextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.PasttextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LogintextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "RegForm";
            this.Text = "RegForm";
            this.Load += new System.EventHandler(this.RegForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ConfirtextBox;
        private System.Windows.Forms.TextBox FamaletextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox PasttextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.Button button1;
    }
}