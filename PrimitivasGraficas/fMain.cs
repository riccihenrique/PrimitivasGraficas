using System;
using System.Drawing;
using System.Windows.Forms;

namespace PrimitivasGraficas
{
    public partial class fMain : Form
    {
        Point pDown;
        Point pOld;
        Color branco = Color.FromArgb(240, 240, 240);
        Color preto = Color.FromArgb(0, 0, 0);

        Bitmap image;
        Bitmap image_copy;
        public fMain()
        {
            InitializeComponent();

            NovoToolStripMenuItem_Click(null, null);
            pDown.X = -1;
        }

        private void PbArea_MouseClick(object sender, MouseEventArgs e)
        {
            /* if (rbPontMedio.Checked && pDown.X == -1)
             {
                 pDown = e.Location;
                 pOld = e.Location;
             }
             else
             {
                 bresenham(pDown.X, pDown.Y, e.X, e.Y, preto);
                 pDown.X = -1;
             }*/
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files | *.jpg;*.jpeg;*.bmp;*.png";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                image = new Bitmap(openFileDialog1.FileName);
                pbArea.Image = image_copy;
            }
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PbArea_MouseDown(object sender, MouseEventArgs e)
        {
            pDown = e.Location;
            pOld = e.Location;
            lbP1.Text = "(" + e.X + "," + e.Y + ")";
            //image = new Bitmap(image_copy);
        }

        private void NovoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            image = new Bitmap(pbArea.Width, pbArea.Height);
            //image_copy = new Bitmap(image);
            pbArea.Image = image;
        }

        private void PbArea_MouseUp(object sender, MouseEventArgs e)
        {
            pDown.X = -1;
            //image_copy = new Bitmap(image);
            lbP1.Text = "( , )";
            lbP2.Text = "( , )";
        }

        private void PbArea_MouseMove(object sender, MouseEventArgs e)
        {
            //image = new Bitmap(image_copy);
            if (pDown.X != -1)
                lbP2.Text = "(" + e.X + "," + e.Y + ")";
            if (pDown.X > -1 && e.X > 0 && e.Y > 0 && e.X < pbArea.Width && e.Y < pbArea.Height)
            {
                if (rbEqFundReta.Checked)
                {
                    equacao_fundamental(pDown.X, pDown.Y, pOld.X, pOld.Y, branco, true);
                    equacao_fundamental(pDown.X, pDown.Y, e.X, e.Y, preto, true);
                }
                else if (rbDda.Checked)
                {
                    dda(pDown.X, pDown.Y, pOld.X, pOld.Y, branco);
                    dda(pDown.X, pDown.Y, e.X, e.Y, preto);
                }
                else if (rbPontMedio.Checked)
                {
                    bresenham(pDown.X, pDown.Y, pOld.X, pOld.Y, branco);
                    bresenham(pDown.X, pDown.Y, e.X, e.Y, preto);
                }

                if (rbEqGeralCirc.Checked)
                {
                    equacao_geral_circunf(pDown.X, pDown.Y, pOld.X, pOld.Y, branco);
                    equacao_geral_circunf(pDown.X, pDown.Y, e.X, e.Y, preto);
                }
                else if (rbPontoMedioCirc.Checked)
                {
                    ponto_medio_circunf(pDown.X, pDown.Y, pOld.X, pOld.Y, branco);
                    ponto_medio_circunf(pDown.X, pDown.Y, e.X, e.Y, preto);
                }

                if (rbPontoMedioElipse.Checked)
                {
                    ponto_medio_elipse(pDown.X, pDown.Y, pOld.X, pOld.Y, branco);
                    ponto_medio_elipse(pDown.X, pDown.Y, e.X, e.Y, preto);
                }
                pOld = e.Location;
                pbArea.Image = image;
            }
        }

