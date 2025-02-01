using Microsoft.EntityFrameworkCore;
using System;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories.Models;
using WinFormsApp1.Repositories;

namespace WinFormsApp1
{
    public partial class pic : Form
    {
        private int serial;
        private int serial2;
        private string name;
        private byte[] imageData1;
        private byte[] imageData2;
        private byte[] imageData3;
        private InvEntities invEntities ;
        private ImageFace imgface;

        public pic()
        {
            InitializeComponent();
        }

        public pic(int serial, string name, int serial2 , InvEntities invEntities)
        {
            InitializeComponent();
            this.serial = serial;
            this.serial2 = serial2;
            this.name = name;
            this.invEntities = invEntities;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
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
                imgface = await invEntities.ImageFaces.FindAsync(serial2, serial);
                if (imgface != null)
                {
                    pictureBox1.Invoke(new Action(() => pictureBox1.Image = ByteArrayToImage(imgface.Faceleft)));
                    pictureBox2.Invoke(new Action(() => pictureBox2.Image = ByteArrayToImage(imgface.Facefront)));
                    pictureBox3.Invoke(new Action(() => pictureBox3.Image = ByteArrayToImage(imgface.Faceright)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void pic_Load(object sender, EventArgs e) {
            Task.Run(async () => await LoadDataAsync());
        }

        private void label2_Click(object sender, EventArgs e) { }

        private void label3_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e)
        {

        }

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

        private async void button3_Click(object sender, EventArgs e)
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
                    pictureBox3.Image = Image.FromFile(filePath);
                    imageData3 = await File.ReadAllBytesAsync(filePath);
                }
            }
        }

        private async void button9_Click(object sender, EventArgs e)
        {
            if (imgface == null)
            {
                if (imageData1 != null && imageData2 != null && imageData3 != null)
                {
                    ImageFace imge = new ImageFace
                    {
                        Serial = this.serial2,
                        Serpers = this.serial,
                        Faceleft = imageData1,
                        Facefront = imageData2,
                        Faceright = imageData3,
                    };

                    invEntities.ImageFaces.Add(imge);
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
            pictureBox3.Image = null;
            imageData1 = null;
            imageData2 = null;
            imageData3 = null;
        }

        private async void button7_Click(object sender, EventArgs e)
        {
            if (imgface == null)
            {
                MessageBox.Show("Record not found!");
            }
            else
            {
                if (imageData1 != null)
                {
                    imgface.Faceleft = imageData1;
                }
                if (imageData2 != null)
                {
                    imgface.Facefront = imageData2;
                }
                if (imageData3 != null)
                {
                    imgface.Faceright = imageData3;
                }
                if (imageData1 != null || imageData2 != null || imageData3 != null)
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
                if (imgface != null)
                {
                    invEntities.ImageFaces.Remove(imgface);
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
    }
}
