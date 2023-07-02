using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaskGen
{
    public partial class Form1 : Form
    {
        string maskFileName;
        string imageFileName;
        System.Drawing.Bitmap mask;
        System.Drawing.Bitmap target;
        System.Drawing.Bitmap outImg;
        int boxW=0;
        int boxH=0;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            boxW = pictureBox1.Width;
            boxH = pictureBox1.Height;

            worker.ProgressChanged += Worker_ProgressChanged;
        }

        private void btnPickMask_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select mask image...";
            dlg.Filter = "PNG file (*.png)|*.png";
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;
            
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                maskFileName = dlg.FileName;
                mask = null;
                DoWork();
            }
            else
            { 
                maskFileName = null;
                lblMask.Text = "";
            }
        }

        private void btnPickImage_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog dlg = new OpenFileDialog();
            dlg.Title = "Select target image...";
            dlg.Filter = "PNG file (*.png)|*.png";
            dlg.CheckFileExists = true;
            dlg.CheckPathExists = true;

            if (dlg.ShowDialog() == DialogResult.OK)
            {
                imageFileName = dlg.FileName;
                target = null;
                DoWork();
            }
            else
            { 
                imageFileName = null;
                lblImage.Text = "";
            }
        }

        void DoWork()
        {
            if (!string.IsNullOrEmpty(imageFileName))
            {
                lblImage.Text = imageFileName;

                if (target == null)
                    target = new System.Drawing.Bitmap(imageFileName);
            }

            if (!string.IsNullOrEmpty(maskFileName))
            {
                lblMask.Text = maskFileName;

                if (mask == null)
                    mask = new System.Drawing.Bitmap(maskFileName);
            }

            if (target != null && mask != null)
            {
                if (target.Width != mask.Width || target.Height != mask.Height)
                {
                    System.Windows.Forms.MessageBox.Show("Images must be the same dimensions to mask", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                outImg = new Bitmap(target.Width, target.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

                progBar.Maximum = target.Width * target.Height;
                progBar.Step = 1;
                progBar.Value = 0;
                worker.CancelAsync();
                worker.RunWorkerAsync();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (outImg != null)
            {
                System.Windows.Forms.SaveFileDialog dlg = new System.Windows.Forms.SaveFileDialog();
                dlg.AddExtension = true;
                dlg.Filter = "PNG file (*png)|*.png";
                dlg.Title = "Save image as...";

                if (dlg.ShowDialog() == DialogResult.OK)
                    outImg.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
            }
        }

        private void worker_DoWork(object sender, DoWorkEventArgs e)
        {
            for (int y = 0; y < target.Height; ++y)
            {
                for (int x = 0; x < target.Width; ++x)
                {
                    Color m = mask.GetPixel(x, y);
                    Color src = target.GetPixel(x, y);

                    float frac = ((float)m.R) / 255.0f;
                    outImg.SetPixel(x, y, Color.FromArgb((byte)(src.A * frac), (byte)(src.R * frac), (byte)(src.G * frac), (byte)(src.B * frac)));
                }

                worker.ReportProgress(target.Width * y);
            }

            worker.ReportProgress(target.Width * target.Height);

            pictureBox1.Image = outImg;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progBar.Value = e.ProgressPercentage;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            progBar.Value = 0;
            lblImage.Text = "";
            lblMask.Text = "";
            pictureBox1.Image = null;
            mask = null;
            target = null;
            outImg = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Load a BLACK & WHITE (or GRAYSCALE) image into the mask slot.\n\nLoad the image you want to mask into image slot.\n\nMasked image will be generated over time as the progess-bar updates. Once complete it will be displayed for preview.\n\nPress Save to save the generated image.", "Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
