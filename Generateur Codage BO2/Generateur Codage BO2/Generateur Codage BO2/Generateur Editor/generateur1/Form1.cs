using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
//Open Source Generator Coding BO2
//Open Source By OldModz95

namespace generateur1
{
    public partial class Form1 : Form
    {

        WebClient WebClient = new WebClient(); 

        public Form1()
        {
            InitializeComponent();
            timer1.Start();
            heuredate.Start();
        }

        private void logInButton1_Click(object sender, EventArgs e)
        {
            if (this.divers.SelectedIndex == 0)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Connexion n'es pas un codage... :O Merci de choisir autre chose.";
            }

            if (this.divers.SelectedIndex == 1)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Anti-Ban";
            }

            if (this.divers.SelectedIndex == 2)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Attache";
            }

            if (this.divers.SelectedIndex == 3)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage CCAPI Notif";
            }

            if (this.divers.SelectedIndex == 4)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage CCAPI";
            }

            if (this.divers.SelectedIndex == 5)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Changer Son CID";
            }

            if (this.divers.SelectedIndex == 6)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Connexion";
            }

            if (this.divers.SelectedIndex == 7)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Deconnexion";
            }

            if (this.divers.SelectedIndex == 8)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage InformationCCL";
            }

            if (this.divers.SelectedIndex == 9)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage TMAPI";
            }

            if (this.divers.SelectedIndex == 10)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "divers n'es pas un codage... :O Merci de choisir autre chose.";
            }

            if (this.divers.SelectedIndex == 11)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage GSC Injector";
            }

            if (this.divers.SelectedIndex == 12)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage IP Grabber + PSN";
            }
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void logInButton2_Click(object sender, EventArgs e)
        {
            if (this.Contacter.SelectedIndex == 0)
            {
                System.Diagnostics.Process.Start("https://www.youtube.com/oldmodz95"); // My channel YTB, sub me ok?!
                statusBar1.Text = "Redirection vers YouTube...";
            }

            if (this.Contacter.SelectedIndex == 1)
            {
                System.Diagnostics.Process.Start("https://discordapp.com/invite/3t2568W"); // My Server Discord
                statusBar1.Text = "Redirection vers Discord...";
            }

            if (this.Contacter.SelectedIndex == 2)
            {
                System.Diagnostics.Process.Start("https://oldmodz95.com"); // My Site Web
                statusBar1.Text = "Redirection vers mon site...";
            }
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void logInLabel3_Click(object sender, EventArgs e)
        {
            //Channel ExoTiQueModz
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCHvV7Nhr8fl3Jv6IniDMMiA?view_as=subscriber"); // channel YTB to ExoTiQueModz ! Sub to channel Exo ^^ OK ?????!!!!
            statusBar1.Text = "Redirection vers YouTube...";
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void Contacter_SelectedIndexChanged(object sender, EventArgs e)
        {
          // Pas toucher ! Sinon tu perd tes couilles :D :O
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void logInButton3_Click(object sender, EventArgs e)
        {
            Historique.Text = WebClient.DownloadString("");
            statusBar1.Text = "List Vide..";
            MessageBox.Show("La liste es maintenant vide...");
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // pas toucher car c'etais une image et je les retirer
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            // pas toucher car c'etais une image et je les retirer
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void timer1_Tick(object sender, EventArgs e) // Flash Label auto
        {
            Random labelcolor = new Random(); // effect^^
            int R = labelcolor.Next(0, 255); // color
            int G = labelcolor.Next(0, 255); // color
            int B = labelcolor.Next(0, 255); // color
            int A = labelcolor.Next(0, 255); // color
            open.ForeColor = Color.FromArgb(R, G, B, A); // name label
            OldModz95.ForeColor = Color.FromArgb(R, G, B, A); // name label
        }

        private void label1_Click(object sender, EventArgs e)
        {
            base.Hide();
            new DevDuTool().Show();
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void timer2_Tick(object sender, EventArgs e)
        {
            Random labelcolor = new Random(); // effect^^
            int R = labelcolor.Next(0, 255); // color
            int B = labelcolor.Next(0, 255); // color
            label1.ForeColor = Color.FromArgb(R, G, B, A);
            label2.ForeColor = Color.FromArgb(R, G, B, A);
            label3.ForeColor = Color.FromArgb(R, G, B, A);// name label
        }

        public int G { get; set; }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        public int A { get; set; }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void logInButton6_Click(object sender, EventArgs e)
        {
            statusBar1.Text = "Action non opérationnel pour le moment. Logiciel crée par OldModz95 le 23/07/19";
            MessageBox.Show("Action non opérationnel pour le moment.");
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void boutonzombie_Click(object sender, EventArgs e)
        {
            if (this.zombie.SelectedIndex == 0)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Change Name n'es pas un codage... :O Merci de choisir autre chose.";
            }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.zombie.SelectedIndex == 1)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Changer Son Nom";
            }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.zombie.SelectedIndex == 2)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Stats Zombie n'es pas un codage... :O Merci de choisir autre chose.";
            }

            if (this.zombie.SelectedIndex == 3)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Ato_uts";
            }

            if (this.zombie.SelectedIndex == 4)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Balles";
            }

            if (this.zombie.SelectedIndex == 5)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Blessure";
            }

            if (this.zombie.SelectedIndex == 6)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Coups";
            }

            if (this.zombie.SelectedIndex == 7)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Double Fusil A Pompe";
            }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.zombie.SelectedIndex == 8)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Gibs";
            }

            if (this.zombie.SelectedIndex == 9)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grenade";
            }

            if (this.zombie.SelectedIndex == 10)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Kills";
            }

            if (this.zombie.SelectedIndex == 11)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Miles";
            }

            if (this.zombie.SelectedIndex == 12)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Mort";
            }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.zombie.SelectedIndex == 13)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Porte";
            }

            if (this.zombie.SelectedIndex == 14)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Reanimer";
            }

            if (this.zombie.SelectedIndex == 15)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Tete De Mort Avec Le Couteau";
            }

            if (this.zombie.SelectedIndex == 16)
            {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Tir Tete";
            }
        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void boutondivers_Click(object sender, EventArgs e)
        {
            if (this.multi.SelectedIndex == 0)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "=====Change Name===== N'est pas un codage... :O Merci de choisir autre choses.";
    }


