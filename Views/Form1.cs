using PatientCRUD.Entities;
using PatientCRUD.Manager;
using PatientCRUD.Models;
using PatientCRUD.Models.Entities;
using PatientCRUD.Views;
using System.Linq;
using System.Data.SqlClient;

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
            patientDataGridView1.Rows.Clear();

            foreach (var patient in patients)
            {
                patientDataGridView1.Rows.Add(patient.Id, patient.FirstName, patient.LastName, patient.BirthDate, patient.Gender, patient.Address);

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
                    return;
                }
                if (string.IsNullOrEmpty(LastNameTextBox.Text))
                {
                    MessageBox.Show("Ingrese un apellido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LastNameTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(genderComboBox.Text))
                {
                    MessageBox.Show("Seleccione sexo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    genderComboBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(streetTextBox.Text))
                {
                    MessageBox.Show("Ingrese una calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    streetTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(streetNumberTextBox.Text))
                {
                    MessageBox.Show("Ingrese un numero de calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    streetNumberTextBox.Focus();
                    return;
                }
                Patient patient = new Patient();
                patient.FirstName = FirstNameTextBox.Text;
                patient.LastName = LastNameTextBox.Text;
                patient.Gender = genderComboBox.Text;
                if(dateTimePicker.Value > DateTime.Today)
                {
                    MessageBox.Show("Ingrese una fecha valida", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    streetNumberTextBox.Focus();
                    return;
                }
                else
                {
                    patient.BirthDate = dateTimePicker.Value;
                }

                PatientsAddresses patientAddress = new PatientsAddresses();
                patientAddress.Patient = patient;
                patientAddress.PatientId = patient.Id;
                patientAddress.Street = streetTextBox.Text;
                patientAddress.StreetNumber = Convert.ToInt32(streetNumberTextBox.Text);
                patient.Address = patientAddress.Address;

                if (string.IsNullOrEmpty(floorTextBox.Text))
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
            SearchTextBox.Clear();
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
                pntDetail.patientIdLabel.Text = dr.Cells[0].Value.ToString();
                pntDetail.FirstNameTextBoxUpdate.Text = dr.Cells[1].Value.ToString();
                pntDetail.LastNameTextBoxUpdate.Text = dr.Cells[2].Value.ToString();
                pntDetail.genderComboBoxUpdate.Text = dr.Cells[4].Value.ToString();              
                pntDetail.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = patientDataGridView1.SelectedRows[0];
                if(MessageBox.Show("Desea eliminar el registro del paciente?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _patientManager.Delete(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Paciente eliminado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Fallo la eliminacion del paciente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(SearchTextBox.Text))
                {
                    MessageBox.Show("Ingrese un ID de paciente", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchTextBox.Focus();
                    return;
                }
                if (SearchTextBox.Text.Length > 6)
                {
                    MessageBox.Show("El ID ingresado es demasiado largo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    SearchTextBox.Focus();
                    return;
                }
                //int id = Convert.ToInt32(SearchTextBox.Text);
                //var patient = _patientManager.GetPatientsById(id);
                //patientDataGridView1.Rows.Clear();

                //patientDataGridView1.Rows.Add(patient);

               


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}