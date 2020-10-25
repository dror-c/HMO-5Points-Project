using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    class GenericTherapy
    {
        private string therapyCode;
        private string nameOftherapy;
        private string durationOfTherapy;
        private string typeOfTherapy;
        private string whoCanGiveTheTherapy;
        public string TherapyCode
        {
            set { this.therapyCode = value; }
            get { return this.therapyCode; }
        }
        public string NameOftherapy
        {
            set { this.nameOftherapy = value; }
            get { return this.nameOftherapy; }
        }
        public string DurationOfTherapy
        {
            set { this.durationOfTherapy = value; }
            get { return this.durationOfTherapy; }
        }
        public string TypeOfTherapy
        {
            set { this.typeOfTherapy = value; }
            get { return this.typeOfTherapy; }
        }
        public string WhoCanGiveTheTherapy
        {
            set { this.whoCanGiveTheTherapy = value; }
            get { return this.whoCanGiveTheTherapy; }
        }
    }
}
