using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;

namespace model_texture_base_color
{
    internal class Imagecreator
    {
        public int targetTaskCount = 4;
        public int CalculateSplitSize()
        {
            var largestSize = Math.Max(this.resultImage.Width, this.resultImage.Height);

            return (int)(largestSize / Math.Sqrt(this.targetTaskCount));
        }


        public bool alphaOnly;
        public Color threshold;
        public bool tiled;
        public double xScale;
        public double yScale;
        public Bitmap outLine;
        public Bitmap texture;


        private Random randSeeder = new Random();
        private bool _finished;
        private Task[] tasks;
        private Graphics gfx;

        public bool Finished { get => this._finished; }
        private Bitmap resultImage;
        public Bitmap Result { get => this.resultImage; }

        public Imagecreator(bool alphaOnly, Color threshold, bool tiled, double xScale, double yScale, Bitmap outLine, Bitmap texture)
        {
            this.alphaOnly = alphaOnly;
            this.threshold = threshold;
            this.tiled = tiled;
            this.xScale = xScale;
            this.yScale = yScale;
            this.outLine = outLine;
            this.texture = texture;

            this._finished = false;

            this.resultImage = new Bitmap(this.outLine.Width, this.outLine.Height);

            if (targetTaskCount == 0)
            {
                System.Diagnostics.Debug.WriteLine("is zero");
            }
        }

        private Task[] createTasks()
        {
            var tasks = new List<Task>();

            var widths = getSizes(this.outLine.Width);
            var heights = getSizes(this.outLine.Height);
            for (int i = 0; i < widths.Length; i++)
            {
                for (int j = 0; j < heights.Length; j++)
                {
                    var size = new Size(widths[i], heights[j]);
                    Point offset = new Point(
                        calculateOffset(widths, i),
                        calculateOffset(heights, j));
                    tasks.Add(imageTask(size, offset));
                }
            }

            return tasks.ToArray();
        }

        private static int calculateOffset(int[] widths, int i)
        {
            int x = 0;
            for (i--; i >= 0; i--)
            {
                x += widths[i];
            }
            return x;
        }

        private int[] getSizes(int target)
        {
            List<int> sizes = new List<int>();
            var splitSize = CalculateSplitSize();
            while (target >= splitSize)
            {
                sizes.Add(splitSize);
                target -= splitSize;
            }

            if (target != 0)
            {
                sizes.Add(target);
            }

            return sizes.ToArray();
        }

        public void Start()
        {
            this.gfx = Graphics.FromImage(this.resultImage);
            this.tasks = createTasks();
            
            
            foreach (var task in this.tasks)
            {
                task.Start();
            }

            waitForTasks();
        }
        private async void waitForTasks()
        {
            await Task.WhenAll(this.tasks);

            this._finished = true;
            this.gfx.Dispose();
        }

        private Task imageTask(Size size, Point offset)
        {
            var rand = new Random(this.randSeeder.Next());
            var outLine2 = new Bitmap(this.outLine);
            var texture2 = new Bitmap(this.texture);
            return new Task(() =>
            {
                Bitmap result = new Bitmap(size.Width, size.Height);
                var width = result.Width;
                var height = result.Height;
                for (int x = 0; x < width; x++)
                {
                    for (int y = 0; y < height; y++)
                    {
                        var xO = x + offset.X;
                        var yO = y + offset.Y;
                        Color outLineColor;
                        outLineColor = outLine2.GetPixel(xO, yO);
                        

                        Color resultColor;
                        if (updatePixel(this.alphaOnly, outLineColor, this.threshold))
                        {
                            resultColor = texturePixel(texture2, rand, xO, yO, this.tiled, this.xScale, this.yScale);
                            
                        }
                        else
                        {
                            resultColor= outLineColor;
                        }
                        result.SetPixel(x, y, resultColor);
                    }
                }

                lock(this.gfx)
                {
                    this.gfx.DrawImage(result, offset);
                }
                outLine2.Dispose();
                texture2.Dispose();
                result.Dispose();
            });
        }
        private static bool updatePixel(bool alphaOnly, Color outLineColor, Color threshold)
        {
            return (alphaOnly
                ? (outLineColor.A >= threshold.A)
                : (outLineColor.A >= threshold.A &&
                    outLineColor.R >= threshold.R &&
                    outLineColor.G >= threshold.G &&
                    outLineColor.B >= threshold.B));
        }

        private static Color texturePixel(Bitmap texture, Random rand, int xIn, int yIn, bool tiled, double xScale = 1, double yScale = 1)
        {
            int x, y;
            if (tiled)
            {
                x = (int)((xIn % (int)(texture.Width * xScale)) / xScale);
                y = (int)((yIn % (int)(texture.Height * yScale)) / yScale);
            }
            else
            {
                x = rand.Next(texture.Width);
                y = rand.Next(texture.Height);
            }

            return texture.GetPixel(x, y);
        }
    }
}