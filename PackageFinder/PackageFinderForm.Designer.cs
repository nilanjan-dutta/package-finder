namespace PackageFinder
{
    partial class PackageFinderForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.workspacePathTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.packageNameTextBox = new System.Windows.Forms.TextBox();
            this.nugetRadioButton = new System.Windows.Forms.RadioButton();
            this.npmRadioButton = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchResultDataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noResultLabel = new System.Windows.Forms.Label();
            this.pip = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Workspace Root Path:";
            // 
            // workspacePathTextBox
            // 
            this.workspacePathTextBox.Location = new System.Drawing.Point(227, 22);
            this.workspacePathTextBox.Name = "workspacePathTextBox";
            this.workspacePathTextBox.Size = new System.Drawing.Size(363, 22);
            this.workspacePathTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(596, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnWorkspaceRootFolderButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Package Name:";
            // 
            // packageNameTextBox
            // 
            this.packageNameTextBox.Location = new System.Drawing.Point(227, 87);
            this.packageNameTextBox.Name = "packageNameTextBox";
            this.packageNameTextBox.Size = new System.Drawing.Size(238, 22);
            this.packageNameTextBox.TabIndex = 3;
            // 
            // nugetRadioButton
            // 
            this.nugetRadioButton.AutoSize = true;
            this.nugetRadioButton.Location = new System.Drawing.Point(609, 88);
            this.nugetRadioButton.Name = "nugetRadioButton";
            this.nugetRadioButton.Size = new System.Drawing.Size(65, 21);
            this.nugetRadioButton.TabIndex = 5;
            this.nugetRadioButton.TabStop = true;
            this.nugetRadioButton.Text = "nuget";
            this.nugetRadioButton.UseVisualStyleBackColor = true;
            // 
            // npmRadioButton
            // 
            this.npmRadioButton.AutoSize = true;
            this.npmRadioButton.Location = new System.Drawing.Point(534, 88);
            this.npmRadioButton.Name = "npmRadioButton";
            this.npmRadioButton.Size = new System.Drawing.Size(56, 21);
            this.npmRadioButton.TabIndex = 4;
            this.npmRadioButton.TabStop = true;
            this.npmRadioButton.Text = "npm";
            this.npmRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Location = new System.Drawing.Point(787, 72);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(100, 50);
            this.searchButton.TabIndex = 6;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.OnSearchButtonClick);
            // 
            // searchResultDataGridView
            // 
            this.searchResultDataGridView.AllowUserToAddRows = false;
            this.searchResultDataGridView.AllowUserToDeleteRows = false;
            this.searchResultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.searchResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.searchResultDataGridView.Location = new System.Drawing.Point(12, 210);
            this.searchResultDataGridView.Name = "searchResultDataGridView";
            this.searchResultDataGridView.ReadOnly = true;
            this.searchResultDataGridView.RowHeadersVisible = false;
            this.searchResultDataGridView.RowHeadersWidth = 51;
            this.searchResultDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.searchResultDataGridView.RowTemplate.Height = 24;
            this.searchResultDataGridView.Size = new System.Drawing.Size(908, 335);
            this.searchResultDataGridView.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PackageName";
            this.Column1.HeaderText = "Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Version";
            this.Column2.HeaderText = "Version";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProjectName";
            this.Column3.HeaderText = "Project Name";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Path";
            this.Column4.HeaderText = "Path";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // noResultLabel
            // 
            this.noResultLabel.AutoSize = true;
            this.noResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noResultLabel.ForeColor = System.Drawing.Color.Maroon;
            this.noResultLabel.Location = new System.Drawing.Point(337, 159);
            this.noResultLabel.Name = "noResultLabel";
            this.noResultLabel.Size = new System.Drawing.Size(253, 20);
            this.noResultLabel.TabIndex = 10;
            this.noResultLabel.Text = "No matching package found !";
            this.noResultLabel.Visible = false;
            // 
            // pip
            // 
            this.pip.AutoSize = true;
            this.pip.Location = new System.Drawing.Point(694, 88);
            this.pip.Name = "pip";
            this.pip.Size = new System.Drawing.Size(48, 21);
            this.pip.TabIndex = 11;
            this.pip.TabStop = true;
            this.pip.Text = "pip";
            this.pip.UseVisualStyleBackColor = true;
            // 
            // PackageFinderForm
            // 
            this.AcceptButton = this.searchButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 567);
            this.Controls.Add(this.pip);
            this.Controls.Add(this.noResultLabel);
            this.Controls.Add(this.searchResultDataGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.npmRadioButton);
            this.Controls.Add(this.nugetRadioButton);
            this.Controls.Add(this.packageNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workspacePathTextBox);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "PackageFinderForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Package Finder";
            ((System.ComponentModel.ISupportInitialize)(this.searchResultDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox workspacePathTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox packageNameTextBox;
        private System.Windows.Forms.RadioButton nugetRadioButton;
        private System.Windows.Forms.RadioButton npmRadioButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView searchResultDataGridView;
        private System.Windows.Forms.Label noResultLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.RadioButton pip;
    }
}

