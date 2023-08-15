using CS322_PZ_VukicMaja3683.Models;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS322_PZ_VukicMaja3683
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            var Users = (from u in Form1.ctx.Korisnici
                         where u.KorisnikRola == Enums.KorisnikRola.Clan
                         select u).ToList();

            dataGridView1.DataSource = Users;


            var Movies = (from b in Form1.ctx.Filmovi
                          select b).ToList();

            dataGridView2.DataSource = Movies;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.ctx.SaveChanges();

                var Users = (from u in Form1.ctx.Korisnici
                             where u.KorisnikRola == Enums.KorisnikRola.Clan
                             select u).ToList();

                dataGridView1.DataSource = Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            { 
                DataGridView dg = dataGridView1;
                if (dg.CurrentCell.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[dg.CurrentCell.RowIndex];

                    int userID = Convert.ToInt32(row.Cells[0].Value.ToString());

                    var del = Form1.ctx.Korisnici.Where(u => u.KorisnikId == (int)userID).First();
                    Form1.ctx.Remove(del);
                    Form1.ctx.SaveChanges();
                    var Users = (from u in Form1.ctx.Korisnici
                                 where u.KorisnikRola == Enums.KorisnikRola.Clan
                                 select u).ToList();


                    dataGridView1.DataSource = Users;
                }
                else
                {
                    MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);

            }
        }

        private void btnNewRow_Click(object sender, EventArgs e)
        {
            try
            {
                var Users = (from u in Form1.ctx.Korisnici
                             where u.KorisnikRola == Enums.KorisnikRola.Clan
                             select u).ToList();
                Users.Add(new Korisnik()
                {
                    KorisnikId = Users.LastOrDefault().KorisnikId + 1,
                    KorisnikRola = Enums.KorisnikRola.Clan
                });
                dataGridView1.DataSource = Users;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            try
            {

                DataGridView dg = dataGridView1;
                if (dg.CurrentCell.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView1.Rows[dg.CurrentCell.RowIndex];

                    String username = row.Cells[1].Value.ToString();
                    String password = row.Cells[2].Value.ToString();

                    Boolean memberFee = Convert.ToBoolean(row.Cells[3].Value.ToString());
                    if ((from u in Form1.ctx.Korisnici
                         select u).Any(u => u.KorisnickoIme == username))
                    {
                        MessageBox.Show("Korisničko ime već postoji!", "Greška", MessageBoxButtons.OK);
                    }
                    else
                    {
                        var EnumRole = Enums.KorisnikRola.Clan;

                        Form1.ctx.Korisnici.Add(new Korisnik()
                        {
                            KorisnickoIme = username,
                            Lozinka = password,
                            Clanarina = memberFee,
                            KorisnikRola = EnumRole
                        });

                        Form1.ctx.SaveChanges();

                        var Users = (from u in Form1.ctx.Korisnici
                                     where u.KorisnikRola == Enums.KorisnikRola.Clan
                                     select u).ToList();

                        dataGridView1.DataSource = Users;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }
        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.ctx.SaveChanges();

                var Movies = (from u in Form1.ctx.Filmovi
                              select u).ToList();

                dataGridView2.DataSource = Movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dg = dataGridView2;
                if (dg.CurrentCell.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[dg.CurrentCell.RowIndex];
                    int bookId = Convert.ToInt32(row.Cells[0].Value.ToString());

                    var del = Form1.ctx.Filmovi.Where(b => b.FilmId == (int)bookId).First();
                    Form1.ctx.Remove(del);
                    Form1.ctx.SaveChanges();
                    var Movies = (from b in Form1.ctx.Filmovi
                                  select b).ToList();

                    dataGridView2.DataSource = Movies;
                }
                else
                {
                    MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);

            }
        }

        private void btnAddNewRowB_Click(object sender, EventArgs e)
        {
            try
            {
                var Movies = (from b in Form1.ctx.Filmovi
                              select b).ToList();
                Movies.Add(new Film()
                {
                    FilmId = Movies.LastOrDefault().FilmId + 1,
                    KorisnikId = 1,

                });
                dataGridView2.DataSource = Movies;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridView dg = dataGridView2;
                if (dg.CurrentCell.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[dg.CurrentCell.RowIndex];
                    String title = row.Cells[1].Value.ToString();
                    String author = row.Cells[2].Value.ToString();


                    Form1.ctx.Filmovi.Add(new Film()
                    {
                        Naziv = title,
                        Reditelj = author,
                        KorisnikId = 1
                        
                    });

                    Form1.ctx.SaveChanges();

                    var Movies = (from b in Form1.ctx.Filmovi
                                  select b).ToList();

                    dataGridView2.DataSource = Movies;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greška!!!", "Greška", MessageBoxButtons.OK);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
            this.Close();
        }
    }
}



