using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace XMLWeather
{
    public partial class CitySearch : UserControl
    {
        public static string search;

        public CitySearch()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CurrentScreen fs = new CurrentScreen();
            f.Controls.Add(fs);
        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            search = searchBox.Text;
            tempLabel.Text = "Name a City";
            tempLabel.ForeColor = Color.White;
            Form1.dayList.Clear();
            Form1.city = searchBox.Text;

            Form1.ExtractForecast();
            Form1.ExtractCurrent();

            if (Form1.city == "Stratford,CA")
            {
                tempLabel.ForeColor = Color.Red;
                tempLabel.Text = "ERROR! Defaulting to Stratford";

                Refresh();
                Thread.Sleep(1500);

                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen fs = new CurrentScreen();
                f.Controls.Add(fs);

            }
            else
            {
                Form f = this.FindForm();
                f.Controls.Remove(this);

                CurrentScreen fs = new CurrentScreen();
                f.Controls.Add(fs);
            }

            
        }

        
    }
}
