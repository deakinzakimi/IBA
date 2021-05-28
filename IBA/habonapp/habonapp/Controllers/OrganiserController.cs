using habonapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace habonapp.Controllers
{
    public class OrganiserController : Controller
    {



        MySqlConnection cnn = new MySqlConnection("server=127.0.0.1;database=iba;uid=root;pwd=Project@010998;");
        // GET: Organiser
        public ActionResult Index()
        {
            return View();
        }

        // GET: Organiser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Organiser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Organiser/Create
        [HttpPost]
        public ActionResult Index(String username, String password)
        {
            Organiser o = new Organiser();
            o.username = username;
            o.password = password;

            try
            {
                string Query = "select ousername,opassword from organizer where ousername='" + o.username + "';";

                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);
             
                cnn.Open();

                MySqlDataReader reader;
                reader = MyCommand2.ExecuteReader();
                if(reader.Read())
                {
                    string input_username = reader[0].ToString();
                    if(o.username == input_username)
                    {
                        ViewBag.result = "Successful login";
                        return View();
                    }
                }
                else
                {
                    ViewBag.result = "Unsuccessful login";
                    return View();
                }

                reader.Close();


                MyCommand2.ExecuteNonQuery();     // Here our query will be executed and data saved into the database.  
              
                cnn.Close();
                TempData["Added"] = "Added";
                return RedirectToAction("Index");
            
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                return View();
            }
        }

        // GET: Organiser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Organiser/Edit/5
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

        // GET: Organiser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Organiser/Delete/5
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
