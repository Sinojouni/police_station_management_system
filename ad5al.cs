using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp1.Repositories;
using WinFormsApp1.Repositories.Models;

namespace WinFormsApp1
{
    public partial class ad5al : Form
    {
        private InvEntities invEntities = new InvEntities();
        private Invest selectedInvest;

        public ad5al()
        {
            InitializeComponent();
            LoadData();
            dataGridView1.RowHeaderMouseClick += dataGridView1_SelectionChanged;
        }

        private async void LoadData()
        {
            try
            {
                var investData = await invEntities.Invests.ToListAsync();
                dataGridView1.DataSource = investData;
                UpdateCrimeComboBox(investData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error retrieving data: {ex.Message}");
            }
        }

        private void UpdateCrimeComboBox(IList<Invest> investData)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("(other)");
            comboBox1.SelectedIndex = 0;

            foreach (var invest in investData)
            {
                if (!comboBox1.Items.Contains(invest.Crime))
                {
                    comboBox1.Items.Add(invest.Crime);
                }
            }
        }


        private async Task DeleteRecord(int serialNumber)
        {
            try
            {
                var investRecord = await invEntities.Invests.FirstOrDefaultAsync(i => i.Serial == serialNumber);

                if (investRecord != null)
                {
                    invEntities.Invests.Remove(investRecord);
                    await invEntities.SaveChangesAsync();
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
            try
            {
                var carRecord = await invEntities.Vehicles.Where(v => v.SerialNb == serialNumber).ToListAsync();

                if (carRecord != null)
                {
                    for(int f = 0; f < carRecord.Count; f++)
                    {
                        invEntities.Vehicles.Remove(carRecord[f]);
                    }
                    await invEntities.SaveChangesAsync();
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
            try
            {
                var perRecord = await invEntities.Invpersons.Where(v => v.Serial== serialNumber).ToListAsync();

                if (perRecord != null)
                {
                    for (int f = 0; f < perRecord.Count; f++)
                    {
                        invEntities.Invpersons.Remove(perRecord[f]);
                    }
                    await invEntities.SaveChangesAsync();
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
            try
            {
                var faceRecord = await invEntities.ImageFaces.Where(v => v.Serial == serialNumber).ToListAsync();

                if (faceRecord != null)
                {
                    for (int f = 0; f < faceRecord.Count; f++)
                    {
                        invEntities.ImageFaces.Remove(faceRecord[f]);
                    }
                    await invEntities.SaveChangesAsync();
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
            try
            {
                var finRecord = await invEntities.ImageFps.Where(v => v.Serial == serialNumber).ToListAsync();

                if (finRecord != null)
                {
                    for (int f = 0; f < finRecord.Count; f++)
                    {
                        invEntities.ImageFps.Remove(finRecord[f]);
                    }
                    await invEntities.SaveChangesAsync();
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


        private async void button1_Click(object sender, EventArgs e)
        {
            string ch1 = checkBox1.Checked ? "Y" : "N";
            string ch2 = checkBox2.Checked ? "Y" : "N";
            string crime = comboBox1.SelectedIndex == 0 ? textBox2.Text : comboBox1.Text;

            Invest newInvest = new Invest
            {
                Dfile = DateOnly.FromDateTime(dateTimePicker1.Value),
                Dmahdar = DateOnly.FromDateTime(dateTimePicker2.Value),
                Crime = crime,
                Madbout = ch1,
                Resume = ch2,
                Rem = textBox1.Text
            };

            invEntities.Invests.Add(newInvest);

            try
            {
                await invEntities.SaveChangesAsync();
                ClearForm();
                LoadData();
                MessageBox.Show("Record added successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding record: {ex.Message}");
            }
        }

        private void ClearForm()
        {
            comboBox1.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
            dateTimePicker2.Value = DateTime.Now;
            checkBox2.Checked = false;
            checkBox1.Checked = false;
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            selectedInvest = null;
        }

        private void dataGridView1_SelectionChanged(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView1.Rows[e.RowIndex];
                int serial = Convert.ToInt32(selectedRow.Cells["Serial"].Value);
                selectedInvest = invEntities.Invests.Find(serial);
                if (selectedInvest != null)
                {
                    dateTimePicker1.Value = selectedInvest.Dfile.ToDateTime(TimeOnly.MinValue);
                    dateTimePicker2.Value = selectedInvest.Dmahdar.ToDateTime(TimeOnly.MinValue);
                    label5.Text = serial.ToString();
                    comboBox1.Text = selectedInvest.Crime;
                    textBox1.Text = selectedInvest.Rem;
                    checkBox1.Checked = selectedInvest.Madbout == "Y";
                    checkBox2.Checked = selectedInvest.Resume == "Y";
                }
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label5.Text) && int.TryParse(label5.Text, out int serial))
            {
                string ch1 = checkBox1.Checked ? "Y" : "N";
                string ch2 = checkBox2.Checked ? "Y" : "N";
                string crime = comboBox1.SelectedIndex == 0 ? textBox2.Text : comboBox1.Text;

                selectedInvest = await invEntities.Invests.FindAsync(serial);
                if (selectedInvest != null)
                {
                    selectedInvest.Dfile = DateOnly.FromDateTime(dateTimePicker1.Value);
                    selectedInvest.Dmahdar = DateOnly.FromDateTime(dateTimePicker2.Value);
                    selectedInvest.Crime = crime;
                    selectedInvest.Madbout = ch1;
                    selectedInvest.Resume = ch2;
                    selectedInvest.Rem = textBox1.Text;

                    try
                    {
                        await invEntities.SaveChangesAsync();
                        ClearForm();
                        LoadData();
                        MessageBox.Show("Record updated successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error updating record: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Record not found!");
                }
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearForm();
            LoadData();
        }

        private async void button4_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                int serial = Convert.ToInt32(row.Cells["Serial"].Value);
                await DeleteRecord(serial);
            }
            LoadData();
            ClearForm();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label5.Text) && int.TryParse(label5.Text, out int serial))
            {
                ach5as ach5as = new ach5as(serial, this.invEntities);
                ach5as.Show();
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(label5.Text) && int.TryParse(label5.Text, out int serial))
            {
                syarat syarat = new syarat(serial, this.invEntities);
                syarat.Show();
            }
            else
            {
                MessageBox.Show("Please select a record");
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LoadData();
            ClearForm();
        }

        private void ad5al_Load(object sender, EventArgs e)
        {

        }
    }
}
