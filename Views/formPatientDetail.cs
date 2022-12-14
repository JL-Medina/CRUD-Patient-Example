using PatientCRUD.Entities;
using PatientCRUD.Manager;
using PatientCRUD.Models.Entities;
using PatientCRUD.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    //if (string.IsNullOrEmpty(FirstNameLabel.Text))
                    //{
                    //    MessageBox.Show("Ingrese un nombre", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //}
                    Patient patient = new Patient();
                    patient.FirstName = FirstNameTextBox.Text;
                    patient.LastName = LastNameTextBox.Text;
                    //patient.BirthDate = dateTimePicker.Value;
                    //patient.Gender = genderComboBox.ValueMember;

                    PatientsAddresses patientAddress = new PatientsAddresses();
                    patientAddress.PatientId = patient.Id;
                    //patientAddress.Street = streetTextBox.Text;
                    //patientAddress.StreetNumber = Convert.ToInt32(streetNumberTextBox.Text);
                   // patientAddress.Floor = Convert.ToInt32(floorTextBox.Text);
                    //patientAddress.Apartment = apartmentTextBox.Text;
                    if (_patientManager.Update(patient, patientAddress))
                    {
                        MessageBox.Show("Cambios guardados con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                        //LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Fallo el guardado", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }
    }
}
