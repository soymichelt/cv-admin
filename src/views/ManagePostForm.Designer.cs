namespace soymichelApp.adminApp
{
    partial class HomeForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.postsDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.otherValueTextBox = new System.Windows.Forms.TextBox();
            this.otherValueLabel = new System.Windows.Forms.Label();
            this.categoriesComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.photoURLTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.avatarURLTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.typePostComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.newButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.searchTextbox = new System.Windows.Forms.TextBox();
            this.waitingMessageLabel = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // postsDataGridView
            // 
            this.postsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.postsDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.postsDataGridView.Location = new System.Drawing.Point(0, 216);
            this.postsDataGridView.Name = "postsDataGridView";
            this.postsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.postsDataGridView.Size = new System.Drawing.Size(501, 234);
            this.postsDataGridView.TabIndex = 0;
            this.postsDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.postsDataGridView_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.photoURLTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.avatarURLTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.typePostComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.titleTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(501, 178);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Post";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.otherValueTextBox);
            this.groupBox2.Controls.Add(this.otherValueLabel);
            this.groupBox2.Controls.Add(this.categoriesComboBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(474, 54);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Otros datos";
            // 
            // otherValueTextBox
            // 
            this.otherValueTextBox.Location = new System.Drawing.Point(226, 20);
            this.otherValueTextBox.Name = "otherValueTextBox";
            this.otherValueTextBox.Size = new System.Drawing.Size(238, 20);
            this.otherValueTextBox.TabIndex = 7;
            // 
            // otherValueLabel
            // 
            this.otherValueLabel.AutoSize = true;
            this.otherValueLabel.Location = new System.Drawing.Point(172, 23);
            this.otherValueLabel.Name = "otherValueLabel";
            this.otherValueLabel.Size = new System.Drawing.Size(30, 13);
            this.otherValueLabel.TabIndex = 6;
            this.otherValueLabel.Text = "Otro:";
            // 
            // categoriesComboBox
            // 
            this.categoriesComboBox.FormattingEnabled = true;
            this.categoriesComboBox.Location = new System.Drawing.Point(67, 20);
            this.categoriesComboBox.Name = "categoriesComboBox";
            this.categoriesComboBox.Size = new System.Drawing.Size(99, 21);
            this.categoriesComboBox.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Categoria:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Location = new System.Drawing.Point(15, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(474, 3);
            this.panel1.TabIndex = 8;
            // 
            // photoURLTextBox
            // 
            this.photoURLTextBox.Location = new System.Drawing.Point(80, 68);
            this.photoURLTextBox.Name = "photoURLTextBox";
            this.photoURLTextBox.Size = new System.Drawing.Size(409, 20);
            this.photoURLTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Url de Foto:";
            // 
            // avatarURLTextBox
            // 
            this.avatarURLTextBox.Location = new System.Drawing.Point(92, 43);
            this.avatarURLTextBox.Name = "avatarURLTextBox";
            this.avatarURLTextBox.Size = new System.Drawing.Size(397, 20);
            this.avatarURLTextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Url del Avatar:";
            // 
            // typePostComboBox
            // 
            this.typePostComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.typePostComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.typePostComboBox.FormattingEnabled = true;
            this.typePostComboBox.Location = new System.Drawing.Point(424, 17);
            this.typePostComboBox.Name = "typePostComboBox";
            this.typePostComboBox.Size = new System.Drawing.Size(65, 21);
            this.typePostComboBox.TabIndex = 3;
            this.typePostComboBox.SelectedIndexChanged += new System.EventHandler(this.typePostComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(349, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de post:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(59, 18);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(284, 20);
            this.titleTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título: ";
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(11, 187);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(75, 22);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "Nuevo";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(92, 187);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 22);
            this.saveButton.TabIndex = 3;
            this.saveButton.Text = "Guardar";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(173, 187);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 22);
            this.deleteButton.TabIndex = 4;
            this.deleteButton.Text = "Eliminar";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(306, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Buscar:";
            // 
            // searchTextbox
            // 
            this.searchTextbox.Location = new System.Drawing.Point(355, 189);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.Size = new System.Drawing.Size(110, 20);
            this.searchTextbox.TabIndex = 6;
            this.searchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextbox_KeyDown);
            // 
            // waitingMessageLabel
            // 
            this.waitingMessageLabel.AutoSize = true;
            this.waitingMessageLabel.Location = new System.Drawing.Point(254, 192);
            this.waitingMessageLabel.Name = "waitingMessageLabel";
            this.waitingMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.waitingMessageLabel.TabIndex = 7;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImage = global::soymichelApp.adminApp.Properties.Resources.search;
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchButton.Location = new System.Drawing.Point(467, 188);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(22, 22);
            this.searchButton.TabIndex = 8;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 450);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.waitingMessageLabel);
            this.Controls.Add(this.searchTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.postsDataGridView);
            this.MaximizeBox = false;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador de publicaciones de estudio y proyectos";
            this.Load += new System.EventHandler(this.HomeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.postsDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView postsDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox searchTextbox;
        private System.Windows.Forms.ComboBox typePostComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox photoURLTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox avatarURLTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox otherValueTextBox;
        private System.Windows.Forms.Label otherValueLabel;
        private System.Windows.Forms.ComboBox categoriesComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label waitingMessageLabel;
        private System.Windows.Forms.Button searchButton;
    }
}

