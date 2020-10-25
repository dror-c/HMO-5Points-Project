using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrorCohen.DB;
using DrorCohen.Utility;
namespace DrorCohen.Models
{
    public class Patient: IEntity
    {
        private string id;
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string dateOfBirth;//string or dateTime
        private string dateOfDeath;//string or dateTime
        private string maleOrFemale;
        public string Id
        {
            set
            {
                if (ValidationUtilites.IsLegalId(value))
                    this.id = value;
            }
            get { return this.id; }
        }
        public string FirstName
        {
            set 
            {
                if(ValidationUtilites.IsLegalName(value))
                    this.firstName = value;
            }
            get { return this.firstName; }
        }
        public string LastName
        {
            set 
            {
                if (ValidationUtilites.IsLegalName(value))
                    this.lastName = value;
            }
            get { return this.lastName; }
        }
        public string Address
        {
            set 
            {
                if (ValidationUtilites.IsLegalName(value))
                    this.address = value;
            }
            get { return this.address; }
        }
        public string PhoneNumber
        {
            set 
            {
                if(ValidationUtilites.IsLegalPhoneNumber(value))
                    this.phoneNumber = value;
            }
            get { return this.phoneNumber; }
        }
        public string DateOfBirth
        {
            set { this.dateOfBirth = value; }
            get { return this.dateOfBirth; }
        }
        public string DateOfDeath
        {
            set { this.dateOfDeath = value; }
            get { return this.dateOfDeath; }
        }
        public string MaleOrFemale
        {
            set 
            {
               if(ValidationUtilites.IsLegalSex(value))
                   this.maleOrFemale = value;
            }
            get { return this.maleOrFemale; }
        }
        public Patient() { }
        public Patient(DataRow dr)
        {
            this.Id = dr["ID"].ToString();
            this.FirstName = dr["FirstName"].ToString();
            this.LastName = dr["LastName"].ToString();
            this.Address = dr["Address"].ToString();
            this.PhoneNumber = dr["PhoneNumber"].ToString();
            this.DateOfBirth = dr["DateOfBirth"].ToString();
            this.DateOfDeath = dr["DateOfDeath"].ToString();
            this.MaleOrFemale = dr["Male/Female"].ToString();
        }
        public void Populate(DataRow dr)
        {
            dr["ID"] = Id;
            dr["FirstName"] = FirstName;
            dr["LastName"] = LastName;
            dr["Address"] = Address;
            dr["PhoneNumber"] = PhoneNumber;
            dr["DateOfBirth"] = DateOfBirth;
            dr["DateOfDeath"] = DateOfDeath;
            dr["Male/Female"] = MaleOrFemale;
        }
    }
}