if (this.multi.SelectedIndex == 1)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage All Frezze Box";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 2)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Change FPS";
    }


if (this.multi.SelectedIndex == 3)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Change Marque Clan";
    }


if (this.multi.SelectedIndex == 4)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Change Name";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 5)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Frezze Box 1";
    }


if (this.multi.SelectedIndex == 6)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Frezze Box 2";
    }


if (this.multi.SelectedIndex == 7)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Frezze Box 3";
    }


if (this.multi.SelectedIndex == 8)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Image Name";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 9)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Name Heure";
    }


if (this.multi.SelectedIndex == 10)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Name Prédefini";
    }


if (this.multi.SelectedIndex == 11)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Nom Des Joueurs";
    }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95

            if (this.multi.SelectedIndex == 12)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "=====Host===== N'es pas un codage... :O Merci de choisir autre choses.";
    }


if (this.multi.SelectedIndex == 13)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Ajouté Plus De Joueurs Dans Un Lobby";
    }


if (this.multi.SelectedIndex == 14)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Changer D'arme";
    }


if (this.multi.SelectedIndex == 15)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Client";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 16)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Freeze Joueur";
    }


if (this.multi.SelectedIndex == 17)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Lobby Dans La Game";
    }

if (this.multi.SelectedIndex == 18)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "=====NoHost====== N'es pas un codage... :O Merci de choisir autre choses.";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 19)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Anti-Freeze";
    }


if (this.multi.SelectedIndex == 20)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Blinking Bodies";
    }


if (this.multi.SelectedIndex == 21)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage EndGame";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 22)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Flash Prestige + Niveau";
    }


if (this.multi.SelectedIndex == 23)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Flash Prestige";
    }


if (this.multi.SelectedIndex == 24)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Invisible Dans L'accueil";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 25)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Nom Des Joeurs En Couleur";
    }


