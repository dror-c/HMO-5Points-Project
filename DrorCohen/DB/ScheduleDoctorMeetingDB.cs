using DrorCohen.DATA;
using DrorCohen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.DB
{
    public class ScheduleDoctorMeetingDB : GeneralDB
    {
        public ScheduleDoctorMeetingDB() : base("MeetingDoctor", "TherapyCode") { }
        public new ScheduleDoctorMeeting GetCurrentRow()
        {
           // DataRow dr = base.GetCurrentRow();
            return new ScheduleDoctorMeeting(base.GetCurrentRow());
        }
        public DataView GetDataView()
        {
            DAL d = DAL.GetInstance();
            DataTable a = d.GetDisplayTable("MeetingDoctor", "Select * From MeetingDoctor");
            return new DataView(table);
        }
        //החזרת מפתח ראשי האחרון
        public /*int*/ string GetKey()
        {
            int x = currentRow;
            GoToLast();
            //int key = Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1;
            string key = Convert.ToString(Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1);
            currentRow = x;
            return key;
        }
        public string GetKeyName()
        {
            return "TherapyCode";
        }
        public void Update(ScheduleDoctorMeeting cos)
        {
            DataRow dr = base.GetCurrentRow();
            cos.Populate(dr);
        }
        //public void Add(Customer cus)
        //{
        //    DataRow dr = base.Add(cus);
        //    cus.Populate(dr);
        //    //base.Add(dr);
        //    Find(cus.Id);
        //}
        //public static DataTable GetAllCustomer()
        //{
        //    DataTable tb;
        //    string sqlStat = "select customer_ID, last_name + ' ' + first_name as [fullName] From customers ";
        //    tb = DAL.GetInstance().GetDisplayTable("customer", sqlStat);
        //    return tb;
        //}
        //public DataView GetDataView()
        //{
        //    DAL d = DAL.GetInstance();
        //    DataTable a = d.GetDisplayTable("customers", "Select customer_ID, first_name,last_name From customers");
        //    return new DataView(table);

        //}
    }
}
