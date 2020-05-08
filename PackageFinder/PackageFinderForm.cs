using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PackageFinder
{
    public partial class PackageFinderForm : Form
    {
        internal delegate List<SearchResult> SearchPackageHandler(List<string> files, string packageToSearch);
        internal event SearchPackageHandler searchPackage;
        public PackageFinderForm()
        {
            InitializeComponent();
        }


        private void OnWorkspaceRootFolderButtonClick(object sender, EventArgs e)
        {
            this.folderBrowserDialog1.ShowDialog();

            this.workspacePathTextBox.Text = this.folderBrowserDialog1.SelectedPath;
        }

        private void OnSearchButtonClick(object sender, EventArgs e)
        {
            if (!IsValidSearchCriteria())
            {
                MessageBox.Show(@"The Search Criteria entered is invalid.", @"Search Criteria");
                return;
            }
            this.searchButton.Enabled = false;
            this.noResultLabel.Visible = false;
            this.searchPackage = null;
            string fileExtensionToSearch = "All";
            fileExtensionToSearch = AssignDelegatesForSearch(fileExtensionToSearch);

            var filteredFiles = GetProjectFiles(fileExtensionToSearch);
            if(filteredFiles == null || filteredFiles.Count == 0)
            {
                MessageBox.Show("No suitable project file found", "No Project File");
                this.searchButton.Enabled = true;

                return;
            }
            var foundPackages = this.searchPackage.Invoke(filteredFiles, this.packageNameTextBox.Text);

            if (foundPackages != null && foundPackages.Count > 0)
            {
                this.searchResultDataGridView.DataSource = foundPackages;
            }
            else
            {
                this.searchResultDataGridView.DataSource = null;
                this.noResultLabel.Visible = true;
            }
            
            this.searchButton.Enabled = true;            
        }

        private bool IsValidSearchCriteria()
        {
            return !string.IsNullOrWhiteSpace(this.workspacePathTextBox.Text)
                && !string.IsNullOrWhiteSpace(this.packageNameTextBox.Text)
                && (this.npmRadioButton.Checked || this.nugetRadioButton.Checked || this.pip.Checked);
        }

        private string AssignDelegatesForSearch(string fileExtensionToSearch)
        {
            if (this.npmRadioButton.Checked)
            {
                this.searchPackage += SearchNpmPackage.FindNPMPackage;
                fileExtensionToSearch = "*package.json";
            }
            else if (this.nugetRadioButton.Checked)
            {
                this.searchPackage += SearchNugetPackage.FindNugetPackage;
                fileExtensionToSearch = "*.csproj";
            }
            else if (this.pip.Checked)
            {
                this.searchPackage += SearchPipPackage.FindPiPPackage;
                fileExtensionToSearch = "*requirements.txt";
            }

            return fileExtensionToSearch;
        }

        private List<string> GetProjectFiles(string fileExtensionToSearch)
        {
            if(!Directory.Exists(this.workspacePathTextBox.Text))
            {
                MessageBox.Show("Workspace Root Folder doesn't exist.", "No Workspace Folder");
                return null;
            }
            IEnumerable<string> allProjFiles;
            allProjFiles = Directory.EnumerateFiles(this.workspacePathTextBox.Text, fileExtensionToSearch, SearchOption.AllDirectories);

            var mainBranchFiles = allProjFiles.Where(filePath =>
            {
                return Path.GetDirectoryName(filePath)
                            .Split(Path.DirectorySeparatorChar)
                            .Any(x => x.Equals("main", StringComparison.InvariantCultureIgnoreCase));
            });

            return mainBranchFiles.ToList();
        }

    }
}
