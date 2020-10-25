using DrorCohen.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    class ConnectionTableBetweenPatientAndDoctorAndSpecificTherapy
    {
        private string serial;
        private string patientID;
        private string doctorID;
        public string Serial
        {
            set { this.serial = value; }
            get { return this.serial; }
        }
        public string PatientID
        {
            set 
            {
              if(ValidationUtilites.IsLegalId(value))
                    this.patientID = value;
            }
            get { return this.patientID; }
        }
        public string DoctorID
        {
            set 
            {
                if (ValidationUtilites.IsLegalId(value))
                    this.doctorID = value;
            }
            get { return this.doctorID; }
        }
    }
}
