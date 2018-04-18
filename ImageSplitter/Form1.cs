using Photoshop;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// http://www.joshwright.com/tips/automating-photoshop-with-c-
// https://stackoverflow.com/questions/11688761/cannot-be-embbedded-use-the-applicable-interface-instead

namespace ImageSplitter {
    public partial class Form1 : Form {
        private ApplicationClass app;
        private string _sourceFolder;
        private string _targetFolder;
        private int _imagesPerRow = 2;
        private int _imagesPerColumn = 2;
        private int _padRow;
        private int _padCol;
        private int _cellWidth; // The width, in px, of your image cell
        private int _cellHeight; // The height, in px, of your image cell
        private int _xOffset; // The space, in px, between each cell in a row
        private int _yOffset; // The space, in px, between each row. Set to 0 for traditional checker board effect
        private JPEGSaveOptions _jpegSaveOptions;

        public Form1() {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e) {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            app = new ApplicationClass { Visible = false };

            _jpegSaveOptions = new JPEGSaveOptions {
                FormatOptions = PsFormatOptionsType.psStandardBaseline,
                Matte = PsMatteType.psNoMatte,
                Quality = 12
            };

            // Store the current rulerUnits for later. We're going to change
            // it to pixels for now, and we want to change it back later.
            var myRulerUnits = app.Preferences.RulerUnits;

            //https://forums.adobe.com/thread/1246514

            // Set rulerUnits to pixels
            app.Preferences.RulerUnits = PsUnits.psPixels;

            _sourceFolder = textBoxSourceFolder.Text;
            _targetFolder = textBoxTargetFolder.Text;

            // Test outFolder, create if needed
            Directory.CreateDirectory(_targetFolder);

            var allFiles = Directory.GetFiles(_sourceFolder, "*.jpg", SearchOption.AllDirectories);

            foreach (var file in allFiles) {
                SplitPicture(file);
            }

            // Reset the ruler units
            app.Preferences.RulerUnits = myRulerUnits;
            app.Quit();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void SplitPicture(string fileName) {
            app.Open(fileName);
            var doc = app.ActiveDocument;
            var rowShift = true;
            var imageWidth = (int)app.ActiveDocument.Width;
            var imageHeight = (int)app.ActiveDocument.Height;

            _imagesPerRow = (int)nupColunas.Value;
            _imagesPerColumn = (int)nupLinhas.Value;

            _padRow = 1 + (int)Math.Log10(_imagesPerColumn);
            _padCol = 1 + (int)Math.Log10(_imagesPerRow);

            _xOffset = (int)nupDistX.Value;
            _yOffset = (int)nupDistY.Value;

            _cellWidth = imageWidth / _imagesPerRow;
            _cellHeight = imageHeight / _imagesPerColumn;

            // Find the "Background"
            var layerRef = doc.ArtLayers.Cast<ArtLayer>().FirstOrDefault(layer => doc.ArtLayers.Count == 1 || layer.Name == "Background");
            if (layerRef == null) return;

            // Set our "Background" to be a Layer
            layerRef.IsBackgroundLayer = false;

            // Reduce the Canvas size to our cell size
            doc.ResizeCanvas(_cellWidth, _cellHeight, PsAnchorPosition.psTopLeft);

            // Do the magic
            for (var y = 0; y < NumberOfRows(imageHeight, _cellHeight); y++) {
                var totalOffset = 0;

                for (var x = 0; x < NumberOfCells(imageWidth, rowShift); x++) {
                    var xMovement = 0;
                    if (x == 0) {
                        xMovement = (rowShift) ? _xOffset : 0;
                    }
                    else {
                        xMovement = _cellWidth + _xOffset;
                    }
                    totalOffset += xMovement;

                    // Offset the layer into our Canvas "window"
                    layerRef.ApplyOffset(-(xMovement), 0, PsOffsetUndefinedAreas.psOffsetWrapAround);
                    SaveCell(doc, x, y);
                };

                // Offset the layer back to the left and down one row
                layerRef.ApplyOffset(totalOffset, -(_cellHeight + _yOffset),
                    PsOffsetUndefinedAreas.psOffsetWrapAround);

                // Flip the rowShift. If it was true, make it false and vice versa.
                rowShift = !rowShift;
            };
            doc.Close(PsSaveOptions.psDoNotSaveChanges);
        }

        // Calculate number of cells per row. May change depending in rowShift, etc
        private int NumberOfCells(int imageWidth, bool rowShift) {
            var theWidth = (decimal)(imageWidth - (rowShift ? _xOffset : 0));
            return (int)Math.Floor((theWidth + _xOffset) / (_cellWidth + _xOffset));
        }

        // Calculate number of rows
        private int NumberOfRows(int imageHeight, int cellHeight) {
            return (int)Math.Floor(((decimal)imageHeight + _yOffset) / (cellHeight + _yOffset));
        }

        // Pad the cell x and y numbers for proper sorting
        private static string Pad(int num, int size) {
            var pattern = new string('0', size);
            return num.ToString(pattern);
        }

        // Actually save, or really "Save For Web" the cell
        private void SaveCell(Document doc, int x, int y) {
            var dname = doc.FullName.Substring(0, doc.FullName.Length - 4);
            var nname = dname.Replace(_sourceFolder, _targetFolder) +
                " " + Pad((x + 1), _padRow) + "_" + Pad((y + 1), _padCol) + ".jpg";
            var fInfo = new FileInfo(nname);
            var folderName = fInfo.Directory.FullName;
            Directory.CreateDirectory(folderName);
            doc.SaveAs(nname, _jpegSaveOptions, true, PsExtensionType.psLowercase);
        }

        private void buttonGetSourceFolder_Click(object sender, EventArgs e) {
            FBD.SelectedPath = textBoxSourceFolder.Text;
            if (FBD.ShowDialog() == DialogResult.Cancel) return;
            textBoxSourceFolder.Text = FBD.SelectedPath;
            buttonProcessar.Enabled =
                !string.IsNullOrEmpty(textBoxSourceFolder.Text) &&
                !string.IsNullOrEmpty(textBoxTargetFolder.Text);
        }

        private void buttonGetTargetFolder_Click(object sender, EventArgs e) {
            FBD.SelectedPath = textBoxTargetFolder.Text;
            if (FBD.ShowDialog() == DialogResult.Cancel) return;
            textBoxTargetFolder.Text = FBD.SelectedPath;
            buttonProcessar.Enabled =
                !string.IsNullOrEmpty(textBoxSourceFolder.Text) &&
                !string.IsNullOrEmpty(textBoxTargetFolder.Text);
        }
    }
}
