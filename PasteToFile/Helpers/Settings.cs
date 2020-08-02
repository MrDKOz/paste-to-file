using System;

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
                    Properties.Settings.Default.TextChooseExtension = chooseExtension.ToString();
                    break;
                case FileType.Image:
                    Properties.Settings.Default.ImageFilenameMask = filenameMask;
                    Properties.Settings.Default.ImageFilenameExtension = filenameExtension;
                    Properties.Settings.Default.ImageChooseExtension = chooseExtension.ToString();
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

        private bool chooseExtension { get; set; }
        public bool ChooseExtension
        {
            get
            {
                switch (_fileType)
                {
                    case FileType.Text:
                        return Convert.ToBoolean(Properties.Settings.Default.TextChooseExtension);
                    case FileType.Image:
                        return Convert.ToBoolean(Properties.Settings.Default.ImageChooseExtension);
                    default:
                        return false;
                }
            }
            set => chooseExtension = value;
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
