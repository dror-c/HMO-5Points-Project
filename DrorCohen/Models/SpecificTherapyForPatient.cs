using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    class SpecificTherapyForPatient
    {
        private string serial;
        private string therapyCode;
        private DateTime dateOfTherapy;
        //private string wasTheTherapyGiven;
        public string Serial
        {
            set
            {
                this.serial = value;
            }
            get
            {
                return this.serial;
            }
        }
        public string TherapyCode
        {
            set
            {
                this.therapyCode = value;
            }
            get
            {
                return this.therapyCode;
            }
        }
        public DateTime DateOfTherapy
        {
            set
            {
                this.dateOfTherapy = value;
            }
            get
            {
                return this.dateOfTherapy;
            }
        }
        //public string WasTheTherapyGiven
        //{
        //    set
        //    {
        //        this.wasTheTherapyGiven = value;
        //    }
        //    get
        //    {
        //        return this.wasTheTherapyGiven;
        //    }
        //}
    }
}
