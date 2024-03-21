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
    public partial class AdminAptekUCcs : UserControl
    {
        public AdminAptekUCcs()
        {
            InitializeComponent();
            //DesignUserControl.useDesign(this);
        }
        string adress = "";
        private void AptekapictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                AptekapictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }


        private void AdminAptekUCcs_Load(object sender, EventArgs e)
        {
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(label1);
            Infopanel.Controls.Add(label4);
            Infopanel.Controls.Add(label3);
            List<string> apteka = SQLClass.myselect("SELECT id, name, pic FROM level1");
            int y = 100;
            for (int i = 0; i < apteka.Count; i += 3)
            {
                Label lbl = new Label();
                lbl.Location = new Point(50, y);
                lbl.Size = new Size(200, 30);
                lbl.Tag = apteka[i];
                lbl.Text = apteka[i + 1];
                Infopanel.Controls.Add(lbl);

                Label lbl1 = new Label();
                lbl1.Location = new Point(350, y);
                lbl1.Size = new Size(200, 30);
                lbl1.Text = apteka[i + 2];
                Infopanel.Controls.Add(lbl1);

                Button btn = new Button();
                btn.Location = new Point(700, y);
                btn.Size = new Size(100, 30);
                btn.Click += new EventHandler(DeleteAptekaClick);
                btn.Text = "Удалить";
                Infopanel.Controls.Add(btn);
                y += 35;

            }

        }
        private void AddAptekabutton_Click(object sender, EventArgs e)
        {
            if (NameAptekaTB.Text != "")
            {
                SQLClass.myUpdate("INSERT INTO level1 (name, adress, pic) VALUES ('" + NameAptekaTB.Text + "', '" + AdressAptekaTB.Text + "', '" + adress + "' )");
                MessageBox.Show("Выполнено");
                NameAptekaTB.Text = "";
                AdminAptekUCcs_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните поля!!");
            }
            AdminAptekUCcs_Load(sender, e);

        }
        private void DeleteAptekaClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in Infopanel.Controls)
            {
                if (control.Location == new Point(100, y))
                {
                    SQLClass.myUpdate("Delete FROM level1 WHERE id = '" + control.Tag + "'");
                    SQLClass.myUpdate("Delete FROM level2 WHERE id_apteka = '" + control.Tag + "'");
                    SQLClass.myUpdate("Delete FROM level3 WHERE id_apteka = '" + control.Tag + "'");
                    MessageBox.Show("Удаление прошло успешно");
                    AdminAptekUCcs_Load(sender, e);
                }
            }
        }
        private void Infopanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Addpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
