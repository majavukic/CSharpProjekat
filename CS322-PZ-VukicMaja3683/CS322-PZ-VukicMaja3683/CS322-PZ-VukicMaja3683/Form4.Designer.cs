namespace CS322_PZ_VukicMaja3683
{
    partial class Form4
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
            filmIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nazivDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            rediteljDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            korisnikIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            movieBinding = new BindingSource(components);
            btnRent = new Button();
            dataGridView2 = new DataGridView();
            filmIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            nazivDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            rediteljDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            korisnikIdDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btnReturnBook = new Button();
            btnLogOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)movieBinding).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { filmIdDataGridViewTextBoxColumn, nazivDataGridViewTextBoxColumn, rediteljDataGridViewTextBoxColumn, korisnikIdDataGridViewTextBoxColumn });
            dataGridView1.DataSource = movieBinding;
            dataGridView1.Location = new Point(61, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(670, 350);
            dataGridView1.TabIndex = 0;
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
            // korisnikIdDataGridViewTextBoxColumn
            // 
            korisnikIdDataGridViewTextBoxColumn.DataPropertyName = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn.HeaderText = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            korisnikIdDataGridViewTextBoxColumn.Name = "korisnikIdDataGridViewTextBoxColumn";
            korisnikIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // movieBinding
            // 
            movieBinding.DataSource = typeof(Models.Film);
            // 
            // btnRent
            // 
            btnRent.Location = new Point(341, 397);
            btnRent.Name = "btnRent";
            btnRent.Size = new Size(104, 29);
            btnRent.TabIndex = 1;
            btnRent.Text = "Iznajmi film";
            btnRent.UseVisualStyleBackColor = true;
            btnRent.Click += btnRent_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { filmIdDataGridViewTextBoxColumn1, nazivDataGridViewTextBoxColumn1, rediteljDataGridViewTextBoxColumn1, korisnikIdDataGridViewTextBoxColumn1 });
            dataGridView2.DataSource = movieBinding;
            dataGridView2.Location = new Point(61, 452);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.RowTemplate.Height = 29;
            dataGridView2.Size = new Size(670, 329);
            dataGridView2.TabIndex = 2;
            // 
            // filmIdDataGridViewTextBoxColumn1
            // 
            filmIdDataGridViewTextBoxColumn1.DataPropertyName = "FilmId";
            filmIdDataGridViewTextBoxColumn1.HeaderText = "FilmId";
            filmIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            filmIdDataGridViewTextBoxColumn1.Name = "filmIdDataGridViewTextBoxColumn1";
            filmIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // nazivDataGridViewTextBoxColumn1
            // 
            nazivDataGridViewTextBoxColumn1.DataPropertyName = "Naziv";
            nazivDataGridViewTextBoxColumn1.HeaderText = "Naziv";
            nazivDataGridViewTextBoxColumn1.MinimumWidth = 6;
            nazivDataGridViewTextBoxColumn1.Name = "nazivDataGridViewTextBoxColumn1";
            nazivDataGridViewTextBoxColumn1.Width = 125;
            // 
            // rediteljDataGridViewTextBoxColumn1
            // 
            rediteljDataGridViewTextBoxColumn1.DataPropertyName = "Reditelj";
            rediteljDataGridViewTextBoxColumn1.HeaderText = "Reditelj";
            rediteljDataGridViewTextBoxColumn1.MinimumWidth = 6;
            rediteljDataGridViewTextBoxColumn1.Name = "rediteljDataGridViewTextBoxColumn1";
            rediteljDataGridViewTextBoxColumn1.Width = 125;
            // 
            // korisnikIdDataGridViewTextBoxColumn1
            // 
            korisnikIdDataGridViewTextBoxColumn1.DataPropertyName = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn1.HeaderText = "KorisnikId";
            korisnikIdDataGridViewTextBoxColumn1.MinimumWidth = 6;
            korisnikIdDataGridViewTextBoxColumn1.Name = "korisnikIdDataGridViewTextBoxColumn1";
            korisnikIdDataGridViewTextBoxColumn1.Width = 125;
            // 
            // btnReturnBook
            // 
            btnReturnBook.Location = new Point(351, 831);
            btnReturnBook.Name = "btnReturnBook";
            btnReturnBook.Size = new Size(94, 29);
            btnReturnBook.TabIndex = 3;
            btnReturnBook.Text = "Vrati film";
            btnReturnBook.UseVisualStyleBackColor = true;
            btnReturnBook.Click += btnReturnBook_Click;
            // 
            // btnLogOut
            // 
            btnLogOut.Location = new Point(671, 831);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(94, 29);
            btnLogOut.TabIndex = 4;
            btnLogOut.Text = "Odjavi se";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 889);
            Controls.Add(btnLogOut);
            Controls.Add(btnReturnBook);
            Controls.Add(dataGridView2);
            Controls.Add(btnRent);
            Controls.Add(dataGridView1);
            Name = "Form4";
            Text = "Član prijavljen";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)movieBinding).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnRent;
        private DataGridView dataGridView2;
        private Button btnReturnBook;
        private Button btnLogOut;
        private DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn rediteljDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn;
        private BindingSource movieBinding;
        private DataGridViewTextBoxColumn filmIdDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nazivDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn rediteljDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn korisnikIdDataGridViewTextBoxColumn1;
    }
}