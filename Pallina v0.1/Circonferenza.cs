using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pallina_v0._1
{

    public class Circonferenza
    {
        PointF centro;
        float raggio;

        public PointF Centro { get => centro; set => centro = value; }

        public float XCentro
        {
            get { return centro.X; }
            set { centro.X = value; }
        }

        public float YCentro
        {
            get { return centro.Y; }
            set { centro.Y = value; }
        }

        public float Raggio
        {
            get { return raggio; }
        }

        public float DistanzaTraDuePunti(PointF C, PointF P)
        {
            return (float)Math.Sqrt(Math.Pow(centro.X - P.X, 2) + (Math.Pow(centro.Y - P.Y, 2)));
        }

        public Circonferenza(PointF C, float _r)
        {
            centro = new PointF(C.X, C.Y);
            raggio = _r;
        }

        public float Alfa
        {
            get { return -2 * centro.X; }
        }
        public float Beta
        {
            get { return -2 * centro.Y; }
        }
        public double Gamma
        {
            get { return Math.Pow(centro.X, 2) + Math.Pow(centro.Y, 2) - Math.Pow(raggio, 2); }
        }        

        public void CalcolaPunti(out List<PointF> superiore, out List<PointF> inferiore)
        {
            superiore = new List<PointF>();
            inferiore = new List<PointF>();
            float x = centro.X - raggio;
            float precisione = 0.25f;
            float a = 1;
            double b = Beta;
            double c;
            float giri =  raggio*2/precisione;

            for (int i = 0; i < giri; i++)
            {
                c = (Math.Pow(x, 2) + Alfa * x + Gamma);
                float delta=(float)(Math.Round(Math.Pow(b, 2), 2) - Math.Round((4 * a * c), 2));
                if (delta < 0)
                    delta = 0;
                superiore.Add(new PointF(x, (float)((-b + Math.Sqrt(delta)) / 2 * a)));
                inferiore.Add(new PointF(x, (float)((-b - Math.Sqrt(delta)) / 2 * a)));
                x += precisione;
            }
            superiore.Add(new PointF(x, superiore[0].Y));
            inferiore.Add(new PointF(x, inferiore[0].Y));
        }
    }
}

