namespace MPConverter
{
    partial class MainWindow
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
            this.listBoxSelectedFiles = new System.Windows.Forms.ListBox();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.labelOpenedFolder = new System.Windows.Forms.Label();
            this.groupBoxConvert = new System.Windows.Forms.GroupBox();
            this.progressBarConverting = new System.Windows.Forms.ProgressBar();
            this.labelProgress = new System.Windows.Forms.Label();
            this.buttonConvert = new System.Windows.Forms.Button();
            this.comboBoxConvertTo = new System.Windows.Forms.ComboBox();
            this.labelConvertTo = new System.Windows.Forms.Label();
            this.labelSelectFolder = new System.Windows.Forms.Label();
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.labelConvertFrom = new System.Windows.Forms.Label();
            this.comboBoxConvertFrom = new System.Windows.Forms.ComboBox();
            this.groupBoxConvert.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "MPConverter";
            // 
            // listBoxSelectedFiles
            // 
            this.listBoxSelectedFiles.FormattingEnabled = true;
            this.listBoxSelectedFiles.Location = new System.Drawing.Point(19, 110);
            this.listBoxSelectedFiles.Name = "listBoxSelectedFiles";
            this.listBoxSelectedFiles.Size = new System.Drawing.Size(303, 303);
            this.listBoxSelectedFiles.TabIndex = 1;
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(19, 81);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.buttonOpenFolder.TabIndex = 2;
            this.buttonOpenFolder.Text = "Open Folder";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.Btn_OpenFolderClick);
            // 
            // labelOpenedFolder
            // 
            this.labelOpenedFolder.AutoSize = true;
            this.labelOpenedFolder.Location = new System.Drawing.Point(100, 86);
            this.labelOpenedFolder.Name = "labelOpenedFolder";
            this.labelOpenedFolder.Size = new System.Drawing.Size(28, 13);
            this.labelOpenedFolder.TabIndex = 3;
            this.labelOpenedFolder.Text = "Test";
            this.labelOpenedFolder.Visible = false;
            // 
            // groupBoxConvert
            // 
            this.groupBoxConvert.Controls.Add(this.progressBarConverting);
            this.groupBoxConvert.Controls.Add(this.labelProgress);
            this.groupBoxConvert.Controls.Add(this.buttonConvert);
            this.groupBoxConvert.Controls.Add(this.comboBoxConvertTo);
            this.groupBoxConvert.Controls.Add(this.labelConvertTo);
            this.groupBoxConvert.Controls.Add(this.labelSelectFolder);
            this.groupBoxConvert.Controls.Add(this.buttonSelectFolder);
            this.groupBoxConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxConvert.Location = new System.Drawing.Point(346, 39);
            this.groupBoxConvert.Name = "groupBoxConvert";
            this.groupBoxConvert.Size = new System.Drawing.Size(396, 374);
            this.groupBoxConvert.TabIndex = 4;
            this.groupBoxConvert.TabStop = false;
            this.groupBoxConvert.Visible = false;
            // 
            // progressBarConverting
            // 
            this.progressBarConverting.Location = new System.Drawing.Point(0, 105);
            this.progressBarConverting.Name = "progressBarConverting";
            this.progressBarConverting.Size = new System.Drawing.Size(390, 23);
            this.progressBarConverting.Step = 1;
            this.progressBarConverting.TabIndex = 12;
            // 
            // labelProgress
            // 
            this.labelProgress.AutoSize = true;
            this.labelProgress.Location = new System.Drawing.Point(-3, 137);
            this.labelProgress.Name = "labelProgress";
            this.labelProgress.Size = new System.Drawing.Size(45, 16);
            this.labelProgress.TabIndex = 11;
            this.labelProgress.Text = "label6";
            this.labelProgress.Visible = false;
            // 
            // buttonConvert
            // 
            this.buttonConvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConvert.Location = new System.Drawing.Point(0, 76);
            this.buttonConvert.Name = "buttonConvert";
            this.buttonConvert.Size = new System.Drawing.Size(91, 23);
            this.buttonConvert.TabIndex = 10;
            this.buttonConvert.Text = "Convert";
            this.buttonConvert.UseVisualStyleBackColor = true;
            this.buttonConvert.Click += new System.EventHandler(this.Btn_ConvertClick);
            // 
            // comboBoxConvertTo
            // 
            this.comboBoxConvertTo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxConvertTo.FormattingEnabled = true;
            this.comboBoxConvertTo.Location = new System.Drawing.Point(64, 12);
            this.comboBoxConvertTo.Name = "comboBoxConvertTo";
            this.comboBoxConvertTo.Size = new System.Drawing.Size(61, 23);
            this.comboBoxConvertTo.TabIndex = 8;
            // 
            // labelConvertTo
            // 
            this.labelConvertTo.AutoSize = true;
            this.labelConvertTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertTo.Location = new System.Drawing.Point(-3, 15);
            this.labelConvertTo.Name = "labelConvertTo";
            this.labelConvertTo.Size = new System.Drawing.Size(74, 16);
            this.labelConvertTo.TabIndex = 7;
            this.labelConvertTo.Text = "Convert to: ";
            // 
            // labelSelectFolder
            // 
            this.labelSelectFolder.AutoSize = true;
            this.labelSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectFolder.Location = new System.Drawing.Point(97, 52);
            this.labelSelectFolder.Name = "labelSelectFolder";
            this.labelSelectFolder.Size = new System.Drawing.Size(28, 13);
            this.labelSelectFolder.TabIndex = 6;
            this.labelSelectFolder.Text = "Test";
            this.labelSelectFolder.Visible = false;
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelectFolder.Location = new System.Drawing.Point(0, 47);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(91, 23);
            this.buttonSelectFolder.TabIndex = 5;
            this.buttonSelectFolder.Text = "Select Folder";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.Btn_SelectFolderClick);
            // 
            // labelConvertFrom
            // 
            this.labelConvertFrom.AutoSize = true;
            this.labelConvertFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConvertFrom.Location = new System.Drawing.Point(16, 54);
            this.labelConvertFrom.Name = "labelConvertFrom";
            this.labelConvertFrom.Size = new System.Drawing.Size(89, 16);
            this.labelConvertFrom.TabIndex = 5;
            this.labelConvertFrom.Text = "Convert from: ";
            // 
            // comboBoxConvertFrom
            // 
            this.comboBoxConvertFrom.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxConvertFrom.FormattingEnabled = true;
            this.comboBoxConvertFrom.Location = new System.Drawing.Point(103, 51);
            this.comboBoxConvertFrom.Name = "comboBoxConvertFrom";
            this.comboBoxConvertFrom.Size = new System.Drawing.Size(61, 21);
            this.comboBoxConvertFrom.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.comboBoxConvertFrom);
            this.Controls.Add(this.labelConvertFrom);
            this.Controls.Add(this.groupBoxConvert);
            this.Controls.Add(this.labelOpenedFolder);
            this.Controls.Add(this.buttonOpenFolder);
            this.Controls.Add(this.listBoxSelectedFiles);
            this.Controls.Add(this.label1);
            this.Name = "MainWindow";
            this.Text = "MPConverter 1.0";
            this.groupBoxConvert.ResumeLayout(false);
            this.groupBoxConvert.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxSelectedFiles;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.Label labelOpenedFolder;
        private System.Windows.Forms.GroupBox groupBoxConvert;
        private System.Windows.Forms.Label labelSelectFolder;
        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.Label labelConvertFrom;
        private System.Windows.Forms.ComboBox comboBoxConvertFrom;
        private System.Windows.Forms.ComboBox comboBoxConvertTo;
        private System.Windows.Forms.Label labelConvertTo;
        private System.Windows.Forms.Label labelProgress;
        private System.Windows.Forms.Button buttonConvert;
        private System.Windows.Forms.ProgressBar progressBarConverting;
    }
}

