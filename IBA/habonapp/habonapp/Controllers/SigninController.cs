using habonapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MySql.Data.MySqlClient;

namespace habonapp.Controllers
{
    public class SigninController : Controller
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
        public ActionResult Index(string id, string firstname, string lastname, string address1, string address2, string suburb, string state, string postcode, string country, string phone, string email, string username, string password)
        {
            Organiser o = new Organiser();

            o.id = id;
            o.oactive = 1;
            o.firstname = firstname;
            o.lasttname = lastname;
            o.address1 = address1;
            o.address2 = address2;
            o.suburb = suburb;
            o.state = state;
            o.postcode = postcode;
            o.country = country;
            o.phone = phone;
            o.email = email;
            o.username = username;
            o.password = password;

            try
            {
                string Query = "insert into organizer(oid, oactive, ofirstname, olastname, oaddress1, oaddress2, osuburb, ostate, opostcode, ocountry, ophone, oemail, ousername, opassword) values('" + o.id.ToString() + "','" + o.oactive.ToString() + "','" + o.firstname.ToString() + "','" + o.lasttname.ToString() + "','" + o.address1.ToString() + "','" + o.address2.ToString() + "','" + o.suburb.ToString() + "','" + o.state.ToString() + "','" + o.postcode.ToString() + "','" + o.country.ToString() + "','" + o.phone.ToString() + "','" + o.email.ToString() + "','" + o.username.ToString() + "','" + o.password.ToString() + "');";

                //This is command class which will handle the query and connection object.  
                MySqlCommand MyCommand2 = new MySqlCommand(Query, cnn);

                cnn.Open();
                MyCommand2.ExecuteNonQuery();     // Here our query will be executed and data saved into the database.  

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