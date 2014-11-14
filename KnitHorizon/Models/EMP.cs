//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KnitHorizon.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    
    public partial class EMP
    {
        [Display(Name = "Software ID")]
        public int ENO { get; set; }
        public string Comp_Code { get; set; }
        [Display(Name = "Name")]
        public string ENAME { get; set; }
        [Display(Name = "F/H/G Name")]
        public string FHGName { get; set; }
        public string AReg_Sno { get; set; }
        [Display(Name = "Gender")]
        public string SEX { get; set; }
        public string Qualification { get; set; }
        [Display(Name = "Designation")]
        public string DESIGNATION { get; set; }
        public string Emp_Type { get; set; }
        [Display(Name = "Date of Birth")]
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DOJ { get; set; }
        [Display(Name = "Address")]
        public string ADDR1 { get; set; }
        public string ADDR2 { get; set; }
        public string ADDR3 { get; set; }
        [Display(Name = "Phone No")]
        public string phone { get; set; }
        [Display(Name = "Email")]
        public string email { get; set; }
        public byte[] Photo { get; set; }
        public decimal BASIC { get; set; }
        public Nullable<decimal> DA { get; set; }
        public Nullable<decimal> OALL { get; set; }
        public Nullable<decimal> HRA { get; set; }
        public Nullable<decimal> CONV { get; set; }
        public Nullable<decimal> ChdEduAll { get; set; }
        public string Incentives { get; set; }
        public string OTST { get; set; }
        public string ITST { get; set; }
        public string ESIST { get; set; }
        public string PFST { get; set; }
        public string ottype { get; set; }
        public string shift { get; set; }
        public string OSTAY { get; set; }
        public string MOP { get; set; }
        public string PFNO { get; set; }
        public string ESINO { get; set; }
        public Nullable<decimal> PROFTAX { get; set; }
        public Nullable<System.DateTime> WEFROM { get; set; }
        public string EMPSTATUS { get; set; }
        public Nullable<System.DateTime> DOL { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string compensate { get; set; }
        public string TDS { get; set; }
        public Nullable<double> TDS_Amt { get; set; }
        public string PTSts { get; set; }
        public string Bank_Name { get; set; }
        public string Bank_Ac { get; set; }
        public string Bank_Sts { get; set; }
        public string LIC_Sts { get; set; }
        public string LIC_No { get; set; }
        public Nullable<decimal> LicAmt { get; set; }
        [Display(Name = "Department ")]
        public string Dept { get; set; }
        public Nullable<System.DateTime> RegDate { get; set; }
        [Display(Name = "Marital Status")]
        public string MaritalStatus { get; set; }
        public string CoffStatus { get; set; }
        [Display(Name = "Grade")]
        public string Grade { get; set; }
        public string RFL { get; set; }
        [Display(Name = "ID Number")]
        public string SSN { get; set; }
        public Nullable<decimal> act_gross { get; set; }
        public Nullable<decimal> comp_gross { get; set; }
    }
}
