using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Xml;
using System.Text;
using System.Collections;
using System.Threading;
using NPlot;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        int intervalTime = 1000;
        string city;
        string region;
        string country;
        string unit = "c";
        int temperature;
        int luchtvochtigheid;
        string windSpeed;
        string windDirection;
        string pubDate;
        int condition;
        string conditionText;

        Grid grid;
        LinePlot stp;


        XmlNodeList nodes;
        // options

        string plaats = "729104";


        ArrayList weather = new ArrayList();

        public Form1()
        {

            Thread t = new Thread(new ThreadStart(splashStart));


            t.Start();
            Thread.Sleep(1000);


            InitializeComponent();

            t.Abort();

            getTheWeather();
           // refreshThread();
            contextMenuStrip1.PerformLayout();
       
           
        }

        public void refreshThread()
        {
            Thread interval = new Thread(new ThreadStart(getTheWeather));

            interval.Start();
        }


        private void splashStart()
        { 
        Application.Run(new splashscreen());
        }

        private void getTheWeather()
        {
            

            // Create a new XmlDocument  
            XmlDocument doc = new XmlDocument();

            // Load data  
            doc.Load("http://weather.yahooapis.com/forecastrss?w="+ plaats+ "&u="+ unit);

            // Set up namespace manager for XPath  
            XmlNamespaceManager ns = new XmlNamespaceManager(doc.NameTable);
            ns.AddNamespace("yweather", "http://xml.weather.yahoo.com/ns/rss/1.0");

            // Get forecast with XPath  

             nodes = doc.SelectNodes("/rss/channel/item/yweather:forecast", ns);
            XmlNodeList nodes1 = doc.SelectNodes("/rss/channel/yweather:location", ns);
            XmlNodeList nodes2 = doc.SelectNodes("/rss/channel/item/yweather:condition", ns);
            XmlNodeList nodes3 = doc.SelectNodes("/rss/channel/yweather:atmosphere", ns);
            XmlNodeList nodes4 = doc.SelectNodes("/rss/channel/yweather:wind", ns);
            XmlNodeList nodes5 = doc.SelectNodes("/rss/channel/item/pubDate", ns);
            XmlNodeList nodes6 = doc.SelectNodes("/rss/channel/image/url", ns);
           

         

            foreach (XmlNode node1 in nodes1)
            {
                city = node1.Attributes["city"].InnerText;
                region = node1.Attributes["region"].InnerText;
                country = node1.Attributes["country"].InnerText;
            }


            foreach (XmlNode node2 in nodes2)
            {
                temperature = int.Parse(node2.Attributes["temp"].InnerText);
                condition = int.Parse(node2.Attributes["code"].InnerText);
                conditionText = node2.Attributes["text"].InnerText;

            }

            foreach (XmlNode node3 in nodes3)
            {
                luchtvochtigheid = int.Parse(node3.Attributes["humidity"].InnerText);
            }

            foreach (XmlNode node3 in nodes3)
            {
                luchtvochtigheid = int.Parse(node3.Attributes["humidity"].InnerText);
            }

            foreach (XmlNode node4 in nodes4)
            {
                windSpeed = node4.Attributes["speed"].InnerText;
                windDirection = node4.Attributes["direction"].InnerText;
            }

            foreach (XmlNode node5 in nodes5)
            {
                pubDate = node5.InnerText;
            }

            foreach (XmlNode node5 in nodes5)
            {
                pubDate = node5.InnerText;
            }

            label5.Text = city + " " + region + " " + country;
            label6.Text = temperature.ToString() + " " + unit;
            label7.Text = luchtvochtigheid.ToString() + " %";
            label8.Text = "snelheid: " + windSpeed.ToString() + " richting: " + windDirection.ToString() + "\u00B0";
            label13.Text = pubDate;
            label14.Text = conditionText;
            pictureBox1.ImageLocation = "https://s.yimg.com/zz/combo?a/i/us/we/52/" + condition + ".gif";

            plot();

            Thread.Sleep(intervalTime);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach(var i in weather)
            {
                MessageBox.Show(i.ToString());
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            plaats = textBox1.Text;
            MessageBox.Show("plaats gewijzigd naar: "+ plaats);
        }


        // update interval
        private void timer1_Tick(object sender, EventArgs e)
        {
            getTheWeather();
            huidigeTemperatuurToolStripMenuItem.Text = "huidige temperatuur: " + temperature + unit;
           
        }

        // update temperatuur unit  c/f
        private void button1_Click(object sender, EventArgs e)
        {
            
            unit = textBox3.Text;
            MessageBox.Show("temperatuur aangepast naar: " + unit);
        }

        // update ververs tijd
        private void button3_Click_1(object sender, EventArgs e)
        {
            int interval = int.Parse(textBox2.Text) ;
            interval = interval * 1000;
            timer1.Interval = interval;
            MessageBox.Show("interval: " + interval);
        }

        // grafiek
        public void plot()
        {

              // clear plot surface
            plot1.Clear();

            // add background grid
            grid = new Grid();
            grid.VerticalGridType = Grid.GridType.Coarse;
            grid.HorizontalGridType = Grid.GridType.Coarse;
            grid.MajorGridPen = new Pen(Color.LightGray, 1.0f);

                 //Arrays voor de data aanmaken
            List<int> xAxis = new List<int>();
            List<int> sineXoverX = new List<int>();

               foreach (XmlNode node in nodes)
            {
                string day;
                day = node.Attributes["day"].InnerText;

                switch(day)
                {
                    case "Mon":
                        xAxis.Add(1);
                        break;
                    case "Tue":
                        xAxis.Add(2);
                        break;
                    case "Wed":
                        xAxis.Add(3);
                        break;
                    case "Thu":
                        xAxis.Add(4);
                        break;
                    case "Fri":
                        xAxis.Add(5);
                        break;
                    case "Sat":
                        xAxis.Add(6);
                        break;
                    case "Sun":
                        xAxis.Add(7);
                        break;

                }
                               
       sineXoverX.Add(int.Parse(node.Attributes["high"].InnerText));


            }


            plot1.Add(grid);

            stp = new LinePlot();
            stp.Pen = new Pen(Color.Red, 2);

            

           

            stp.AbscissaData = xAxis;
            stp.DataSource = sineXoverX;

            plot1.Add(stp);

            plot1.ShowCoordinates = false;
        
            plot1.YAxis1.HideTickText = false;
            plot1.Padding = 5;

            plot1.Refresh();

        }
        //   buttons van de toolstripmenu
        private void sluitenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void verversenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getTheWeather();
        }

        private void huidigeTemperatuurToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            contextMenuStrip1.Show(this, Control.MousePosition);
        }

        private void overToolStripMenuItem_Click(object sender, EventArgs e)
        {
            over o = new over();
            o.Show();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void optiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

     
    }
}
