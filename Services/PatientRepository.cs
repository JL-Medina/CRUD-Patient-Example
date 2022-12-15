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
        public bool Update(Patient patient)
        {
            var data = _dbContext.Patients.FirstOrDefault(c => c.Id == patient.Id);
            
            if (data == null)
            {
                return false;
            }
            data.FirstName = patient.FirstName;
            data.LastName = patient.LastName;
            data.BirthDate = patient.BirthDate;
            data.Gender = patient.Gender;
            data.Address = patient.Address;
            return _dbContext.SaveChanges() > 0;
        }
        public bool UpdateAddress(PatientsAddresses address)
        {
            var data2 = _dbContext.PatientsAddresses.FirstOrDefault(c => c.Id == address.PatientId);
            if (data2 == null)
            {
                return false;
            }   
            data2.Street = address.Street;
            data2.StreetNumber = address.StreetNumber;
            data2.Floor = address.Floor;
            data2.Apartment = address.Apartment;
            return _dbContext.SaveChanges() > 0;
        }
        public bool Delete(int id)
        {
            var patient = _dbContext.Patients.FirstOrDefault(c => c.Id == id);
            var address = _dbContext.PatientsAddresses.FirstOrDefault(c => c.PatientId == id);
            if (patient == null || address == null)
            {
                return false;
            }
            _dbContext.Patients.Remove(patient);
            _dbContext.PatientsAddresses.Remove(address);

            return _dbContext.SaveChanges() > 0;
        }
        public Patient? GetPatientsById(int id)
        {
            var patient = _dbContext.Patients.FirstOrDefault(c => c.Id == id);
            if (patient != null)
            {
                return patient;
            }
            return null;
        }
    }
}
