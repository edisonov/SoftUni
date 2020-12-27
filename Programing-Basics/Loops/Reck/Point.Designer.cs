namespace Reck
{
    partial class Point
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelRectangle = new System.Windows.Forms.Label();
            this.labelX1 = new System.Windows.Forms.Label();
            this.numericUpDownX1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownY1 = new System.Windows.Forms.NumericUpDown();
            this.labelY1 = new System.Windows.Forms.Label();
            this.numericUpDownY2 = new System.Windows.Forms.NumericUpDown();
            this.labelY2 = new System.Windows.Forms.Label();
            this.numericUpDownX2 = new System.Windows.Forms.NumericUpDown();
            this.labelX2 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.labelY = new System.Windows.Forms.Label();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.labelX = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.butondraw = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelRectangle
            // 
            this.labelRectangle.AutoSize = true;
            this.labelRectangle.Location = new System.Drawing.Point(13, 18);
            this.labelRectangle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangle.Name = "labelRectangle";
            this.labelRectangle.Size = new System.Drawing.Size(86, 20);
            this.labelRectangle.TabIndex = 0;
            this.labelRectangle.Text = "Rectangle:";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.Location = new System.Drawing.Point(13, 50);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(34, 20);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "x1=";
            // 
            // numericUpDownX1
            // 
            this.numericUpDownX1.DecimalPlaces = 2;
            this.numericUpDownX1.Location = new System.Drawing.Point(53, 48);
            this.numericUpDownX1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX1.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX1.Name = "numericUpDownX1";
            this.numericUpDownX1.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownX1.TabIndex = 2;
            this.numericUpDownX1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownX1.ValueChanged += new System.EventHandler(this.numericUpDownX1_ValueChanged);
            // 
            // numericUpDownY1
            // 
            this.numericUpDownY1.DecimalPlaces = 2;
            this.numericUpDownY1.Location = new System.Drawing.Point(53, 80);
            this.numericUpDownY1.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY1.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.Name = "numericUpDownY1";
            this.numericUpDownY1.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownY1.TabIndex = 4;
            this.numericUpDownY1.Value = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.numericUpDownY1.ValueChanged += new System.EventHandler(this.numericUpDownY1_ValueChanged);
            // 
            // labelY1
            // 
            this.labelY1.AutoSize = true;
            this.labelY1.Location = new System.Drawing.Point(13, 82);
            this.labelY1.Name = "labelY1";
            this.labelY1.Size = new System.Drawing.Size(34, 20);
            this.labelY1.TabIndex = 3;
            this.labelY1.Text = "y1=";
            // 
            // numericUpDownY2
            // 
            this.numericUpDownY2.DecimalPlaces = 2;
            this.numericUpDownY2.Location = new System.Drawing.Point(53, 144);
            this.numericUpDownY2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY2.Name = "numericUpDownY2";
            this.numericUpDownY2.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownY2.TabIndex = 8;
            this.numericUpDownY2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDownY2.ValueChanged += new System.EventHandler(this.numericUpDownY2_ValueChanged);
            // 
            // labelY2
            // 
            this.labelY2.AutoSize = true;
            this.labelY2.Location = new System.Drawing.Point(13, 146);
            this.labelY2.Name = "labelY2";
            this.labelY2.Size = new System.Drawing.Size(34, 20);
            this.labelY2.TabIndex = 7;
            this.labelY2.Text = "y2=";
            // 
            // numericUpDownX2
            // 
            this.numericUpDownX2.DecimalPlaces = 2;
            this.numericUpDownX2.Location = new System.Drawing.Point(53, 112);
            this.numericUpDownX2.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX2.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX2.Name = "numericUpDownX2";
            this.numericUpDownX2.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownX2.TabIndex = 6;
            this.numericUpDownX2.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.numericUpDownX2.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.Location = new System.Drawing.Point(13, 114);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(34, 20);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "x2=";
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.DecimalPlaces = 2;
            this.numericUpDownY.Location = new System.Drawing.Point(53, 244);
            this.numericUpDownY.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownY.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownY.TabIndex = 13;
            this.numericUpDownY.Value = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // labelY
            // 
            this.labelY.AutoSize = true;
            this.labelY.Location = new System.Drawing.Point(13, 246);
            this.labelY.Name = "labelY";
            this.labelY.Size = new System.Drawing.Size(29, 20);
            this.labelY.TabIndex = 12;
            this.labelY.Text = "y =";
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.DecimalPlaces = 2;
            this.numericUpDownX.Location = new System.Drawing.Point(53, 212);
            this.numericUpDownX.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownX.Minimum = new decimal(new int[] {
            10000000,
            0,
            0,
            -2147483648});
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(82, 26);
            this.numericUpDownX.TabIndex = 11;
            this.numericUpDownX.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Location = new System.Drawing.Point(13, 214);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(29, 20);
            this.labelX.TabIndex = 10;
            this.labelX.Text = "x =";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 182);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Point:";
            // 
            // butondraw
            // 
            this.butondraw.Location = new System.Drawing.Point(12, 289);
            this.butondraw.Name = "butondraw";
            this.butondraw.Size = new System.Drawing.Size(123, 37);
            this.butondraw.TabIndex = 14;
            this.butondraw.Text = "Draw";
            this.butondraw.UseVisualStyleBackColor = true;
            this.butondraw.Click += new System.EventHandler(this.butondraw_Click);
            // 
            // labelResult
            // 
            this.labelResult.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelResult.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResult.Location = new System.Drawing.Point(13, 339);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(122, 33);
            this.labelResult.TabIndex = 15;
            this.labelResult.Text = "Result";
            this.labelResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(165, 18);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(300, 220);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(518, 370);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Point
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 400);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.butondraw);
            this.Controls.Add(this.numericUpDownY);
            this.Controls.Add(this.labelY);
            this.Controls.Add(this.numericUpDownX);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownY2);
            this.Controls.Add(this.labelY2);
            this.Controls.Add(this.numericUpDownX2);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.numericUpDownY1);
            this.Controls.Add(this.labelY1);
            this.Controls.Add(this.numericUpDownX1);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.labelRectangle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(400, 320);
            this.Name = "Point";
            this.Text = "Point";
            this.Load += new System.EventHandler(this.Point_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRectangle;
        private System.Windows.Forms.Label labelX1;
        private System.Windows.Forms.NumericUpDown numericUpDownX1;
        private System.Windows.Forms.NumericUpDown numericUpDownY1;
        private System.Windows.Forms.Label labelY1;
        private System.Windows.Forms.NumericUpDown numericUpDownY2;
        private System.Windows.Forms.Label labelY2;
        private System.Windows.Forms.NumericUpDown numericUpDownX2;
        private System.Windows.Forms.Label labelX2;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.Label labelY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button butondraw;
        private System.Windows.Forms.Label labelResult;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

