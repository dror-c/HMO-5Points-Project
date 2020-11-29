using DrorCohen.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    public class GenericTherapy:IEntity
    {
        private string therapyCode;
        private string nameOftherapy;
        private string durationOfTherapy;
        private string typeOfTherapy;
        private string whoCanGiveTheTherapy;
        public GenericTherapy() { }
        public GenericTherapy(DataRow dr)
        {
            this.TherapyCode = dr["TherapyCode"].ToString();
            this.nameOftherapy = dr["NameOftherapy"].ToString();
            this.durationOfTherapy = dr["DurationOfTherapy"].ToString();
            this.typeOfTherapy = dr["TypeOfTherapy"].ToString();
            this.whoCanGiveTheTherapy = dr["WhoCanGiveTheTherapy"].ToString();
        }

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
        public virtual void Populate(DataRow dr)
        {
            dr["TherapyCode"] = TherapyCode;
            dr["NameOftherapy"] = NameOftherapy;
            dr["DurationOfTherapy"] = DurationOfTherapy;
            dr["TypeOfTherapy"] = TypeOfTherapy;
            dr["WhoCanGiveTheTherapy"] = WhoCanGiveTheTherapy;
        }
    }
}
