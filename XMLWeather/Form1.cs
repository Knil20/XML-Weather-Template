using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Xml;

namespace XMLWeather
{
    public partial class Form1 : Form
    {
        // TODO: create list to hold day objects
        public static List<Day> dayList = new List<Day>();
        public static string city;

        public Form1()
        {
            InitializeComponent();

            ExtractForecast();
            ExtractCurrent();

            // open weather screen for todays weather
            CurrentScreen cs = new CurrentScreen();
            this.Controls.Add(cs);
        }

        public static void ExtractForecast()
        {
            string part1, part3, combined;

            part1 = "http://api.openweathermap.org/data/2.5/forecast/daily?q=";
            city = CitySearch.search;
            part3 = "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            combined = part1 + city + part3;

            XmlReader reader;

            try
            {
                reader = XmlReader.Create(combined);
            }
            catch
            {
                city = "Stratford,CA";
                combined = part1 + city + part3;

                reader = XmlReader.Create(combined);
            }

            while (reader.Read())
            {
                //TODO: create a day object
                Day d = new Day();

                //TODO: fill day object with required data
                reader.ReadToFollowing("time");
                d.date = reader.GetAttribute("day");

                reader.ReadToFollowing("symbol");
                d.condNum = Convert.ToInt32(reader.GetAttribute("number"));
                d.condition = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                d.tempLow = reader.GetAttribute("min");
                d.tempHigh = reader.GetAttribute("max");

                reader.ReadToFollowing("humidity");
                d.humidity = reader.GetAttribute("value");

                //TODO: if day object not null add to the days list
                dayList.Add(d);

            }


        }

        public static void ExtractCurrent()
        {
            string part1, part3;

            part1 = "http://api.openweathermap.org/data/2.5/weather?q=";

            city = CitySearch.search;

            part3 = "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

            string combined = part1 + city + part3;

            // current info is not included in forecast file so we need to use this file to get it
            try
            {
                XmlReader reader = XmlReader.Create(combined);

                //TODO: find the city and current temperature and add to appropriate item in days list
                reader.ReadToFollowing("city");
                dayList[0].location = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                dayList[0].currentTemp = reader.GetAttribute("value");
            }
            catch
            {
                part1 = "http://api.openweathermap.org/data/2.5/weather?q=";

                city = "Stratford,CA";

                part3 = "&mode=xml&units=metric&cnt=7&appid=3f2e224b815c0ed45524322e145149f0";

                combined = part1 + city + part3;

                XmlReader reader = XmlReader.Create(combined);

                //TODO: find the city and current temperature and add to appropriate item in days list
                reader.ReadToFollowing("city");
                dayList[0].location = reader.GetAttribute("name");

                reader.ReadToFollowing("temperature");
                dayList[0].currentTemp = reader.GetAttribute("value");
            }



        }


    }
}
