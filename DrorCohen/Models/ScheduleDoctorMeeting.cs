using DrorCohen.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.Models
{
    public class ScheduleDoctorMeeting:IEntity
    {
        private string therapyCode;
        private string whoCanGiveTheTherapy;
        private string idDoctor;
        private int day;
        private string hour;
        
        public ScheduleDoctorMeeting() { }
        public ScheduleDoctorMeeting(DataRow dr)
        {
            this.TherapyCode = dr["TherapyCode"].ToString();
            this.whoCanGiveTheTherapy = dr["WhoCanGiveTheTherapy"].ToString();
            this.idDoctor = dr["IdDoctor"].ToString();
            this.day =Convert.ToInt32(dr["day"].ToString());
            this.hour = dr["hour"].ToString();
        }

        public string TherapyCode
        {
            set { this.therapyCode = value; }
            get { return this.therapyCode; }
        }
        public string WhoCanGiveTheTherapy
        {
            set { this.whoCanGiveTheTherapy = value; }
            get { return this.whoCanGiveTheTherapy; }
        }
        public string IdDoctor
        {
            set { this.idDoctor = value; }
            get { return this.idDoctor; }
        }
        public int Day
        {
            set { this.day = value; }
            get { return this.day; }
        }
        public string Hour
        {
            set { this.hour = value; }
            get { return this.hour; }
        }
        
        public virtual void Populate(DataRow dr)
        {
            dr["TherapyCode"] = TherapyCode;
            dr["WhoCanGiveTheTherapy"] = WhoCanGiveTheTherapy;
            dr["IdDoctor"] = idDoctor;
            dr["day"] = day;
            dr["hour"] = hour;
        }
    }
}
