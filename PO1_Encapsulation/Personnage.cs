using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    public class Personnage
    {
        int pointDeVie;
        int puissanceAttaque;

        public int PointDeVie { get => pointDeVie;
            set
            {
                if (value < 0)
                {
                    pointDeVie = 0;
                }
                else
                {
                    pointDeVie = value;
                }
            }
        }
        public int PuissanceAttaque { get => puissanceAttaque; set => puissanceAttaque = value; }
    }
}
