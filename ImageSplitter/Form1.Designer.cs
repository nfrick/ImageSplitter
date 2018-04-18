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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nupLinhas = new System.Windows.Forms.NumericUpDown();
            this.nupColunas = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nupDistX = new System.Windows.Forms.NumericUpDown();
            this.nupDistY = new System.Windows.Forms.NumericUpDown();
            this.textBoxSourceFolder = new System.Windows.Forms.TextBox();
            this.textBoxTargetFolder = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonGetSourceFolder = new System.Windows.Forms.Button();
            this.buttonGetTargetFolder = new System.Windows.Forms.Button();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupLinhas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupColunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistY)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonProcessar
            // 
            this.buttonProcessar.Enabled = false;
            this.buttonProcessar.Location = new System.Drawing.Point(691, 23);
            this.buttonProcessar.Name = "buttonProcessar";
            this.buttonProcessar.Size = new System.Drawing.Size(107, 63);
            this.buttonProcessar.TabIndex = 0;
            this.buttonProcessar.Text = "Processar";
            this.buttonProcessar.UseVisualStyleBackColor = true;
            this.buttonProcessar.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Linhas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Colunas";
            // 
            // nupLinhas
            // 
            this.nupLinhas.Location = new System.Drawing.Point(112, 21);
            this.nupLinhas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupLinhas.Name = "nupLinhas";
            this.nupLinhas.Size = new System.Drawing.Size(69, 31);
            this.nupLinhas.TabIndex = 3;
            this.nupLinhas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupLinhas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // nupColunas
            // 
            this.nupColunas.Location = new System.Drawing.Point(112, 58);
            this.nupColunas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nupColunas.Name = "nupColunas";
            this.nupColunas.Size = new System.Drawing.Size(69, 31);
            this.nupColunas.TabIndex = 4;
            this.nupColunas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nupColunas.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Distância X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Distância Y";
            // 
            // nupDistX
            // 
            this.nupDistX.Location = new System.Drawing.Point(409, 21);
            this.nupDistX.Name = "nupDistX";
            this.nupDistX.Size = new System.Drawing.Size(69, 31);
            this.nupDistX.TabIndex = 7;
            this.nupDistX.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // nupDistY
            // 
            this.nupDistY.Location = new System.Drawing.Point(409, 55);
            this.nupDistY.Name = "nupDistY";
            this.nupDistY.Size = new System.Drawing.Size(69, 31);
            this.nupDistY.TabIndex = 8;
            this.nupDistY.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxSourceFolder
            // 
            this.textBoxSourceFolder.Enabled = false;
            this.textBoxSourceFolder.Location = new System.Drawing.Point(112, 95);
            this.textBoxSourceFolder.Name = "textBoxSourceFolder";
            this.textBoxSourceFolder.Size = new System.Drawing.Size(638, 31);
            this.textBoxSourceFolder.TabIndex = 9;
            // 
            // textBoxTargetFolder
            // 
            this.textBoxTargetFolder.Enabled = false;
            this.textBoxTargetFolder.Location = new System.Drawing.Point(112, 132);
            this.textBoxTargetFolder.Name = "textBoxTargetFolder";
            this.textBoxTargetFolder.Size = new System.Drawing.Size(638, 31);
            this.textBoxTargetFolder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Origem";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 12;
            this.label6.Text = "Destino";
            // 
            // buttonGetSourceFolder
            // 
            this.buttonGetSourceFolder.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonGetSourceFolder.Location = new System.Drawing.Point(756, 95);
            this.buttonGetSourceFolder.Name = "buttonGetSourceFolder";
            this.buttonGetSourceFolder.Size = new System.Drawing.Size(42, 31);
            this.buttonGetSourceFolder.TabIndex = 13;
            this.buttonGetSourceFolder.Text = "1";
            this.buttonGetSourceFolder.UseVisualStyleBackColor = true;
            this.buttonGetSourceFolder.Click += new System.EventHandler(this.buttonGetSourceFolder_Click);
            // 
            // buttonGetTargetFolder
            // 
            this.buttonGetTargetFolder.Font = new System.Drawing.Font("Wingdings", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.buttonGetTargetFolder.Location = new System.Drawing.Point(756, 132);
            this.buttonGetTargetFolder.Name = "buttonGetTargetFolder";
            this.buttonGetTargetFolder.Size = new System.Drawing.Size(42, 31);
            this.buttonGetTargetFolder.TabIndex = 14;
            this.buttonGetTargetFolder.Text = "1";
            this.buttonGetTargetFolder.UseVisualStyleBackColor = true;
            this.buttonGetTargetFolder.Click += new System.EventHandler(this.buttonGetTargetFolder_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(484, 57);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "pixels";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(484, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 25);
            this.label8.TabIndex = 15;
            this.label8.Text = "pixels";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 187);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.buttonGetTargetFolder);
            this.Controls.Add(this.buttonGetSourceFolder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTargetFolder);
            this.Controls.Add(this.textBoxSourceFolder);
            this.Controls.Add(this.nupDistY);
            this.Controls.Add(this.nupDistX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nupColunas);
            this.Controls.Add(this.nupLinhas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonProcessar);
            this.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Image Splitter";
            ((System.ComponentModel.ISupportInitialize)(this.nupLinhas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupColunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nupDistY)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nupLinhas;
        private System.Windows.Forms.NumericUpDown nupColunas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nupDistX;
        private System.Windows.Forms.NumericUpDown nupDistY;
        private System.Windows.Forms.TextBox textBoxSourceFolder;
        private System.Windows.Forms.TextBox textBoxTargetFolder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonGetSourceFolder;
        private System.Windows.Forms.Button buttonGetTargetFolder;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}

