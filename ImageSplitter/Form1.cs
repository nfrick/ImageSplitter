using Photoshop;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Windows.Forms;

// http://www.joshwright.com/tips/automating-photoshop-with-c-
// https://stackoverflow.com/questions/11688761/cannot-be-embbedded-use-the-applicable-interface-instead

namespace ImageSplitter {
    public partial class Form1 : Form {
        private ApplicationClass app;
        private OutPutManager _OutMgr;
        private int _cellWidth; // The width, in px, of your image cell
        private int _cellHeight; // The height, in px, of your image cell
        private int _xOffset; // The space, in px, between each cell in a row
        private int _yOffset; // The space, in px, between each row. Set to 0 for traditional checker board effect
        private JPEGSaveOptions _jpegSaveOptions;

        public Form1() {
            InitializeComponent();
        }

        private OutPutManager SetOutPutManager() {
            return new OutPutManager(textBoxSourceFolder.Text, textBoxTargetFolder.Text,
                (int)nupLinhas.Value, (int)nupColunas.Value,
                trackBarQuality.Value);
        }

        private void btnStart_Click(object sender, EventArgs e) {
            // Set cursor as hourglass
            Cursor.Current = Cursors.WaitCursor;

            _OutMgr = SetOutPutManager();
            if (radioButtonPhotoshop.Checked)
                ProcessPhotoshop();
            else
                ProcessCode();

            // Set cursor as default arrow
            Cursor.Current = Cursors.Default;
        }

        private void ProcessPhotoshop() {
            app = new ApplicationClass { Visible = false };

            _jpegSaveOptions = new JPEGSaveOptions {
                FormatOptions = PsFormatOptionsType.psStandardBaseline,
                Matte = PsMatteType.psNoMatte,
                Quality = _OutMgr.Quality
            };

            // Store the current rulerUnits for later. We're going to change
            // it to pixels for now, and we want to change it back later.
            var myRulerUnits = app.Preferences.RulerUnits;

            //https://forums.adobe.com/thread/1246514

            // Set rulerUnits to pixels
            app.Preferences.RulerUnits = PsUnits.psPixels;

            foreach (var file in _OutMgr.GetAllFiles()) {
                SplitPicture(file);
            }

            // Reset the ruler units
            app.Preferences.RulerUnits = myRulerUnits;
            app.Quit();
        }

        private void SplitPicture(string fileName) {
            app.Open(fileName);
            var doc = app.ActiveDocument;
            var rowShift = true;
            var imageWidth = (int)app.ActiveDocument.Width;
            var imageHeight = (int)app.ActiveDocument.Height;

            _xOffset = (int)nupDistX.Value;
            _yOffset = (int)nupDistY.Value;

            _cellWidth = imageWidth / _OutMgr.Cols;
            _cellHeight = imageHeight / _OutMgr.Rows;

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

        // Actually save, or really "Save For Web" the cell
        private void SaveCell(Document doc, int x, int y) {
            var nname = _OutMgr.GetFileName(doc.FullName, x, y);
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

        private void ProcessCode() {
            foreach (var file in _OutMgr.GetAllFiles()) {
                var it = new ImageTile(file, _OutMgr);
                it.GenerateTiles();
            }
        }

        private void radioButtonMethod_CheckedChanged(object sender, EventArgs e) {
            var rbtn = sender as RadioButton;
            if (rbtn.Name == @"radioButtonPhotoshop" && rbtn.Checked) {
                trackBarQuality.Value = (int)Math.Ceiling((double)trackBarQuality.Value * 0.12);
                trackBarQuality.Maximum = 12;
            }
            else if (rbtn.Name == @"radioButtonCode" && rbtn.Checked) {
                trackBarQuality.Maximum = 100;
                trackBarQuality.Value = (int)Math.Ceiling((double)trackBarQuality.Value / 0.12);
            }

        }

        private void trackBarQuality_ValueChanged(object sender, EventArgs e) {
            groupBox4.Text = $@"Qualidade: {trackBarQuality.Value}";
        }
    }
}
