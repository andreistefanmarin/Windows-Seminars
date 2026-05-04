using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChartLibrary
{
    public partial class BarChartControl : Control
    {
        public BarChartControl()
        {
            InitializeComponent();

            Data = new[]
            {
                new BarChartValue("andrei",10),
                new BarChartValue("m",40),
                new BarChartValue("code",30),
                new BarChartValue("lol",5)
            };
        }

        private BarChartValue[] _data;
        public BarChartValue[] Data
        {
            get { return _data; }
            set { _data = value; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            //context
            Graphics graphics = e.Graphics;

            Rectangle r = e.ClipRectangle;

            var barWidth = e.ClipRectangle.Width / Data.Length;

            var maxBarHeight = r.Height * 0.9;

            var f = maxBarHeight / Data.Max(x => x.Value);

            Brush red = new SolidBrush(Color.Red);

            for(int i=0; i < Data.Length; i++)
            {
                var barHeight = Data[i].Value * f;

                graphics.FillRectangle(red, i * barWidth, 
                    (float)(r.Height - barHeight), (float)(barWidth * 0.9), 
                    (float)(barHeight) );
            }
        }
    }
}
