using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SecurytyManagmentSystem
{
    public partial class fireCentralForm : Form
    {
        public fireCentralForm()
        {
            InitializeComponent();
            //otwarcie okna zmaksymalizowango 
            this.WindowState = FormWindowState.Maximized;
            //otwarcie okna na 2 monitorze
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Screen.AllScreens[1].Bounds.Left, Screen.AllScreens[1].Bounds.Top);
            //otwarcie okna bez kontrolek okna
            this.FormBorderStyle = FormBorderStyle.None;
        }

        ///<example> 
        ///metoda zmieniajaca obraze po zanaczeniu odopwiedniego checkBox
        ///</example>
        ///

        public string boiuowiec = "C:\\Users\\tmysz\\source\\repos\\SecurytyManagmentSystem\\SecurytyManagmentSystem\\bin\\Debug\\Images\\biurowiec.png";
        public string budTechniczny = "C:\\Users\\tmysz\\source\\repos\\SecurytyManagmentSystem\\SecurytyManagmentSystem\\bin\\Debug\\Images\\budTechniczny.png";
        public string hala = "C:\\Users\\tmysz\\source\\repos\\SecurytyManagmentSystem\\SecurytyManagmentSystem\\bin\\Debug\\Images\\calosc.png";
        
        public string defaultImage = "C:\\Users\\tmysz\\source\\repos\\SecurytyManagmentSystem\\SecurytyManagmentSystem\\bin\\Debug\\Images\\zdjecieGlowne.png";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                pictureBox1.ImageLocation = boiuowiec;
            }
            else
            {
                pictureBox1.ImageLocation = defaultImage;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                pictureBox1.ImageLocation = budTechniczny;
            }
            else
            {
                pictureBox1.ImageLocation = defaultImage;
            }

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                pictureBox1.ImageLocation = hala;
            }
            else
            {
                pictureBox1.ImageLocation = defaultImage;
            }

        }





    }
}
