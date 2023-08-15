namespace CS322_PZ_VukicMaja3683
{
    partial class Form2
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
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { korisnikIdDataGridViewTextBoxColumn, korisnickoImeDataGridViewTextBoxColumn, lozinkaDataGridViewTextBoxColumn, clanarinaDataGridViewCheckBoxColumn, korisnikRolaDataGridViewTextBoxColumn });
            dataGridView1.DataSource = userBindingSource;
            dataGridView1.Location = new Point(73, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(643, 345);
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
            btnUpdate.Location = new Point(28, 403);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Izmeni";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(179, 403);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Obriši";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnNewRow
            // 
            btnNewRow.Location = new Point(342, 403);
            btnNewRow.Name = "btnNewRow";
            btnNewRow.Size = new Size(94, 29);
            btnNewRow.TabIndex = 3;
            btnNewRow.Text = "Dodaj red";
            btnNewRow.UseVisualStyleBackColor = true;
            btnNewRow.Click += btnNewRow_Click;
            // 
            // btnAddUser
            // 
            btnAddUser.Location = new Point(483, 403);
            btnAddUser.Name = "btnAddUser";
            btnAddUser.Size = new Size(149, 29);
            btnAddUser.TabIndex = 4;
            btnAddUser.Text = "Dodaj zaposlenog";
            btnAddUser.UseVisualStyleBackColor = true;
            btnAddUser.Click += btnAddUser_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(668, 403);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Odjavi se";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogOut);
            Controls.Add(btnAddUser);
            Controls.Add(btnNewRow);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(dataGridView1);
            Name = "Form2";
            Text = "Pregled zaposlenih";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnNewRow;
        private Button btnAddUser;
        private Button btnLogOut;
        private BindingSource userBindingSource;
        private DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn korisnickoImeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lozinkaDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn clanarinaDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn korisnikRolaDataGridViewTextBoxColumn;
    }
}