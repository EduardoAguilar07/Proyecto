using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiSeguridadMVC.Models;

namespace MiSeguridadMVC.Controllers
{
    public class RecursosController: Controller
    { 
    public static List<Recursos> empList = new List<Recursos>
        {
            new Recursos
            {
                ID = 1,
                nombre = "  Salon 1",
                disponibilidad= "Disponible",
                FechaEntrega= DateTime.Parse(DateTime.Today.ToString()),
                FechaPrime= DateTime.Parse(DateTime.Today.ToString()),
            },
            new Recursos
            {
                ID = 2,
                nombre = "  Cañon 1",
                disponibilidad= "Disponible",
                FechaEntrega= DateTime.Parse(DateTime.Today.ToString()),
                FechaPrime= DateTime.Parse(DateTime.Today.ToString()),
            },
        };
    // GET: Clientes
    private EmpDBContext db = new EmpDBContext();
    public ActionResult Index()
    {
        var Recursos = from e in db.Recursos
                       orderby e.ID
                       select e;
        return View(Recursos);
    }

        public ActionResult Index2()
        {
            var Recursos = from e in db.Recursos
                           orderby e.ID
                           select e;
            return View(Recursos);
        }
        // GET: Clientes/Details/5
        public ActionResult Details(int id)
    {
        return View();
    }

    // GET: Clientes/Create
    public ActionResult Create()
    {
        return View();
    }

    // POST: Clientes/Create
    [HttpPost]
    public ActionResult Create(Recursos emp)
    {
        try
        {
            db.Recursos.Add(emp);
            db.SaveChanges();
            return RedirectToAction("Index2");

            // TODO: Add insert logic here
            //  Clientes emp = new Models.Clientes();
            //  emp.nombre = collection["nombre"];
            //  DateTime jDate;
            //  DateTime.TryParse(collection["DOB"], out jDate);
            // emp.FechaAlta = jDate;
            ///  string edad = collection["edad"];
            //  emp.edad = Int32.Parse(edad);
            // empList.Add(emp);
            
        }
        catch
        {
            return View();
        }
    }

    // GET: Clientes/Edit/5
    public ActionResult Edit(int id)
    {
        //   List<Clientes> empList = TodosLosClientes(); //lista de clientes y asignar empLIST donde se guarden
        var Recursos = db.Recursos.Single(m => m.ID == id);//CLIENTES TENDRA EL REGISTRO Y BUSCARA EL ID QUE TIENE CON EL QUE LE PUSIMOS
        return View(Recursos);//MUESTRA VIEW
    }

        public ActionResult Edit2(int id)
        {
            //   List<Clientes> empList = TodosLosClientes(); //lista de clientes y asignar empLIST donde se guarden
            var Recursos = db.Recursos.Single(m => m.ID == id);//CLIENTES TENDRA EL REGISTRO Y BUSCARA EL ID QUE TIENE CON EL QUE LE PUSIMOS
            return View(Recursos);//MUESTRA VIEW
        }

        // POST: Clientes/Edit/5
        [HttpPost]
    public ActionResult Edit(int id, FormCollection collection)
    {
        try
        {
            // TODO: Add update logic here

            var Recursos = db.Recursos.Single(m => m.ID == id);
            if (TryUpdateModel(Recursos))
            {
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(Recursos);

        }
        catch
        {
            return View();
        }
    }
        [HttpPost]
        public ActionResult Edit2(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                var Recursos = db.Recursos.Single(m => m.ID == id);
                if (TryUpdateModel(Recursos))
                {
                    db.SaveChanges();
                    return RedirectToAction("Index2");
                }

                return View(Recursos);

            }
            catch
            {
                return View();
            }
        }

        // GET: Clientes/Delete/5
        public ActionResult Delete(int id)
    {
        return View();
    }

    // POST: Clientes/Delete/5
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
    [NonAction]//no queremos que la gente acceda
    public List<Recursos> TodosLosRecursos()
    {

        return new List<Recursos>
            {
               new Recursos
            {
                ID = 1,
                nombre = "  Salon 1",
                disponibilidad= "Disponible",
                FechaEntrega= DateTime.Parse(DateTime.Today.ToString()),
                FechaPrime= DateTime.Parse(DateTime.Today.ToString()),
            },
            new Recursos
            {
                ID = 2,
                nombre = "  Cañon 1",
                disponibilidad= "Disponible",
                FechaEntrega= DateTime.Parse(DateTime.Today.ToString()),
                FechaPrime= DateTime.Parse(DateTime.Today.ToString()),
            },
        };


        }
}
}

