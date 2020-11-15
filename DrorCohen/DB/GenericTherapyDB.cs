using DrorCohen.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrorCohen.DB
{
    class GenericTherapyDB: GeneralDB
    {
        public GenericTherapyDB() : base("GenericTherapy", "TherapyCode") { }
        public new GenericTherapy GetCurrentRow()
        {
            return new GenericTherapy(base.GetCurrentRow());
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
        public void Update(GenericTherapy cos)
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
