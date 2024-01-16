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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Антибиотики");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Мази");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Таблетки");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Аптека Апрель", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Аптеки", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.Authpanel = new System.Windows.Forms.Panel();
            this.CopyRightpanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Infopanel = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Authpanel
            // 
            this.Authpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Authpanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Authpanel.Location = new System.Drawing.Point(0, 0);
            this.Authpanel.Margin = new System.Windows.Forms.Padding(5);
            this.Authpanel.Name = "Authpanel";
            this.Authpanel.Size = new System.Drawing.Size(1461, 105);
            this.Authpanel.TabIndex = 0;
            // 
            // CopyRightpanel
            // 
            this.CopyRightpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.CopyRightpanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CopyRightpanel.Location = new System.Drawing.Point(0, 539);
            this.CopyRightpanel.Margin = new System.Windows.Forms.Padding(5);
            this.CopyRightpanel.Name = "CopyRightpanel";
            this.CopyRightpanel.Size = new System.Drawing.Size(1461, 88);
            this.CopyRightpanel.TabIndex = 2;
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1461, 434);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Infopanel
            // 
            this.Infopanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Infopanel.Location = new System.Drawing.Point(291, 3);
            this.Infopanel.Name = "Infopanel";
            this.Infopanel.Size = new System.Drawing.Size(1167, 428);
            this.Infopanel.TabIndex = 3;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Узел6";
            treeNode1.Tag = "1";
            treeNode1.Text = "Антибиотики";
            treeNode2.Name = "Узел7";
            treeNode2.Tag = "2";
            treeNode2.Text = "Мази";
            treeNode3.Name = "Узел8";
            treeNode3.Tag = "3";
            treeNode3.Text = "Таблетки";
            treeNode4.Name = "Узел1";
            treeNode4.Tag = "1";
            treeNode4.Text = "Аптека Апрель";
            treeNode5.Name = "Аптеки";
            treeNode5.Text = "Аптеки";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5});
            this.treeView1.Size = new System.Drawing.Size(282, 428);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 627);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.CopyRightpanel);
            this.Controls.Add(this.Authpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Authpanel;
        private System.Windows.Forms.Panel CopyRightpanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel Infopanel;
    }
}