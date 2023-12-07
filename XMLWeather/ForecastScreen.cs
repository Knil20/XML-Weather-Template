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
            date1.Text = Form1.dayList[1].date;
            max1.Text = Form1.dayList[1].tempHigh;
            min1.Text = Form1.dayList[1].tempLow;

            date2.Text = Form1.dayList[2].date;
            max2.Text = Form1.dayList[2].tempHigh;
            min2.Text = Form1.dayList[2].tempLow;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen cs = new CurrentScreen();
            f.Controls.Add(cs);
        }
    }
}
