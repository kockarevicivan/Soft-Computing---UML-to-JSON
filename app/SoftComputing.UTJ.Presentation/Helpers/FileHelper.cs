using System.IO;

namespace SoftComputing.UTJ.Presentation.Helpers
{
    public static class FileHelper
    {
        public static void ClearTempDirectory()
        {
            DirectoryInfo di = new DirectoryInfo("temp");

            foreach (FileInfo file in di.GetFiles())
            {
                file.Delete();
            }
            foreach (DirectoryInfo dir in di.GetDirectories())
            {
                dir.Delete(true);
            }
        }
    }
}
