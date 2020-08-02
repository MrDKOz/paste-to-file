using PasteToFile.Helpers;
using System.IO;
using System.Windows.Forms;

namespace PasteToFile.DataTypes
{
    public static class Text
    {
        private static readonly Settings Settings = new Settings(FileType.Text);
        private static readonly FilenameMask FilenameMask = new FilenameMask();

        /// <summary>
        /// Handle the creation of an text file, fetch settings, and display output choices dialog.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        public static void Handle(string outputDirectory)
        {
            if (Settings.ShowConfig)
                using (var fileOutput = new FileOutput(FileType.Text, outputDirectory))
                    fileOutput.ShowDialog();
            else
            {
                var filename = FilenameMask.Generate(Settings.FilenameMask);
                var filenameExtension = Settings.FilenameExtension;
                var fullOutputPath = Path.Combine(outputDirectory, $"{filename}.{filenameExtension}");

                WriteOut(fullOutputPath);
            }
        }

        /// <summary>
        /// Writes the text within the clipboard to the given file location.
        /// </summary>
        /// <param name="fullFilePath">The path to write the text file to.</param>
        private static void WriteOut(string fullFilePath)
        {
            File.WriteAllText(fullFilePath, Clipboard.GetText());
        }
    }
}
