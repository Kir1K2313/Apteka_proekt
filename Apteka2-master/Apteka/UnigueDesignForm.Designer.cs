namespace Apteka
{
    partial class UnigueDesignForm
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
            this.Fontbtn = new System.Windows.Forms.Button();
            this.Colorbtn = new System.Windows.Forms.Button();
            this.Samplebtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.CoordinatetB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SizetB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Savebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Fontbtn
            // 
            this.Fontbtn.Location = new System.Drawing.Point(86, 160);
            this.Fontbtn.Name = "Fontbtn";
            this.Fontbtn.Size = new System.Drawing.Size(227, 74);
            this.Fontbtn.TabIndex = 0;
            this.Fontbtn.Text = "Изменить текст";
            this.Fontbtn.UseVisualStyleBackColor = true;
            this.Fontbtn.Click += new System.EventHandler(this.Fontbtn_Click);
            // 
            // Colorbtn
            // 
            this.Colorbtn.Location = new System.Drawing.Point(86, 271);
            this.Colorbtn.Name = "Colorbtn";
            this.Colorbtn.Size = new System.Drawing.Size(226, 77);
            this.Colorbtn.TabIndex = 1;
            this.Colorbtn.Text = "Изменить цвет";
            this.Colorbtn.UseVisualStyleBackColor = true;
            this.Colorbtn.Click += new System.EventHandler(this.Colorbtn_Click);
            // 
            // Samplebtn
            // 
            this.Samplebtn.Location = new System.Drawing.Point(487, 160);
            this.Samplebtn.Name = "Samplebtn";
            this.Samplebtn.Size = new System.Drawing.Size(249, 80);
            this.Samplebtn.TabIndex = 2;
            this.Samplebtn.Text = "Образец";
            this.Samplebtn.UseVisualStyleBackColor = true;
            this.Samplebtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Дизайн выбранной кнопки";
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // CoordinatetB
            // 
            this.CoordinatetB.Location = new System.Drawing.Point(86, 407);
            this.CoordinatetB.Name = "CoordinatetB";
            this.CoordinatetB.Size = new System.Drawing.Size(347, 34);
            this.CoordinatetB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Координаты";
            // 
            // SizetB
            // 
            this.SizetB.Location = new System.Drawing.Point(86, 494);
            this.SizetB.Name = "SizetB";
            this.SizetB.Size = new System.Drawing.Size(347, 34);
            this.SizetB.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 462);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "Размеры";
            // 
            // Savebutton
            // 
            this.Savebutton.Location = new System.Drawing.Point(529, 407);
            this.Savebutton.Name = "Savebutton";
            this.Savebutton.Size = new System.Drawing.Size(249, 126);
            this.Savebutton.TabIndex = 8;
            this.Savebutton.Text = "Применить";
            this.Savebutton.UseVisualStyleBackColor = true;
            this.Savebutton.Click += new System.EventHandler(this.Savebutton_Click);
            // 
            // UnigueDesignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 681);
            this.Controls.Add(this.Savebutton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SizetB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CoordinatetB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Samplebtn);
            this.Controls.Add(this.Colorbtn);
            this.Controls.Add(this.Fontbtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "UnigueDesignForm";
            this.Text = "UnigueDesignForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fontbtn;
        private System.Windows.Forms.Button Colorbtn;
        private System.Windows.Forms.Button Samplebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.TextBox CoordinatetB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SizetB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Savebutton;
    }
}