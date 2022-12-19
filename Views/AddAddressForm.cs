using PatientCRUD.Entities;
using PatientCRUD.Manager;
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
    public partial class AddAddressForm : Form
    {
        public AddAddressForm()
        {
            InitializeComponent();
        }
        PatientManager _patientManager = new PatientManager();

        private void AddAddressButtonForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(AddStreeTextBox.Text))
                {
                    MessageBox.Show("Ingrese una calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddStreeTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(AddStreetNumberTextBox.Text))
                {
                    MessageBox.Show("Ingrese un numero de calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddStreetNumberTextBox.Focus();
                    return;
                }

                PatientsAddresses patientAddress = new PatientsAddresses();
                //patientAddress.Patient = patient;
                patientAddress.PatientId = Convert.ToInt32(PatientID.Text);
                patientAddress.Street = AddStreeTextBox.Text;
                if (AddStreetNumberTextBox.Text.Length > 2)
                {
                    MessageBox.Show("El numero de calle debe contener un maximo de dos(2) digitos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    AddStreetNumberTextBox.Focus();
                    return;
                }
                else
                {
                    patientAddress.StreetNumber = Convert.ToInt32(AddStreetNumberTextBox.Text);
                }

                if (string.IsNullOrEmpty(AddFloorTextBox.Text))
                {
                    patientAddress.Floor = null;
                }
                else
                {
                    if (AddFloorTextBox.Text.Length > 2)
                    {
                        MessageBox.Show("El numero de piso debe contener un maximo de dos(2) digitos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AddFloorTextBox.Focus();
                        return;
                    }
                    patientAddress.Floor = Convert.ToInt32(AddFloorTextBox.Text);
                }
                if (AddApartTextBox.Text != null)
                {
                    if (AddApartTextBox.Text.Length > 2)
                    {
                        MessageBox.Show("El numero de apartamento debe contener un maximo de dos(2) caracteres", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        AddApartTextBox.Focus();
                        return;
                    }
                    patientAddress.Apartment = AddApartTextBox.Text;
                }
                if (_patientManager.AddAdditionalAddress(patientAddress))
                {
                    MessageBox.Show("Domicilio agregado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //LoadAddresses();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fallo la operacion", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
