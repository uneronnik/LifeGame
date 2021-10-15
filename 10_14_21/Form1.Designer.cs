namespace _10_14_21
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.densityNum = new System.Windows.Forms.NumericUpDown();
            this.resolutionNum = new System.Windows.Forms.NumericUpDown();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.labelResolution = new System.Windows.Forms.Label();
            this.labelDensity = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.borderRadioButton1 = new System.Windows.Forms.RadioButton();
            this.borderRadioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.densityNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(26, 287);
            this.startButton.Margin = new System.Windows.Forms.Padding(6);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(150, 44);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(188, 287);
            this.stopButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(150, 44);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            // 
            // densityNum
            // 
            this.densityNum.Location = new System.Drawing.Point(26, 204);
            this.densityNum.Margin = new System.Windows.Forms.Padding(6);
            this.densityNum.Name = "densityNum";
            this.densityNum.Size = new System.Drawing.Size(312, 31);
            this.densityNum.TabIndex = 6;
            this.densityNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.densityNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // resolutionNum
            // 
            this.resolutionNum.Location = new System.Drawing.Point(28, 111);
            this.resolutionNum.Margin = new System.Windows.Forms.Padding(6);
            this.resolutionNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.resolutionNum.Name = "resolutionNum";
            this.resolutionNum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.resolutionNum.Size = new System.Drawing.Size(310, 31);
            this.resolutionNum.TabIndex = 7;
            this.resolutionNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.resolutionNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.borderRadioButton2);
            this.splitContainer1.Panel1.Controls.Add(this.borderRadioButton1);
            this.splitContainer1.Panel1.Controls.Add(this.labelResolution);
            this.splitContainer1.Panel1.Controls.Add(this.labelDensity);
            this.splitContainer1.Panel1.Controls.Add(this.resolutionNum);
            this.splitContainer1.Panel1.Controls.Add(this.startButton);
            this.splitContainer1.Panel1.Controls.Add(this.densityNum);
            this.splitContainer1.Panel1.Controls.Add(this.stopButton);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1386, 773);
            this.splitContainer1.SplitterDistance = 352;
            this.splitContainer1.SplitterWidth = 8;
            this.splitContainer1.TabIndex = 8;
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResolution.Location = new System.Drawing.Point(28, 79);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(125, 26);
            this.labelResolution.TabIndex = 9;
            this.labelResolution.Text = "Resolution";
            // 
            // labelDensity
            // 
            this.labelDensity.AutoSize = true;
            this.labelDensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDensity.Location = new System.Drawing.Point(28, 167);
            this.labelDensity.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelDensity.Name = "labelDensity";
            this.labelDensity.Size = new System.Drawing.Size(92, 26);
            this.labelDensity.TabIndex = 8;
            this.labelDensity.Text = "Density";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1026, 773);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // borderRadioButton1
            // 
            this.borderRadioButton1.AutoSize = true;
            this.borderRadioButton1.Location = new System.Drawing.Point(3, 366);
            this.borderRadioButton1.Name = "borderRadioButton1";
            this.borderRadioButton1.Size = new System.Drawing.Size(241, 29);
            this.borderRadioButton1.TabIndex = 10;
            this.borderRadioButton1.TabStop = true;
            this.borderRadioButton1.Text = "Обвести все клетки";
            this.borderRadioButton1.UseVisualStyleBackColor = true;
            // 
            // borderRadioButton2
            // 
            this.borderRadioButton2.AutoSize = true;
            this.borderRadioButton2.Checked = true;
            this.borderRadioButton2.Location = new System.Drawing.Point(6, 416);
            this.borderRadioButton2.Name = "borderRadioButton2";
            this.borderRadioButton2.Size = new System.Drawing.Size(346, 29);
            this.borderRadioButton2.TabIndex = 11;
            this.borderRadioButton2.TabStop = true;
            this.borderRadioButton2.Text = "Обвести только живые клетки";
            this.borderRadioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1386, 773);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.densityNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resolutionNum)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown densityNum;
        private System.Windows.Forms.NumericUpDown resolutionNum;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label labelDensity;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton borderRadioButton2;
        private System.Windows.Forms.RadioButton borderRadioButton1;
    }
}

