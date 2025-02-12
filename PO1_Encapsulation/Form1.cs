namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {

        Personnage joueur;
        Personnage monstre;

        public Form1()
        {
            InitializeComponent();

            joueur = new Personnage();
            joueur.PointDeVie = 10;
            joueur.PuissanceAttaque = 1;
            monstre = new Personnage();
            monstre.PointDeVie = 30;
            monstre.PuissanceAttaque = 3;

        }




        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            monstre.PointDeVie = monstre.PointDeVie - joueur.PuissanceAttaque;
            joueur.PointDeVie = joueur.PointDeVie - monstre.PuissanceAttaque;

            lbl_pointsVieDragon.Text = "Points de vie : " + monstre.PointDeVie.ToString();
            lbl_pointsVieJoueur.Text = "Points de vie : " + joueur.PointDeVie.ToString();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}