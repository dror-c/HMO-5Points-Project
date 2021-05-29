using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DrorCohen.Models;
using System.Data;
using DrorCohen.DATA;

namespace DrorCohen.DB
{
    public class PatientDB : GeneralDB
    {
        public PatientDB() : base("Patient", "ID") { }
        public new Patient GetCurrentRow()
        {
            return new Patient(base.GetCurrentRow());
        }
        public DataView GetDataView()
        {
            DAL d = DAL.GetInstance();
            DataTable a = d.GetDisplayTable("Patient", "Select * From Patient");
            return new DataView(table);

        }
        //החזרת מפתח ראשי האחרון
        //public /*int*/ string GetKey()
        //{
        //    int x = currentRow;
        //    GoToLast();
        //    //int key = Convert.ToInt32(base.GetCurrentRow()[primaryKey]) + 1;
        //    string key = Convert.ToString(Convert.ToString(base.GetCurrentRow()[primaryKey]) + 1);
        //    currentRow = x;
        //    return key;
        //}
        public string GetKeyName()
        {
            return "ID";
        }
        public void Update(Patient cos)
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
    }
}