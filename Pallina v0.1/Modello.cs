using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pallina_v0._1
{
    class Modello
    {
        Circonferenza palla;
        ModelloGrafico modello;
        Retta top;
        Retta bottom;
        Retta right;
        Retta left;
        Retta traiettoria;
        Direzione dir;
        float precisione;
        PointF posMouse;

        public Modello(float x,float y,float raggio,ModelloGrafico m)
        {
            palla = new Circonferenza(new PointF(x,y), raggio);
            modello = m;
            top = new Retta(modello.Xfmin, modello.Yfmax, modello.Xfmax, modello.Yfmax);
            bottom = new Retta(modello.Xfmin, modello.Yfmin, modello.Xfmax, modello.Yfmin);
            left = new Retta(modello.Xfmin, modello.Yfmax, modello.Xfmin, modello.Yfmin);
            right = new Retta(modello.Xfmax, modello.Yfmax, modello.Xfmax, modello.Yfmin);           
            posMouse = new PointF();
        }

        public Circonferenza Palla { get => palla; set => palla = value; }
        public Retta Top { get => top; set => top = value; }
        public Retta Bottom { get => bottom; set => bottom = value; }
        public Retta Right { get => right; set => right = value; }
        public Retta Left { get => left; set => left = value; }
        public Retta Traiettoria { get => traiettoria; set => traiettoria = value; }
        public PointF PosMouse { get => posMouse; set => posMouse = value; }

        public void CalcolaDirezione(float xFoglio,float yFoglio)
        {
            if (xFoglio < palla.XCentro)
                dir = Direzione.Sinistra;
            else if (xFoglio > palla.XCentro)
                dir = Direzione.Destra;
            else if (yFoglio > palla.YCentro)
                dir = Direzione.Sopra;
            else
                dir = Direzione.Sotto;
            traiettoria = new Retta(palla.XCentro, palla.YCentro, xFoglio, yFoglio);            
        }

        PointF NuovoCentro()
        {
            if (dir == Direzione.Destra || dir==Direzione.Sopra)
                return traiettoria.CalcolaNuovoPunto(precisione, palla.Centro);
            else
                return traiettoria.CalcolaNuovoPunto(-precisione, palla.Centro);            
        }

        public void CalcolaVelocita(int vel)
        {
            precisione = vel;
        }

        public void RicalcolaCrf()
        {
            palla.Centro = NuovoCentro();         
        }
        
        public bool RicalcolaTraiettoria()
        {
            bool collisione = false;
            PointF punto = NuovoCentro();
            
            if (punto.Y+palla.Raggio> modello.Yfmax)
            {
                traiettoria = traiettoria.RettaSupplementare(palla.Centro);
                collisione = true;
                palla.YCentro = modello.Yfmax - palla.Raggio;
                if (dir == Direzione.Sopra)
                    dir = Direzione.Sotto;
                else
                    palla.XCentro = traiettoria.CalcolaX(palla.YCentro);                
                    
            }
            if(punto.Y-palla.Raggio < modello.Yfmin)
            {
                traiettoria = traiettoria.RettaSupplementare(palla.Centro);
                collisione = true;
                palla.YCentro = modello.Yfmin + palla.Raggio;                
                if (dir == Direzione.Sotto)
                    dir = Direzione.Sopra;
                else
                    palla.XCentro = traiettoria.CalcolaX(palla.YCentro);
            }
            if (punto.X+palla.Raggio > modello.Xfmax)
            {
                traiettoria = traiettoria.RettaSupplementare(palla.Centro);
                dir = Direzione.Sinistra;
                collisione = true;
            }
            if (punto.X-palla.Raggio < modello.Xfmin)
            {
                traiettoria = traiettoria.RettaSupplementare(palla.Centro);
                dir = Direzione.Destra;
                collisione = true;
            }
            return collisione;
        }
        
        public bool CalcolaCollisione(Circonferenza crf)
        {
            return crf.Centro.Y + crf.Raggio > modello.Yfmax || crf.Centro.Y - crf.Raggio< modello.Yfmin || crf.Centro.X + crf.Raggio > modello.Xfmax || crf.Centro.X - crf.Raggio < modello.Xfmin;
        }     
        

    }
}
