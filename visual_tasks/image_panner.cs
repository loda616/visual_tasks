using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace visual_tasks
{
    public partial class image_panner : Form
    {
        private List<string> imagePaths = new List<string>();
        private int currentImageIndex = 0;
        private const int maxImages = 10;

        public image_panner()
        {
            InitializeComponent();
        }

        private void buttonNext_Click_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images to display.");
                return;
            }

            currentImageIndex = (currentImageIndex + 1) % imagePaths.Count;
            DisplayImage(imagePaths[currentImageIndex]);
        }

        private void buttonAdd_Click_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count >= maxImages)
            {
                MessageBox.Show("You have reached the maximum limit of images.");
                return;
            }

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePaths.Add(ofd.FileName);
                    currentImageIndex = imagePaths.Count - 1;
                    DisplayImage(imagePaths[currentImageIndex]);
                }
            }
        }

        private void buttonPrevious_Click_Click(object sender, EventArgs e)
        {
            if (imagePaths.Count == 0)
            {
                MessageBox.Show("No images to display.");
                return;
            }

            currentImageIndex = (currentImageIndex - 1 + imagePaths.Count) % imagePaths.Count;
            DisplayImage(imagePaths[currentImageIndex]);
        }

        private void DisplayImage(string imagePath)
        {
            if (File.Exists(imagePath))
            {
                pictureBox1.Image = Image.FromFile(imagePath); // Load and display the image
            }
            else
            {
                MessageBox.Show("Image not found.");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // No functionality for now
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            // Implement deletion if necessary
        }
    }
}
