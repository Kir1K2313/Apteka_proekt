namespace Apteka
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Аптеки");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Админка");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Дизайн");
            this.Authpanel = new System.Windows.Forms.Panel();
            this.dizainbutton = new System.Windows.Forms.Button();
            this.Regbutton = new System.Windows.Forms.Button();
            this.Hellolabel = new System.Windows.Forms.Label();
            this.Adminbutton = new System.Windows.Forms.Button();
            this.Authbutton = new System.Windows.Forms.Button();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.Passlabel = new System.Windows.Forms.Label();
            this.LogintextBox = new System.Windows.Forms.TextBox();
            this.Loginlabel = new System.Windows.Forms.Label();
            this.CopyRightpanel = new System.Windows.Forms.Panel();
            this.VkpictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Infopanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.дизайнКнопкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuEditpanel = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.изменениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Weatherlabel = new System.Windows.Forms.Label();
            this.Authpanel.SuspendLayout();
            this.CopyRightpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VkpictureBox)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuEditpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authpanel
            // 
            this.Authpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Authpanel.Controls.Add(this.dizainbutton);
            this.Authpanel.Controls.Add(this.Regbutton);
            this.Authpanel.Controls.Add(this.Hellolabel);
            this.Authpanel.Controls.Add(this.Adminbutton);
            this.Authpanel.Controls.Add(this.Authbutton);
            this.Authpanel.Controls.Add(this.PasstextBox);
            this.Authpanel.Controls.Add(this.Passlabel);
            this.Authpanel.Controls.Add(this.LogintextBox);
            this.Authpanel.Controls.Add(this.Loginlabel);
            this.Authpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Authpanel.Location = new System.Drawing.Point(0, 0);
            this.Authpanel.Margin = new System.Windows.Forms.Padding(5);
            this.Authpanel.Name = "Authpanel";
            this.Authpanel.Size = new System.Drawing.Size(1461, 105);
            this.Authpanel.TabIndex = 0;
            this.Authpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.Authpanel_Paint);
            // 
            // dizainbutton
            // 
            this.dizainbutton.Location = new System.Drawing.Point(1240, 35);
            this.dizainbutton.Name = "dizainbutton";
            this.dizainbutton.Size = new System.Drawing.Size(155, 37);
            this.dizainbutton.TabIndex = 8;
            this.dizainbutton.Text = "Дизайн";
            this.dizainbutton.UseVisualStyleBackColor = true;
            this.dizainbutton.Click += new System.EventHandler(this.dizainbutton_Click);
            // 
            // Regbutton
            // 
            this.Regbutton.Location = new System.Drawing.Point(1026, 27);
            this.Regbutton.Name = "Regbutton";
            this.Regbutton.Size = new System.Drawing.Size(180, 51);
            this.Regbutton.TabIndex = 7;
            this.Regbutton.Text = "Регистрация";
            this.Regbutton.UseVisualStyleBackColor = true;
            // 
            // Hellolabel
            // 
            this.Hellolabel.AutoSize = true;
            this.Hellolabel.Location = new System.Drawing.Point(17, 24);
            this.Hellolabel.Name = "Hellolabel";
            this.Hellolabel.Size = new System.Drawing.Size(0, 29);
            this.Hellolabel.TabIndex = 6;
            // 
            // Adminbutton
            // 
            this.Adminbutton.Location = new System.Drawing.Point(842, 12);
            this.Adminbutton.Name = "Adminbutton";
            this.Adminbutton.Size = new System.Drawing.Size(164, 74);
            this.Adminbutton.TabIndex = 5;
            this.Adminbutton.Text = "Панель админа";
            this.Adminbutton.UseVisualStyleBackColor = true;
            this.Adminbutton.Click += new System.EventHandler(this.Adminbutton_Click);
            // 
            // Authbutton
            // 
            this.Authbutton.Location = new System.Drawing.Point(677, 33);
            this.Authbutton.Name = "Authbutton";
            this.Authbutton.Size = new System.Drawing.Size(159, 38);
            this.Authbutton.TabIndex = 4;
            this.Authbutton.Text = "Войти";
            this.Authbutton.UseVisualStyleBackColor = true;
            this.Authbutton.Click += new System.EventHandler(this.Authbutton_Click);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Location = new System.Drawing.Point(431, 35);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(198, 34);
            this.PasstextBox.TabIndex = 3;
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Location = new System.Drawing.Point(329, 35);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(96, 29);
            this.Passlabel.TabIndex = 2;
            this.Passlabel.Text = "Пароль";
            // 
            // LogintextBox
            // 
            this.LogintextBox.Location = new System.Drawing.Point(113, 35);
            this.LogintextBox.Name = "LogintextBox";
            this.LogintextBox.Size = new System.Drawing.Size(198, 34);
            this.LogintextBox.TabIndex = 1;
            // 
            // Loginlabel
            // 
            this.Loginlabel.AutoSize = true;
            this.Loginlabel.Location = new System.Drawing.Point(14, 35);
            this.Loginlabel.Name = "Loginlabel";
            this.Loginlabel.Size = new System.Drawing.Size(82, 29);
            this.Loginlabel.TabIndex = 0;
            this.Loginlabel.Text = "Логин";
            // 
            // CopyRightpanel
            // 
            this.CopyRightpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CopyRightpanel.Controls.Add(this.Weatherlabel);
            this.CopyRightpanel.Controls.Add(this.VkpictureBox);
            this.CopyRightpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightpanel.Location = new System.Drawing.Point(0, 531);
            this.CopyRightpanel.Margin = new System.Windows.Forms.Padding(5);
            this.CopyRightpanel.Name = "CopyRightpanel";
            this.CopyRightpanel.Size = new System.Drawing.Size(1461, 96);
            this.CopyRightpanel.TabIndex = 2;
            // 
            // VkpictureBox
            // 
            this.VkpictureBox.Image = ((System.Drawing.Image)(resources.GetObject("VkpictureBox.Image")));
            this.VkpictureBox.Location = new System.Drawing.Point(19, 3);
            this.VkpictureBox.Name = "VkpictureBox";
            this.VkpictureBox.Size = new System.Drawing.Size(51, 33);
            this.VkpictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VkpictureBox.TabIndex = 0;
            this.VkpictureBox.TabStop = false;
            this.VkpictureBox.Click += new System.EventHandler(this.VkpictureBox_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.71253F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.28748F));
            this.tableLayoutPanel1.Controls.Add(this.Infopanel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.treeView1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 105);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1461, 522);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Infopanel
            // 
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Infopanel.Location = new System.Drawing.Point(291, 3);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(1167, 516);
            this.Infopanel.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Аптеки";
            treeNode1.Text = "Аптеки";
            treeNode2.Name = "Узел0";
            treeNode2.Text = "Админка";
            treeNode3.Name = "";
            treeNode3.Text = "Дизайн";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            this.treeView1.Size = new System.Drawing.Size(282, 516);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.дизайнКнопкиToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 28);
            // 
            // дизайнКнопкиToolStripMenuItem
            // 
            this.дизайнКнопкиToolStripMenuItem.Name = "дизайнКнопкиToolStripMenuItem";
            this.дизайнКнопкиToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.дизайнКнопкиToolStripMenuItem.Text = "Дизайн кнопки";
            this.дизайнКнопкиToolStripMenuItem.Click += new System.EventHandler(this.дизайнКнопкиToolStripMenuItem_Click);
            // 
            // contextMenuEditpanel
            // 
            this.contextMenuEditpanel.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuEditpanel.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.изменениеToolStripMenuItem});
            this.contextMenuEditpanel.Name = "contextMenuEditpanel";
            this.contextMenuEditpanel.Size = new System.Drawing.Size(159, 28);
            // 
            // изменениеToolStripMenuItem
            // 
            this.изменениеToolStripMenuItem.Name = "изменениеToolStripMenuItem";
            this.изменениеToolStripMenuItem.Size = new System.Drawing.Size(158, 24);
            this.изменениеToolStripMenuItem.Text = "Изменение";
            this.изменениеToolStripMenuItem.Click += new System.EventHandler(this.изменениеToolStripMenuItem_Click);
            // 
            // Weatherlabel
            // 
            this.Weatherlabel.AutoSize = true;
            this.Weatherlabel.Location = new System.Drawing.Point(191, 22);
            this.Weatherlabel.Name = "Weatherlabel";
            this.Weatherlabel.Size = new System.Drawing.Size(79, 29);
            this.Weatherlabel.TabIndex = 1;
            this.Weatherlabel.Text = "label1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 627);
            this.Controls.Add(this.CopyRightpanel);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Authpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Authpanel.ResumeLayout(false);
            this.Authpanel.PerformLayout();
            this.CopyRightpanel.ResumeLayout(false);
            this.CopyRightpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VkpictureBox)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuEditpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Authpanel;
        private System.Windows.Forms.Panel CopyRightpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel Infopanel;
        private System.Windows.Forms.Button Adminbutton;
        private System.Windows.Forms.Button Authbutton;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Label Passlabel;
        private System.Windows.Forms.TextBox LogintextBox;
        private System.Windows.Forms.Label Loginlabel;
        private System.Windows.Forms.Label Hellolabel;
        private System.Windows.Forms.Button Regbutton;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button dizainbutton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem дизайнКнопкиToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuEditpanel;
        private System.Windows.Forms.ToolStripMenuItem изменениеToolStripMenuItem;
        public System.Windows.Forms.PictureBox VkpictureBox;
        private System.Windows.Forms.Label Weatherlabel;
    }
}