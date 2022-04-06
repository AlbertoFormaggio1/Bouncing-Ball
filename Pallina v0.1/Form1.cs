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

namespace Pallina_v0._1
{

    public partial class Form1 : Form
    {
        Pen penna;
        ModelloGrafico modelloGrafico;
        Modello model;
        Graphics foglio;
        bool click;
        bool movimento;
        bool coloreAutomatico;
        bool entrato;        
        public Form1()
        {
            InitializeComponent();
            penna = new Pen(Color.White);
            modelloGrafico = new ModelloGrafico();
            entrato = false;
            click = false;
            movimento = false;
            btnStop.Enabled = false;
            numRaggio.Value = 10;
            modelloGrafico.QuotaFoglio();
            modelloGrafico.QuotaVideo(panel1.Width, panel1.Height);
            coloreAutomatico = false;
            numVel.Value = 1;
            panel1.GetType().GetMethod("SetStyle", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).    //Abilita il double buffering
                Invoke(panel1, new object[]
                {  System.Windows.Forms.ControlStyles.UserPaint |System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
                  System.Windows.Forms.ControlStyles.DoubleBuffer, true });
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, panel1.DisplayRectangle, Color.White, ButtonBorderStyle.Inset);
            if (click)
            {
                foglio = e.Graphics;
                List<PointF> superiore;
                List<PointF> inferiore;
                model.Palla.CalcolaPunti(out superiore, out inferiore);

                for (int i = 0; i < superiore.Count - 1; i++)
                {
                    foglio.DrawLine(penna, modelloGrafico.CoordinataVideoX(superiore[i].X), modelloGrafico.CoordinataVideoY(superiore[i].Y), modelloGrafico.CoordinataVideoX(superiore[i + 1].X), modelloGrafico.CoordinataVideoY(superiore[i + 1].Y));
                    foglio.DrawLine(penna, modelloGrafico.CoordinataVideoX(inferiore[i].X), modelloGrafico.CoordinataVideoY(inferiore[i].Y), modelloGrafico.CoordinataVideoX(inferiore[i + 1].X), modelloGrafico.CoordinataVideoY(inferiore[i + 1].Y));
                }
                RectangleF rect = new RectangleF(modelloGrafico.CoordinataVideoX(model.Palla.XCentro - model.Palla.Raggio), modelloGrafico.CoordinataVideoY(model.Palla.YCentro - model.Palla.Raggio), model.Palla.Raggio * 2 * modelloGrafico.FattoreDiScalaVideoX(), model.Palla.Raggio * 2 * modelloGrafico.FattoreDiScalaVideoY());
                SolidBrush b = new SolidBrush(penna.Color);
                e.Graphics.FillEllipse(b, rect);
                if (click && !movimento && entrato)
                {
                    e.Graphics.DrawLine(penna, modelloGrafico.CoordinataVideoX(model.Palla.XCentro), modelloGrafico.CoordinataVideoY(model.Palla.YCentro), modelloGrafico.CoordinataVideoX(model.PosMouse.X), modelloGrafico.CoordinataVideoY(model.PosMouse.Y));
                }
            }
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            float xFoglio = modelloGrafico.CoordinataFoglioX(me.X);
            float yFoglio = modelloGrafico.CoordinataFoglioY(me.Y);
            if (!click)
            {
                if (xFoglio - (float)numRaggio.Value > modelloGrafico.Xfmin & xFoglio + (float)numRaggio.Value < modelloGrafico.Xfmax & yFoglio - (float)numRaggio.Value > modelloGrafico.Yfmin & yFoglio + (float)numRaggio.Value < modelloGrafico.Yfmax)
                {
                    click = true;
                    model = new Modello(xFoglio, yFoglio, (float)numRaggio.Value, modelloGrafico);
                    model.CalcolaVelocita((int)numVel.Value);
                    Refresh();
                }
                else
                { MessageBox.Show("La palla esce dallo schermo"); }
            }
            else if (!movimento & click)
            {
                btnStop.Enabled = true;
                btnStop.BackColor = Color.Lime;
                numRaggio.Enabled = false;
                movimento = true;
                model.CalcolaDirezione(xFoglio, yFoglio);
                timer.Enabled = true;
            }
            }