        private void equacao_fundamental(int x1, int y1, int x2, int y2, Color c)
        {
            int x0, y0;
            double m, y, x;
            int i, ifim;

            m = (x2 - x1);
            m = m == 0 ? 0 : (y2 - y1) / m;

            if (m >= 0 && m <= 1) // BO aqui
            {
                if (x1 < x2)
                {
                    i = x1;
                    ifim = x2;
                    y0 = y1;
                }
                else
                {
                    i = x2;
                    ifim = x1;
                    y0 = y2;
                }
                x0 = i;

                for (; i < ifim; i++)
                {
                    y = y0 + m * (i - x0);
                    image.SetPixel(i, (int)y, c);
                }
            }
            else if (m > 1)
            {
                if (y1 < y2)
                {
                    i = y1;
                    ifim = y2;
                    x0 = x1;
                }
                else
                {
                    i = y2;
                    ifim = y1;
                    x0 = x2;
                }
                y0 = i;

                for (; i < ifim; i++)
                {
                    x = (i - y0 + m * x0) / m;
                    image.SetPixel((int)x, i, c);
                }
            }
            else if (m < -1)
            {
                if (y1 < y2)
                {
                    i = y1;
                    ifim = y2;
                    x0 = x1;
                }
                else
                {

                    i = y2;
                    ifim = y1;
                    x0 = x2;
                }
                y0 = i;

                for (; i < ifim; i++)
                {
                    x = (i - y0 + m * x0) / m;
                    image.SetPixel((int)x, i, c);
                }
            }
            else
            {
                if (x1 < x2)
                {
                    i = x1;
                    ifim = x2;
                    y0 = y1;
                }
                else
                {
                    i = x2;
                    ifim = x1;
                    y0 = y2;
                }
                x0 = i;

                for (; i < ifim; i++)
                {
                    y = y0 + m * (i - x0);
                    image.SetPixel(i, (int)y, c);
                }
            }
        }

        private void dda(int x1, int y1, int x2, int y2, Color c)
        {
            if (x1 > x2)
                dda(x2, y2, x1, y1, c);
            else
            {
                int length;
                double x, y, xinc, yinc;

                length = Math.Abs(x2 - x1);

                if (Math.Abs(y2 - y1) > length)
                    length = Math.Abs(y2 - y1);

                xinc = (double)(x2 - x1) / length;
                yinc = (double)(y2 - y1) / length;

                x = x1;
                y = y1;

                if (x1 == x2)
                {
                    if (y2 < y1)
                    {
                        y1 ^= y2;
                        y2 ^= y1;
                        y1 ^= y2;
                        y = y1;
                        yinc = -yinc;
                    }
                    while (y < y2)
                    {
                        image.SetPixel((int)Math.Round(x), (int)Math.Round(y), c);
                        y += yinc;
                    }
                }
                else
                    while (x < x2)
                    {
                        image.SetPixel((int)Math.Round(x), (int)Math.Round(y), c);
                        x += xinc;
                        y += yinc;
                    }
            }
        }

