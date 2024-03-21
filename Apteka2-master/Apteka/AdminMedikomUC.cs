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
    public partial class AdminMedikomUC : UserControl
    {
        public AdminMedikomUC()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void AdminMedikomUC_Load(object sender, EventArgs e)
        {
            Infopanel.Controls.Clear();
            Infopanel.Controls.Add(label1);
            Infopanel.Controls.Add(label2);
            Infopanel.Controls.Add(label3);
            Infopanel.Controls.Add(label4);

            List<string> classif = SQLClass.myselect("SELECT id, name, id_apteka FROM level2");

            NameClassifCB.Items.Clear();
            for (int i = 0; i < classif.Count; i += 3)
            {
                List<string> apteka = SQLClass.myselect("SELECT id, name FROM level1 WHERE id = '" + classif[i+2] +"' ");
                NameClassifCB.Items.Add(classif[i] + ". " + classif[i + 1] + ". " + apteka[0] + ". " + apteka[1]);
            }

            List<string> medic = SQLClass.myselect("SELECT id, name, id_apteka, id_class FROM level3");
            int y = 100;
            for (int i = 0; i < medic.Count; i += 4)
            {
                Label lbl = new Label();
                lbl.Location = new Point(80, y);
                lbl.Size = new Size(200, 30);
                lbl.Tag = medic[i];
                lbl.Text = medic[i + 1];
                Infopanel.Controls.Add(lbl);

                List<string> aptek = SQLClass.myselect("SELECT name FROM level1 WHERE id = '" + medic[i + 2] + "'");

                Label lbl1 = new Label();
                lbl1.Location = new Point(280, y);
                lbl1.Size = new Size(180, 30);
                lbl1.Font = new Font("Arial Narrow", 13);
                lbl1.Text = aptek[0];
                Infopanel.Controls.Add(lbl1);


                List<string> classi = SQLClass.myselect("SELECT name FROM level2 WHERE id = '" + medic[i + 3] + "'");

                Label lbl2 = new Label();
                lbl2.Location = new Point(480, y);
                lbl2.Size = new Size(180, 30);
                lbl2.Font = new Font("Arial Narrow", 13);
                lbl2.Text = classi[0];
                Infopanel.Controls.Add(lbl2);

                Button btn = new Button();
                btn.Location = new Point(700, y);
                btn.Size = new Size(100, 30);
                btn.Click += new EventHandler(DeleteMedicClick);
                btn.Text = "Удалить";
                Infopanel.Controls.Add(btn);
                y += 35;

            }
        }




        private void AddMedicbutton_Click(object sender, EventArgs e)
        { 
            string id_class = "";
            string id_apteka = "";
            string[] text = NameClassifCB.Text.Split(new string[] { ". " }, StringSplitOptions.None);
            id_class = text[0];
            id_apteka = text[2];
            if ( NamemedicTB.Text != "" && NameClassifCB.Text != "")
            {
                SQLClass.myUpdate("INSERT INTO level3 (name, id_apteka, id_class, pic) VALUES ('" + NamemedicTB.Text + "', '" + id_apteka + "', '" + id_class + "', '" + adress + "' )");
                MessageBox.Show("Выполнено");
                NamemedicTB.Text = "";
                NameClassifCB.Text = "";
                MedicpictureBox.Image = null;
                AdminMedikomUC_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Заполните поля!!");
            }
            AdminMedikomUC_Load(sender, e);
        }
        string adress;
        private void ClassifpictureBox_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                adress = openFileDialog1.FileName;
                MedicpictureBox.Load(adress);
                adress = Path.GetFileName(adress);
            }
        }
        private void DeleteMedicClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int y = btn.Location.Y;
            foreach (Control control in Infopanel.Controls)
            {
                if (control.Location == new Point(80, y))
                {
                    SQLClass.myUpdate("Delete FROM level3 WHERE id = '" + control.Tag + "'");
                    MessageBox.Show("Удаление прошло успешно");
                    AdminMedikomUC_Load(sender, e);
                }
            }
        }
        private void MedicpictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
