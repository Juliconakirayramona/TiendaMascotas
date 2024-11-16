using lib_entidades;
using lib_entidades.Modelos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace asp_presentacion.Pages.Ventanas.Menu
{
    public class MenuModel : PageModel
    {
        public void OnGet()
        {
            ViewData["Mensaje"] = "Pruebas de datos";

            Lista.Add(new Clientes()
            {
                ID_Persona = 1,
                Cedula = "120129283",
                Nombre = "Juan",
            });

        }

        public Clientes Actual { get; set; }
        public void OnPostBtGuardar()
        {
            Lista.Add(Actual);
        }
        public List<Clientes> Lista { get; set; } = new List<Clientes>();
    }


}