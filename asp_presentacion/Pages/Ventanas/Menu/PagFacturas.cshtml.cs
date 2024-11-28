
using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using lib_entidades;

namespace asp_presentacion.Pages.Ventanas.Menu
{
    public class FacturasModel : PageModel
    {
        private IFacturaspresentacion? iPresentacion = null;

        public FacturasModel(IFacturaspresentacion iPresentacion)
        {
            try
            {
                this.iPresentacion = iPresentacion;
                Filtro = new Facturas();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        [BindProperty] public Enumerables.Ventanas Accion { get; set; }
        [BindProperty] public Facturas? Actual { get; set; }
        [BindProperty] public Facturas? Filtro { get; set; }
        [BindProperty] public List<Facturas>? Lista { get; set; }

        public async Task OnGet()
        {
            await OnPostBtRefrescar();
        }

        public async Task OnPostBtRefrescar()
        {
            try
            {
                Filtro!.Codigo_Factura = Filtro!.Codigo_Factura ?? "";

                Accion = Enumerables.Ventanas.Listas;
                Lista = await this.iPresentacion!.Buscar(Filtro!, "Codigo Factura");
                Actual = null;
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtModificar(string data)
        {
            try
            {
                await OnPostBtRefrescar();
                Accion = Enumerables.Ventanas.Editar;
                Actual = Lista!.FirstOrDefault(x => x.ID_Factura.ToString() == data);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }


        public async Task OnPostBtNuevo()
        {
            try
            {
                Accion = Enumerables.Ventanas.Nuevo; 
                Actual = new Facturas(); 
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtGuardar()
        {
            try
            {
                Accion = Enumerables.Ventanas.Editar;
                Task<Facturas>? task = null;
                if (Actual!.ID_Factura == 0 )
                    task = this.iPresentacion!.Guardar(Actual!);
                else
                    task = this.iPresentacion!.Modificar(Actual!);
                Actual = await task;
                Accion = Enumerables.Ventanas.Listas;
                await OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtBorrarVal(string data)
        {
            try
            {
                await OnPostBtRefrescar();
                Accion = Enumerables.Ventanas.Borrar;
                Actual = Lista!.FirstOrDefault(x => x.ID_Factura.ToString() == data);
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtBorrar()
        {
            try
            {
                var task = this.iPresentacion!.Borrar(Actual!);
                Actual = await task;
                await OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtCancelar()
        {
            try
            {
                Accion = Enumerables.Ventanas.Listas;
                await OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }

        public async Task OnPostBtCerrar()
        {
            try
            {
                if (Accion == Enumerables.Ventanas.Listas)
                    await OnPostBtRefrescar();
            }
            catch (Exception ex)
            {
                LogConversor.Log(ex, ViewData!);
            }
        }
    }

}