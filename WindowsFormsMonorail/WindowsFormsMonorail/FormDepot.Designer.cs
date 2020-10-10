namespace WindowsFormsMonorail
{
    partial class FormDepot
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
            this.pictureBoxDepot = new System.Windows.Forms.PictureBox();
            this.buttonParkTrain = new System.Windows.Forms.Button();
            this.buttonParkMonorail = new System.Windows.Forms.Button();
            this.Place = new System.Windows.Forms.Label();
            this.maskedTextBoxTrain = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxTrain = new System.Windows.Forms.GroupBox();
            this.buttonPickUp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).BeginInit();
            this.groupBoxTrain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxDepot
            // 
            this.pictureBoxDepot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxDepot.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxDepot.Name = "pictureBoxDepot";
            this.pictureBoxDepot.Size = new System.Drawing.Size(1184, 661);
            this.pictureBoxDepot.TabIndex = 0;
            this.pictureBoxDepot.TabStop = false;
            // 
            // buttonParkTrain
            // 
            this.buttonParkTrain.Location = new System.Drawing.Point(1038, 42);
            this.buttonParkTrain.Name = "buttonParkTrain";
            this.buttonParkTrain.Size = new System.Drawing.Size(121, 23);
            this.buttonParkTrain.TabIndex = 1;
            this.buttonParkTrain.Text = "Park the Train";
            this.buttonParkTrain.UseVisualStyleBackColor = true;
            this.buttonParkTrain.Click += new System.EventHandler(this.buttonSetTrain_Click);
            // 
            // buttonParkMonorail
            // 
            this.buttonParkMonorail.Location = new System.Drawing.Point(1038, 103);
            this.buttonParkMonorail.Name = "buttonParkMonorail";
            this.buttonParkMonorail.Size = new System.Drawing.Size(121, 23);
            this.buttonParkMonorail.TabIndex = 2;
            this.buttonParkMonorail.Text = "Park the Monorail";
            this.buttonParkMonorail.UseVisualStyleBackColor = true;
            this.buttonParkMonorail.Click += new System.EventHandler(this.buttonSetMonorail_Click);
            // 
            // Place
            // 
            this.Place.AutoSize = true;
            this.Place.Location = new System.Drawing.Point(15, 33);
            this.Place.Name = "Place";
            this.Place.Size = new System.Drawing.Size(37, 13);
            this.Place.TabIndex = 3;
            this.Place.Text = "Place:";
            // 
            // maskedTextBoxTrain
            // 
            this.maskedTextBoxTrain.Location = new System.Drawing.Point(65, 30);
            this.maskedTextBoxTrain.Name = "maskedTextBoxTrain";
            this.maskedTextBoxTrain.Size = new System.Drawing.Size(50, 20);
            this.maskedTextBoxTrain.TabIndex = 4;
            // 
            // groupBoxTrain
            // 
            this.groupBoxTrain.Controls.Add(this.buttonPickUp);
            this.groupBoxTrain.Controls.Add(this.Place);
            this.groupBoxTrain.Controls.Add(this.maskedTextBoxTrain);
            this.groupBoxTrain.Location = new System.Drawing.Point(1038, 156);
            this.groupBoxTrain.Name = "groupBoxTrain";
            this.groupBoxTrain.Size = new System.Drawing.Size(121, 100);
            this.groupBoxTrain.TabIndex = 5;
            this.groupBoxTrain.TabStop = false;
            this.groupBoxTrain.Text = "Pick up the Train";
            // 
            // buttonPickUp
            // 
            this.buttonPickUp.Location = new System.Drawing.Point(25, 62);
            this.buttonPickUp.Name = "buttonPickUp";
            this.buttonPickUp.Size = new System.Drawing.Size(75, 23);
            this.buttonPickUp.TabIndex = 5;
            this.buttonPickUp.Text = "Pick up";
            this.buttonPickUp.UseVisualStyleBackColor = true;
            this.buttonPickUp.Click += new System.EventHandler(this.buttonPickUpTrain_Click);
            // 
            // FormDepot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 661);
            this.Controls.Add(this.groupBoxTrain);
            this.Controls.Add(this.buttonParkMonorail);
            this.Controls.Add(this.buttonParkTrain);
            this.Controls.Add(this.pictureBoxDepot);
            this.Name = "FormDepot";
            this.Text = "FormDepot";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDepot)).EndInit();
            this.groupBoxTrain.ResumeLayout(false);
            this.groupBoxTrain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxDepot;
        private System.Windows.Forms.Button buttonParkTrain;
        private System.Windows.Forms.Button buttonParkMonorail;
        private System.Windows.Forms.Label Place;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxTrain;
        private System.Windows.Forms.GroupBox groupBoxTrain;
        private System.Windows.Forms.Button buttonPickUp;
    }
}