        private void bresenham(int x1, int y1, int x2, int y2, Color c)
        {
            int declive;
            int dx, dy, incE, incNE, d, x, y;
            dx = x2 - x1;
            dy = y2 - y1;

            if (Math.Abs(dx) >= Math.Abs(dy))
            {
                if (x2 < x1)
                    bresenham(x2, y2, x1, y1, c);
                else
                {
                    if (dy < 0)
                    {
                        declive = -1;
                        dy = -dy;
                    }
                    else
                        declive = 1;

                    incE = 2 * dy;
                    incNE = 2 * (dy - dx);
                    d = incE - dx;
                    y = y1;
                    for (x = x1; x <= x2; x++)
                    {
                        image.SetPixel(x, y, c);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            y += declive;
                        }
                    }
                }
            }
            else
            {
                if (y2 < y1)
                    bresenham(x2, y2, x1, y1, c);
                else
                {
                    if (dx < 0)
                    {
                        declive = -1;
                        dx = -dx;
                    }
                    else
                        declive = 1;

                    incE = 2 * dx;
                    incNE = 2 * (dx - dy);
                    d = incE - dy;
                    x = x1;
                    for (y = y1; y <= y2; y++)
                    {
                        image.SetPixel(x, y, c);
                        if (d <= 0)
                            d += incE;
                        else
                        {
                            d += incNE;
                            x += declive;
                        }
                    }
                }
            }
        }

        private void equacao_geral_circunf(int x1, int y1, int x2, int y2, Color c)
        {
            double raio = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)), raioMeio = raio / Math.Sqrt(2);
            int x, y;

            for (x = 0; x < raioMeio; x++)
            {
                y = (int)Math.Sqrt(Math.Pow(raio, 2) - Math.Pow(x, 2));
                Console.WriteLine(y);
                simetria(x, y, x1, y1, c);
            }
        }

        private void ponto_medio_circunf(int x1, int y1, int x2, int y2, Color c)
        {
            int x = 0;
            int y = (int)Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            double d = 1 - y;
            simetria(x, y, x1, y1, c);
            while (y > x)
            {
                if (d < 0) /* escolhe E */
                    d += 2 * x + 3;
                else
                {  /* escolhe SE */
                    d += 2 * (x - y) + 5;
                    y--;
                }
                x++;
                simetria(x, y, x1, y1, c);
            }
        }

        private void ponto_medio_elipse(int x1, int y1, int x2, int y2, Color c)
        {
            double d1, d2;
            int a = Math.Abs(x2 - x1), b = Math.Abs(y2 - y1);
            int x = 0;
            int y = b;

            d1 = b * b - a * a * b + a * a / 4.0;
            simetria4(x, y, x1, y1, c);
            while (a * a * (y - 0.5) > b * b * (x + 1))
            {
                if (d1 < 0)
                {
                    d1 = d1 + b * b * (2 * x + 3);
                    x++;
                }
                else
                {
                    d1 = d1 + b * b * (2 * x + 3) + a * a * (-2 * y + 2);
                    x++;
                    y--;
                }
                simetria4(x, y, x1, y1, c);
            }
            d2 = b * b * (x + 0.5) * (x + 0.5) + a * a * (y - 1) * (y - 1) - a * a * b * b;
            while (y > 0)
            {
                if (d2 < 0)
                {
                    d2 = d2 + b * b * (2 * x + 2) + a * a * (-2 * y + 3);
                    x++;
                    y--;
                }
                else
                {
                    d2 = d2 + a * a * (-2 * y + 3);
                    y--;
                }
                simetria4(x, y, x1, y1, c);
            }
        }

        private void simetria4(int x, int y, int cx, int cy, Color c)
        {
            if (cx + x < image.Width && cy + y < image.Height && cx - x > 0 && cy - y > 0)
            {
                image.SetPixel(cx + x, cy + y, c);
                image.SetPixel(cx + x, cy - y, c);
                image.SetPixel(cx - x, cy + y, c);
                image.SetPixel(cx - x, cy - y, c);
            }
        }

        private void simetria(int x, int y, int cx, int cy, Color c)
        {
            if (cx + x < image.Width && cy + y < image.Height && cx - x > 0 && cy - y > 0)
            {
                image.SetPixel(cx + x, cy + y, c);
                image.SetPixel(cx + y, cy + x, c);
                image.SetPixel(cx + y, cy - x, c);
                image.SetPixel(cx + x, cy - y, c);
                image.SetPixel(cx - x, cy - y, c);
                image.SetPixel(cx - y, cy - x, c);
                image.SetPixel(cx - y, cy + x, c);
                image.SetPixel(cx - x, cy + y, c);
            }
        }

        private void RbEqGeralCirc_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                rbEqFundReta.Checked = false;
                rbPontMedio.Checked = false;
                rbDda.Checked = false;

                rbPontoMedioElipse.Checked = false;
            }
        }

        private void RbEqFundReta_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                rbPontoMedioElipse.Checked = false;
                rbPontoMedioCirc.Checked = false;
                rbEqGeralCirc.Checked = false;
                rbTrigonometria.Checked = false;
            }
        }

        private void RbPontoMedioElipse_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                rbPontoMedioCirc.Checked = false;
                rbEqGeralCirc.Checked = false;
                rbTrigonometria.Checked = false;
                rbEqFundReta.Checked = false;
                rbPontMedio.Checked = false;
                rbDda.Checked = false;
            }
        }
        private void equacao_fundamental(int x1, int y1, int x2, int y2, Color c, bool f)
        {
            int x0, y0;
            double m, y, x;
            int i, ifim, inc;

            m = (x2 - x1);
            m = m == 0 ? 0 : (y2 - y1) / m;

            int len = Math.Abs(x2 - x1);
            if (Math.Abs(y2 - y1) > len)
                len = Math.Abs(y2 - y1);

            if (Math.Abs(x2 - x1) > Math.Abs(y2 - y1)) // BO aqui
            {
                if (x1 < x2)
                {
                    i = x1; ifim = x2;
                    x0 = x1;
                }
                else
                {
                    i = x2; ifim = x1;
                    x0 = x2;
                }
                y0 = y1 < y2 ? y1 : y2;
                for (; i <= ifim; i++)
                {
                    y = y0 + m * (i - x1);
                    image.SetPixel(i, (int)y, c);
                }
            }
            else
            {
                if (y1 < y2)
                {
                    i = y1; ifim = y2;
                    y0 = y1;
                }
                else
                {
                    i = y2; ifim = y1;
                    y0 = y2;
                }

                x0 = x1 < x2 ? x1 : x2;
                for (; i <= ifim; i++)
                {
                    x = x0 + (i - y1) / (m + 0.1);
                    if (x < 0)
                        x = 0;
                    image.SetPixel((int)x, i, c);
                }
            }
        }
    }
}
