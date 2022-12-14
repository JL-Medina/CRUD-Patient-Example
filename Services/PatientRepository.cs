using PatientCRUD.Entities;
using PatientCRUD.Models;
using PatientCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientCRUD.Services
{
    public class PatientRepository
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Patient patient, PatientsAddresses patientAddress)
        {
            _dbContext.Patients.Add(patient);
            _dbContext.PatientsAddresses.Add(patientAddress);
            return _dbContext.SaveChanges() > 0;
        }
        public List<Patient> GetPatients()
        {
            return _dbContext.Patients.ToList();
        }
        public List<PatientsAddresses> GetPatientAddress()
        {
            return _dbContext.PatientsAddresses.ToList();
        }
        public bool Update(Patient patient, PatientsAddresses patientAddress)
        {
            var data = _dbContext.Patients.FirstOrDefault(c => c.Id == patient.Id);
            var data2 = _dbContext.PatientsAddresses.FirstOrDefault(c => c.Id == patientAddress.Id);
            if (data == null)
            {
                return false;
            }
            data.FirstName = patient.FirstName;
            data.LastName = patient.LastName;
            data.BirthDate = patient.BirthDate;
            data.Gender = patient.Gender;
            data.Address = patientAddress.Address;

            data2.PatientId = patient.Id;
            data2.Street = patientAddress.Street;
            data2.StreetNumber = patientAddress.StreetNumber;
            data2.Floor = patientAddress.Floor;
            data2.Apartment = patientAddress.Apartment;
            return _dbContext.SaveChanges() > 0;
        }

    }
}
