using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    class Department
    {
        private string departmentID;
        private string departmentName;
        private int amountOfPatient;
        public string DepartmentID
        {
            set { this.departmentID = value; }
            get { return this.departmentID; }
        }
        public string DepartmentName
        {
            set { this.departmentName = value; }
            get { return this.departmentName; }
        }
        public int AmountOfPatient
        {
            set { this.amountOfPatient = value; }
            get { return this.amountOfPatient; }
        }
    }
}
