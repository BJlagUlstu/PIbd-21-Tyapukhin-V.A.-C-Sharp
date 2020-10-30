namespace WindowsFormsMonorail
{
    partial class FormTrainConfig
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
            this.pictureBoxTrainConfig = new System.Windows.Forms.PictureBox();
            this.groupBoxTrainConfig = new System.Windows.Forms.GroupBox();
            this.checkBoxSportLine = new System.Windows.Forms.CheckBox();
            this.checkBoxBottomMonorail = new System.Windows.Forms.CheckBox();
            this.checkBoxHeadlights = new System.Windows.Forms.CheckBox();
            this.numericUpDownTrainWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelTrainWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBoxTrainType = new System.Windows.Forms.GroupBox();
            this.labelMonorail = new System.Windows.Forms.Label();
            this.labelTrain = new System.Windows.Forms.Label();
            this.panelTrainConfig = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGrey = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelAdditionalColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainConfig)).BeginInit();
            this.groupBoxTrainConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrainWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            this.groupBoxTrainType.SuspendLayout();
            this.panelTrainConfig.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxTrainConfig
            // 
            this.pictureBoxTrainConfig.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxTrainConfig.Location = new System.Drawing.Point(13, 12);
            this.pictureBoxTrainConfig.Name = "pictureBoxTrainConfig";
            this.pictureBoxTrainConfig.Size = new System.Drawing.Size(294, 85);
            this.pictureBoxTrainConfig.TabIndex = 0;
            this.pictureBoxTrainConfig.TabStop = false;
            // 
            // groupBoxTrainConfig
            // 
            this.groupBoxTrainConfig.Controls.Add(this.checkBoxSportLine);
            this.groupBoxTrainConfig.Controls.Add(this.checkBoxBottomMonorail);
            this.groupBoxTrainConfig.Controls.Add(this.checkBoxHeadlights);
            this.groupBoxTrainConfig.Controls.Add(this.numericUpDownTrainWeight);
            this.groupBoxTrainConfig.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxTrainConfig.Controls.Add(this.labelTrainWeight);
            this.groupBoxTrainConfig.Controls.Add(this.labelMaxSpeed);
            this.groupBoxTrainConfig.Location = new System.Drawing.Point(12, 134);
            this.groupBoxTrainConfig.Name = "groupBoxTrainConfig";
            this.groupBoxTrainConfig.Size = new System.Drawing.Size(419, 115);
            this.groupBoxTrainConfig.TabIndex = 1;
            this.groupBoxTrainConfig.TabStop = false;
            this.groupBoxTrainConfig.Text = "Parameters";
            // 
            // checkBoxSportLine
            // 
            this.checkBoxSportLine.AutoSize = true;
            this.checkBoxSportLine.Location = new System.Drawing.Point(260, 76);
            this.checkBoxSportLine.Name = "checkBoxSportLine";
            this.checkBoxSportLine.Size = new System.Drawing.Size(71, 17);
            this.checkBoxSportLine.TabIndex = 6;
            this.checkBoxSportLine.Text = "SportLine";
            this.checkBoxSportLine.UseVisualStyleBackColor = true;
            // 
            // checkBoxBottomMonorail
            // 
            this.checkBoxBottomMonorail.AutoSize = true;
            this.checkBoxBottomMonorail.Location = new System.Drawing.Point(260, 53);
            this.checkBoxBottomMonorail.Name = "checkBoxBottomMonorail";
            this.checkBoxBottomMonorail.Size = new System.Drawing.Size(102, 17);
            this.checkBoxBottomMonorail.TabIndex = 5;
            this.checkBoxBottomMonorail.Text = "Bottom Monorail";
            this.checkBoxBottomMonorail.UseVisualStyleBackColor = true;
            // 
            // checkBoxHeadlights
            // 
            this.checkBoxHeadlights.AutoSize = true;
            this.checkBoxHeadlights.Location = new System.Drawing.Point(260, 30);
            this.checkBoxHeadlights.Name = "checkBoxHeadlights";
            this.checkBoxHeadlights.Size = new System.Drawing.Size(76, 17);
            this.checkBoxHeadlights.TabIndex = 4;
            this.checkBoxHeadlights.Text = "Headlights";
            this.checkBoxHeadlights.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTrainWeight
            // 
            this.numericUpDownTrainWeight.Location = new System.Drawing.Point(109, 73);
            this.numericUpDownTrainWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownTrainWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownTrainWeight.Name = "numericUpDownTrainWeight";
            this.numericUpDownTrainWeight.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownTrainWeight.TabIndex = 3;
            this.numericUpDownTrainWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(109, 30);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(76, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelTrainWeight
            // 
            this.labelTrainWeight.AutoSize = true;
            this.labelTrainWeight.Location = new System.Drawing.Point(26, 75);
            this.labelTrainWeight.Name = "labelTrainWeight";
            this.labelTrainWeight.Size = new System.Drawing.Size(68, 13);
            this.labelTrainWeight.TabIndex = 1;
            this.labelTrainWeight.Text = "Train weight:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(26, 36);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(64, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Max Speed:";
            // 
            // groupBoxTrainType
            // 
            this.groupBoxTrainType.Controls.Add(this.labelMonorail);
            this.groupBoxTrainType.Controls.Add(this.labelTrain);
            this.groupBoxTrainType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxTrainType.Name = "groupBoxTrainType";
            this.groupBoxTrainType.Size = new System.Drawing.Size(90, 110);
            this.groupBoxTrainType.TabIndex = 2;
            this.groupBoxTrainType.TabStop = false;
            this.groupBoxTrainType.Text = "Train type";
            // 
            // labelMonorail
            // 
            this.labelMonorail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMonorail.Location = new System.Drawing.Point(6, 65);
            this.labelMonorail.Name = "labelMonorail";
            this.labelMonorail.Size = new System.Drawing.Size(78, 25);
            this.labelMonorail.TabIndex = 3;
            this.labelMonorail.Text = "Monorail";
            this.labelMonorail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMonorail.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMonorail_MouseDown);
            // 
            // labelTrain
            // 
            this.labelTrain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTrain.Location = new System.Drawing.Point(6, 26);
            this.labelTrain.Name = "labelTrain";
            this.labelTrain.Size = new System.Drawing.Size(78, 25);
            this.labelTrain.TabIndex = 3;
            this.labelTrain.Text = "Train";
            this.labelTrain.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTrain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTrain_MouseDown);
            // 
            // panelTrainConfig
            // 
            this.panelTrainConfig.AllowDrop = true;
            this.panelTrainConfig.Controls.Add(this.pictureBoxTrainConfig);
            this.panelTrainConfig.Location = new System.Drawing.Point(110, 12);
            this.panelTrainConfig.Name = "panelTrainConfig";
            this.panelTrainConfig.Size = new System.Drawing.Size(321, 111);
            this.panelTrainConfig.TabIndex = 3;
            this.panelTrainConfig.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragDrop);
            this.panelTrainConfig.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelTrain_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGrey);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelAdditionalColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Location = new System.Drawing.Point(437, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(185, 171);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Colors";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(146, 122);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 11;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(98, 122);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 10;
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(54, 122);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 9;
            // 
            // panelGrey
            // 
            this.panelGrey.BackColor = System.Drawing.Color.Gray;
            this.panelGrey.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGrey.Location = new System.Drawing.Point(6, 122);
            this.panelGrey.Name = "panelGrey";
            this.panelGrey.Size = new System.Drawing.Size(30, 30);
            this.panelGrey.TabIndex = 7;
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(146, 68);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 7;
            // 
            // panelBlack
            // 
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(98, 68);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(30, 30);
            this.panelBlack.TabIndex = 8;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(54, 68);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 7;
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 68);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 6;
            // 
            // labelAdditionalColor
            // 
            this.labelAdditionalColor.AllowDrop = true;
            this.labelAdditionalColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelAdditionalColor.Location = new System.Drawing.Point(98, 26);
            this.labelAdditionalColor.Name = "labelAdditionalColor";
            this.labelAdditionalColor.Size = new System.Drawing.Size(78, 25);
            this.labelAdditionalColor.TabIndex = 5;
            this.labelAdditionalColor.Text = "Add. color";
            this.labelAdditionalColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAdditionalColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelAdditionalColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(6, 26);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(78, 25);
            this.labelMainColor.TabIndex = 4;
            this.labelMainColor.Text = "Main color";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(443, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(78, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(535, 209);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(78, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormTrainConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 261);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelTrainConfig);
            this.Controls.Add(this.groupBoxTrainType);
            this.Controls.Add(this.groupBoxTrainConfig);
            this.Name = "FormTrainConfig";
            this.Text = "FormTrainConfig";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTrainConfig)).EndInit();
            this.groupBoxTrainConfig.ResumeLayout(false);
            this.groupBoxTrainConfig.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTrainWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            this.groupBoxTrainType.ResumeLayout(false);
            this.panelTrainConfig.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTrainConfig;
        private System.Windows.Forms.GroupBox groupBoxTrainConfig;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.Label labelTrainWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownTrainWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxSportLine;
        private System.Windows.Forms.CheckBox checkBoxBottomMonorail;
        private System.Windows.Forms.CheckBox checkBoxHeadlights;
        private System.Windows.Forms.GroupBox groupBoxTrainType;
        private System.Windows.Forms.Label labelMonorail;
        private System.Windows.Forms.Label labelTrain;
        private System.Windows.Forms.Panel panelTrainConfig;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Label labelAdditionalColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGrey;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}