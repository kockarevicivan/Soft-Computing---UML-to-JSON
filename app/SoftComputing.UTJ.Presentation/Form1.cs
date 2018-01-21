using Newtonsoft.Json;
using SoftComputing.UTJ.BLL.Entities;
using SoftComputing.UTJ.BLL.Services;
using SoftComputing.UTJ.Presentation.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SoftComputing.UTJ.Presentation
{
    public partial class Form1 : Form
    {
        private SliceService _sliceService;
        private OCRService _ocrService;

        public Form1()
        {
            InitializeComponent();

            _sliceService = new SliceService();
            _ocrService = new OCRService();
        }

        private void chooseFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileHelper.ClearTempDirectory();
                    resultPicture.Image = _sliceService.Process(openFileDialog.FileName);

                    string[] filePaths = Directory.GetFiles("temp");

                    if (filePaths.Length == 0)
                    {
                        MessageBox.Show("No processed images found!");
                        return;
                    }

                    List<string> entityStrings = _ocrService.Process(filePaths.ToList());
                    List<Entity> entities = new List<Entity>();

                    foreach (string entityString in entityStrings)
                    {
                        entities.Add(new Entity(entityString));
                    }

                    string entitiesJson = JsonConvert.SerializeObject(entities, Formatting.Indented);

                    jsonTextbox.Text = entitiesJson;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
    }
}
