using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace ImageSplitter {
    public class ImageTile {
        private readonly Image _image;
        private Size _size;
        private readonly string _fileName;
        private readonly OutPutManager _outMgr;
        private readonly ImageCodecInfo _jpgEncoder;
        private readonly EncoderParameters _encoderParameters = new EncoderParameters(1);

        public ImageTile(string inputFile, OutPutManager outMgr) {
            if (!File.Exists(inputFile)) throw new FileNotFoundException();

            _jpgEncoder = GetEncoderInfo("image/jpeg");
            _outMgr = outMgr;
            _fileName = inputFile;
            _image = Image.FromFile(inputFile);
            var xSize = _outMgr.Cols;
            var ySize = _outMgr.Rows;

            _size = new Size(xSize, ySize);

            var myEncoder = Encoder.Quality;
            var myEncoderParameter = new EncoderParameter(myEncoder, outMgr.Quality);
            _encoderParameters.Param[0] = myEncoderParameter;

        }

        public void GenerateTiles() {
            var xMax = _image.Width;
            var yMax = _image.Height;
            var tileWidth = xMax / _size.Width;
            var tileHeight = yMax / _size.Height;

            for (var x = 0; x < _size.Width; x++) {
                for (var y = 0; y < _size.Height; y++) {
                    var outputFileName = _outMgr.GetFileName(_fileName, x, y);

                    var tileBounds = new Rectangle(x * tileWidth, y * tileHeight, tileWidth, tileHeight);
                    var target = new Bitmap(tileWidth, tileHeight);

                    using (var graphics = Graphics.FromImage(target)) {
                        graphics.DrawImage(
                            _image,
                            new Rectangle(0, 0, tileWidth, tileHeight),
                            tileBounds,
                            GraphicsUnit.Pixel);
                    }

                    target.Save(outputFileName,
                        _jpgEncoder,
                        _encoderParameters);
                }
            }
        }

        private static ImageCodecInfo GetEncoderInfo(string mimeType) {
            int j;
            var encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j) {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}
