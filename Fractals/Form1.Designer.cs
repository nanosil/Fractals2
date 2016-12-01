namespace Fractals
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.loadingLabel = new System.Windows.Forms.Label();
            this.maxlabel = new System.Windows.Forms.Label();
            this.maxNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.yMinNumeric = new System.Windows.Forms.NumericUpDown();
            this.yMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.xMinNumeric = new System.Windows.Forms.NumericUpDown();
            this.xMaxNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upButton = new System.Windows.Forms.Button();
            this.DownBbutton = new System.Windows.Forms.Button();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.stepNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.inButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.stepZnumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepZnumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(650, 650);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(872, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // loadingLabel
            // 
            this.loadingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.loadingLabel.AutoSize = true;
            this.loadingLabel.Location = new System.Drawing.Point(875, 413);
            this.loadingLabel.Name = "loadingLabel";
            this.loadingLabel.Size = new System.Drawing.Size(64, 13);
            this.loadingLabel.TabIndex = 9;
            this.loadingLabel.Text = "LOADING...";
            this.loadingLabel.Visible = false;
            // 
            // maxlabel
            // 
            this.maxlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxlabel.AutoSize = true;
            this.maxlabel.Location = new System.Drawing.Point(707, 373);
            this.maxlabel.Name = "maxlabel";
            this.maxlabel.Size = new System.Drawing.Size(79, 13);
            this.maxlabel.TabIndex = 14;
            this.maxlabel.Text = "max func value";
            // 
            // maxNumericUpDown
            // 
            this.maxNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.maxNumericUpDown.DecimalPlaces = 2;
            this.maxNumericUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.maxNumericUpDown.Location = new System.Drawing.Point(801, 369);
            this.maxNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.maxNumericUpDown.Name = "maxNumericUpDown";
            this.maxNumericUpDown.Size = new System.Drawing.Size(51, 20);
            this.maxNumericUpDown.TabIndex = 15;
            this.maxNumericUpDown.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.maxNumericUpDown.ValueChanged += new System.EventHandler(this.maxNumericUpDown_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.yMinNumeric);
            this.groupBox1.Controls.Add(this.yMaxNumeric);
            this.groupBox1.Controls.Add(this.xMinNumeric);
            this.groupBox1.Controls.Add(this.xMaxNumeric);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(706, 445);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 149);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "window";
            // 
            // yMinNumeric
            // 
            this.yMinNumeric.DecimalPlaces = 3;
            this.yMinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yMinNumeric.Location = new System.Drawing.Point(172, 86);
            this.yMinNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.yMinNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.yMinNumeric.Name = "yMinNumeric";
            this.yMinNumeric.Size = new System.Drawing.Size(63, 20);
            this.yMinNumeric.TabIndex = 7;
            this.yMinNumeric.ValueChanged += new System.EventHandler(this.yMinNumeric_ValueChanged);
            // 
            // yMaxNumeric
            // 
            this.yMaxNumeric.DecimalPlaces = 3;
            this.yMaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.yMaxNumeric.Location = new System.Drawing.Point(70, 86);
            this.yMaxNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.yMaxNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.yMaxNumeric.Name = "yMaxNumeric";
            this.yMaxNumeric.Size = new System.Drawing.Size(63, 20);
            this.yMaxNumeric.TabIndex = 6;
            this.yMaxNumeric.ValueChanged += new System.EventHandler(this.yMaxNumeric_ValueChanged);
            // 
            // xMinNumeric
            // 
            this.xMinNumeric.DecimalPlaces = 3;
            this.xMinNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xMinNumeric.Location = new System.Drawing.Point(172, 52);
            this.xMinNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.xMinNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.xMinNumeric.Name = "xMinNumeric";
            this.xMinNumeric.Size = new System.Drawing.Size(63, 20);
            this.xMinNumeric.TabIndex = 5;
            this.xMinNumeric.ValueChanged += new System.EventHandler(this.xMinNumeric_ValueChanged);
            // 
            // xMaxNumeric
            // 
            this.xMaxNumeric.DecimalPlaces = 3;
            this.xMaxNumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.xMaxNumeric.Location = new System.Drawing.Point(70, 52);
            this.xMaxNumeric.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.xMaxNumeric.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            -2147483648});
            this.xMaxNumeric.Name = "xMaxNumeric";
            this.xMaxNumeric.Size = new System.Drawing.Size(63, 20);
            this.xMaxNumeric.TabIndex = 4;
            this.xMaxNumeric.ValueChanged += new System.EventHandler(this.xMaxNumeric_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Y";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(186, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "min";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "max";
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.Location = new System.Drawing.Point(789, 168);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(75, 23);
            this.upButton.TabIndex = 17;
            this.upButton.Text = "Up";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // DownBbutton
            // 
            this.DownBbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DownBbutton.Location = new System.Drawing.Point(789, 261);
            this.DownBbutton.Name = "DownBbutton";
            this.DownBbutton.Size = new System.Drawing.Size(75, 23);
            this.DownBbutton.TabIndex = 18;
            this.DownBbutton.Text = "Down";
            this.DownBbutton.UseVisualStyleBackColor = true;
            this.DownBbutton.Click += new System.EventHandler(this.DownBbutton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.leftButton.Location = new System.Drawing.Point(700, 218);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 19;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.rightButton.Location = new System.Drawing.Point(877, 218);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 20;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // stepNumericUpDown
            // 
            this.stepNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stepNumericUpDown.DecimalPlaces = 3;
            this.stepNumericUpDown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.stepNumericUpDown.Location = new System.Drawing.Point(799, 219);
            this.stepNumericUpDown.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stepNumericUpDown.Name = "stepNumericUpDown";
            this.stepNumericUpDown.Size = new System.Drawing.Size(54, 20);
            this.stepNumericUpDown.TabIndex = 21;
            this.stepNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // inButton
            // 
            this.inButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.inButton.Location = new System.Drawing.Point(700, 305);
            this.inButton.Name = "inButton";
            this.inButton.Size = new System.Drawing.Size(75, 23);
            this.inButton.TabIndex = 22;
            this.inButton.Text = "In";
            this.inButton.UseVisualStyleBackColor = true;
            this.inButton.Click += new System.EventHandler(this.inButton_Click);
            // 
            // outButton
            // 
            this.outButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.outButton.Location = new System.Drawing.Point(877, 303);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(75, 23);
            this.outButton.TabIndex = 23;
            this.outButton.Text = "Out";
            this.outButton.UseVisualStyleBackColor = true;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // stepZnumeric
            // 
            this.stepZnumeric.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stepZnumeric.DecimalPlaces = 3;
            this.stepZnumeric.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.stepZnumeric.Location = new System.Drawing.Point(789, 305);
            this.stepZnumeric.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.stepZnumeric.Name = "stepZnumeric";
            this.stepZnumeric.Size = new System.Drawing.Size(75, 20);
            this.stepZnumeric.TabIndex = 24;
            this.stepZnumeric.Value = new decimal(new int[] {
            4,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "label7";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(692, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 26);
            this.label1.TabIndex = 27;
            this.label1.Text = "resize window to set resolution and\n computing speed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 682);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.stepZnumeric);
            this.Controls.Add(this.outButton);
            this.Controls.Add(this.inButton);
            this.Controls.Add(this.stepNumericUpDown);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.DownBbutton);
            this.Controls.Add(this.upButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.maxNumericUpDown);
            this.Controls.Add(this.maxlabel);
            this.Controls.Add(this.loadingLabel);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yMinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMinNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xMaxNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepZnumeric)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label loadingLabel;
        private System.Windows.Forms.Label maxlabel;
        private System.Windows.Forms.NumericUpDown maxNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown yMinNumeric;
        private System.Windows.Forms.NumericUpDown yMaxNumeric;
        private System.Windows.Forms.NumericUpDown xMinNumeric;
        private System.Windows.Forms.NumericUpDown xMaxNumeric;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button DownBbutton;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.NumericUpDown stepNumericUpDown;
        private System.Windows.Forms.Button inButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.NumericUpDown stepZnumeric;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
    }
}

