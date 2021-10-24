
namespace WindowsFormsExcavator
{
    partial class ParkingForm
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
            this.buttonParkingExcavator = new System.Windows.Forms.Button();
            this.buttonParkingBucketExcavator = new System.Windows.Forms.Button();
            this.groupBoxGetExcavator = new System.Windows.Forms.GroupBox();
            this.buttonGetExcavator = new System.Windows.Forms.Button();
            this.maskedTextBoxPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.groupBoxGetExcavator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParkingExcavator
            // 
            this.buttonParkingExcavator.Location = new System.Drawing.Point(768, 12);
            this.buttonParkingExcavator.Name = "buttonParkingExcavator";
            this.buttonParkingExcavator.Size = new System.Drawing.Size(104, 36);
            this.buttonParkingExcavator.TabIndex = 1;
            this.buttonParkingExcavator.Text = "Припарковать экскаватор";
            this.buttonParkingExcavator.UseVisualStyleBackColor = true;
            this.buttonParkingExcavator.Click += new System.EventHandler(this.buttonParkingExcavator_Click);
            // 
            // buttonParkingBucketExcavator
            // 
            this.buttonParkingBucketExcavator.Location = new System.Drawing.Point(768, 54);
            this.buttonParkingBucketExcavator.Name = "buttonParkingBucketExcavator";
            this.buttonParkingBucketExcavator.Size = new System.Drawing.Size(104, 48);
            this.buttonParkingBucketExcavator.TabIndex = 2;
            this.buttonParkingBucketExcavator.Text = "Припарковать экскаватор с ковшами";
            this.buttonParkingBucketExcavator.UseVisualStyleBackColor = true;
            this.buttonParkingBucketExcavator.Click += new System.EventHandler(this.buttonParkingBucketExcavator_Click);
            // 
            // groupBoxGetExcavator
            // 
            this.groupBoxGetExcavator.Controls.Add(this.buttonGetExcavator);
            this.groupBoxGetExcavator.Controls.Add(this.maskedTextBoxPlace);
            this.groupBoxGetExcavator.Controls.Add(this.labelPlace);
            this.groupBoxGetExcavator.Location = new System.Drawing.Point(768, 108);
            this.groupBoxGetExcavator.Name = "groupBoxGetExcavator";
            this.groupBoxGetExcavator.Size = new System.Drawing.Size(112, 88);
            this.groupBoxGetExcavator.TabIndex = 3;
            this.groupBoxGetExcavator.TabStop = false;
            this.groupBoxGetExcavator.Text = "Забрать экскаватор";
            // 
            // buttonGetExcavator
            // 
            this.buttonGetExcavator.Location = new System.Drawing.Point(19, 59);
            this.buttonGetExcavator.Name = "buttonGetExcavator";
            this.buttonGetExcavator.Size = new System.Drawing.Size(72, 23);
            this.buttonGetExcavator.TabIndex = 2;
            this.buttonGetExcavator.Text = "Забрать";
            this.buttonGetExcavator.UseVisualStyleBackColor = true;
            this.buttonGetExcavator.Click += new System.EventHandler(this.buttonGetExcavator_Click);
            // 
            // maskedTextBoxPlace
            // 
            this.maskedTextBoxPlace.Location = new System.Drawing.Point(54, 32);
            this.maskedTextBoxPlace.Name = "maskedTextBoxPlace";
            this.maskedTextBoxPlace.Size = new System.Drawing.Size(27, 20);
            this.maskedTextBoxPlace.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(6, 35);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(42, 13);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(2, 1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(750, 450);
            this.pictureBoxParking.TabIndex = 4;
            this.pictureBoxParking.TabStop = false;
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.groupBoxGetExcavator);
            this.Controls.Add(this.buttonParkingBucketExcavator);
            this.Controls.Add(this.buttonParkingExcavator);
            this.Name = "ParkingForm";
            this.Text = "ParkingForm";
            this.groupBoxGetExcavator.ResumeLayout(false);
            this.groupBoxGetExcavator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonParkingExcavator;
        private System.Windows.Forms.Button buttonParkingBucketExcavator;
        private System.Windows.Forms.GroupBox groupBoxGetExcavator;
        private System.Windows.Forms.Button buttonGetExcavator;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPlace;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxParking;
    }
}