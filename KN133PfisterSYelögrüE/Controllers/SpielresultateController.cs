using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KN133PfisterSYelögrüE.Models;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;


namespace KN133PfisterSYelögrüE.Controllers
{
    public class SpielresultateController : Controller
    {
        // GET: SpielresultateEingeben
        public ActionResult Spielresultate()
        {
            List<Spielresultat> Spielresultate = new List<Spielresultat>();
            string constring = "Data Source=DESKTOP-NNGJNDN;Initial Catalog=db_fussballliga;Integrated Security=True";
            SqlConnection con = new SqlConnection(constring);

            if (con.State != ConnectionState.Open)
            {
                con.Open();
            }

            if (con.State == System.Data.ConnectionState.Open)
            {
                string query = "SELECT s.id, Team1.mannschaftsname, Team2.mannschaftsname, s.datum FROM tbl_spielergebnisse S, tbl_mannschaften Team1, tbl_mannschaften Team2 WHERE s.fk_heimteam = Team1.id AND s.fk_auswaertsteam = Team2.id ORDER BY CONVERT(date,s.datum, 104)";
                SqlCommand command;
                SqlDataReader reader;
                command = new SqlCommand(query, con);
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Spielresultate.Add(new Spielresultat(reader.GetInt32(0).ToString(), reader.GetString(1), reader.GetString(2), reader.GetString(3)));
                }
                reader.Close();
                con.Close();
                
            }
            
                return View(Spielresultate);
            
        }

        

    }
}