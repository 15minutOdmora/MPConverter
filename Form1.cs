using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace MPConverter
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            // Add all conversion file types to combo boxes

            foreach (string extension in converter.conversionTypesFrom) 
            {
                comboBoxConvertFrom.Items.Add(extension);
            }
            comboBoxConvertFrom.SelectedIndex = 0; 

            foreach (string extension in converter.conversionTypesTo)
            {
                comboBoxConvertTo.Items.Add(extension);
            }
            comboBoxConvertTo.SelectedIndex = 0;

            this.Text = "MPConverter 1.0";
        }

        Converter converter = new Converter();

        /// <summary>
        ///  Open Folder button click
        ///  Opens a file dialog, from where to load files, will only load files with the chosen extension
        /// </summary>
        private void Btn_OpenFolderClick(object sender, EventArgs e)
        {
            // Open and handle a new file dialog
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = "C:\\Users";
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.converter.FindAllFiles(dialog.FileName);
                // Clear previously displayed items
                listBoxSelectedFiles.Items.Clear();
                // Display new items
                foreach (string filepath in this.converter.filePaths)
                {
                    string[] filePathSplit = filepath.Split('\\');
                    string filename = filePathSplit[filePathSplit.Length - 1];
                    labelOpenedFolder.Text = this.converter.pathToFolder;
                    labelOpenedFolder.Visible = true;
                    listBoxSelectedFiles.Items.Add(filename);
                }

                // Show groupbox
                groupBoxConvert.Visible = true;
                labelSelectFolder.Text = this.converter.pathToFolder + "\\converted";
                labelSelectFolder.Visible = true;
            }

            // Hide and clear groupBox items
            this.converter.pathToOutFolder = this.converter.pathToFolder + "\\converted";
            progressBarConverting.Value = 0;
            labelProgress.Visible = false;
            
        }

        /// <summary>
        ///  Slect Folder button click
        ///  Opens a dialog to set the folder for output files
        /// </summary>
        private void Btn_SelectFolderClick(object sender, EventArgs e)
        {
            CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            dialog.InitialDirectory = converter.pathToFolder;
            dialog.IsFolderPicker = true;
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                this.converter.pathToOutFolder = dialog.FileName;
                labelSelectFolder.Text = this.converter.pathToOutFolder;
            }
        }

        /// <summary>
        /// Convert button click 
        /// Converts opened files in another thread, updating progress bar and progress label 
        /// </summary>
        private async void Btn_ConvertClick(object sender, EventArgs e)
        {
            var progress = new Progress<int>(v =>
            {
                this.progressBarConverting.Value = v;
                this.progressBarConverting.Refresh();
            });

            var labelUpdate = new Progress<string>(txt =>
            {
                labelProgress.Text = txt;
                labelProgress.Visible = true;
            });

            progressBarConverting.Value = 1;

            // Run operation in another thread
            string outType = this.comboBoxConvertTo.Text;
            await Task.Run(() => this.converter.ConvertAll(outType, progress, labelUpdate));

            // When finished
            labelProgress.Text = String.Format(
                "Finished, successfully converted {0} mp4 files to:\n {1}", 
                this.converter.filePaths.Length, 
                this.converter.pathToOutFolder);
        }
    }
}
