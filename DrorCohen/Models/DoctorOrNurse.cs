using DrorCohen.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    class DoctorOrNurse: Patient
    {
        private string isDoctorOrNurse;
        private string departmentID;
        public string IsDoctorOrNurse
        {
            set 
            {
                if (ValidationUtilites.IsLegalJob(value))
                    this.isDoctorOrNurse = value;
            }
            get { return this.isDoctorOrNurse; }
        }
        public string DepartmentID
        {
            set { this.DepartmentID = value; }
            get { return this.DepartmentID; }
        }
    }
}
