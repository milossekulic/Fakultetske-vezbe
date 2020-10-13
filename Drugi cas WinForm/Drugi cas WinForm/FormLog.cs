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
    public partial class FormLog : Form
    {
        //originalni konstruktor koji se sam stvorio prilikom dodavanje forme
        public FormLog()
        {
            InitializeComponent();
        }
        //nas novi konstruktor
        public FormLog(Form1 callingForm)   //kao argument konstuktora zelimo da se prosledi glavna(pozivajuca) forma
        {
            InitializeComponent();  //Obavezno, isto kao i u originalnom konstruktoru
            mainForm = callingForm;
        }
        private Form1 mainForm; //dodajemo Formi za SignIn promenljivu u kojoj se cuva koja forma ju je stvorila


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //ako su i username i sifra tacni, zatvori formu
            //Username: admin, Password: admin
            if (textBoxUsername.Text == "admin" && textBoxPassword.Text == "admin")
            {
                //&& znaci 'i' - moraju oba uslova da budu tacna da bi se izvrsio ovaj blok koda
                //'ili' se pise sa ||
                mainForm.changeUser("admin");
                this.Close();
            }
        }
    }
}
