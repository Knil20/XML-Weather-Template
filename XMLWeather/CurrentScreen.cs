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
    public partial class CurrentScreen : UserControl
    {
        public CurrentScreen()
        {

            InitializeComponent();

            cityOutput.Parent = displayBox;
            tempLabel.Parent = displayBox;
            maxLabel.Parent = displayBox;
            minLabel.Parent = displayBox;
            humidityLabel.Parent = displayBox;
            conditionLabel.Parent = displayBox;

            

            if (Form1.dayList[0].condNum <= 232)
            {
                displayBox.Image = Properties.Resources.TSClipArt;
                BackColor = Color.Black;
                cityOutput.ForeColor = Color.White;
                tempLabel.ForeColor = Color.White;
                conditionLabel.ForeColor = Color.White;
                humidityLabel.ForeColor = Color.White;
            }
            else if (Form1.dayList[0].condNum <= 531 && Form1.dayList[0].condNum >= 233)
            {
                displayBox.Image = Properties.Resources.rClipArt;
                BackColor= Color.DimGray;
            }
            else if(Form1.dayList[0].condNum <= 622 && Form1.dayList[0].condNum >= 532)
            {
                displayBox.Image = Properties.Resources.snClipArt;
                BackColor = Color.LightGray;
            }
            else if(Form1.dayList[0].condNum == 800)
            {
                displayBox.Image = Properties.Resources.sunClipArt;
                BackColor = Color.DodgerBlue;
            }
            else if (Form1.dayList[0].condNum <= 804 && Form1.dayList[0].condNum >= 800)
            {
                displayBox.Image = Properties.Resources.cClipArt;
                BackColor = Color.SteelBlue;

            }
            DisplayCurrent();
        }

        public void DisplayCurrent()
        {
            cityOutput.Text = Form1.city + "";
            tempLabel.Text = Convert.ToDouble(Form1.dayList[0].currentTemp).ToString("0") + "°C";
            conditionLabel.Text = "Today Features " + Form1.dayList[0].condition;
            minLabel.Text = Convert.ToDouble(Form1.dayList[0].tempLow).ToString("0") + "°C";
            maxLabel.Text = Convert.ToDouble(Form1.dayList[0].tempHigh).ToString("0") + "°C";
            humidityLabel.Text = "Today's Humidex is " + Form1.dayList[0].humidity + "%";


        }

        private void forecastLabel_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            ForecastScreen fs = new ForecastScreen();
            f.Controls.Add(fs);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form f = this.FindForm();
            f.Controls.Remove(this);

            CitySearch fs = new CitySearch();
            f.Controls.Add(fs);
        }

        
    }
}
