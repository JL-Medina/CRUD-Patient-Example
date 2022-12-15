using PatientCRUD.Entities;
using PatientCRUD.Models.Entities;
using PatientCRUD.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCRUD.Manager
{
    public class PatientManager
    {
        PatientRepository _patientRepository = new PatientRepository();
        public bool Add(Patient patient, PatientsAddresses patientsAddresses)
        {
            return _patientRepository.Add(patient, patientsAddresses);
        }
        public List<Patient> GetPatients()
        {
            return _patientRepository.GetPatients();
        }
        public List<PatientsAddresses> GetPatientsAddresses()
        {
            return _patientRepository.GetPatientAddress();
        }
        public bool Update(Patient patient)
        {
            return _patientRepository.Update(patient);
        }
        public bool UpdateAddress(PatientsAddresses address)
        {
            return _patientRepository.UpdateAddress(address);
        }

    }
}
