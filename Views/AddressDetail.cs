using PatientCRUD.Entities;
using PatientCRUD.Manager;
using PatientCRUD.Models.Entities;
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
    public partial class AddressDetail : Form
    {
        public AddressDetail()
        {
            InitializeComponent();
            //LoadAddresses();    
        }
        PatientManager _patientManager = new PatientManager();
        public void LoadAddresses()
        {
            var id = Convert.ToInt32(PatientIdLabel.Text);
            var addresses1 = _patientManager.GetAddressByPatientId(id);       
            AddressDataGrid.Rows.Clear();
            foreach (var address in addresses1)
            {
                AddressDataGrid.Rows.Add(address.Id, address.Street, address.StreetNumber, address.Floor, address.Apartment);
            }
        }

        private void AddAddressButton_Click(object sender, EventArgs e)
        {
            AddAddressForm addAddress = new AddAddressForm();
            addAddress.PatientID.Text = PatientIdLabel.Text;
            addAddress.ShowDialog();
            LoadAddresses();
        }


        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = AddressDataGrid.SelectedRows[0];
                if (MessageBox.Show("Desea eliminar el domicilio del paciente?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    int id = (int)dr.Cells[0].Value;
                    bool isDelete = _patientManager.DeleteAddress(id);
                    if (isDelete)
                    {
                        MessageBox.Show("Paciente eliminado con exito", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadAddresses();
                    }
                    else
                    {
                        MessageBox.Show("Fallo la eliminacion del domicilio", "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = AddressDataGrid.SelectedRows[0];
                UpdateAddress uptAddress = new UpdateAddress();
                uptAddress.UpdatePatientID.Text = PatientIdLabel.Text;
                uptAddress.UpdateAddressId.Text = dr.Cells[0].Value.ToString();
                uptAddress.UpdateStreeTextBox.Text = dr.Cells[1].Value.ToString();
                uptAddress.UpdateStreetNumberTextBox.Text = dr.Cells[2].Value.ToString();
                if (dr.Cells[3].Value != null)
                {
                    uptAddress.UpdateFloorTextBox.Text = dr.Cells[3].Value.ToString();
                }
                
                if (dr.Cells[4].Value != null)
                {
                    uptAddress.UpdateApartTextBox.Text = dr.Cells[4].Value.ToString();
                }
                
                uptAddress.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
            }
        }
    }
}
