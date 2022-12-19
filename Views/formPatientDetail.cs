using PatientCRUD.Entities;
using PatientCRUD.Manager;
using PatientCRUD.Models.Entities;

namespace PatientCRUD.Views
{
    public partial class formPatientDetail : Form
    {

        public formPatientDetail()
        {
            InitializeComponent();
        }

        PatientManager _patientManager = new PatientManager();

        private void updateButton1_Click(object sender, EventArgs e)
        {
            
            try
            {

                if (string.IsNullOrEmpty(FirstNameTextBoxUpdate.Text))
                {
                    MessageBox.Show("Ingrese un nombre", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    FirstNameTextBoxUpdate.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(LastNameTextBoxUpdate.Text))
                {
                    MessageBox.Show("Ingrese un apellido", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    LastNameTextBoxUpdate.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(genderComboBoxUpdate.Text))
                {
                    MessageBox.Show("Seleccione sexo", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    genderComboBoxUpdate.Focus();
                    return;
                }
              
                Patient patient = new Patient();
                patient.Id = Convert.ToInt32(patientIdLabel.Text);
                patient.FirstName = FirstNameTextBoxUpdate.Text;
                patient.LastName = LastNameTextBoxUpdate.Text;
                patient.Gender = genderComboBoxUpdate.Text;
                if (dateTimePickerUpdate.Value > DateTime.Today)
                {
                    MessageBox.Show("Ingrese una fecha valida", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    dateTimePickerUpdate.Focus();
                    return;
                }
                else
                {
                    patient.BirthDate = dateTimePickerUpdate.Value;
                }

                if (_patientManager.Update(patient))
                {
                    MessageBox.Show("Paciente editado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fallo la edicion del paciente", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
            
        }

        
    }
}
