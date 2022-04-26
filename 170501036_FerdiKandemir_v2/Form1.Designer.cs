namespace _170501036_FerdiKandemir_v2
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.wilkommenMesssage = new System.Windows.Forms.Label();
            this.loginPage = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.benutzerNameInput = new System.Windows.Forms.TextBox();
            this.passwortInput = new System.Windows.Forms.TextBox();
            this.einloggenButton = new System.Windows.Forms.Button();
            this.rechtsbuero_DBDataSet1 = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1();
            this.personTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personTableTableAdapter = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.PersonTableTableAdapter();
            this.tableAdapterManager = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager();
            this.personTableBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.personTableBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.loginPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsbuero_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingNavigator)).BeginInit();
            this.personTableBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(186, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // wilkommenMesssage
            // 
            this.wilkommenMesssage.AutoSize = true;
            this.wilkommenMesssage.Font = new System.Drawing.Font("Century", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wilkommenMesssage.Location = new System.Drawing.Point(225, 41);
            this.wilkommenMesssage.Name = "wilkommenMesssage";
            this.wilkommenMesssage.Size = new System.Drawing.Size(435, 25);
            this.wilkommenMesssage.TabIndex = 1;
            this.wilkommenMesssage.Text = "Wilkommen zur Rechtsbuero Desktop App!";
            // 
            // loginPage
            // 
            this.loginPage.Controls.Add(this.einloggenButton);
            this.loginPage.Controls.Add(this.passwortInput);
            this.loginPage.Controls.Add(this.benutzerNameInput);
            this.loginPage.Controls.Add(this.label2);
            this.loginPage.Controls.Add(this.label1);
            this.loginPage.Location = new System.Drawing.Point(0, 127);
            this.loginPage.Name = "loginPage";
            this.loginPage.Size = new System.Drawing.Size(801, 339);
            this.loginPage.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Benutzername";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Passwort";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // benutzerNameInput
            // 
            this.benutzerNameInput.Location = new System.Drawing.Point(387, 94);
            this.benutzerNameInput.Name = "benutzerNameInput";
            this.benutzerNameInput.Size = new System.Drawing.Size(100, 20);
            this.benutzerNameInput.TabIndex = 2;
            // 
            // passwortInput
            // 
            this.passwortInput.Location = new System.Drawing.Point(387, 120);
            this.passwortInput.Name = "passwortInput";
            this.passwortInput.Size = new System.Drawing.Size(100, 20);
            this.passwortInput.TabIndex = 3;
            // 
            // einloggenButton
            // 
            this.einloggenButton.Location = new System.Drawing.Point(387, 155);
            this.einloggenButton.Name = "einloggenButton";
            this.einloggenButton.Size = new System.Drawing.Size(75, 23);
            this.einloggenButton.TabIndex = 4;
            this.einloggenButton.Text = "Einloggen";
            this.einloggenButton.UseVisualStyleBackColor = true;
            this.einloggenButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // rechtsbuero_DBDataSet1
            // 
            this.rechtsbuero_DBDataSet1.DataSetName = "Rechtsbuero_DBDataSet1";
            this.rechtsbuero_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personTableBindingSource
            // 
            this.personTableBindingSource.DataMember = "PersonTable";
            this.personTableBindingSource.DataSource = this.rechtsbuero_DBDataSet1;
            // 
            // personTableTableAdapter
            // 
            this.personTableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.PersonTableTableAdapter = this.personTableTableAdapter;
            this.tableAdapterManager.UpdateOrder = _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personTableBindingNavigator
            // 
            this.personTableBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personTableBindingNavigator.BindingSource = this.personTableBindingSource;
            this.personTableBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personTableBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personTableBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personTableBindingNavigatorSaveItem});
            this.personTableBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personTableBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personTableBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personTableBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personTableBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personTableBindingNavigator.Name = "personTableBindingNavigator";
            this.personTableBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personTableBindingNavigator.Size = new System.Drawing.Size(801, 25);
            this.personTableBindingNavigator.TabIndex = 3;
            this.personTableBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // personTableBindingNavigatorSaveItem
            // 
            this.personTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.personTableBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personTableBindingNavigatorSaveItem.Image")));
            this.personTableBindingNavigatorSaveItem.Name = "personTableBindingNavigatorSaveItem";
            this.personTableBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.personTableBindingNavigatorSaveItem.Text = "Save Data";
            this.personTableBindingNavigatorSaveItem.Click += new System.EventHandler(this.personTableBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 464);
            this.Controls.Add(this.personTableBindingNavigator);
            this.Controls.Add(this.loginPage);
            this.Controls.Add(this.wilkommenMesssage);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Rechtsbuero Desktop App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.loginPage.ResumeLayout(false);
            this.loginPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsbuero_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personTableBindingNavigator)).EndInit();
            this.personTableBindingNavigator.ResumeLayout(false);
            this.personTableBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label wilkommenMesssage;
        private System.Windows.Forms.Panel loginPage;
        private System.Windows.Forms.Button einloggenButton;
        private System.Windows.Forms.TextBox passwortInput;
        private System.Windows.Forms.TextBox benutzerNameInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Rechtsbuero_DBDataSet1 rechtsbuero_DBDataSet1;
        private System.Windows.Forms.BindingSource personTableBindingSource;
        private Rechtsbuero_DBDataSet1TableAdapters.PersonTableTableAdapter personTableTableAdapter;
        private Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personTableBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personTableBindingNavigatorSaveItem;
    }
}