if (this.multi.SelectedIndex == 26)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Mettre Le Ciel En Couleur";
    }


if (this.multi.SelectedIndex == 27)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Mettre Les Joueurs En Couleur";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 28)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Mettre Son Micro";
    }


if (this.multi.SelectedIndex == 29)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Modifier L'ecriture Du Menu Principal";
    }


if (this.multi.SelectedIndex == 30)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Probation Bypass";
    }


if (this.multi.SelectedIndex == 31)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Red Box";
    }


if (this.multi.SelectedIndex == 32)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Relancer La Parti";
    }


if (this.multi.SelectedIndex == 33)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Reticule De L'arme Modifier";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 34)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage UAV";
    }


if (this.multi.SelectedIndex == 35)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Voir Les Joueurs A Traver Les Murs";
    }
            //Open Source Generator Coding BO2
            //Open Source By OldModz95

            if (this.multi.SelectedIndex == 36)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage VSAT";
    }


if (this.multi.SelectedIndex == 37)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "=====Stats===== N'es pas un codage... :O Merci de choisir autre choses.";
    }


if (this.multi.SelectedIndex == 38)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage 4 armes + 6 atouts";
    }


if (this.multi.SelectedIndex == 39)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage 4 armes";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 40)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage 6 atouts";
    }


if (this.multi.SelectedIndex == 41)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage 10 classe";
    }


if (this.multi.SelectedIndex == 42)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo AW Vitrine";
    }


if (this.multi.SelectedIndex == 43)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo AW";
    }


if (this.multi.SelectedIndex == 44)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo Destroyer Vitrine";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 45)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo Ghost Vitrine";
    }


if (this.multi.SelectedIndex == 46)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo modder";
    }


if (this.multi.SelectedIndex == 47)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Camo Nuketown Vitrine";
    }


if (this.multi.SelectedIndex == 48)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Carte Destroyer Vitrine";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 49)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Carte Nuketown Vitrine";
    }


if (this.multi.SelectedIndex == 50)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Changer C'est classe";
    }


if (this.multi.SelectedIndex == 51)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Changer son niveau";
    }


if (this.multi.SelectedIndex == 52)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Defaite";
    }


if (this.multi.SelectedIndex == 53)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Kills";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 54)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Mort";
    }


if (this.multi.SelectedIndex == 55)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Niveau 55";
    }


if (this.multi.SelectedIndex == 56)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Prestige";
    }


if (this.multi.SelectedIndex == 57)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Score";
    }


if (this.multi.SelectedIndex == 58)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Temps Jouer";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 59)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Tire Tete";
    }


if (this.multi.SelectedIndex == 60)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Tout debloquer";
    }


if (this.multi.SelectedIndex == 61)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Unlock All";
    }


if (this.multi.SelectedIndex == 62)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Victoire";
    }


if (this.multi.SelectedIndex == 63)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "=====Stats Ligue===== N'es pas un codage... :O Merci de choisir autre choses.";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 64)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grade Argent";
    }


if (this.multi.SelectedIndex == 65)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grade Bronze";
    }


if (this.multi.SelectedIndex == 66)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grade Fer";
    }


if (this.multi.SelectedIndex == 67)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grade Master";
    }


if (this.multi.SelectedIndex == 68)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codageGrade OR";
    }

            //Open Source Generator Coding BO2
            //Open Source By OldModz95
            if (this.multi.SelectedIndex == 69)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Grade Platine";
    }


if (this.multi.SelectedIndex == 70)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Poins De Ligue";
    }


if (this.multi.SelectedIndex == 71)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Série De Victoire";
    }


if (this.multi.SelectedIndex == 72)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Victoire Carriére";
    }


if (this.multi.SelectedIndex == 73)
    {
                Historique.Text = WebClient.DownloadString("");
                statusBar1.Text = "Generation du codage Victoire Saison";
    }

        }
        //Open Source Generator Coding BO2
        //Open Source By OldModz95
        private void heuredate_Tick(object sender, EventArgs e)
        {
            date.Text = DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void logInLabel4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://youtube.com/oldmodz95");
        }
    }
}
//Open Source Generator Coding BO2
//Open Source By OldModz95