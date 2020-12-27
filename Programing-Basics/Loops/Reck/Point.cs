using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reck
{
    public partial class Point : Form
    {
        public Point()
        {
            InitializeComponent();
        }

        private void Point_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void butondraw_Click(object sender, EventArgs e)
        {
            Draw();
        }
        private void Draw()
        {
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;

            var left = Math.Min(x1, x2);
            var right = Math.Max(x1, x2);
            var up = Math.Min(y1, y2);
            var down = Math.Max(y1, y2);

            if (x > left && x < right && y > up && y < down)
            {
                this.labelResult.Text = "Inside";
                this.labelResult.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < up || y > down)
            {
                this.labelResult.Text = "Outside";
                this.labelResult.BackColor = Color.LightPink;
            }
            else if (((x == left) || (x == right)) && ((y == up) || (y == down)))
            {
                this.labelResult.Text = "Corner";
                this.labelResult.BackColor = Color.Coral;
            }
            else
            {
                this.labelResult.Text = "Border";
                this.labelResult.BackColor = Color.LightSkyBlue;
            }

            Visualize();

        }

        private void Visualize()
        {
            var x1 = this.numericUpDownX1.Value;
            var y1 = this.numericUpDownY1.Value;
            var x2 = this.numericUpDownX2.Value;
            var y2 = this.numericUpDownY2.Value;
            var x = this.numericUpDownX.Value;
            var y = this.numericUpDownY.Value;

            DisplayPointLocation(x1, y1, x2, y2, x, y);

            var MinX = Min(x1, x2, x);
            var MaxX = Max(x1, x2, x);
            var MinY = Min(y1, y2, y);
            var MaxY = Max(y1, y2, y);
            var diagramWidth = MaxX - MinX;
            var diagramHeight = MaxY - MinY;
            var ratio = 1.0m;
            var offset = 10;
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                var ratioX = (pictureBox1.Width - 2 * offset - 1) / diagramWidth;
                var ratioY = (pictureBox1.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }
            var rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - MinX) * ratio);
            var rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - MinY) * ratio);
            var rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
            var rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);
            var rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            var pointX = (int)Math.Round(offset + (x - MinX) * ratio);
            var pointY = (int)Math.Round(offset + (y - MinY) * ratio);
            var pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height,);
            using (var g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);

                var pen = new Pen(Color.Blue, 5);
                g.DrawRectangle(pen, rect);

            }

            private decimal Min(decimal val1, decimal val2, decimal val3)
            {
                return Math.Min(val1, Math.Min(val2, val3));
            }
            private decimal Max(decimal val1, decimal val2, decimal val3)
            {
                return Math.Max(val1, Math.Max(val2, val3));
            }


        }

        private void numericUpDownX1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY1_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY2_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            Draw();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Draw();
        }
    }
}
