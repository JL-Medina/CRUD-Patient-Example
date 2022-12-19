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
    public partial class UpdateAddress : Form
    {
        public UpdateAddress()
        {
            InitializeComponent();
        }
        PatientManager _patientManager = new PatientManager();
        private void UpdateAddressButtonForm_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(UpdateStreeTextBox.Text))
                {
                    MessageBox.Show("Ingrese una calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStreeTextBox.Focus();
                    return;
                }
                if (string.IsNullOrEmpty(UpdateStreetNumberTextBox.Text))
                {
                    MessageBox.Show("Ingrese un numero de calle", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStreetNumberTextBox.Focus();
                    return;
                }

                PatientsAddresses patientAddress = new PatientsAddresses();
                patientAddress.PatientId = Convert.ToInt32(UpdatePatientID.Text);
                patientAddress.Id = Convert.ToInt32(UpdateAddressId.Text);
                patientAddress.Street = UpdateStreeTextBox.Text;
                if (UpdateStreetNumberTextBox.Text.Length > 2)
                {
                    MessageBox.Show("El numero de calle debe contener un maximo de dos(2) digitos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    UpdateStreetNumberTextBox.Focus();
                    return;
                }
                else
                {
                    patientAddress.StreetNumber = Convert.ToInt32(UpdateStreetNumberTextBox.Text);
                }

                if (string.IsNullOrEmpty(UpdateFloorTextBox.Text))
                {
                    patientAddress.Floor = null;
                }
                else
                {
                    if (UpdateFloorTextBox.Text.Length > 2)
                    {
                        MessageBox.Show("El numero de piso debe contener un maximo de dos(2) digitos", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateFloorTextBox.Focus();
                        return;
                    }
                    patientAddress.Floor = Convert.ToInt32(UpdateFloorTextBox.Text);
                }
                if (UpdateApartTextBox.Text != null)
                {
                    if (UpdateApartTextBox.Text.Length > 2)
                    {
                        MessageBox.Show("El numero de apartamento debe contener un maximo de dos(2) caracteres", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        UpdateApartTextBox.Focus();
                        return;
                    }
                    patientAddress.Apartment = UpdateApartTextBox.Text;
                }
                if (_patientManager.UpdateAddress(patientAddress))
                {
                    MessageBox.Show("Domicilio editado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Fallo la edicion del domicilio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
