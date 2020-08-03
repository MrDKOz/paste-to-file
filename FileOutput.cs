using PasteToFile.DataTypes;
using PasteToFile.Helpers;
using System;
using System.IO;
using System.Windows.Forms;

namespace PasteToFile
{
    public partial class FileOutput : Form
    {
        private readonly FileType _fileTypeFocused;
        private readonly FilenameMask _mask = new FilenameMask();
        private readonly Settings _settings;
        private readonly string _outputDirectory;

        private readonly Text _text = new Text();
        private readonly Image _image = new Image();

        public FileOutput(FileType fileType, string outputDirectory)
        {
            InitializeComponent();

            _fileTypeFocused = fileType;
            _outputDirectory = outputDirectory;
            _settings = new Settings(_fileTypeFocused);

            // Configure the UI
            LoadSettings();
        }

        /// <summary>
        /// Loads the settings and configures the UI.
        /// </summary>
        private void LoadSettings()
        {
            // Load UI data
            Text = $"Paste to File [{_fileTypeFocused}]";
            lblTitle.Text = _fileTypeFocused.ToString();
            lblInformation.Text = $"One time output settings for detected file type of {_fileTypeFocused}.";
            LoadExtensions();

            // Load config
            tboxFilename.Text = _mask.Generate(_mask.Generate(_settings.FilenameMask));
            cboxExtension.Text = _settings.FilenameExtension;
        }

        /// <summary>
        /// Loads the supported extensions for the selected file type.
        /// </summary>
        private void LoadExtensions()
        {
            var bindingSource = new BindingSource();

            switch (_fileTypeFocused)
            {
                case FileType.Text:
                    bindingSource.DataSource = Output.TextExtensions();
                    break;
                case FileType.Image:
                    bindingSource.DataSource = Output.ImageExtensions();
                    break;
                default:
                    throw new Exception("Invalid File Type passed when fetching extensions.");
            }

            cboxExtension.DataSource = bindingSource;
        }

        /// <summary>
        /// Writes out the file using the given configuration and closes the window.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tboxFilename.Text))
            {
                MessageBox.Show("A filename must be provided to create the file.");
                return;
            }

            SetAsDefault();

            CreateFile();
            Close();
        }

        private void CreateFile()
        {
            var fullFilePath = Path.Combine(_outputDirectory, $"{tboxFilename.Text}.{cboxExtension.Text}");

            switch (_fileTypeFocused)
            {
                case FileType.Text:
                    _text.WriteOut(fullFilePath);
                    break;
                case FileType.Image:
                    _image.WriteOut(fullFilePath);
                    break;
            }
        }

        /// <summary>
        /// Check if we should use these settings next time without confirming.
        /// </summary>
        private void SetAsDefault()
        {
            if (!chkSetAsDefault.Checked) return;

            switch (_fileTypeFocused)
            {
                case FileType.Text:
                    Properties.Settings.Default.TextFilenameExtension = cboxExtension.Text;
                    Properties.Settings.Default.TextShowConfig = "false";
                    break;
                case FileType.Image:
                    Properties.Settings.Default.ImageFilenameExtension = cboxExtension.Text;
                    Properties.Settings.Default.ImageShowConfig = "false";
                    break;
                default:
                    throw new Exception("Invalid File Type passed when setting defaults.");
            }

            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Close this window, and don't create file.
        /// </summary>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
