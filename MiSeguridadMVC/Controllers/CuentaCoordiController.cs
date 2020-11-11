using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiSeguridadMVC.Models;
using System.Data.SqlClient;


namespace MiSeguridadMVC.Controllers
{
    public class CuentaCoordiController : Controller
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        // GET: Account
        [HttpGet]
        public ActionResult InicioSesionCoordis()
        {
            return View();
        }

        //Conexion de la base de datos
        void connectionString()
        {
            con.ConnectionString = @"Data source=localhost\SQLEXPRESS;Initial Catalog=PrestamoCDB;Integrated Security=True";
        }

        //Verificamos la conexion mandando a llamar el modelo
        // GET: Account
        [HttpPost]
        public ActionResult Verify(Account acc)
        {
            connectionString();
            con.Open();
            com.Connection = con;
            //Realizamos la consula mandando a llamar la tabla login
            com.CommandText = "select * from loginCoordis where username='" + acc.Name + "' and password='" + acc.Password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                con.Close();
                return View("Index");
            }
            else
            {
                con.Close();
                return View("Error");
            }


        }
    }
}