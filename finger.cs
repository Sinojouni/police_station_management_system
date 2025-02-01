using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class finger : Form
    {
        public finger()
        {
            InitializeComponent();
        }

        private int serial;
        private int serial2;
        private string name;
        private byte[] imageData1;
        private byte[] imageData2;
        private InvEntities invEntities;
        private ImageFp imgfp;


        public finger(int serial, string name, int serial2, InvEntities invEntities)
        {
            InitializeComponent();
            this.serial = serial;
            this.serial2 = serial2;
            this.name = name;
            this.invEntities = invEntities;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private async Task LoadDataAsync()
        {
            label2.Invoke(new Action(() => label2.Text = serial.ToString()));
            label3.Invoke(new Action(() => label3.Text = name));
            try
            {
                imgfp = await invEntities.ImageFps.FindAsync(serial2, serial);
                if (imgfp != null)
                {
                    pictureBox1.Invoke(new Action(() => pictureBox1.Image = ByteArrayToImage(imgfp.Fpleft)));
                    pictureBox2.Invoke(new Action(() => pictureBox2.Image = ByteArrayToImage(imgfp.Fpright)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }

        private async void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(filePath);
                    imageData1 = await File.ReadAllBytesAsync(filePath);
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png)|*.bmp;*.jpg;*.jpeg;*.png";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    pictureBox2.Image = Image.FromFile(filePath);
                    imageData2 = await File.ReadAllBytesAsync(filePath);
                }
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (imgfp == null)
            {
                if (imageData1 != null && imageData2 != null)
                {
                    ImageFp imge = new ImageFp
                    {
                        Serial = this.serial2,
                        Serpers = this.serial,
                        Fpleft = imageData1,
                        Fpright = imageData2,
                    };

                    invEntities.ImageFps.Add(imge);
                    await invEntities.SaveChangesAsync();
                    ClearForm();
                    await LoadDataAsync();
                    MessageBox.Show("Record added successfully!");
                }
                else
                {
                    MessageBox.Show("Upload all the images");
                }
            }
            else
            {
                MessageBox.Show("This record already exists");
            }
        }

        private void ClearForm()
        {
            pictureBox1.Image = null;
            pictureBox2.Image = null;
            imageData1 = null;
            imageData2 = null;
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (imgfp == null)
            {
                MessageBox.Show("Record not found!");
            }
            else
            {
                if (imageData1 != null)
                {
                    imgfp.Fpleft = imageData1;
                }
                if (imageData2 != null)
                {
                    imgfp.Fpright = imageData2;
                }
                if (imageData1 != null || imageData2 != null)
                {
                    await invEntities.SaveChangesAsync();
                    ClearForm();
                    await LoadDataAsync();
                    MessageBox.Show("Record updated");
                }
            }
        }

        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (imgfp != null)
                {
                    invEntities.ImageFps.Remove(imgfp);
                    await invEntities.SaveChangesAsync();
                    ClearForm();
                    await LoadDataAsync();
                    MessageBox.Show("Record deleted successfully!");
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting record: {ex.Message}");
            }
        }

        private async void button8_Click(object sender, EventArgs e)
        {
            ClearForm();
            await LoadDataAsync();
        }
        private void finger_Load(object sender, EventArgs e)
        {
            Task.Run(async () => await LoadDataAsync());
        }
    }
}
