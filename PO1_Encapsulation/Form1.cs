namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new();
        public Form1()
        {
            InitializeComponent();

            joueur.PointsDevie = 10;
            dragon.PointsDevie = joueur.PointsDevie * 3;
            joueur.PointDePuissance = 1;
            dragon.PointDePuissance = joueur.PointsDevie * 3;
           
        }

        private void Attaquer()
        {
            {
                lbl_pointsVieJoueur.Text= " Point de vie :" +
                    joueur.PointsDevie.ToString();

                lbl_pointsVieDragon.Text= " Point de vie :" +
                    dragon.PointsDevie.ToString();

                lbl_puissanceAttaqueJoueur.Text = "Points de vie : " +
                    joueur.PointDePuissance.ToString();

                lbl_puissanceAttaqueDragon.Text = "Point de vie : " +
                    dragon.PointDePuissance.ToString();

            }
        }
        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.PointsDevie -= joueur.PointDePuissance;
            TourDragon();
            Actualiserlabel();
        }
       

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }
    }
}