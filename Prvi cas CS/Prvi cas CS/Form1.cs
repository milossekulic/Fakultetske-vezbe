using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prvi_cas_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            rememberValue = 0;  //dajemo po;etnu vrednost 0
            rememberOperation = 'n';    //karakter n stavljamo da oznacava "nema operacije"
        }

        private double rememberValue;   //pamtimo vrednost prvog (desnog) operanda
        private char rememberOperation; //pamtimo vrednost poslednje klikute operacije


        private void btn1_Click(object sender, EventArgs e)
        {
            //OutputBox.Text = OutputBox.Text + "1";
            //OutputBox.Text += "1";
            //gornja dva reda koda imaju isto znacenje, a donje je samo skracena verzija

            //zelimo da smanjimo broj cifara koje mogu da stanu na kalkulator
            //vidimo da Properties->maxlenght ne radi (ovo zaustavlja upisivanje samo u toku rada programa ako korisnik koristi tastaturu)
            //zato moramo da smislimo drugo resenje
            //ono sto se nalazi u bloku koda posle if() ce se izvrsiti samo ako je uslov u ( ) tacan
            //u nasem slucaju ispitujemo da li je duzina teksta u textBox-u manja od 16, i ako jeste samo tada dodajemo jos jednu cifru
            if (textBoxNum.Text.Length < 16) {
                textBoxNum.Text += "1";
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "2";
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "3";
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "4";
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "5";
            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "6";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "7";
            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "8";
            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "9";
            }
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += "0";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            //koristimo switch - on gleda koja je vrednost promenljive u zagradi i ide na odgovarajuci case
            switch (rememberOperation)
            {
                case 'n':   //nema operacije
                    rememberValue = Double.Parse(textBoxNum.Text);
                    //ako nema operacije zelimo samo da se zapamti trenutna vrednost
                    break;  //ovo je obavezno - kada se izvrsi, izlazi se iz bloka koda u kojem se nalazi (sto je ovde switch blok koda)
                case 'a':   //sabiranje
                    rememberValue += Double.Parse(textBoxNum.Text);
                    //prvi operand, koji se nalazi u rememberValue sabiramo sa drugim, koji se nalazi u textBox-u i upisujemo u rememberValue
                    break;
                case 's':   //oduzimanje
                    rememberValue -= Double.Parse(textBoxNum.Text);
                    break;
                case 'm':   //deljenje
                    rememberValue *= Double.Parse(textBoxNum.Text);
                    break;
                case 'd':   //mnozenje
                    rememberValue /= Double.Parse(textBoxNum.Text);
                    break;
                default:    //ovde se ide samo ako nije nijedan od prethodnih slucajeva
                    break;
             }
            textBoxNum.Text = rememberValue.ToString(); //ispisujemo rezultat u textBox (toString() transformise rememberValue u String tip)
            rememberOperation = 'n';    //stavljamo da opet nema operacije
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            //textBoxNum.Text = ""; - isto moze da se koristi za brisanje
            textBoxNum.Clear();
            rememberValue = 0;
            rememberOperation = 'n';
        }

        private void btC_Click(object sender, EventArgs e)
        {
            textBoxNum.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            OperationSwitch();  //pozivamo funkciju koju smo napravili
            rememberOperation = 'a';
            textBoxNum.Clear();            
            
            /*
            rememberValue = Double.Parse(textBoxNum.Text);
            textBoxNum.Clear();
            rememberOperation = 'a';
            */
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            rememberValue = Double.Parse(textBoxNum.Text);  //Brojevni tipovi (int, double...) imaju funkcije Parse i TryParse
            //Parse - pretvara zadati string u broj datog tipa, TryParse - ispituje da li string moze da se pretvori u broj i vraca rezultat ispitivanja
            //u rememberValue upisujemo broj koji je bio zapisan u textBoxu
            textBoxNum.Clear(); //praznimo textBox da bismo napravili mesta za drugi operator
            rememberOperation = 's';    //stavljamo karakter koji odgovara kliknutoj operaciji
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            rememberValue = Double.Parse(textBoxNum.Text);
            textBoxNum.Clear();
            rememberOperation = 'm';
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            rememberValue = Double.Parse(textBoxNum.Text);
            textBoxNum.Clear();
            rememberOperation = 'd';
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (textBoxNum.Text.Length < 16)
            {
                textBoxNum.Text += ".";
            }
        }

        private void btnNegative_Click(object sender, EventArgs e)
        {
            /*
            double d = double.Parse(textBoxNum.Text);
            d = -d;
            textBoxNum.Text = d.ToString();
            */
            textBoxNum.Text = (-double.Parse(textBoxNum.Text)).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (textBoxNum.TextLength > 0)  //dolazi do greske ako pokusamo da brisemo a nema sta da se brise
            {
                textBoxNum.Text = textBoxNum.Text.Remove(textBoxNum.Text.Length - 1);
                //Remove brise deo teksta od datog indeksa do kraja
                //U programiranju indeksi se broje od 0, pa zato uzimamo Lenght - 1 da bismo izbrisali poslednji
            }
        }


        private void OperationSwitch()
        {
            switch (rememberOperation)
            {
                case 'n':
                    rememberValue = Double.Parse(textBoxNum.Text);
                    break;
                case 'a':
                    rememberValue += Double.Parse(textBoxNum.Text);
                    break;
                case 's':
                    rememberValue -= Double.Parse(textBoxNum.Text);
                    break;
                case 'm':
                    rememberValue *= Double.Parse(textBoxNum.Text);
                    break;
                case 'd':
                    rememberValue /= Double.Parse(textBoxNum.Text);
                    break;
                default:
                    break;
            }
        }

    }
}
