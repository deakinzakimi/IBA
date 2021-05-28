using habonapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace habonapp.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Student/Create
        public ActionResult Create()
        {
            return View();
        }
        MySqlConnection cnn = new MySqlConnection("server=127.0.0.1;database=iba;uid=root;pwd=Project@010998;");
        // POST: Student/Create
        [HttpPost]
        public ActionResult Index(string id, string firstname, string lastname, string email)
        {
            Student s = new Student();
            s.studentID = id;
            s.sactive = 1;
            s.firstname = firstname;
            s.lastname = lastname;
            s.email = email;

            try
            {
                // TODO: Add insert logic here
                string Query = "insert into student(sid, sactive, sfirstname, slastname, semail) values('" + s.studentID.ToString() + "','" + s.sactive.ToString() + "','" + s.firstname.ToString() + "','" + s.lastname.ToString() + "','" + s.email.ToString() + "');";

                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
             
                cnn.Open();
                MyCommand2.ExecuteNonQuery();  // Here our query will be executed and data saved into the database.  

  
                cnn.Close();
                TempData["Added"] = "Added";
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Student/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Student/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
