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
    public partial class DesignUserControl : UserControl
    {
        public static Font label_font;
        public static Color label_color;
        public DesignUserControl()
        {
            InitializeComponent();
        }

      

        private void DesignUserControl_Load(object sender, EventArgs e)
        {

        }

        private void editlabelBTN_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label_font = fontDialog1.Font;
                label_color = fontDialog1.Color;

                Sampllabel.Font = label_font;
                Sampllabel.ForeColor = label_color;

                SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Sampllabel.GetType() + "' AND parametr = 'FONT'");
                SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Sampllabel.GetType() + "' AND parametr = 'FONT_COLOR'");

                SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Sampllabel.GetType() + "', 'FONT', '" + label_font.Name + ";" + label_font.Size.ToString() + "')");
                SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Sampllabel.GetType() + "', 'FONT_COLOR', '" + label_color.ToArgb() + "')");
            }


        }

        public static void ReadDesign()
        {
            //Чтение  параметров надписей
            string font = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT'")[0];
            string[] parts = font.Split(new char[] { ';' });
            label_font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));
        }
    }
}
