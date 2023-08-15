using CS322_PZ_VukicMaja3683.Models;
using Microsoft.VisualBasic.ApplicationServices;

namespace CS322_PZ_VukicMaja3683
{
    public partial class Form1 : Form
    {
        public static int USERID = 0;
        public static Context ctx = new Context();

        public Form1()
        {
            InitializeComponent();
           /* Korisnik prvi = new Korisnik() 
            {
                KorisnickoIme = "Maja",
                Lozinka = "maja123",
                KorisnikRola = Enums.KorisnikRola.Menadzer,
            };

            ctx.Korisnici.Add(prvi);
            ctx.SaveChanges();

            Film prviFilm = new Film()
            {
                Naziv = "Titanik",
                Reditelj = "Benjamin Alire Saenz",
                KorisnikId = 1
            };

            ctx.Filmovi.Add(prviFilm);
            ctx.SaveChanges();*/
        }



        private void btnLogIn_Click(object sender, EventArgs e)
        {
            String username = tbUsername.Text;
            String password = tbPassword.Text;

            var user = ctx.Korisnici
                .Where(u => u.KorisnickoIme == username)
                .ToList();

            if (user.Count() > 0)
            {
                if (user[0].KorisnickoIme == username && user[0].Lozinka == password)
                {
                    USERID = user[0].KorisnikId;
                    this.Hide();
                    if (user[0].KorisnikRola == Enums.KorisnikRola.Menadzer)
                    {
                        Form2 form2 = new Form2();
                        form2.ShowDialog();
                        this.Close();
                    }
                    else if (user[0].KorisnikRola == Enums.KorisnikRola.Zaposleni)
                    {
                        Form3 form3 = new Form3();
                        form3.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        Form4 form4 = new Form4();
                        form4.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show(this, "Pogresna lozinka!", "Zatvaranje", MessageBoxButtons.OK);
                }
            }
            else
            {
                MessageBox.Show(this, "Niste član video kluba!", "Zatvaranje", MessageBoxButtons.OK);
            }

        
    }
    }
}