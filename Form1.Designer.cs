
namespace MaskGen
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
            this.btnPickMask = new System.Windows.Forms.Button();
            this.btnPickImage = new System.Windows.Forms.Button();
            this.lblMask = new System.Windows.Forms.Label();
            this.lblImage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.progBar = new System.Windows.Forms.ProgressBar();
            this.worker = new System.ComponentModel.BackgroundWorker();
            this.btnClear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPickMask
            // 
            this.btnPickMask.Location = new System.Drawing.Point(13, 13);
            this.btnPickMask.Name = "btnPickMask";
            this.btnPickMask.Size = new System.Drawing.Size(90, 23);
            this.btnPickMask.TabIndex = 0;
            this.btnPickMask.Text = "Select Mask";
            this.btnPickMask.UseVisualStyleBackColor = true;
            this.btnPickMask.Click += new System.EventHandler(this.btnPickMask_Click);
            // 
            // btnPickImage
            // 
            this.btnPickImage.Location = new System.Drawing.Point(13, 38);
            this.btnPickImage.Name = "btnPickImage";
            this.btnPickImage.Size = new System.Drawing.Size(90, 23);
            this.btnPickImage.TabIndex = 1;
            this.btnPickImage.Text = "Select Image";
            this.btnPickImage.UseVisualStyleBackColor = true;
            this.btnPickImage.Click += new System.EventHandler(this.btnPickImage_Click);
            // 
            // lblMask
            // 
            this.lblMask.AutoSize = true;
            this.lblMask.Location = new System.Drawing.Point(109, 18);
            this.lblMask.Name = "lblMask";
            this.lblMask.Size = new System.Drawing.Size(0, 13);
            this.lblMask.TabIndex = 2;
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(109, 43);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(0, 13);
            this.lblImage.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MaskGen.Properties.Resources.trans_tile;
            this.pictureBox1.Location = new System.Drawing.Point(13, 94);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(423, 318);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(361, 418);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // progBar
            // 
            this.progBar.Location = new System.Drawing.Point(13, 65);
            this.progBar.Name = "progBar";
            this.progBar.Size = new System.Drawing.Size(423, 23);
            this.progBar.TabIndex = 6;
            // 
            // worker
            // 
            this.worker.WorkerReportsProgress = true;
            this.worker.WorkerSupportsCancellation = true;
            this.worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.worker_DoWork);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 417);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 418);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Instructions";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 447);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.progBar);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.lblMask);
            this.Controls.Add(this.btnPickImage);
            this.Controls.Add(this.btnPickMask);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Mask Gen";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPickMask;
        private System.Windows.Forms.Button btnPickImage;
        private System.Windows.Forms.Label lblMask;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ProgressBar progBar;
        private System.ComponentModel.BackgroundWorker worker;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button button1;
    }
}

