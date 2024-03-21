namespace Apteka
{
    partial class DesignUserControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Samplpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.editpanelbtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Samplbutton = new System.Windows.Forms.Button();
            this.editbuttonbtn2 = new System.Windows.Forms.Button();
            this.editbuttonbtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edittextboxbtn2 = new System.Windows.Forms.Button();
            this.SampletextBox = new System.Windows.Forms.TextBox();
            this.edittextboxbtn = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.Samplelabel = new System.Windows.Forms.Label();
            this.editlabelbtn = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Панель дизайна";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(60, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(855, 446);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Samplpanel);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.editpanelbtn);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(847, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Дизайн Панелей";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Samplpanel
            // 
            this.Samplpanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Samplpanel.Location = new System.Drawing.Point(398, 119);
            this.Samplpanel.Name = "Samplpanel";
            this.Samplpanel.Size = new System.Drawing.Size(360, 234);
            this.Samplpanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(393, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Образец панели";
            // 
            // editpanelbtn
            // 
            this.editpanelbtn.Location = new System.Drawing.Point(82, 136);
            this.editpanelbtn.Name = "editpanelbtn";
            this.editpanelbtn.Size = new System.Drawing.Size(231, 78);
            this.editpanelbtn.TabIndex = 0;
            this.editpanelbtn.Text = "Изменить панель";
            this.editpanelbtn.UseVisualStyleBackColor = true;
            this.editpanelbtn.Click += new System.EventHandler(this.editpanelbtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Samplbutton);
            this.tabPage2.Controls.Add(this.editbuttonbtn2);
            this.tabPage2.Controls.Add(this.editbuttonbtn);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(847, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дизайн кнопок";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Samplbutton
            // 
            this.Samplbutton.Location = new System.Drawing.Point(417, 131);
            this.Samplbutton.Name = "Samplbutton";
            this.Samplbutton.Size = new System.Drawing.Size(205, 65);
            this.Samplbutton.TabIndex = 5;
            this.Samplbutton.Text = "образец";
            this.Samplbutton.UseVisualStyleBackColor = true;
            // 
            // editbuttonbtn2
            // 
            this.editbuttonbtn2.Location = new System.Drawing.Point(100, 210);
            this.editbuttonbtn2.Name = "editbuttonbtn2";
            this.editbuttonbtn2.Size = new System.Drawing.Size(232, 76);
            this.editbuttonbtn2.TabIndex = 4;
            this.editbuttonbtn2.Text = "Изменить цвет";
            this.editbuttonbtn2.UseVisualStyleBackColor = true;
            this.editbuttonbtn2.Click += new System.EventHandler(this.editbuttonbtn2_Click);
            // 
            // editbuttonbtn
            // 
            this.editbuttonbtn.Location = new System.Drawing.Point(100, 120);
            this.editbuttonbtn.Name = "editbuttonbtn";
            this.editbuttonbtn.Size = new System.Drawing.Size(232, 76);
            this.editbuttonbtn.TabIndex = 3;
            this.editbuttonbtn.Text = "Изменить текст";
            this.editbuttonbtn.UseVisualStyleBackColor = true;
            this.editbuttonbtn.Click += new System.EventHandler(this.editbuttonbtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.edittextboxbtn2);
            this.tabPage3.Controls.Add(this.SampletextBox);
            this.tabPage3.Controls.Add(this.edittextboxbtn);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(847, 404);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Дизайн Текстбоксов";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edittextboxbtn2
            // 
            this.edittextboxbtn2.Location = new System.Drawing.Point(100, 211);
            this.edittextboxbtn2.Name = "edittextboxbtn2";
            this.edittextboxbtn2.Size = new System.Drawing.Size(232, 76);
            this.edittextboxbtn2.TabIndex = 2;
            this.edittextboxbtn2.Text = "Изменить цвет";
            this.edittextboxbtn2.UseVisualStyleBackColor = true;
            this.edittextboxbtn2.Click += new System.EventHandler(this.edittextboxbtn2_Click);
            // 
            // SampletextBox
            // 
            this.SampletextBox.Enabled = false;
            this.SampletextBox.Location = new System.Drawing.Point(386, 141);
            this.SampletextBox.Name = "SampletextBox";
            this.SampletextBox.ReadOnly = true;
            this.SampletextBox.Size = new System.Drawing.Size(257, 34);
            this.SampletextBox.TabIndex = 1;
            this.SampletextBox.Text = "Образец";
            // 
            // edittextboxbtn
            // 
            this.edittextboxbtn.Location = new System.Drawing.Point(100, 120);
            this.edittextboxbtn.Name = "edittextboxbtn";
            this.edittextboxbtn.Size = new System.Drawing.Size(232, 76);
            this.edittextboxbtn.TabIndex = 0;
            this.edittextboxbtn.Text = "Изменить текст";
            this.edittextboxbtn.UseVisualStyleBackColor = true;
            this.edittextboxbtn.Click += new System.EventHandler(this.edittextboxbtn_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.Samplelabel);
            this.tabPage4.Controls.Add(this.editlabelbtn);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(847, 404);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Дизайн Надписей";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // Samplelabel
            // 
            this.Samplelabel.AutoSize = true;
            this.Samplelabel.Location = new System.Drawing.Point(401, 132);
            this.Samplelabel.Name = "Samplelabel";
            this.Samplelabel.Size = new System.Drawing.Size(211, 29);
            this.Samplelabel.TabIndex = 4;
            this.Samplelabel.Text = "Образец надписи";
            // 
            // editlabelbtn
            // 
            this.editlabelbtn.Location = new System.Drawing.Point(100, 120);
            this.editlabelbtn.Name = "editlabelbtn";
            this.editlabelbtn.Size = new System.Drawing.Size(231, 78);
            this.editlabelbtn.TabIndex = 3;
            this.editlabelbtn.Text = "Изменить надпись";
            this.editlabelbtn.UseVisualStyleBackColor = true;
            this.editlabelbtn.Click += new System.EventHandler(this.editlabelbtn_Click);
            // 
            // fontDialog1
            // 
            this.fontDialog1.ShowColor = true;
            // 
            // DesignUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DesignUserControl";
            this.Size = new System.Drawing.Size(951, 573);
            this.Load += new System.EventHandler(this.DesignUserControl_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Panel Samplpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editpanelbtn;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label Samplelabel;
        private System.Windows.Forms.Button editlabelbtn;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox SampletextBox;
        private System.Windows.Forms.Button edittextboxbtn;
        private System.Windows.Forms.Button edittextboxbtn2;
        private System.Windows.Forms.Button Samplbutton;
        private System.Windows.Forms.Button editbuttonbtn2;
        private System.Windows.Forms.Button editbuttonbtn;
    }
}
