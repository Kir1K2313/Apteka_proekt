using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class AdminClassifUC : UserControl
    {
        public AdminClassifUC()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void AdminClassifUC_Load(object sender, EventArgs e)
        {
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(label2);
            Infopanel.Controls.Add(label4);
            Infopanel.Controls.Add(label3);
            List<string> apteka = SQLClass.myselect("SELECT id, name FROM level1");

            NameAptekaCB.Items.Clear();
            for (int i = 0; i<apteka.Count; i += 2)
            {
                NameAptekaCB.Items.Add(apteka[i] + ". " + apteka[i+1] );
            }
            List<string> classif = SQLClass.myselect("SELECT id, name, id_apteka FROM level2");
            int y = 100;
            for (int i = 0; i < classif.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(80, y);
                lbl.Size = new Size(200, 30);
                lbl.Tag = classif[i];
                lbl.Text = classif[i + 1];
                Infopanel.Controls.Add(lbl);

                List<string> aptek = SQLClass.myselect("SELECT name FROM level1 WHERE id = '" + classif[i+2] + "'");

                Label lbl1 = new Label();
                lbl1.Location = new Point(420, y);
                lbl1.Size = new Size(180, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = aptek[0];
                Infopanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(700, y);
                btn.Size = new Size(100, 30);
                btn.Click += new EventHandler(DeleteClassifClick);
                btn.Text = "Удалить";
                Infopanel.Controls.Add(btn);
                y += 35;

            }
        }
        
       

        
        private void DeleteClassifClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in Infopanel.Controls)
            {
                if (control.Location == new Point(80, y))
                {
                    SQLClass.myUpdate("Delete FROM level2 WHERE id = '" + control.Tag + "'");
                    SQLClass.myUpdate("Delete FROM level3 WHERE id_class = '" + control.Tag + "'");
                    MessageBox.Show("Удаление прошло успешно");
                    AdminClassifUC_Load(sender, e);
                }
            }
        }
        
        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AddClassifbutton_Click(object sender, EventArgs e)
        {
            string id_apteka = "";
            string[] text = NameAptekaCB.Text.Split(new string[] { ". " }, StringSplitOptions.None);
            id_apteka = text[0];
            if (NameClassifCB.Text != "" && NameAptekaCB.Text != "")
            {
                SQLClass.myUpdate("INSERT INTO level2 (name, id_apteka, pic) VALUES ('" + NameClassifCB.Text + "', '" + NameAptekaCB.Text + "', '" + adress + "' )");
                MessageBox.Show("Выполнено");
                NameAptekaCB.Text = "";
                NameClassifCB.Text = "";
                ClassifpictureBox.Image = null;
                AdminClassifUC_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните поля!!");
            }
            AdminClassifUC_Load(sender, e);
        }
        string adress;
        private void ClassifpictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                ClassifpictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }
    }
}
