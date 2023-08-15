namespace CS322_PZ_VukicMaja3683
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            korisnikIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            korisnickoImeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lozinkaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clanarinaDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            korisnikRolaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            userBindingSource = new BindingSource(components);
            btnUpdate = new Button();
            btnDelete = new Button();
            btnNewRow = new Button();
            btnAddUser = new Button();
            dataGridView2 = new DataGridView();
            filmIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rediteljDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            korisnikIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            movieBindingSource = new BindingSource(components);
            btnAddBook = new Button();
            btnAddNewRowB = new Button();
            btnDeleteBook = new Button();
            btnUpdateBook = new Button();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { korisnikIdDataGridViewTextBoxColumn, korisnickoImeDataGridViewTextBoxColumn, lozinkaDataGridViewTextBoxColumn, clanarinaDataGridViewCheckBoxColumn, korisnikRolaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(75, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(623, 340);
            dataGridView1.TabIndex = 0;
            // 
            // korisnikIdDataGridViewTextBoxColumn
            // 
            korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn.HeaderText = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            korisnikIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // korisnickoImeDataGridViewTextBoxColumn
            // 
            korisnickoImeDataGridViewTextBoxColumn.DataPropertyName = "KorisnickoIme";
            korisnickoImeDataGridViewTextBoxColumn.HeaderText = "KorisnickoIme";
            korisnickoImeDataGridViewTextBoxColumn.MinimumWidth = 6;
            korisnickoImeDataGridViewTextBoxColumn.Name = "korisnickoImeDataGridViewTextBoxColumn";
            korisnickoImeDataGridViewTextBoxColumn.Width = 125;
            // 
            // lozinkaDataGridViewTextBoxColumn
            // 
            lozinkaDataGridViewTextBoxColumn.DataPropertyName = "Lozinka";
            lozinkaDataGridViewTextBoxColumn.HeaderText = "Lozinka";
            lozinkaDataGridViewTextBoxColumn.MinimumWidth = 6;
            lozinkaDataGridViewTextBoxColumn.Name = "lozinkaDataGridViewTextBoxColumn";
            lozinkaDataGridViewTextBoxColumn.Width = 125;
            // 
            // clanarinaDataGridViewCheckBoxColumn
            // 
            clanarinaDataGridViewCheckBoxColumn.DataPropertyName = "Clanarina";
            clanarinaDataGridViewCheckBoxColumn.HeaderText = "Clanarina";
            clanarinaDataGridViewCheckBoxColumn.MinimumWidth = 6;
            clanarinaDataGridViewCheckBoxColumn.Name = "clanarinaDataGridViewCheckBoxColumn";
            clanarinaDataGridViewCheckBoxColumn.Width = 125;
            // 
            // korisnikRolaDataGridViewTextBoxColumn
            // 
            korisnikRolaDataGridViewTextBoxColumn.DataPropertyName = "KorisnikRola";
            korisnikRolaDataGridViewTextBoxColumn.HeaderText = "KorisnikRola";
            korisnikRolaDataGridViewTextBoxColumn.MinimumWidth = 6;
            korisnikRolaDataGridViewTextBoxColumn.Name = "korisnikRolaDataGridViewTextBoxColumn";
            korisnikRolaDataGridViewTextBoxColumn.Width = 125;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Models.Korisnik);
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(53, 400);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Izmeni";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(247, 400);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Izbriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewRow
            // 
            btnNewRow.Location = new Point(438, 400);
            btnNewRow.Name = "btnNewRow";
            btnNewRow.Size = new Size(94, 29);
            btnNewRow.TabIndex = 3;
            btnNewRow.Text = "Dodaj red";
            btnNewRow.UseVisualStyleBackColor = true;
            btnNewRow.Click += btnNewRow_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(614, 400);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(103, 29);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Dodaj člana";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { filmIdDataGridViewTextBoxColumn, nazivDataGridViewTextBoxColumn, rediteljDataGridViewTextBoxColumn, korisnikIdDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = movieBindingSource;
            dataGridView2.Location = new Point(66, 472);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(651, 407);
            dataGridView2.TabIndex = 5;
            // 
            // filmIdDataGridViewTextBoxColumn
            // 
            filmIdDataGridViewTextBoxColumn.DataPropertyName = "FilmId";
            filmIdDataGridViewTextBoxColumn.HeaderText = "FilmId";
            filmIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            filmIdDataGridViewTextBoxColumn.Name = "filmIdDataGridViewTextBoxColumn";
            filmIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn
            // 
            nazivDataGridViewTextBoxColumn.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn.MinimumWidth = 6;
            nazivDataGridViewTextBoxColumn.Name = "nazivDataGridViewTextBoxColumn";
            nazivDataGridViewTextBoxColumn.Width = 125;
            // 
            // rediteljDataGridViewTextBoxColumn
            // 
            rediteljDataGridViewTextBoxColumn.DataPropertyName = "Reditelj";
            rediteljDataGridViewTextBoxColumn.HeaderText = "Reditelj";
            rediteljDataGridViewTextBoxColumn.MinimumWidth = 6;
            rediteljDataGridViewTextBoxColumn.Name = "rediteljDataGridViewTextBoxColumn";
            rediteljDataGridViewTextBoxColumn.Width = 125;
            // 
            // korisnikIdDataGridViewTextBoxColumn1
            // 
            korisnikIdDataGridViewTextBoxColumn1.DataPropertyName = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn1.HeaderText = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            korisnikIdDataGridViewTextBoxColumn1.Name = "korisnikIdDataGridViewTextBoxColumn1";
            korisnikIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // movieBindingSource
            // 
            movieBindingSource.DataSource = typeof(Models.Film);
            // 
            // btnAddBook
            // 
            btnAddBook.Location = new Point(531, 929);
            btnAddBook.Name = "btnAddBook";
            btnAddBook.Size = new Size(94, 29);
            btnAddBook.TabIndex = 6;
            btnAddBook.Text = "Dodaj film";
            btnAddBook.UseVisualStyleBackColor = true;
            btnAddBook.Click += btnAddBook_Click;
            // 
            // btnAddNewRowB
            // 
            btnAddNewRowB.Location = new Point(371, 929);
            btnAddNewRowB.Name = "btnAddNewRowB";
            btnAddNewRowB.Size = new Size(94, 29);
            btnAddNewRowB.TabIndex = 7;
            btnAddNewRowB.Text = "Dodaj red";
            btnAddNewRowB.UseVisualStyleBackColor = true;
            btnAddNewRowB.Click += btnAddNewRowB_Click;
            // 
            // btnDeleteBook
            // 
            btnDeleteBook.Location = new Point(186, 929);
            btnDeleteBook.Name = "btnDeleteBook";
            btnDeleteBook.Size = new Size(94, 29);
            btnDeleteBook.TabIndex = 8;
            btnDeleteBook.Text = "Izbriši";
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnDeleteBook.Click += btnDeleteBook_Click;
            // 
            // btnUpdateBook
            // 
            btnUpdateBook.Location = new Point(12, 929);
            btnUpdateBook.Name = "btnUpdateBook";
            btnUpdateBook.Size = new Size(94, 29);
            btnUpdateBook.TabIndex = 9;
            btnUpdateBook.Text = "Izmeni";
            btnUpdateBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Click += btnUpdateBook_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(694, 929);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 10;
            btnLogOut.Text = "Odjavi se";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 982);
            Controls.Add(btnLogOut);
            Controls.Add(btnUpdateBook);
            Controls.Add(btnDeleteBook);
            Controls.Add(btnAddNewRowB);
            Controls.Add(btnAddBook);
            Controls.Add(dataGridView2);
            Controls.Add(btnAddUser);
            Controls.Add(btnNewRow);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Name = "Form3";
            Text = "Zaposleni prijavljen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNewRow;
        private Button btnAddUser;
        private DataGridView dataGridView2;
        private Button btnAddBook;
        private Button btnAddNewRowB;
        private Button btnDeleteBook;
        private Button btnUpdateBook;
        private Button btnLogOut;
        private DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn clanarinaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn korisnikRolaDataGridViewTextBoxColumn;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rediteljDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn1;
        private BindingSource movieBindingSource;
    }
}