using System;
using System.IO;

namespace ImageSplitter {
    public class OutPutManager {
        private readonly string _sourceFolder;
        private readonly string _targetFolder;
        private readonly int _padRow;
        private readonly int _padCol;
        public int Rows { get; set; }
        public int Cols { get; set; }
        public int Quality { get; }

        public OutPutManager(string source, string target, int rows, int cols, int quality) {
            _sourceFolder = source;
            _targetFolder = target;
            Quality = quality;
            Rows = rows;
            Cols = cols;
            _padRow = 1 + (int)Math.Log10(rows);
            _padCol = 1 + (int)Math.Log10(cols);
            // Test outFolder, create if needed
            Directory.CreateDirectory(_targetFolder);
        }

        public string GetFileName(string sourceName, int x, int y) {
            var dname = sourceName.Substring(0, sourceName.Length - 4);
            var nname = dname.Replace(_sourceFolder, _targetFolder) +
                        " " + Pad((x + 1), _padRow) + "_" + Pad((y + 1), _padCol) + ".jpg";
            var fInfo = new FileInfo(nname);
            var folderName = fInfo.Directory.FullName;
            Directory.CreateDirectory(folderName);
            return nname;
        }

        // Pad the cell x and y numbers for proper sorting
        private static string Pad(int num, int size) {
            var pattern = new string('0', size);
            return num.ToString(pattern);
        }

        public string[] GetAllFiles() {
            return Directory.GetFiles(_sourceFolder, "*.jpg", SearchOption.AllDirectories);
        }
    }
}
