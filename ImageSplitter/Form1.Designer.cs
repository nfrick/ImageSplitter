namespace ImageSplitter {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.buttonProcessar = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nupColunas = new System.Windows.Forms.NumericUpDown();
            this.nupLinhas = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nupDistY = new System.Windows.Forms.NumericUpDown();
            this.nupDistX = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonCode = new System.Windows.Forms.RadioButton();
            this.radioButtonPhotoshop = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGetTargetFolder = new System.Windows.Forms.Button();
            this.buttonGetSourceFolder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLinhas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistX)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.Enabled = false;
            this.buttonProcessar.Location = new System.Drawing.Point(665, 20);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(107, 63);
            this.buttonProcessar.TabIndex = 0;
            this.buttonProcessar.Text = "Processar";
            this.buttonProcessar.UseVisualStyleBackColor = true;
            this.buttonProcessar.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nupColunas);
            this.groupBox1.Controls.Add(this.nupLinhas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 105);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dividir em";
            // 
            // nupColunas
            // 
            this.nupColunas.Location = new System.Drawing.Point(108, 59);
            this.nupColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupColunas.Name = "nupColunas";
            this.nupColunas.Size = new System.Drawing.Size(57, 31);
            this.nupColunas.TabIndex = 8;
            this.nupColunas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupColunas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nupLinhas
            // 
            this.nupLinhas.Location = new System.Drawing.Point(108, 25);
            this.nupLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupLinhas.Name = "nupLinhas";
            this.nupLinhas.Size = new System.Drawing.Size(57, 31);
            this.nupLinhas.TabIndex = 7;
            this.nupLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupLinhas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Colunas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Linhas";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nupDistY);
            this.groupBox2.Controls.Add(this.nupDistX);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 105);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Margens (pixels)";
            // 
            // nupDistY
            // 
            this.nupDistY.Location = new System.Drawing.Point(128, 59);
            this.nupDistY.Name = "nupDistY";
            this.nupDistY.Size = new System.Drawing.Size(57, 31);
            this.nupDistY.TabIndex = 12;
            this.nupDistY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupDistX
            // 
            this.nupDistX.Location = new System.Drawing.Point(128, 25);
            this.nupDistX.Name = "nupDistX";
            this.nupDistX.Size = new System.Drawing.Size(57, 31);
            this.nupDistX.TabIndex = 11;
            this.nupDistX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 25);
            this.label4.TabIndex = 10;
            this.label4.Text = "Vertical";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Horizontal";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonCode);
            this.groupBox3.Controls.Add(this.radioButtonPhotoshop);
            this.groupBox3.Location = new System.Drawing.Point(439, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(174, 105);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Método";
            // 
            // radioButtonCode
            // 
            this.radioButtonCode.AutoSize = true;
            this.radioButtonCode.Location = new System.Drawing.Point(28, 57);
            this.radioButtonCode.Name = "radioButtonCode";
            this.radioButtonCode.Size = new System.Drawing.Size(94, 29);
            this.radioButtonCode.TabIndex = 21;
            this.radioButtonCode.Text = "Código";
            this.radioButtonCode.UseVisualStyleBackColor = true;
            this.radioButtonCode.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // radioButtonPhotoshop
            // 
            this.radioButtonPhotoshop.AutoSize = true;
            this.radioButtonPhotoshop.Checked = true;
            this.radioButtonPhotoshop.Location = new System.Drawing.Point(28, 25);
            this.radioButtonPhotoshop.Name = "radioButtonPhotoshop";
            this.radioButtonPhotoshop.Size = new System.Drawing.Size(124, 29);
            this.radioButtonPhotoshop.TabIndex = 20;
            this.radioButtonPhotoshop.TabStop = true;
            this.radioButtonPhotoshop.Text = "Photoshop";
            this.radioButtonPhotoshop.UseVisualStyleBackColor = true;
            this.radioButtonPhotoshop.CheckedChanged += new System.EventHandler(this.radioButtonMethod_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.trackBarQuality);
            this.groupBox4.Location = new System.Drawing.Point(12, 132);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(601, 102);
            this.groupBox4.TabIndex = 26;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Qualidade: 12";
            // 
            // trackBarQuality
            // 
            this.trackBarQuality.Location = new System.Drawing.Point(28, 30);
            this.trackBarQuality.Maximum = 12;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(551, 56);
            this.trackBarQuality.TabIndex = 26;
            this.trackBarQuality.Value = 12;
            this.trackBarQuality.ValueChanged += new System.EventHandler(this.trackBarQuality_ValueChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonGetTargetFolder);
            this.groupBox5.Controls.Add(this.buttonGetSourceFolder);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxTargetFolder);
            this.groupBox5.Controls.Add(this.textBoxSourceFolder);
            this.groupBox5.Location = new System.Drawing.Point(12, 250);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(760, 114);
            this.groupBox5.TabIndex = 27;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Diretórios";
            // 
            // buttonGetTargetFolder
            // 
            this.buttonGetTargetFolder.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonGetTargetFolder.Location = new System.Drawing.Point(700, 67);
            this.buttonGetTargetFolder.Name = "buttonGetTargetFolder";
            this.buttonGetTargetFolder.Size = new System.Drawing.Size(42, 31);
            this.buttonGetTargetFolder.TabIndex = 20;
            this.buttonGetTargetFolder.Text = "1";
            this.buttonGetTargetFolder.UseVisualStyleBackColor = true;
            this.buttonGetTargetFolder.Click += new System.EventHandler(this.buttonGetTargetFolder_Click);
            // 
            // buttonGetSourceFolder
            // 
            this.buttonGetSourceFolder.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonGetSourceFolder.Location = new System.Drawing.Point(700, 27);
            this.buttonGetSourceFolder.Name = "buttonGetSourceFolder";
            this.buttonGetSourceFolder.Size = new System.Drawing.Size(42, 31);
            this.buttonGetSourceFolder.TabIndex = 19;
            this.buttonGetSourceFolder.Text = "1";
            this.buttonGetSourceFolder.UseVisualStyleBackColor = true;
            this.buttonGetSourceFolder.Click += new System.EventHandler(this.buttonGetSourceFolder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Destino";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Origem";
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Enabled = false;
            this.textBoxTargetFolder.Location = new System.Drawing.Point(108, 67);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(586, 31);
            this.textBoxTargetFolder.TabIndex = 16;
            this.textBoxTargetFolder.Text = "D:\\teste\\out";
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Enabled = false;
            this.textBoxSourceFolder.Location = new System.Drawing.Point(108, 30);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(586, 31);
            this.textBoxSourceFolder.TabIndex = 15;
            this.textBoxSourceFolder.Text = "D:\\teste";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 378);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonProcessar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Image Splitter";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupLinhas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistX)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessar;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nupColunas;
        private System.Windows.Forms.NumericUpDown nupLinhas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown nupDistY;
        private System.Windows.Forms.NumericUpDown nupDistX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButtonCode;
        private System.Windows.Forms.RadioButton radioButtonPhotoshop;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGetTargetFolder;
        private System.Windows.Forms.Button buttonGetSourceFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
    }
}

