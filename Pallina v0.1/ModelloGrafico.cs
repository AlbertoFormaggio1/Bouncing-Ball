using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallina_v0._1
{
    public class ModelloGrafico
    {
        float xfmin, xfmax, yfmin, yfmax;
        float xvmin, xvmax, yvmin, yvmax;

        public float Xfmin { get => xfmin; }        
        public float Xfmax { get => xfmax; }
        public float Yfmin { get => yfmin; }
        public float Yfmax { get => yfmax; }        

        public void QuotaFoglio()
        {
            xfmin = -100;
            yfmax = 100;

            xfmax = 100;
            yfmin = -100;
        }
        public void QuotaVideo(int width,int height)
        {
            xvmin = 0;
            xvmax = width;

            yvmin = height;
            yvmax = 0;
        }
        public float FattoreDiScalaVideoX()
        {
            return (xvmax - xvmin) / (xfmax - xfmin);
        }
        public float FattoreDiScalaVideoY()
        {
            return (yvmax - yvmin) / (yfmax - yfmin);
        }
        public float FattoreDiScalaFoglioY()
        {
            return (yfmax - yfmin) / (yvmax - yvmin);
        }
        public float FattoreDiScalaFoglioX()
        {
            return (xfmax - xfmin) / (xvmax - xvmin);
        }
        public float CoordinataVideoX(float x)
        {
            return FattoreDiScalaVideoX() * (x - xfmin) + xvmin;
        }
        public float CoordinataVideoY(float y)
        {
            return FattoreDiScalaVideoY() * (y - yfmin) + yvmin;
        }
        public float CoordinataFoglioX(float x)
        {
            return FattoreDiScalaFoglioX() * (x - xvmin) + xfmin;
        }
        public float CoordinataFoglioY(float y)
        {
            return FattoreDiScalaFoglioY() * (y - yvmin) + yfmin;
        }
    }
}
