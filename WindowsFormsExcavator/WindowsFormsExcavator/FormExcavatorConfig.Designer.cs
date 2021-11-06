
namespace WindowsFormsExcavator
{
    partial class FormExcavatorConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxBackBucket = new System.Windows.Forms.CheckBox();
            this.checkBoxFrontBucket = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.labelMaxWeight = new System.Windows.Forms.Label();
            this.pictureBoxExcavator = new System.Windows.Forms.PictureBox();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.labelBucketExcavator = new System.Windows.Forms.Label();
            this.labelExcavator = new System.Windows.Forms.Label();
            this.panelExcavator = new System.Windows.Forms.Panel();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelGray = new System.Windows.Forms.Panel();
            this.panelBlack = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.labelDopCol = new System.Windows.Forms.Label();
            this.labelMainCol = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcavator)).BeginInit();
            this.groupBoxType.SuspendLayout();
            this.panelExcavator.SuspendLayout();
            this.groupBoxColors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxBackBucket);
            this.groupBoxParameters.Controls.Add(this.checkBoxFrontBucket);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelMaxWeight);
            this.groupBoxParameters.Location = new System.Drawing.Point(12, 178);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(293, 123);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxBackBucket
            // 
            this.checkBoxBackBucket.AutoSize = true;
            this.checkBoxBackBucket.Location = new System.Drawing.Point(184, 81);
            this.checkBoxBackBucket.Name = "checkBoxBackBucket";
            this.checkBoxBackBucket.Size = new System.Drawing.Size(92, 17);
            this.checkBoxBackBucket.TabIndex = 6;
            this.checkBoxBackBucket.Text = "Задний ковш";
            this.checkBoxBackBucket.UseVisualStyleBackColor = true;
            // 
            // checkBoxFrontBucket
            // 
            this.checkBoxFrontBucket.AutoSize = true;
            this.checkBoxFrontBucket.Location = new System.Drawing.Point(184, 42);
            this.checkBoxFrontBucket.Name = "checkBoxFrontBucket";
            this.checkBoxFrontBucket.Size = new System.Drawing.Size(105, 17);
            this.checkBoxFrontBucket.TabIndex = 5;
            this.checkBoxFrontBucket.Text = "Передний ковш";
            this.checkBoxFrontBucket.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(9, 81);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownWeight.TabIndex = 4;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(9, 42);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            150,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownMaxSpeed.TabIndex = 3;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(6, 26);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(134, 13);
            this.labelMaxSpeed.TabIndex = 2;
            this.labelMaxSpeed.Text = "Максимальная скорость";
            // 
            // labelMaxWeight
            // 
            this.labelMaxWeight.AutoSize = true;
            this.labelMaxWeight.Location = new System.Drawing.Point(6, 65);
            this.labelMaxWeight.Name = "labelMaxWeight";
            this.labelMaxWeight.Size = new System.Drawing.Size(94, 13);
            this.labelMaxWeight.TabIndex = 1;
            this.labelMaxWeight.Text = "Вес экскаватора";
            // 
            // pictureBoxExcavator
            // 
            this.pictureBoxExcavator.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxExcavator.Name = "pictureBoxExcavator";
            this.pictureBoxExcavator.Size = new System.Drawing.Size(191, 150);
            this.pictureBoxExcavator.TabIndex = 1;
            this.pictureBoxExcavator.TabStop = false;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.labelBucketExcavator);
            this.groupBoxType.Controls.Add(this.labelExcavator);
            this.groupBoxType.Location = new System.Drawing.Point(12, 12);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(129, 160);
            this.groupBoxType.TabIndex = 2;
            this.groupBoxType.TabStop = false;
            this.groupBoxType.Text = "Тип кузова";
            // 
            // labelBucketExcavator
            // 
            this.labelBucketExcavator.AllowDrop = true;
            this.labelBucketExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBucketExcavator.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.labelBucketExcavator.Location = new System.Drawing.Point(6, 96);
            this.labelBucketExcavator.Name = "labelBucketExcavator";
            this.labelBucketExcavator.Size = new System.Drawing.Size(114, 42);
            this.labelBucketExcavator.TabIndex = 4;
            this.labelBucketExcavator.Text = "Экскаватор с ковшами";
            this.labelBucketExcavator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelBucketExcavator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBucketExcavator_MouseDown);
            // 
            // labelExcavator
            // 
            this.labelExcavator.AllowDrop = true;
            this.labelExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelExcavator.Location = new System.Drawing.Point(6, 37);
            this.labelExcavator.Name = "labelExcavator";
            this.labelExcavator.Size = new System.Drawing.Size(114, 41);
            this.labelExcavator.TabIndex = 3;
            this.labelExcavator.Text = "Обычный экскаватор";
            this.labelExcavator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelExcavator.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelExcavator_MouseDown);
            // 
            // panelExcavator
            // 
            this.panelExcavator.AllowDrop = true;
            this.panelExcavator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExcavator.Controls.Add(this.pictureBoxExcavator);
            this.panelExcavator.Location = new System.Drawing.Point(151, 12);
            this.panelExcavator.Name = "panelExcavator";
            this.panelExcavator.Size = new System.Drawing.Size(199, 160);
            this.panelExcavator.TabIndex = 3;
            this.panelExcavator.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelExcavator_DragDrop);
            this.panelExcavator.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelExcavator_DragEnter);
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelWhite);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelOrange);
            this.groupBoxColors.Controls.Add(this.panelGray);
            this.groupBoxColors.Controls.Add(this.panelBlack);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Controls.Add(this.labelDopCol);
            this.groupBoxColors.Controls.Add(this.labelMainCol);
            this.groupBoxColors.Location = new System.Drawing.Point(380, 12);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(207, 160);
            this.groupBoxColors.TabIndex = 4;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.AllowDrop = true;
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(154, 114);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(40, 40);
            this.panelBlue.TabIndex = 4;
            // 
            // panelWhite
            // 
            this.panelWhite.AllowDrop = true;
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(154, 69);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(40, 40);
            this.panelWhite.TabIndex = 4;
            // 
            // panelGreen
            // 
            this.panelGreen.AllowDrop = true;
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(108, 114);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(40, 40);
            this.panelGreen.TabIndex = 4;
            // 
            // panelOrange
            // 
            this.panelOrange.AllowDrop = true;
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(62, 114);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(40, 40);
            this.panelOrange.TabIndex = 4;
            // 
            // panelGray
            // 
            this.panelGray.AllowDrop = true;
            this.panelGray.BackColor = System.Drawing.Color.Gray;
            this.panelGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGray.Location = new System.Drawing.Point(16, 114);
            this.panelGray.Name = "panelGray";
            this.panelGray.Size = new System.Drawing.Size(40, 40);
            this.panelGray.TabIndex = 4;
            // 
            // panelBlack
            // 
            this.panelBlack.AllowDrop = true;
            this.panelBlack.BackColor = System.Drawing.Color.Black;
            this.panelBlack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlack.Location = new System.Drawing.Point(108, 69);
            this.panelBlack.Name = "panelBlack";
            this.panelBlack.Size = new System.Drawing.Size(40, 40);
            this.panelBlack.TabIndex = 4;
            // 
            // panelYellow
            // 
            this.panelYellow.AllowDrop = true;
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(62, 69);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(40, 40);
            this.panelYellow.TabIndex = 4;
            // 
            // panelRed
            // 
            this.panelRed.AllowDrop = true;
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(16, 69);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(40, 40);
            this.panelRed.TabIndex = 3;
            // 
            // labelDopCol
            // 
            this.labelDopCol.AllowDrop = true;
            this.labelDopCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopCol.Location = new System.Drawing.Point(128, 16);
            this.labelDopCol.Name = "labelDopCol";
            this.labelDopCol.Size = new System.Drawing.Size(66, 36);
            this.labelDopCol.TabIndex = 2;
            this.labelDopCol.Text = "Доп. цвет";
            this.labelDopCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopCol_DragDrop);
            this.labelDopCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainCol_DragEnter);
            // 
            // labelMainCol
            // 
            this.labelMainCol.AllowDrop = true;
            this.labelMainCol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainCol.Location = new System.Drawing.Point(16, 16);
            this.labelMainCol.Name = "labelMainCol";
            this.labelMainCol.Size = new System.Drawing.Size(66, 36);
            this.labelMainCol.TabIndex = 0;
            this.labelMainCol.Text = "Основной цвет";
            this.labelMainCol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainCol.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainCol_DragDrop);
            this.labelMainCol.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainCol_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(442, 209);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(442, 238);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormExcavatorConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 313);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelExcavator);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormExcavatorConfig";
            this.Text = "Выбор экскаватора";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcavator)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            this.panelExcavator.ResumeLayout(false);
            this.groupBoxColors.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelMaxWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxBackBucket;
        private System.Windows.Forms.CheckBox checkBoxFrontBucket;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxExcavator;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Label labelBucketExcavator;
        private System.Windows.Forms.Label labelExcavator;
        private System.Windows.Forms.Panel panelExcavator;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelGray;
        private System.Windows.Forms.Panel panelBlack;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Label labelDopCol;
        private System.Windows.Forms.Label labelMainCol;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}