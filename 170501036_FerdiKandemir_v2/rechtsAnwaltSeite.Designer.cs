namespace _170501036_FerdiKandemir_v2
{
    partial class rechtsAnwaltSeite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rechtsAnwaltSeite));
            this.wilkommenMesssage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.raExitButton = new System.Windows.Forms.Button();
            this.raFallButton = new System.Windows.Forms.Button();
            this.raHomeButton = new System.Windows.Forms.Button();
            this.raFaellePanel = new System.Windows.Forms.Panel();
            this.fallTabelleDataGridView = new System.Windows.Forms.DataGridView();
            this.homePanel = new System.Windows.Forms.Panel();
            this.raBenNameAndern = new System.Windows.Forms.TextBox();
            this.raPwAndern = new System.Windows.Forms.TextBox();
            this.homeBenNameLabel = new System.Windows.Forms.Label();
            this.homePwLabel = new System.Windows.Forms.Label();
            this.homePwAndernLabel = new System.Windows.Forms.Label();
            this.passwortAendernButton = new System.Windows.Forms.Button();
            this.homeTeamNr = new System.Windows.Forms.Label();
            this.raHomeTeamNr = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.raHomeTeamLeiter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.raDeinTeamTabelleGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideMenu.SuspendLayout();
            this.raFaellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleDataGridView)).BeginInit();
            this.homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raDeinTeamTabelleGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // wilkommenMesssage
            // 
            this.wilkommenMesssage.AutoSize = true;
            this.wilkommenMesssage.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wilkommenMesssage.Location = new System.Drawing.Point(225, 41);
            this.wilkommenMesssage.Name = "wilkommenMesssage";
            this.wilkommenMesssage.Size = new System.Drawing.Size(435, 25);
            this.wilkommenMesssage.TabIndex = 4;
            this.wilkommenMesssage.Text = "Wilkommen zur Rechtsbuero Desktop App!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // sideMenu
            // 
            this.sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(180)))));
            this.sideMenu.Controls.Add(this.raExitButton);
            this.sideMenu.Controls.Add(this.raFallButton);
            this.sideMenu.Controls.Add(this.raHomeButton);
            this.sideMenu.Location = new System.Drawing.Point(1, 123);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(200, 377);
            this.sideMenu.TabIndex = 3;
            // 
            // raExitButton
            // 
            this.raExitButton.BackColor = System.Drawing.Color.White;
            this.raExitButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raExitButton.Location = new System.Drawing.Point(3, 313);
            this.raExitButton.Name = "raExitButton";
            this.raExitButton.Size = new System.Drawing.Size(192, 44);
            this.raExitButton.TabIndex = 1;
            this.raExitButton.Text = "Verlassen";
            this.raExitButton.UseVisualStyleBackColor = false;
            this.raExitButton.Click += new System.EventHandler(this.raExitButton_Click);
            // 
            // raFallButton
            // 
            this.raFallButton.BackColor = System.Drawing.Color.White;
            this.raFallButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raFallButton.Image = ((System.Drawing.Image)(resources.GetObject("raFallButton.Image")));
            this.raFallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raFallButton.Location = new System.Drawing.Point(3, 66);
            this.raFallButton.Name = "raFallButton";
            this.raFallButton.Size = new System.Drawing.Size(192, 44);
            this.raFallButton.TabIndex = 1;
            this.raFallButton.Text = "    Deine Fälle";
            this.raFallButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raFallButton.UseVisualStyleBackColor = false;
            this.raFallButton.Click += new System.EventHandler(this.raFallButton_Click);
            // 
            // raHomeButton
            // 
            this.raHomeButton.BackColor = System.Drawing.Color.White;
            this.raHomeButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("raHomeButton.Image")));
            this.raHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raHomeButton.Location = new System.Drawing.Point(3, 3);
            this.raHomeButton.Name = "raHomeButton";
            this.raHomeButton.Size = new System.Drawing.Size(192, 44);
            this.raHomeButton.TabIndex = 1;
            this.raHomeButton.Text = "    Home";
            this.raHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.raHomeButton.UseVisualStyleBackColor = false;
            this.raHomeButton.Click += new System.EventHandler(this.raHomeButton_Click);
            // 
            // raFaellePanel
            // 
            this.raFaellePanel.Controls.Add(this.homePanel);
            this.raFaellePanel.Controls.Add(this.fallTabelleDataGridView);
            this.raFaellePanel.Location = new System.Drawing.Point(204, 126);
            this.raFaellePanel.Name = "raFaellePanel";
            this.raFaellePanel.Size = new System.Drawing.Size(592, 355);
            this.raFaellePanel.TabIndex = 5;
            // 
            // fallTabelleDataGridView
            // 
            this.fallTabelleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fallTabelleDataGridView.Location = new System.Drawing.Point(3, 3);
            this.fallTabelleDataGridView.Name = "fallTabelleDataGridView";
            this.fallTabelleDataGridView.Size = new System.Drawing.Size(589, 351);
            this.fallTabelleDataGridView.TabIndex = 0;
            // 
            // homePanel
            // 
            this.homePanel.Controls.Add(this.raDeinTeamTabelleGrid);
            this.homePanel.Controls.Add(this.label1);
            this.homePanel.Controls.Add(this.raHomeTeamLeiter);
            this.homePanel.Controls.Add(this.label2);
            this.homePanel.Controls.Add(this.raHomeTeamNr);
            this.homePanel.Controls.Add(this.homeTeamNr);
            this.homePanel.Controls.Add(this.passwortAendernButton);
            this.homePanel.Controls.Add(this.homePwAndernLabel);
            this.homePanel.Controls.Add(this.homePwLabel);
            this.homePanel.Controls.Add(this.homeBenNameLabel);
            this.homePanel.Controls.Add(this.raPwAndern);
            this.homePanel.Controls.Add(this.raBenNameAndern);
            this.homePanel.Location = new System.Drawing.Point(3, 3);
            this.homePanel.Name = "homePanel";
            this.homePanel.Size = new System.Drawing.Size(589, 353);
            this.homePanel.TabIndex = 1;
            // 
            // raBenNameAndern
            // 
            this.raBenNameAndern.Location = new System.Drawing.Point(96, 57);
            this.raBenNameAndern.Name = "raBenNameAndern";
            this.raBenNameAndern.Size = new System.Drawing.Size(133, 20);
            this.raBenNameAndern.TabIndex = 0;
            // 
            // raPwAndern
            // 
            this.raPwAndern.Location = new System.Drawing.Point(96, 95);
            this.raPwAndern.Name = "raPwAndern";
            this.raPwAndern.Size = new System.Drawing.Size(133, 20);
            this.raPwAndern.TabIndex = 1;
            // 
            // homeBenNameLabel
            // 
            this.homeBenNameLabel.AutoSize = true;
            this.homeBenNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBenNameLabel.Location = new System.Drawing.Point(3, 60);
            this.homeBenNameLabel.Name = "homeBenNameLabel";
            this.homeBenNameLabel.Size = new System.Drawing.Size(87, 13);
            this.homeBenNameLabel.TabIndex = 2;
            this.homeBenNameLabel.Text = "Benutzername";
            // 
            // homePwLabel
            // 
            this.homePwLabel.AutoSize = true;
            this.homePwLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePwLabel.Location = new System.Drawing.Point(3, 95);
            this.homePwLabel.Name = "homePwLabel";
            this.homePwLabel.Size = new System.Drawing.Size(58, 13);
            this.homePwLabel.TabIndex = 3;
            this.homePwLabel.Text = "Passwort";
            // 
            // homePwAndernLabel
            // 
            this.homePwAndernLabel.AutoSize = true;
            this.homePwAndernLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homePwAndernLabel.Location = new System.Drawing.Point(3, 12);
            this.homePwAndernLabel.Name = "homePwAndernLabel";
            this.homePwAndernLabel.Size = new System.Drawing.Size(226, 16);
            this.homePwAndernLabel.TabIndex = 4;
            this.homePwAndernLabel.Text = "Benutzername/Passwort Ändern";
            // 
            // passwortAendernButton
            // 
            this.passwortAendernButton.Location = new System.Drawing.Point(150, 121);
            this.passwortAendernButton.Name = "passwortAendernButton";
            this.passwortAendernButton.Size = new System.Drawing.Size(79, 28);
            this.passwortAendernButton.TabIndex = 5;
            this.passwortAendernButton.Text = "Ändern";
            this.passwortAendernButton.UseVisualStyleBackColor = true;
            this.passwortAendernButton.Click += new System.EventHandler(this.passwortAendern_Click);
            // 
            // homeTeamNr
            // 
            this.homeTeamNr.AutoSize = true;
            this.homeTeamNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeTeamNr.Location = new System.Drawing.Point(419, 21);
            this.homeTeamNr.Name = "homeTeamNr";
            this.homeTeamNr.Size = new System.Drawing.Size(129, 20);
            this.homeTeamNr.TabIndex = 6;
            this.homeTeamNr.Text = "Team Nummer:";
            this.homeTeamNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // raHomeTeamNr
            // 
            this.raHomeTeamNr.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raHomeTeamNr.Location = new System.Drawing.Point(419, 57);
            this.raHomeTeamNr.Name = "raHomeTeamNr";
            this.raHomeTeamNr.Size = new System.Drawing.Size(128, 23);
            this.raHomeTeamNr.TabIndex = 7;
            this.raHomeTeamNr.Text = "A";
            this.raHomeTeamNr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(428, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Team-Leiter:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // raHomeTeamLeiter
            // 
            this.raHomeTeamLeiter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raHomeTeamLeiter.Location = new System.Drawing.Point(419, 126);
            this.raHomeTeamLeiter.Name = "raHomeTeamLeiter";
            this.raHomeTeamLeiter.Size = new System.Drawing.Size(128, 23);
            this.raHomeTeamLeiter.TabIndex = 9;
            this.raHomeTeamLeiter.Text = "A";
            this.raHomeTeamLeiter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dein Team:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // raDeinTeamTabelleGrid
            // 
            this.raDeinTeamTabelleGrid.AllowUserToAddRows = false;
            this.raDeinTeamTabelleGrid.AllowUserToDeleteRows = false;
            this.raDeinTeamTabelleGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.raDeinTeamTabelleGrid.Location = new System.Drawing.Point(6, 209);
            this.raDeinTeamTabelleGrid.Name = "raDeinTeamTabelleGrid";
            this.raDeinTeamTabelleGrid.ReadOnly = true;
            this.raDeinTeamTabelleGrid.Size = new System.Drawing.Size(565, 150);
            this.raDeinTeamTabelleGrid.TabIndex = 11;
            // 
            // rechtsAnwaltSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.raFaellePanel);
            this.Controls.Add(this.wilkommenMesssage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rechtsAnwaltSeite";
            this.Load += new System.EventHandler(this.rechtsAnwaltSeite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.raFaellePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleDataGridView)).EndInit();
            this.homePanel.ResumeLayout(false);
            this.homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raDeinTeamTabelleGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wilkommenMesssage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button raExitButton;
        private System.Windows.Forms.Button raFallButton;
        private System.Windows.Forms.Button raHomeButton;
        private System.Windows.Forms.Panel raFaellePanel;
        private System.Windows.Forms.DataGridView fallTabelleDataGridView;
        private System.Windows.Forms.Panel homePanel;
        private System.Windows.Forms.TextBox raPwAndern;
        private System.Windows.Forms.TextBox raBenNameAndern;
        private System.Windows.Forms.Button passwortAendernButton;
        private System.Windows.Forms.Label homePwAndernLabel;
        private System.Windows.Forms.Label homePwLabel;
        private System.Windows.Forms.Label homeBenNameLabel;
        private System.Windows.Forms.Label raHomeTeamLeiter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label raHomeTeamNr;
        private System.Windows.Forms.Label homeTeamNr;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView raDeinTeamTabelleGrid;
    }
}