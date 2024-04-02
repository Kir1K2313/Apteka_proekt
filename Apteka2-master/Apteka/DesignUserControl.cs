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
       public static ContextMenuStrip button_conmenu;

       public static Font label_font;
       public static Color label_color;

       public static Color panel_color;

       public static Font textbox_font;
       public static Color textbox_forecolor;
       public static Color textbox_backcolor;

       public static Font button_font;
       public static Color button_forecolor;
       public static Color button_backcolor;
        public DesignUserControl()
        {
            InitializeComponent();
            DesignUserControl.useDesign(this);
        }

        private void editlabelbtn_Click(object sender, EventArgs e)
        {
            label_font = fontDialog1.Font;
            label_color = fontDialog1.Color;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                label_font = fontDialog1.Font;
                label_color = fontDialog1.Color;

                Samplelabel.Font = label_font;
                Samplelabel.ForeColor = label_color;

                SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplelabel.GetType() + "' AND parametr = 'FONT'");
                SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplelabel.GetType() + "' AND parametr = 'FONT_COLOR'");

                SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplelabel.GetType() + "', 'FONT', '" + label_font.Name + ";" + label_font.Size.ToString() + "')");
                SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplelabel.GetType() + "', 'FONT_COLOR', '" + label_color.ToArgb() + "')");
            }
        }
        public static void ReadDesign()

        {
            //Чтение  параметров надписей
            try
            {
                string font = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                label_font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Label' AND parametr = 'FONT_COLOR'")[0];
                label_color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            try
            {

                string color = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Panel' AND parametr = 'PANEL_COLOR'")[0];
                panel_color = Color.FromArgb(Convert.ToInt32(color));
            }
            catch (Exception) { }
            #region чтение параметров текстбокса

            try
            {
                string font = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                textbox_font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'FORECOLOR'")[0];
                textbox_forecolor = Color.FromArgb(Convert.ToInt32(color));

                string bgcolor = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.TextBox' AND parametr = 'BACK_COLOR'")[0];
                textbox_backcolor = Color.FromArgb(Convert.ToInt32(bgcolor));
            }
            catch (Exception) { }
            #endregion
            #region чтение параметров кнопок

            try
            {
                string font = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FONT'")[0];
                string[] parts = font.Split(new char[] { ';' });
                button_font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FORECOLOR'")[0];
                button_forecolor = Color.FromArgb(Convert.ToInt32(color));

                string bgcolor = SQLClass.myselect("SELECT value FROM Design WHERE type = 'System.Windows.Forms.Button' AND parametr = 'BACK_COLOR'")[0];
                button_backcolor = Color.FromArgb(Convert.ToInt32(bgcolor));
            }
            catch (Exception) { }
            #endregion

        }
        public static void useDesign(Control Form)
        {
            foreach (Control ctrl in Form.Controls)
            {
                if (ctrl is Label)
                {
                    ctrl.Font = label_font;
                    ctrl.ForeColor = label_color;
                }
                else
                {
                    useDesign(ctrl);
                }

                if (ctrl is Panel)
                {
                    ctrl.BackColor = panel_color;
                }
                else
                {
                    useDesign(ctrl);
                }
                #region примение параметров текстбокса
                if (ctrl is TextBox)
                {
                    ctrl.Font = textbox_font;
                    ctrl.ForeColor = textbox_forecolor;
                    ctrl.BackColor = textbox_backcolor;
                }
                else
                {
                    useDesign(ctrl);
                }
                #endregion
                #region примение параметров кнопок
                if (ctrl is Button)
                {
                    ctrl.Font = button_font;
                    ctrl.ForeColor = button_forecolor;
                    ctrl.BackColor = button_backcolor;
                    ReadUniqueDesign(ctrl as Button);
                }
                else
                {
                    useDesign(ctrl);
                }
                #endregion
            }
        }
  


        private void DesignUserControl_Load(object sender, EventArgs e)
        {

        }

        private void editpanelbtn_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = panel_color;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                 panel_color = colorDialog1.Color;

                 Samplpanel.BackColor = panel_color;
            }

            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplpanel.GetType() + "' AND parametr = 'PANEL_COLOR'");
            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplpanel.GetType() + "', 'PANEL_COLOR', '" + panel_color.ToArgb() + "')");
        }
        #region функция текстбоксов
        private void edittextboxbtn_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = textbox_font;
            fontDialog1.Color = textbox_forecolor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_font = fontDialog1.Font;
                textbox_forecolor = fontDialog1.Color;
                SampletextBox.Font = textbox_font;
                SampletextBox.ForeColor = textbox_forecolor;

            }
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + SampletextBox.GetType() + "' AND parametr = 'FONT'");
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + SampletextBox.GetType() + "' AND parametr = 'FORECOLOR'");

            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + SampletextBox.GetType() + "', 'FONT', '" + textbox_font.Name + ";" + textbox_font.Size.ToString() + "')");
            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + SampletextBox.GetType() + "', 'FORECOLOR', '" + textbox_forecolor.ToArgb() + "')");
        }

        private void edittextboxbtn2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = textbox_backcolor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                textbox_backcolor = colorDialog1.Color;
                SampletextBox.BackColor = textbox_backcolor;
            }
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + SampletextBox.GetType() + "' AND parametr = 'BACK_COLOR'");
            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + SampletextBox.GetType() + "', 'BACK_COLOR', '" + textbox_backcolor.ToArgb() + "')");
        }
        #endregion
        #region функции кнопок
        private void editbuttonbtn_Click(object sender, EventArgs e)
        {

            fontDialog1.Font = button_font;
            fontDialog1.Color = button_forecolor;
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                button_font = fontDialog1.Font;
                button_forecolor = fontDialog1.Color;
                Samplbutton.Font = button_font;
                Samplbutton.ForeColor = button_forecolor;

            }
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplbutton.GetType() + "' AND parametr = 'FONT'");
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplbutton.GetType() + "' AND parametr = 'FORECOLOR'");

            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplbutton.GetType() + "', 'FONT', '" + button_font.Name + ";" + button_font.Size.ToString() + "')");
            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplbutton.GetType() + "', 'FORECOLOR', '" + button_forecolor.ToArgb() + "')");
        }

        private void editbuttonbtn2_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = button_backcolor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button_backcolor = colorDialog1.Color;
                Samplbutton.BackColor = textbox_backcolor;
            }
            SQLClass.myUpdate("DELETE FROM Design WHERE type = '" + Samplbutton.GetType() + "' AND parametr = 'BACK_COLOR'");
            SQLClass.myUpdate("INSERT INTO Design (type, parametr, value) VALUE ('" + Samplbutton.GetType() + "', 'BACK_COLOR', '" + button_backcolor.ToArgb() + "')");
        }
        #endregion
        public static void useMenu(Control Form)
        {
            foreach(Control ctrl in Form.Controls)
            {
                if(ctrl is Button && Convert.ToBoolean(MainForm.isAdmin))
                {
                    ctrl.ContextMenuStrip = button_conmenu;
                }
                else
                {
                    useMenu(ctrl);
                }
            }
        }
        public static void ReadUniqueDesign(Button btn)
        {
            try
            {
                string font = SQLClass.myselect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FONT' AND form = '" + btn.FindForm().Name + "' AND name = '" + btn.Name +"'")[0];
                string[] parts = font.Split(new char[] { ';' });
                btn.Font = new Font(new FontFamily(parts[0]), (float)Convert.ToDouble(parts[1]));

                string color = SQLClass.myselect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'FONT_COLOR' AND form = '" + btn.FindForm().Name + "' AND name = '" + btn.Name + "'")[0];
                btn.ForeColor = Color.FromArgb(Convert.ToInt32(color));

                string bgcolor = SQLClass.myselect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'BACK_COLOR' AND form = '" + btn.FindForm().Name + "' AND name = '" + btn.Name + "'")[0];
                btn.BackColor = Color.FromArgb(Convert.ToInt32(bgcolor));

                string Location = SQLClass.myselect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'LOCATION' AND form = '" + btn.FindForm().Name + "' AND name = '" + btn.Name + "'")[0];
                string[] parts1 = Location.Split(new string [] { ", " }, StringSplitOptions.None);
                btn.Location = new Point(Convert.ToInt32(parts1[0]), Convert.ToInt32(parts1[1]));

                string size = SQLClass.myselect("SELECT value FROM uniquedesign WHERE type = 'System.Windows.Forms.Button' AND parametr = 'SIZE' AND form = '" + btn.FindForm().Name + "' AND name = '" + btn.Name + "'")[0];
                string[] size1 = size.Split(new string[] { ", " }, StringSplitOptions.None);
                btn.Size = new Size(Convert.ToInt32(size1[0]), Convert.ToInt32(size1[1]));


            }
            catch (Exception) { }
        }
    }
    
}
