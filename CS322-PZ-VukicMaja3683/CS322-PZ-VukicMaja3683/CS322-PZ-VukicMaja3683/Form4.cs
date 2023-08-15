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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            var Movies = (from b in Form1.ctx.Filmovi
                          where b.KorisnikId == 1
                          select b).ToList();

            dataGridView1.DataSource = Movies;
            var MovieUser = (from b in Form1.ctx.Filmovi
                             where b.KorisnikId == Form1.USERID
                             select b).ToList();

            dataGridView2.DataSource = MovieUser;
        }

      /*  private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
      */

        private void btnRent_Click(object sender, EventArgs e)
        {
            try
            {

                var Movies = (from b in Form1.ctx.Filmovi
                              where b.KorisnikId == 1
                              select b).ToList();

                var rentedMovies = (from b in Form1.ctx.Filmovi
                                    where b.KorisnikId == Form1.USERID
                                    select b).ToList();


                var memberFee = (from u in Form1.ctx.Korisnici
                                 where u.KorisnikId == Form1.USERID
                                 select u.Clanarina).FirstOrDefault();
                if (memberFee)
                {
                    if (rentedMovies.Count() < 3)
                    {
                        DataGridView dg = dataGridView1;
                        if (dg.CurrentCell.RowIndex >= 0)
                        {
                            DataGridViewRow row = dataGridView1.Rows[dg.CurrentCell.RowIndex];
                            int movieId = Convert.ToInt32(row.Cells[0].Value.ToString());

                            var movieUpdate = Form1.ctx
                                     .Filmovi
                                     .FirstOrDefault(b => b.FilmId == movieId);
                            movieUpdate.KorisnikId = Form1.USERID;
                            Form1.ctx.SaveChanges();
                        }
                        else
                        {
                            MessageBox.Show(this, "Greška", "Zatvaranje", MessageBoxButtons.OK);
                        }
                    }
                    else
                    {
                        MessageBox.Show(this, "Već ste iznajmili 3 filma", "Zatvaranje", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show(this, "Morate platiti članarinu!!!", "Zatvaranje", MessageBoxButtons.OK);
                }
                var Movies2 = (from b in Form1.ctx.Filmovi
                               where b.KorisnikId == 1
                               select b).ToList();

                dataGridView1.DataSource = Movies2;


                var MovieUser = (from b in Form1.ctx.Filmovi
                                 where b.KorisnikId == Form1.USERID
                                 select b).ToList();

                dataGridView2.DataSource = MovieUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Greška", "Zatvaranje", MessageBoxButtons.OK);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                var Movies = (from b in Form1.ctx.Filmovi
                              where b.KorisnikId == Form1.USERID
                              select b).ToList();


                DataGridView dg = dataGridView2;
                if (dg.CurrentCell.RowIndex >= 0)
                {
                    DataGridViewRow row = dataGridView2.Rows[dg.CurrentCell.RowIndex];
                    int movieId = Convert.ToInt32(row.Cells[0].Value.ToString());

                    var movieUpdate = Form1.ctx
                             .Filmovi
                             .FirstOrDefault(b => b.FilmId == movieId);
                    movieUpdate.KorisnikId = 1;
                    Form1.ctx.SaveChanges();
                }
                else
                {
                    MessageBox.Show(this, "Greška", "Zatvaranje", MessageBoxButtons.OK);
                }
                var movies2 = (from b in Form1.ctx.Filmovi
                               where b.KorisnikId == 1
                               select b).ToList();
                dataGridView1.DataSource = movies2;


                var MovieUser = (from b in Form1.ctx.Filmovi
                                 where b.KorisnikId == Form1.USERID
                                 select b).ToList();

                dataGridView2.DataSource = MovieUser;
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Greška", "Zatvaranje", MessageBoxButtons.OK);
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

