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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rechtsAnwaltSeite));
            this.wilkommenMesssage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sideMenu = new System.Windows.Forms.Panel();
            this.adminSystemSettingsButton = new System.Windows.Forms.Button();
            this.adminExitButton = new System.Windows.Forms.Button();
            this.rechtsAnwaltFallButton = new System.Windows.Forms.Button();
            this.adminHomeButton = new System.Windows.Forms.Button();
            this.raFaellePanel = new System.Windows.Forms.Panel();
            this.rechtsbuero_DBDataSet1 = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1();
            this.fallTabelleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fallTabelleTableAdapter = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.FallTabelleTableAdapter();
            this.tableAdapterManager = new _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager();
            this.fallTabelleBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.fallTabelleBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fallTabelleDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.sideMenu.SuspendLayout();
            this.raFaellePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rechtsbuero_DBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleBindingNavigator)).BeginInit();
            this.fallTabelleBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleDataGridView)).BeginInit();
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
            this.sideMenu.Controls.Add(this.adminSystemSettingsButton);
            this.sideMenu.Controls.Add(this.adminExitButton);
            this.sideMenu.Controls.Add(this.rechtsAnwaltFallButton);
            this.sideMenu.Controls.Add(this.adminHomeButton);
            this.sideMenu.Location = new System.Drawing.Point(1, 123);
            this.sideMenu.Name = "sideMenu";
            this.sideMenu.Size = new System.Drawing.Size(200, 333);
            this.sideMenu.TabIndex = 3;
            // 
            // adminSystemSettingsButton
            // 
            this.adminSystemSettingsButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.adminSystemSettingsButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminSystemSettingsButton.Image = ((System.Drawing.Image)(resources.GetObject("adminSystemSettingsButton.Image")));
            this.adminSystemSettingsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminSystemSettingsButton.Location = new System.Drawing.Point(3, 123);
            this.adminSystemSettingsButton.Name = "adminSystemSettingsButton";
            this.adminSystemSettingsButton.Size = new System.Drawing.Size(192, 44);
            this.adminSystemSettingsButton.TabIndex = 1;
            this.adminSystemSettingsButton.Text = "    Einstellungen";
            this.adminSystemSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminSystemSettingsButton.UseVisualStyleBackColor = false;
            // 
            // adminExitButton
            // 
            this.adminExitButton.BackColor = System.Drawing.Color.White;
            this.adminExitButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminExitButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminExitButton.Location = new System.Drawing.Point(3, 278);
            this.adminExitButton.Name = "adminExitButton";
            this.adminExitButton.Size = new System.Drawing.Size(192, 44);
            this.adminExitButton.TabIndex = 1;
            this.adminExitButton.Text = "Verlassen";
            this.adminExitButton.UseVisualStyleBackColor = false;
            this.adminExitButton.Click += new System.EventHandler(this.adminExitButton_Click);
            // 
            // rechtsAnwaltFallButton
            // 
            this.rechtsAnwaltFallButton.BackColor = System.Drawing.Color.White;
            this.rechtsAnwaltFallButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechtsAnwaltFallButton.Image = ((System.Drawing.Image)(resources.GetObject("rechtsAnwaltFallButton.Image")));
            this.rechtsAnwaltFallButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechtsAnwaltFallButton.Location = new System.Drawing.Point(3, 62);
            this.rechtsAnwaltFallButton.Name = "rechtsAnwaltFallButton";
            this.rechtsAnwaltFallButton.Size = new System.Drawing.Size(192, 44);
            this.rechtsAnwaltFallButton.TabIndex = 1;
            this.rechtsAnwaltFallButton.Text = "    Fälle";
            this.rechtsAnwaltFallButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.rechtsAnwaltFallButton.UseVisualStyleBackColor = false;
            this.rechtsAnwaltFallButton.Click += new System.EventHandler(this.adminUserPanelButton_Click);
            // 
            // adminHomeButton
            // 
            this.adminHomeButton.BackColor = System.Drawing.Color.White;
            this.adminHomeButton.Font = new System.Drawing.Font("Century", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminHomeButton.Image = ((System.Drawing.Image)(resources.GetObject("adminHomeButton.Image")));
            this.adminHomeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminHomeButton.Location = new System.Drawing.Point(3, 3);
            this.adminHomeButton.Name = "adminHomeButton";
            this.adminHomeButton.Size = new System.Drawing.Size(192, 44);
            this.adminHomeButton.TabIndex = 1;
            this.adminHomeButton.Text = "    Home";
            this.adminHomeButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.adminHomeButton.UseVisualStyleBackColor = false;
            // 
            // raFaellePanel
            // 
            this.raFaellePanel.Controls.Add(this.fallTabelleDataGridView);
            this.raFaellePanel.Location = new System.Drawing.Point(204, 126);
            this.raFaellePanel.Name = "raFaellePanel";
            this.raFaellePanel.Size = new System.Drawing.Size(592, 318);
            this.raFaellePanel.TabIndex = 5;
            // 
            // rechtsbuero_DBDataSet1
            // 
            this.rechtsbuero_DBDataSet1.DataSetName = "Rechtsbuero_DBDataSet1";
            this.rechtsbuero_DBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fallTabelleBindingSource
            // 
            this.fallTabelleBindingSource.DataMember = "FallTabelle";
            this.fallTabelleBindingSource.DataSource = this.rechtsbuero_DBDataSet1;
            // 
            // fallTabelleTableAdapter
            // 
            this.fallTabelleTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.FallTabelleTableAdapter = this.fallTabelleTableAdapter;
            this.tableAdapterManager.PersonTabelleTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = _170501036_FerdiKandemir_v2.Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // fallTabelleBindingNavigator
            // 
            this.fallTabelleBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.fallTabelleBindingNavigator.BindingSource = this.fallTabelleBindingSource;
            this.fallTabelleBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.fallTabelleBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.fallTabelleBindingNavigator.Dock = System.Windows.Forms.DockStyle.Right;
            this.fallTabelleBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.fallTabelleBindingNavigatorSaveItem});
            this.fallTabelleBindingNavigator.Location = new System.Drawing.Point(747, 0);
            this.fallTabelleBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.fallTabelleBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.fallTabelleBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.fallTabelleBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.fallTabelleBindingNavigator.Name = "fallTabelleBindingNavigator";
            this.fallTabelleBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.fallTabelleBindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.fallTabelleBindingNavigator.Size = new System.Drawing.Size(53, 456);
            this.fallTabelleBindingNavigator.TabIndex = 6;
            this.fallTabelleBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // fallTabelleBindingNavigatorSaveItem
            // 
            this.fallTabelleBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fallTabelleBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("fallTabelleBindingNavigatorSaveItem.Image")));
            this.fallTabelleBindingNavigatorSaveItem.Name = "fallTabelleBindingNavigatorSaveItem";
            this.fallTabelleBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.fallTabelleBindingNavigatorSaveItem.Text = "Save Data";
            this.fallTabelleBindingNavigatorSaveItem.Click += new System.EventHandler(this.fallTabelleBindingNavigatorSaveItem_Click);
            // 
            // fallTabelleDataGridView
            // 
            this.fallTabelleDataGridView.AutoGenerateColumns = false;
            this.fallTabelleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fallTabelleDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.fallTabelleDataGridView.DataSource = this.fallTabelleBindingSource;
            this.fallTabelleDataGridView.Location = new System.Drawing.Point(0, 0);
            this.fallTabelleDataGridView.Name = "fallTabelleDataGridView";
            this.fallTabelleDataGridView.Size = new System.Drawing.Size(592, 319);
            this.fallTabelleDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Fall ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Fall ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fall Nummer";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fall Nummer";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Fall Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Fall Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Fall Beschreibung";
            this.dataGridViewTextBoxColumn4.HeaderText = "Fall Beschreibung";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Fall Typ";
            this.dataGridViewTextBoxColumn5.HeaderText = "Fall Typ";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Beklagter Vorname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Beklagter Vorname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Beklagter Nachname";
            this.dataGridViewTextBoxColumn7.HeaderText = "Beklagter Nachname";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // rechtsAnwaltSeite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.fallTabelleBindingNavigator);
            this.Controls.Add(this.raFaellePanel);
            this.Controls.Add(this.wilkommenMesssage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "rechtsAnwaltSeite";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.rechtsAnwaltSeite_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.sideMenu.ResumeLayout(false);
            this.raFaellePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rechtsbuero_DBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleBindingNavigator)).EndInit();
            this.fallTabelleBindingNavigator.ResumeLayout(false);
            this.fallTabelleBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fallTabelleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wilkommenMesssage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel sideMenu;
        private System.Windows.Forms.Button adminSystemSettingsButton;
        private System.Windows.Forms.Button adminExitButton;
        private System.Windows.Forms.Button rechtsAnwaltFallButton;
        private System.Windows.Forms.Button adminHomeButton;
        private System.Windows.Forms.Panel raFaellePanel;
        private Rechtsbuero_DBDataSet1 rechtsbuero_DBDataSet1;
        private System.Windows.Forms.BindingSource fallTabelleBindingSource;
        private Rechtsbuero_DBDataSet1TableAdapters.FallTabelleTableAdapter fallTabelleTableAdapter;
        private Rechtsbuero_DBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator fallTabelleBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton fallTabelleBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView fallTabelleDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
    }
}