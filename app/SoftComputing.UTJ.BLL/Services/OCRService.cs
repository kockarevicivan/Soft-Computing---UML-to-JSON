using System.Collections.Generic;
using Tesseract;

namespace SoftComputing.UTJ.BLL.Services
{
    public class OCRService
    {
        public List<string> Process(List<string> imagePaths)
        {
            List<string> entityStrings = new List<string>();

            using (var engine = new TesseractEngine(@"../../../tessdata", "eng", EngineMode.Default))
            {
                foreach (string imagePath in imagePaths)
                {
                    using (var img = Pix.LoadFromFile(imagePath))
                    {
                        using (var page = engine.Process(img))
                        {
                            entityStrings.Add(page.GetText());
                        }
                    }
                }
            }

            return entityStrings;
        }
    }
}
