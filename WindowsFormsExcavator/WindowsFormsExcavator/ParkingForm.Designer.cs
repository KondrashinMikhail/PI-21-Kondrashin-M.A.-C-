
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
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.listBoxParkings = new System.Windows.Forms.ListBox();
            this.buttonAddParking = new System.Windows.Forms.Button();
            this.buttonDeletePaking = new System.Windows.Forms.Button();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.labelParkings = new System.Windows.Forms.Label();
            this.groupBoxGetExcavator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonParkingExcavator
            // 
            this.buttonParkingExcavator.Location = new System.Drawing.Point(708, 265);
            this.buttonParkingExcavator.Name = "buttonParkingExcavator";
            this.buttonParkingExcavator.Size = new System.Drawing.Size(104, 36);
            this.buttonParkingExcavator.TabIndex = 1;
            this.buttonParkingExcavator.Text = "Припарковать экскаватор";
            this.buttonParkingExcavator.UseVisualStyleBackColor = true;
            this.buttonParkingExcavator.Click += new System.EventHandler(this.buttonParkingExcavator_Click);
            // 
            // buttonParkingBucketExcavator
            // 
            this.buttonParkingBucketExcavator.Location = new System.Drawing.Point(708, 307);
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
            this.groupBoxGetExcavator.Controls.Add(this.maskedTextBox);
            this.groupBoxGetExcavator.Controls.Add(this.labelPlace);
            this.groupBoxGetExcavator.Location = new System.Drawing.Point(708, 361);
            this.groupBoxGetExcavator.Name = "groupBoxGetExcavator";
            this.groupBoxGetExcavator.Size = new System.Drawing.Size(104, 88);
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
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(54, 32);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(27, 20);
            this.maskedTextBox.TabIndex = 1;
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
            this.pictureBoxParking.Size = new System.Drawing.Size(686, 462);
            this.pictureBoxParking.TabIndex = 4;
            this.pictureBoxParking.TabStop = false;
            // 
            // listBoxParkings
            // 
            this.listBoxParkings.FormattingEnabled = true;
            this.listBoxParkings.Location = new System.Drawing.Point(708, 94);
            this.listBoxParkings.Name = "listBoxParkings";
            this.listBoxParkings.Size = new System.Drawing.Size(104, 95);
            this.listBoxParkings.TabIndex = 5;
            // 
            // buttonAddParking
            // 
            this.buttonAddParking.Location = new System.Drawing.Point(708, 51);
            this.buttonAddParking.Name = "buttonAddParking";
            this.buttonAddParking.Size = new System.Drawing.Size(104, 37);
            this.buttonAddParking.TabIndex = 6;
            this.buttonAddParking.Text = "Добавить парковку";
            this.buttonAddParking.UseVisualStyleBackColor = true;
            this.buttonAddParking.Click += new System.EventHandler(this.buttonAddParking_Click);
            // 
            // buttonDeletePaking
            // 
            this.buttonDeletePaking.Location = new System.Drawing.Point(708, 195);
            this.buttonDeletePaking.Name = "buttonDeletePaking";
            this.buttonDeletePaking.Size = new System.Drawing.Size(104, 37);
            this.buttonDeletePaking.TabIndex = 7;
            this.buttonDeletePaking.Text = "Удалить парковку";
            this.buttonDeletePaking.UseVisualStyleBackColor = true;
            this.buttonDeletePaking.Click += new System.EventHandler(this.buttonDeletePaking_Click);
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(708, 25);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(100, 20);
            this.textBoxNewLevelName.TabIndex = 8;
            // 
            // labelParkings
            // 
            this.labelParkings.AutoSize = true;
            this.labelParkings.Location = new System.Drawing.Point(729, 9);
            this.labelParkings.Name = "labelParkings";
            this.labelParkings.Size = new System.Drawing.Size(60, 13);
            this.labelParkings.TabIndex = 9;
            this.labelParkings.Text = "Парковки:";
            // 
            // ParkingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 461);
            this.Controls.Add(this.labelParkings);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.buttonDeletePaking);
            this.Controls.Add(this.buttonAddParking);
            this.Controls.Add(this.listBoxParkings);
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
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonParkingExcavator;
        private System.Windows.Forms.Button buttonParkingBucketExcavator;
        private System.Windows.Forms.GroupBox groupBoxGetExcavator;
        private System.Windows.Forms.Button buttonGetExcavator;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.ListBox listBoxParkings;
        private System.Windows.Forms.Button buttonAddParking;
        private System.Windows.Forms.Button buttonDeletePaking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Label labelParkings;
    }
}