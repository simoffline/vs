using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KN133PfisterSYelögrüE.Models;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Threading;
using System.Globalization;

namespace KN133PfisterSYelögrüE.Controllers
{
    public class TorschuetzenController : Controller
    {
        // GET: Torschützen
        public ActionResult Torschuetzen()
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-us");
            List<Torschuetzen> torschütze = new List<Torschuetzen>();
            string constring = "Data Source=DESKTOP-NNGJNDN;Initial Catalog=db_fussballliga;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            if (con.State == ConnectionState.Open)
            {
                string query = "SELECT TOP 10 spielername, anzahltore FROM tbl_spieler ORDER BY anzahltore";
                SqlCommand command;
                SqlDataReader reader;
                command = new SqlCommand(query, con);
                reader = command.ExecuteReader();
                
                int i = 0;
                
                while (reader.Read())
                {
                    torschütze.Add(new Torschuetzen(reader.GetString(0).ToString(), Convert.ToInt16(reader.GetValue(1))));
                    i++;
                }
                reader.Close();
                con.Close();
            }
            
            
            return View(torschütze);

        }
    }
}