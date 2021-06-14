using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MPConverter
{
    /// <summary>
    ///  Converter class
    ///  For loading and converting files
    /// </summary>
    class Converter
    {
        public string pathToFolder;
        public string pathToOutFolder;
        public string[] filePaths;
        public string[] conversionTypesFrom = { "mp4", "mp3" };
        public string[] conversionTypesTo = { "mp3", "avi" };
        public string convertFrom = "mp4";  // Auto preset to mp4
        private string _dir = System.IO.Path.GetDirectoryName(Application.ExecutablePath);

        /// <summary>
        /// <c>FindAllFiles(path)</c> finds all files in given path
        /// <para>path: string of absolute path</para>
        /// </summary>
        public void FindAllFiles(string path) 
        {
            Console.WriteLine(this._dir);
            this.pathToFolder = path;
            this.filePaths = Directory.GetFiles(path, String.Format("*.{0}", convertFrom));
        }

        /// <summary>
        /// <c>ConvertAll(outType, progress, labelUpdate)</c> converts all files saved in the filePath property
        /// <para>outType: string of extension to convert to</para>
        /// <para>progress: IProgress<int> lambda for setting progress bar value</para>
        /// <para>labelUpdate: IProgress<string> lambda for updating progress label</para>
        /// </summary>
        public void ConvertAll(string outType, IProgress<int> progress, IProgress<string> labelUpdate) 
        {
            // Check if outFolder exists
            if (!Directory.Exists(this.pathToOutFolder)) 
            {
                Directory.CreateDirectory(this.pathToOutFolder);
                Console.WriteLine("Created directory: " + this.pathToOutFolder);
            }

            int finished = 0;
            foreach (string filename in this.filePaths)
            {
                string labelUpdate_str = String.Format("Converting {0} / {1}", finished, this.filePaths.Length);

                // First time display Started converting ... 
                if (finished == 0)
                {
                    if (labelUpdate != null)
                        labelUpdate.Report("Started converting ... ");
                }
                else {
                    if (labelUpdate != null)
                        labelUpdate.Report(labelUpdate_str);
                }

                this.Convert(filename, outType);

                finished++;
                if (progress != null)
                    progress.Report((int)(((double)finished / (double)this.filePaths.Length) * 100));
            }
        }

        /// <summary>
        /// <c>Convert(toConvert, outType)</c> converts a single file given by param
        /// <para>toConvert: string of absolute path of file to be converted</para>
        /// <para>outType: string of extension to convert to</para>
        /// </summary>
        private void Convert(string toConvert, string outType)
        {
            var filepath = toConvert.Split('.')[0];
            var filename_list = filepath.Split('\\');
            var filename = filename_list[filename_list.Length - 1];  // Last item is name of file without the extension
            var outputFile = this.pathToOutFolder + "\\" + filename + '.' + outType;

            var standardOutput = Converter.Execute(
                this._dir + "\\ffmpeg\\ffmpeg.exe",
                String.Format(" -loglevel error -i \"{0}\" \"{1}\"", toConvert, outputFile));
        }

        /// <summary>
        /// <c>Execute(exePath, parameters)</c> executes a single parameter with Process
        /// <para>exePath: string path of executable to execute from</para>
        /// <para>parameters: string of set parameters to execute</para>
        /// </summary>
        private static string Execute(string exePath, string parameters)
        {
            string result = String.Empty;

            using (Process p = new Process())
            {
                p.StartInfo.UseShellExecute = false;
                p.StartInfo.CreateNoWindow = true;
                p.StartInfo.RedirectStandardOutput = true;
                p.StartInfo.FileName = exePath;
                p.StartInfo.Arguments = parameters;
                p.Start();
                p.WaitForExit();

                result = p.StandardOutput.ReadToEnd();
            }

            return result;
        }
    }
}
