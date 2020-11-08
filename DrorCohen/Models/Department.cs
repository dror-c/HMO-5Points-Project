using DrorCohen.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    public class Department: IEntity
    {
        private string departmentID;
        private string departmentName;
        private int amountOfPatient;

        public Department(DataRow dr)
        {
            this.departmentID = dr["DepartmentID"].ToString();
            this.departmentName = dr["DepartmentName"].ToString();
            this.amountOfPatient = (int)dr["AmountOfPatient"];
        }
        public Department() { }
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
        public void Populate(DataRow dr)
        {
            dr["DepartmentID"] = DepartmentID;
            dr["DepartmentName"] = DepartmentName;
            dr["AmountOfPatient"] = AmountOfPatient;
        }
    }
}
