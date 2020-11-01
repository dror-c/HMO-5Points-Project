using DrorCohen.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrorCohen.DB;
namespace DrorCohen.Models
{
    public class DoctorOrNurse: Patient,IEntity
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
            set { this.departmentID = value; }
            get { return this.departmentID; }
        }
        public DoctorOrNurse() { }
        public DoctorOrNurse(DataRow dr)
        {
            this.Id = dr["ID"].ToString();
            this.FirstName = dr["FirstName"].ToString();
            this.LastName = dr["LastName"].ToString();
            this.Address = dr["Address"].ToString();
            this.PhoneNumber = dr["PhoneNumber"].ToString();
            this.DateOfBirth = Convert.ToDateTime(dr["DateOfBirth"]);
            this.DateOfDeath = Convert.ToDateTime(dr["DateOfDeath"]);
            this.MaleOrFemale = dr["MaleFemale"].ToString();
            this.DepartmentID = dr["DepartmentID"].ToString();
            this.IsDoctorOrNurse = dr["IsDoctorOrNurse"].ToString();
        }
        public override void Populate(DataRow dr)
        {
            dr["ID"] = Id;
            dr["FirstName"] = FirstName;
            dr["LastName"] = LastName;
            dr["Address"] = Address;
            dr["PhoneNumber"] = PhoneNumber;
            dr["DateOfBirth"] = DateOfBirth;
            dr["DateOfDeath"] = DateOfDeath;
            dr["MaleFemale"] = MaleOrFemale;
            /*How use the populate in Patient and add continue to the populate*/
            dr["DepartmentID"] = DepartmentID;
            dr["IsDoctorOrNurse"] = IsDoctorOrNurse;

        }
    }
}
