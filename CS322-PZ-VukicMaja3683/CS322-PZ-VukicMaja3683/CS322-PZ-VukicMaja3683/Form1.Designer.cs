namespace CS322_PZ_VukicMaja3683
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            lbUsername = new Label();
            lbPassword = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnLogIn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(223, 55);
            label1.Name = "label1";
            label1.Size = new Size(348, 50);
            label1.TabIndex = 0;
            label1.Text = "Video Klub \"Žabac\"";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.Location = new Point(177, 155);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(127, 25);
            lbUsername.TabIndex = 1;
            lbUsername.Text = "Korisničko ime";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.Location = new Point(223, 221);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(71, 25);
            lbPassword.TabIndex = 2;
            lbPassword.Text = "Lozinka";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(310, 155);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(217, 27);
            tbUsername.TabIndex = 3;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(310, 221);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(217, 27);
            tbPassword.TabIndex = 4;
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(370, 317);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(94, 36);
            btnLogIn.TabIndex = 5;
            btnLogIn.Text = "Prijava";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogIn);
            Controls.Add(tbPassword);
            Controls.Add(tbUsername);
            Controls.Add(lbPassword);
            Controls.Add(lbUsername);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Prijava";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnLogIn;
    }
}