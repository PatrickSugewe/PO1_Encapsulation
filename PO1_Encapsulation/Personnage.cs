using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PO1_Encapsulation
{
    internal class Personnage
    {
        private string nom;
        private int pointsDevie;
        private int pointDePuissance;

        public string Nom { get => nom; set => nom = value; }
        public int PointsDevie 
        {
            get => pointsDevie;
            set
            {
             
                if (value > 0)
                {
                    pointsDevie = value;
                }
                else
                {
                    pointsDevie = 0;
                }

            }   
        }
        public int PointDePuissance { get => pointDePuissance; set => pointDePuissance=value; }

        public bool EstEnVie
        {
            get
            {
                if(pointsDevie > 0)
                {

                    return true;
                }
                return false;
            }

        }
    }
}
