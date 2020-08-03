using System;
using System.Drawing.Imaging;
using PasteToFile.Helpers;
using System.IO;
using System.Windows.Forms;

namespace PasteToFile.DataTypes
{
    public class Image
    {
        private readonly Settings _settings = new Settings(FileType.Image);
        private readonly FilenameMask _filenameMask = new FilenameMask();

        /// <summary>
        /// Handle the creation of an image file, fetch settings, and display output choices dialog.
        /// </summary>
        /// <param name="outputDirectory">The output directory.</param>
        public void Handle(string outputDirectory)
        {
            var filename = _filenameMask.Generate(_settings.FilenameMask);
            var filenameExtension = _settings.FilenameExtension;
            var fullOutputPath = Path.Combine(outputDirectory, $"{filename}.{filenameExtension}");

            WriteOut(fullOutputPath);
        }

        /// <summary>
        /// Writes the image within the clipboard to the given file location.
        /// </summary>
        /// <param name="fullOutputPath">The path to write the image file to.</param>
        public void WriteOut(string fullOutputPath)
        {
            ImageFormat imageFormat;
            Enum.TryParse(_settings.FilenameExtension, out ImageFileExtension extension);

            switch (extension)
            {
                case ImageFileExtension.png:
                    imageFormat = ImageFormat.Png;
                    break;
                case ImageFileExtension.jpg:
                    imageFormat = ImageFormat.Jpeg;
                    break;
                case ImageFileExtension.bmp:
                    imageFormat = ImageFormat.Bmp;
                    break;
                case ImageFileExtension.gif:
                    imageFormat = ImageFormat.Gif;
                    break;
                default:
                    imageFormat = ImageFormat.Png;
                    break;
            }

            Clipboard.GetImage()?.Save(fullOutputPath, imageFormat);
        }
    }
}
