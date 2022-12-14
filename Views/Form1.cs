using PatientCRUD.Entities;
using PatientCRUD.Manager;
using PatientCRUD.Models;
using PatientCRUD.Models.Entities;
using PatientCRUD.Views;

namespace PatientCRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        PatientManager _patientManager = new PatientManager();

        public void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        public void LoadData()
        {
            var patients = _patientManager.GetPatients();
            var patientsAddresses = _patientManager.GetPatientsAddresses();
            patientDataGridView1.Rows.Clear();
            addressDataGridView.Rows.Clear();
            //patients.Add(patientsAddresses);

            foreach (var patient in patients)
            {
                patientDataGridView1.Rows.Add(patient.Id, patient.FirstName, patient.LastName, patient.BirthDate, patient.Gender);
                
                foreach(var address in patientsAddresses)
                {
                    if(address.PatientId == patient.Id)
                    {
                        patientDataGridView1.Rows.Add(address.Address);
                    }
                }
            }



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(FirstNameTextBox.Text))
                {
                    MessageBox.Show("Ingrese un nombre", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FirstNameTextBox.Focus();
                }
                if (string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    MessageBox.Show("Ingrese un apellido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LastNameTextBox.Focus();
                }
                if (string.IsNullOrEmpty(streetTextBox.Text))
                {
                    MessageBox.Show("Ingrese una calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (string.IsNullOrEmpty(streetNumberTextBox.Text))
                {
                    MessageBox.Show("Ingrese un numero de calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Patient patient = new Patient();
                patient.FirstName = FirstNameTextBox.Text;
                patient.LastName = LastNameTextBox.Text;
                patient.BirthDate = dateTimePicker.Value;
                patient.Gender = genderComboBox.Text;

                PatientsAddresses patientAddress = new PatientsAddresses();
                patientAddress.Patient = patient;
                patientAddress.PatientId = patient.Id;
                patientAddress.Street = streetTextBox.Text;
                patientAddress.StreetNumber = Convert.ToInt32(streetNumberTextBox.Text);

                if (floorTextBox.Text == null)
                {
                    patientAddress.Floor = null;
                }
                else
                {
                    patientAddress.Floor = Convert.ToInt32(floorTextBox.Text);
                }
                if (apartmentTextBox.Text != null)
                {
                    patientAddress.Apartment = apartmentTextBox.Text;
                }
                


                if (_patientManager.Add(patient, patientAddress))
                {
                    MessageBox.Show("Paciente creado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Reset();
                }
                else
                {
                    MessageBox.Show("Fallo la creacion del paciente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ; 
            }
        }

        private void Reset()
        {
            FirstNameTextBox.Clear();
            LastNameTextBox.Clear();
            streetTextBox.Clear();
            streetNumberTextBox.Clear();
            floorTextBox.Clear();
            apartmentTextBox.Clear();
            LoadData();

        }

        public void patientDataGridView1_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                
                DataGridViewRow dr = patientDataGridView1.SelectedRows[0];
                formPatientDetail pntDetail = new formPatientDetail();
                //this.Hide();
                //frm.Show();
                pntDetail.patientId.Text = dr.Cells[0].Value.ToString();
                pntDetail.FirstNameTextBox.Text = dr.Cells[1].Value.ToString();
                pntDetail.LastNameTextBox.Text = dr.Cells[2].Value.ToString();
                //pntDetail = dr.Cells[3].Value.ToString();
                pntDetail.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }

        private void GenderLabel_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            //LoadData();
            String query = "select * from Patients, PatientsAddresses";
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}