            private void Form1_Paint(object sender, PaintEventArgs e)
            {

            }

            private void muovi_Tick(object sender, EventArgs e)
            {
                if (model.RicalcolaTraiettoria())
                {
                    if (coloreAutomatico)
                    {
                        Random rnd = new Random();
                        Color randomColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                        penna.Color = randomColor;
                    }
                }
                model.RicalcolaCrf();
                Refresh();
            }

            private void Form1_Resize(object sender, EventArgs e)
            {
                this.Height=(int)Math.Truncate(this.Width * 0.8491);
                panel1.Height = panel1.Width;
                modelloGrafico.QuotaVideo(panel1.Width, panel1.Height);
                Refresh();
            }

            private void numVel_ValueChanged(object sender, EventArgs e)
            {
                lbErrore.Text = "";
                if (numVel.Value <= 50)
                {
                    if (click)
                        model.CalcolaVelocita((int)numVel.Value);
                }
                else
                {
                    numVel.Value--;
                    lbErrore.Text = "Il valore massimo \nper la velocità 50";
                }
            }

            private void numRaggio_ValueChanged(object sender, EventArgs e)
            {
                lbErrore.Text = "";
                if (numRaggio.Value > 0)
                {
                    if (numRaggio.Value <= 50)
                    {
                        if (!movimento && click)
                        {
                            Circonferenza tmp = new Circonferenza(model.Palla.Centro, (float)numRaggio.Value);
                            if (!model.CalcolaCollisione(tmp))
                            {
                                model.Palla = tmp;
                                Refresh();
                            }
                            else
                            {
                                numRaggio.Value--;
                                lbErrore.Text = "La palla esce\ndallo schermo";
                            }
                        }
                    }
                    else
                    {
                        numRaggio.Value--;
                        lbErrore.Text = "Il valore massimo \ndel raggio è 50";
                    }
                }
                else
                {
                    numRaggio.Value++;
                    lbErrore.Text = "Il valore minimo \ndel raggio è 0";
                }
            }

            void Reset()
            {
                model = null;
                click = false;
                movimento = false;
                timer.Enabled = false;
                btnStop.Enabled = false;
                btnStop.Text = "Pausa";
                btnStop.BackColor = Color.LightGreen;
                numRaggio.Enabled = true;
            }

            private void button2_Click(object sender, EventArgs e)
            {
                Reset();
                Refresh();
            }

            private void btnStop_Click(object sender, EventArgs e)
            {
                if (timer.Enabled)
                {
                    timer.Enabled = false;
                    btnStop.Text = "Riprendi";
                }
                else
                {
                    timer.Enabled = true;
                    btnStop.Text = "Pausa";
                }
            }

            private void panel1_MouseMove(object sender, MouseEventArgs e)
            {
                if (click)
                {
                    PointF pos = model.PosMouse;
                    pos.X = modelloGrafico.CoordinataFoglioX(e.X);
                    pos.Y = modelloGrafico.CoordinataFoglioY(e.Y);
                    model.PosMouse = pos;
                    Refresh();
                }
            }

            private void checkBox1_CheckedChanged(object sender, EventArgs e)
            {
                coloreAutomatico = !coloreAutomatico;
            }

            private void btnPalla_Click(object sender, EventArgs e)
            {
                cDPalla.ShowDialog();
                if (cDSfondo.Color != cDPalla.Color)
                    penna.Color = cDPalla.Color;
                Refresh();
            }

            private void btnSfondo_Click(object sender, EventArgs e)
            {
                cDSfondo.ShowDialog();
                if (cDSfondo.Color != cDPalla.Color)
                    panel1.BackColor = cDSfondo.Color;
            }

            private void panel1_MouseEnter(object sender, EventArgs e)
            {
                entrato = true;
                Refresh();
            }

            private void panel1_MouseLeave(object sender, EventArgs e)
            {
                entrato = false;
                Refresh();
            }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    }
