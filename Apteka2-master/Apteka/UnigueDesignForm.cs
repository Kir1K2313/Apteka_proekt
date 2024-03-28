using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apteka
{
    public partial class UnigueDesignForm : Form
    {
        Button btn;
        public UnigueDesignForm(Button _btn)
        {
            InitializeComponent();
            btn = _btn;
            Samplebtn.Text = btn.Text;
            Samplebtn.Font = btn.Font;
            Samplebtn.ForeColor = btn.ForeColor;
            Samplebtn.BackColor = btn.BackColor;
            Samplebtn.Size = btn.Size;

            CoordinatetB.Text = btn.Location.X.ToString() + ", " + btn.Location.Y.ToString();
            SizetB.Text = btn.Size.Width.ToString() + ", " + btn.Size.Height.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Fontbtn_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = Samplebtn.Font;
            fontDialog1.Color = Samplebtn.ForeColor;
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                Samplebtn.Font = fontDialog1.Font;
                Samplebtn.ForeColor = fontDialog1.Color;

                SQLClass.myUpdate("DELETE FROM uniquedesign WHERE type = '" + Samplebtn.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name +"' AND parametr = 'FONT'");
                SQLClass.myUpdate("DELETE FROM uniquedesign WHERE type = '" + Samplebtn.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name +"' AND parametr = 'FONT_COLOR'");

                SQLClass.myUpdate("INSERT INTO uniquedesign (type, parametr, form, name, value) VALUE ('" + Samplebtn.GetType() + "', 'FONT', '" + btn.FindForm().Name + "','" + btn.Name + "', '" + Samplebtn.Font.Name + ";" + Samplebtn.Font.Size.ToString() + "')");
                SQLClass.myUpdate("INSERT INTO uniquedesign (type, parametr, form, name, value) VALUE ('" + Samplebtn.GetType() + "', 'FONT_COLOR', '" + btn.FindForm().Name + "','" + btn.Name + "', '" + Samplebtn.ForeColor.ToArgb() + "')");


            }
        }

        private void Colorbtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = Samplebtn.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Samplebtn.BackColor = colorDialog1.Color;
                SQLClass.myUpdate("DELETE FROM uniquedesign WHERE type = '" + Samplebtn.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parametr = 'BACK_COLOR'");
                SQLClass.myUpdate("INSERT INTO uniquedesign (type, parametr, form, name, value) VALUE ('" + Samplebtn.GetType() + "', 'BACK_COLOR',  '" + btn.FindForm().Name + "','" + btn.Name + "', '" + Samplebtn.BackColor.ToArgb() + "')");
            }
        }

        private void Savebutton_Click(object sender, EventArgs e)
        {

            SQLClass.myUpdate("DELETE FROM uniquedesign WHERE type = '" + Samplebtn.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parametr = 'LOCATION'");
            SQLClass.myUpdate("DELETE FROM uniquedesign WHERE type = '" + Samplebtn.GetType() + "' AND name = '" + btn.Name + "' AND form = '" + btn.FindForm().Name + "' AND parametr = 'SIZE'");

            SQLClass.myUpdate("INSERT INTO uniquedesign (type, parametr, form, name, value) VALUE ('" + Samplebtn.GetType() + "', 'LOCATION', '" + btn.FindForm().Name + "','" + btn.Name + "', '" + CoordinatetB.Text + "')");
            SQLClass.myUpdate("INSERT INTO uniquedesign (type, parametr, form, name, value) VALUE ('" + Samplebtn.GetType() + "', 'SIZE', '" + btn.FindForm().Name + "','" + btn.Name + "', '" + SizetB.Text + "')");
        }
    }
}
