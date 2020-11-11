using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiSeguridadMVC.Models;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace MiSeguridadMVC.Models
{
    public class Recursos
    {
        public int ID { get; set; }//ID

        [StringLength(60, MinimumLength = 3)] // longitud de nombre
        public string nombre { get; set; } //STRING NOMBRE
        
        [StringLength(60, MinimumLength = 3)]
        public string disponibilidad { get; set; }//STRING disponible


        //FECHA PETICION
        
        [Display(Name = "Fecha de petición")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaPrime { get; set; }

        //FECHA ENTREFA
        
        [Display(Name = "Fecha de Entrega")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FechaEntrega { get; set; }

    }
    public class EmpDBContext : DbContext
    {
        public EmpDBContext()
        {

        }
        public DbSet<Recursos> Recursos { get; set; }
    }
}
