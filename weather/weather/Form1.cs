using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;
using Presentation_Layer;

namespace weather
{
    public partial class F_Weather : Form
    {
        WeatherManager manager;
        Weather_Status status;
        public F_Weather()
        {
            manager = new WeatherManager();
            status = new Weather_Status();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int radius = 40;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            this.Region = new Region(path);

            time();

        }

        private void B_Search_Click(object sender, EventArgs e)
        {
            manager.Connection(T_City.Text);
            manager.ExtracData();

            L_Info.Text = $"{T_City.Text} : {manager.Weather_Description} \n temp : {manager.temperature}º\n wind : {manager.Wind}";
            status.weather_status(manager.Weather_Description);
            picture();
        }

        public void time()
        {
            L_Time.Text = DateTime.Now.ToString("MMMM");
        }

        public void picture()
        {
            pictureBox1.ImageLocation = status.location;
        }
    }
}
