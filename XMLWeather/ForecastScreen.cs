using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XMLWeather
{
    public partial class ForecastScreen : UserControl
    {
        public ForecastScreen()
        {
            InitializeComponent();
            displayForecast();
        }

        public void displayForecast()
        {
            date1.Text = "Tomorrow";
            max1.Text = Convert.ToDouble(Form1.dayList[1].tempHigh).ToString("0") + "°C";
            min1.Text = Convert.ToDouble(Form1.dayList[1].tempLow).ToString("0") + "°C";

            if (Form1.dayList[1].condNum <= 232)
            {
                dayBox1.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[1].condNum <= 531 && Form1.dayList[1].condNum >= 233)
            {
                dayBox1.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[1].condNum <= 622 && Form1.dayList[1].condNum >= 532)
            {
                dayBox1.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[1].condNum == 800)
            {
                dayBox1.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[1].condNum <= 804 && Form1.dayList[1].condNum >= 800)
            {
                dayBox1.Image = Properties.Resources.cClipArt;
            }

            date2.Text = "Following Day";
            max2.Text = Convert.ToDouble(Form1.dayList[2].tempHigh).ToString("0") + "°C";
            min2.Text = Convert.ToDouble(Form1.dayList[2].tempLow).ToString("0") + "°C";

            if (Form1.dayList[2].condNum <= 232)
            {
                dayBox2.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[2].condNum <= 531 && Form1.dayList[2].condNum >= 233)
            {
                dayBox2.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[2].condNum <= 622 && Form1.dayList[2].condNum >= 532)
            {
                dayBox2.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[2].condNum == 800)
            {
                dayBox2.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[2].condNum <= 804 && Form1.dayList[2].condNum >= 800)
            {
                dayBox2.Image = Properties.Resources.cClipArt;
            }

            date3.Text = Form1.dayList[3].date;
            max3.Text = Convert.ToDouble(Form1.dayList[3].tempHigh).ToString("0") + "°C";
            min3.Text = Convert.ToDouble(Form1.dayList[3].tempLow).ToString("0") + "°C";

            if (Form1.dayList[3].condNum <= 232)
            {
                dayBox3.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[3].condNum <= 531 && Form1.dayList[3].condNum >= 233)
            {
                dayBox3.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[3].condNum <= 622 && Form1.dayList[3].condNum >= 532)
            {
                dayBox3.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[3].condNum == 800)
            {
                dayBox3.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[3].condNum <= 804 && Form1.dayList[3].condNum >= 800)
            {
                dayBox3.Image = Properties.Resources.cClipArt;
            }
            date4.Text = Form1.dayList[4].date;
            max4.Text = Convert.ToDouble(Form1.dayList[4].tempHigh).ToString("0") + "°C";
            min4.Text = Convert.ToDouble(Form1.dayList[4].tempLow).ToString("0") + "°C";

            if (Form1.dayList[4].condNum <= 232)
            {
                dayBox4.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[4].condNum <= 531 && Form1.dayList[4].condNum >= 233)
            {
                dayBox4.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[4].condNum <= 622 && Form1.dayList[4].condNum >= 532)
            {
                dayBox4.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[4].condNum == 800)
            {
                dayBox4.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[4].condNum <= 804 && Form1.dayList[4].condNum >= 800)
            {
                dayBox4.Image = Properties.Resources.cClipArt;
            }

            date5.Text = Form1.dayList[5].date;
            max5.Text = Convert.ToDouble(Form1.dayList[5].tempHigh).ToString("0") + "°C";
            min5.Text = Convert.ToDouble(Form1.dayList[5].tempLow).ToString("0") + "°C";

            if (Form1.dayList[5].condNum <= 232)
            {
                dayBox5.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[5].condNum <= 531 && Form1.dayList[5].condNum >= 233)
            {
                dayBox5.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[5].condNum <= 622 && Form1.dayList[5].condNum >= 532)
            {
                dayBox5.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[5].condNum == 800)
            {
                dayBox5.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[5].condNum <= 804 && Form1.dayList[5].condNum >= 800)
            {
                dayBox5.Image = Properties.Resources.cClipArt;
            }

            date6.Text = Form1.dayList[6].date;
            max6.Text = Convert.ToDouble(Form1.dayList[6].tempHigh).ToString("0") + "°C";
            min6.Text = Convert.ToDouble(Form1.dayList[6].tempLow).ToString("0") + "°C";

            if (Form1.dayList[6].condNum <= 232)
            {
                dayBox6.Image = Properties.Resources.TSClipArt;
            }
            else if (Form1.dayList[6].condNum <= 531 && Form1.dayList[6].condNum >= 233)
            {
                dayBox6.Image = Properties.Resources.rClipArt;
            }
            else if (Form1.dayList[6].condNum <= 622 && Form1.dayList[6].condNum >= 532)
            {
                dayBox6.Image = Properties.Resources.snClipArt;
            }
            else if (Form1.dayList[6].condNum == 800)
            {
                dayBox6.Image = Properties.Resources.sunClipArt;
            }
            else if (Form1.dayList[6].condNum <= 804 && Form1.dayList[6].condNum >= 800)
            {
                dayBox6.Image = Properties.Resources.cClipArt;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CitySearch cs = new CitySearch();
            f.Controls.Add(cs);
        }
    }
}
