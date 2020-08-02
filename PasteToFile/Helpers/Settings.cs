using System;
using PasteToFile.DataTypes;

namespace PasteToFile.Helpers
{
    public class Settings
    {
        private readonly FileType _fileType;

        public Settings(FileType fileType)
        {
            _fileType = fileType;
        }

        /// <summary>
        /// Saves the configuration values.
        /// </summary>
        public void Save()
        {
            switch (_fileType)
            {
                case FileType.Text:
                    Properties.Settings.Default.TextFilenameMask = filenameMask;
                    Properties.Settings.Default.TextFilenameExtension = filenameExtension;
                    Properties.Settings.Default.TextShowConfig = showConfig.ToString();
                    break;
                case FileType.Image:
                    Properties.Settings.Default.ImageFilenameMask = filenameMask;
                    Properties.Settings.Default.ImageFilenameExtension = filenameExtension;
                    Properties.Settings.Default.ImageShowConfig = showConfig.ToString();
                    break;
            }

            Properties.Settings.Default.Save();
        }

        private string filenameMask { get; set; }
        public string FilenameMask
        {
            get
            {
                switch (_fileType)
                {
                    case FileType.Text:
                        return Properties.Settings.Default.TextFilenameMask;
                    case FileType.Image:
                        return Properties.Settings.Default.ImageFilenameMask;
                    default:
                        return string.Empty;
                }
            }
            set => filenameMask = value;
        }

        private string filenameExtension { get; set; }
        public string FilenameExtension
        {
            get
            {
                switch (_fileType)
                {
                    case FileType.Text:
                        return Properties.Settings.Default.TextFilenameExtension;
                    case FileType.Image:
                        return Properties.Settings.Default.ImageFilenameExtension;
                    default:
                        return string.Empty;
                }
            }
            set => filenameExtension = value;
        }

        private bool showConfig { get; set; }
        public bool ShowConfig
        {
            get
            {
                switch (_fileType)
                {
                    case FileType.Text:
                        return Convert.ToBoolean(Properties.Settings.Default.TextShowConfig);
                    case FileType.Image:
                        return Convert.ToBoolean(Properties.Settings.Default.ImageShowConfig);
                    default:
                        return false;
                }
            }
            set => showConfig = value;
        }

        private string mask { get; set; }
        public string Mask
        {
            get
            {
                switch (_fileType)
                {
                    case FileType.Text:
                        return Properties.Settings.Default.TextFilenameMask;
                    case FileType.Image:
                        return Properties.Settings.Default.ImageFilenameMask;
                    default:
                        return string.Empty;
                }
            }
            set => mask = value;
        }
    }
}
