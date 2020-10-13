using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugi_cas_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //this.Close();
            //ne mozemo da koristimo this.Close() jer ce se tada zatvoriti samo ova forma a ne cela aplikacija
            //to je problem ako u aplikaciji imamo više od jedne forme
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void btnApplication_Click(object sender, EventArgs e)
        {
            if (panelApp.Visible == false)  //ako pod-meni nije prikazan, prikazi ga
            {
                panelApp.Visible = true;
            }
            else
            //ako izraz u if zagradama nije tacan (pod-meni jeste prikazan) onda cemo ga sakriti
            {
                panelApp.Visible = false;
            }
        }

        private void btnGames_Click(object sender, EventArgs e)
        {
            if (panelGames.Visible == false)
            {
                panelGames.Visible = true;
            }
            else
            {
                panelGames.Visible = false;
            }
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            if (labelUser.Text == "Not Signed In")  //ako niko nije prijavljen, onda otvaramo formu za prijavu
            {
                FormLog logForm = new FormLog();    //stvaramo novu formu tipa FormLog sa nazivom logForm
                //logForm.Show();       //osvime prikazujemo formu, ali korisnik i dalje moze da se vrati na glavnu formu
                logForm.ShowDialog();   //sa ShowDialog() korisnik ne moze da koristi glavnu formu sve dok ne zatvori ovu
            }
            else
            {   //u slucaju da je korisnik vec ulogovan, mi cemo ga odlogovati
                labelUser.Text = "Not Signed In";
                btnSign.Text = "SIGN IN";
            }
        }

        public void changeUser(string Username) //prosledjujemo koja osoba se ulogovala
        {
            labelUser.Text = Username;  //stavljamo da tekst labele bude prosledjeni Username
            btnSign.Text = "SIGN OUT";   //menjamo da na dugmetu pise SIGN OUT
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(0);    
            //menjamo trenutno prikazan tab na onaj sa indeksom 0
        }

        private void btnShopA_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(1);
        }

        private void btnOwnedA_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(2);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(3);
        }

        private void buttonFB_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com");
        }
    }
}
