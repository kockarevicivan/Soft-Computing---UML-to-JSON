using AForge;
using AForge.Imaging;
using AForge.Imaging.Filters;
using AForge.Math.Geometry;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftComputing.UTJ.BLL.Services
{
    public class SliceService
    {
        public Bitmap Process(string imagePath)
        {
            Bitmap image = PreProcess((Bitmap)Bitmap.FromFile(imagePath));
            Bitmap fakeImage = new Bitmap(image.Width, image.Height);


            BlobCounter blobCounter = new BlobCounter();
            blobCounter.FilterBlobs = true;
            blobCounter.MinHeight = 80;
            blobCounter.MinWidth = 80;

            blobCounter.ProcessImage(image);

            Blob[] blobs = blobCounter.GetObjectsInformation();

            var maxArea = blobs.Max(b => b.Area);
            blobs = blobs.Where(b => b.Area != maxArea).ToArray();

            // check for rectangles
            SimpleShapeChecker shapeChecker = new SimpleShapeChecker();

            Graphics g = Graphics.FromImage(fakeImage);
            g.DrawImage(image, 0, 0, image.Width, image.Height);

            foreach (var blob in blobs)
            {
                Bitmap cropped = Crop(image, blob.Rectangle.X, blob.Rectangle.Y, blob.Rectangle.Width, blob.Rectangle.Height);

                cropped.Save(@"temp/" + DateTime.Now.Ticks + ".png");

                List<IntPoint> edgePoints = blobCounter.GetBlobsEdgePoints(blob);
                List<IntPoint> cornerPoints;

                shapeChecker.IsQuadrilateral(edgePoints, out cornerPoints);
                
                List<System.Drawing.Point> Points = new List<System.Drawing.Point>();
                foreach (var point in cornerPoints)
                {
                    Points.Add(new System.Drawing.Point(point.X, point.Y));
                }


                g.DrawPolygon(new Pen(Color.Red, 5.0f), Points.ToArray());
            }
            
            return fakeImage;
        }

        private Bitmap Crop(Bitmap image, int x, int y, int width, int height)
        {
            Crop filter = new Crop(new Rectangle(x, y, width, height));
            return filter.Apply(image);
        }

        private Bitmap PreProcess(Bitmap bmp)
        {
            Grayscale gfilter = new Grayscale(0.2125, 0.7154, 0.0721);
            BradleyLocalThresholding thfilter = new BradleyLocalThresholding();

            bmp = gfilter.Apply(bmp);
            thfilter.ApplyInPlace(bmp);

            return bmp;
        }
    }
}

