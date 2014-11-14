using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KnitHorizon.Models;

namespace KnitHorizon.Controllers
{
    public class EMPController : Controller
    {
        private knithEntities db = new knithEntities();

        // GET: /EMP/
        public ActionResult Index()
        {
            return View(db.EMPs.ToList());
        }

        // GET: /EMP/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP emp = db.EMPs.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // GET: /EMP/Create
        public ActionResult Create()
        {
            // Finf the depertment in and name
            var query = db.Departments.ToList();
            ViewData["Department"] = new SelectList(query, "SlNo", "Department1").ToList();
            var query1 = db.Designations.ToList();
            ViewData["Designations"] = new SelectList(query1, "SlNo", "Designation1 ").ToList();

            return View();
        }

        // POST: /EMP/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include="ENO,Comp_Code,ENAME,FHGName,AReg_Sno,SEX,Qualification,DESIGNATION,Emp_Type,DOB,DOJ,ADDR1,ADDR2,ADDR3,phone,email,Photo,BASIC,DA,OALL,HRA,CONV,ChdEduAll,Incentives,OTST,ITST,ESIST,PFST,ottype,shift,OSTAY,MOP,PFNO,ESINO,PROFTAX,WEFROM,EMPSTATUS,DOL,Reason,Remarks,compensate,TDS,TDS_Amt,PTSts,Bank_Name,Bank_Ac,Bank_Sts,LIC_Sts,LIC_No,LicAmt,Dept,RegDate,MaritalStatus,CoffStatus,Grade,RFL,SSN,act_gross,comp_gross")] EMP emp)
        {
            if (ModelState.IsValid)
            {
                db.EMPs.Add(emp);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(emp);
        }

        // GET: /EMP/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP emp = db.EMPs.Find(id);
         
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: /EMP/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include="ENO,Comp_Code,ENAME,FHGName,AReg_Sno,SEX,Qualification,DESIGNATION,Emp_Type,DOB,DOJ,ADDR1,ADDR2,ADDR3,phone,email,Photo,BASIC,DA,OALL,HRA,CONV,ChdEduAll,Incentives,OTST,ITST,ESIST,PFST,ottype,shift,OSTAY,MOP,PFNO,ESINO,PROFTAX,WEFROM,EMPSTATUS,DOL,Reason,Remarks,compensate,TDS,TDS_Amt,PTSts,Bank_Name,Bank_Ac,Bank_Sts,LIC_Sts,LIC_No,LicAmt,Dept,RegDate,MaritalStatus,CoffStatus,Grade,RFL,SSN,act_gross,comp_gross")] EMP emp)
        {
            if (ModelState.IsValid)
            {
                db.Entry(emp).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(emp);
        }

        // GET: /EMP/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EMP emp = db.EMPs.Find(id);
            if (emp == null)
            {
                return HttpNotFound();
            }
            return View(emp);
        }

        // POST: /EMP/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EMP emp = db.EMPs.Find(id);
            db.EMPs.Remove(emp);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
