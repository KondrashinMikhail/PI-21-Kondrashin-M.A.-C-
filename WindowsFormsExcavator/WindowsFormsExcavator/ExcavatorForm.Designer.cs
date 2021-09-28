
namespace WindowsFormsExcavator
{
    partial class ExcavatorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcavatorForm));
            this.pictureBoxExcavator = new System.Windows.Forms.PictureBox();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonCreate_bucket_excavator = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCreate_usual_excavator = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcavator)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxExcavator
            // 
            this.pictureBoxExcavator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxExcavator.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxExcavator.Name = "pictureBoxExcavator";
            this.pictureBoxExcavator.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxExcavator.TabIndex = 0;
            this.pictureBoxExcavator.TabStop = false;
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(770, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 1;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreate_bucket_excavator
            // 
            this.buttonCreate_bucket_excavator.Location = new System.Drawing.Point(12, 424);
            this.buttonCreate_bucket_excavator.Name = "buttonCreate_bucket_excavator";
            this.buttonCreate_bucket_excavator.Size = new System.Drawing.Size(144, 30);
            this.buttonCreate_bucket_excavator.TabIndex = 2;
            this.buttonCreate_bucket_excavator.Text = "Create bucket excavator";
            this.buttonCreate_bucket_excavator.UseVisualStyleBackColor = true;
            this.buttonCreate_bucket_excavator.Click += new System.EventHandler(this.buttonCreate_bucket_excavator_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(842, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 3;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(806, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(806, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreate_usual_excavator
            // 
            this.buttonCreate_usual_excavator.Location = new System.Drawing.Point(12, 388);
            this.buttonCreate_usual_excavator.Name = "buttonCreate_usual_excavator";
            this.buttonCreate_usual_excavator.Size = new System.Drawing.Size(144, 30);
            this.buttonCreate_usual_excavator.TabIndex = 6;
            this.buttonCreate_usual_excavator.Text = "Create usual excavator";
            this.buttonCreate_usual_excavator.UseVisualStyleBackColor = true;
            this.buttonCreate_usual_excavator.Click += new System.EventHandler(this.buttonCreate_usual_excavator_Click);
            // 
            // ExcavatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.buttonCreate_usual_excavator);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonCreate_bucket_excavator);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.pictureBoxExcavator);
            this.Name = "ExcavatorForm";
            this.Text = "ExcavatorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExcavator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxExcavator;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonCreate_bucket_excavator;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonCreate_usual_excavator;
    }
}

