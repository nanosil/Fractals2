using System;
using System.Drawing;
using System.Windows.Forms;
using System.Numerics;

namespace Fractals
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap pic;
        int size;//=100;
        double max = 2;
        double xMax;
        double yMax;
        double xMin;
        double yMin;

        double xstep;
        double ystep;

        private void Form1_Load(object sender, EventArgs e)
        {
            size = pictureBox1.Size.Height;
            maxNumericUpDown.Value = 2;
            xMaxNumeric.Value = .5M;
            xMinNumeric.Value = -1.5M;
            yMaxNumeric.Value = 1.2M;
            yMinNumeric.Value = -1.2M;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic = new Bitmap(Fractals.Properties.Resources.IMAG0468, size, size);
            loadingLabel.Visible = true;
            this.Refresh();

            Complex ans = new Complex(0, 0);

            xstep = (xMax - xMin) / size;
            ystep = (yMax - yMin) / size;
            double re = xMin;
            double img = yMin;
            for (int y = 0; y < size; y++)
            {
                for (int x = 0; x < size; x++)
                {
                    ans = new Complex(0, 0);
                    for (int i = 0; i < 10; i++)
                    {
                        ans = Complex.Pow(ans, 2) + new Complex(re, img);
                        if (ans.Magnitude > max)
                            break;
                    }
                    if (ans.Magnitude > max)
                        pic.SetPixel(x, y, Color.White);
                    else//is a good number
                        pic.SetPixel(x, y, Color.Black);

                    re += xstep;
                }
                re = xMin;
                img += ystep;
            }
            pictureBox1.Image = pic;
            loadingLabel.Visible = false;
        }

        private void maxNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            max = Convert.ToDouble(maxNumericUpDown.Value);
        }

        private void xMaxNumeric_ValueChanged(object sender, EventArgs e)
        {
            xMax = Convert.ToDouble(xMaxNumeric.Value);
        }

        private void yMaxNumeric_ValueChanged(object sender, EventArgs e)
        {
            yMax = Convert.ToDouble(yMaxNumeric.Value);
        }

        private void xMinNumeric_ValueChanged(object sender, EventArgs e)
        {
            xMin = Convert.ToDouble(xMinNumeric.Value);
        }

        private void yMinNumeric_ValueChanged(object sender, EventArgs e)
        {
            yMin = Convert.ToDouble(yMinNumeric.Value);
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            yMaxNumeric.Value -= stepNumericUpDown.Value;
            yMinNumeric.Value -= stepNumericUpDown.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            xMaxNumeric.Value -= stepNumericUpDown.Value;
            xMinNumeric.Value -= stepNumericUpDown.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            xMaxNumeric.Value += stepNumericUpDown.Value;
            xMinNumeric.Value += stepNumericUpDown.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void DownBbutton_Click(object sender, EventArgs e)
        {
            yMaxNumeric.Value += stepNumericUpDown.Value;
            yMinNumeric.Value += stepNumericUpDown.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void inButton_Click(object sender, EventArgs e)
        {
            yMaxNumeric.Value -= stepZnumeric.Value;
            yMinNumeric.Value += stepZnumeric.Value;
            xMaxNumeric.Value -= stepZnumeric.Value;
            xMinNumeric.Value += stepZnumeric.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            yMaxNumeric.Value += stepZnumeric.Value;
            yMinNumeric.Value -= stepZnumeric.Value;
            xMaxNumeric.Value += stepZnumeric.Value;
            xMinNumeric.Value -= stepZnumeric.Value;
            button1_Click(new object(), EventArgs.Empty);
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            label7.Text = "Real Value: " + (xMin+(e.X *xstep))
                + "\nImag Value: " + (yMin + ((size - e.Y) * ystep));
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            int x = this.Size.Width - 330;
            size = x;
            label1.Text = "size is: " + x + "Pixels";
            pictureBox1.Size = new Size(x,x);
        }
    }
}
