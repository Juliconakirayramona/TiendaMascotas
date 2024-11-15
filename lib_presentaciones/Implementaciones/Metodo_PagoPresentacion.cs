using lib_comunicaciones.Interfaces;
using lib_entidades;
using lib_entidades.Modelos;
using lib_presentaciones.Interfaces;
using lib_utilidades;

namespace lib_presentaciones.Implementaciones
{
    public class Metodo_pagopresentacion : IMetodo_pagopresentacion
    {
        private IMetodo_pagoComunicacion? iComunicacion = null;

        public Metodo_pagopresentacion(IMetodo_pagoComunicacion iComunicacion)
        {
            this.iComunicacion = iComunicacion;
        }

        public async Task<List<Metodo_pago>> Listar()
        {
            var lista = new List<Metodo_pago>();
            var datos = new Dictionary<string, object>();

            var respuesta = await iComunicacion!.Listar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Metodo_pago>>(
                JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }

        public async Task<List<Metodo_pago>> Buscar(Metodo_pago entidad, string tipo)
        {
            var lista = new List<Metodo_pago>();
            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;
            datos["Tipo"] = tipo;

            var respuesta = await iComunicacion!.Buscar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            lista = JsonConversor.ConvertirAObjeto<List<Metodo_pago>>(
                JsonConversor.ConvertirAString(respuesta["Entidades"]));
            return lista;
        }

        public async Task<Metodo_pago> Guardar(Metodo_pago entidad)
        {
            if (entidad.ID_Pago != 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }

            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;

            var respuesta = await iComunicacion!.Guardar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<Metodo_pago>(
                JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

        public async Task<Metodo_pago> Modificar(Metodo_pago entidad)
        {
            if (entidad.ID_Pago == 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }

            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;

            var respuesta = await iComunicacion!.Modificar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<Metodo_pago>(
                JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }

        public async Task<Metodo_pago> Borrar(Metodo_pago entidad)
        {
            if (entidad.ID_Pago == 0 || !entidad.Validar())
            {
                throw new Exception("lbFaltaInformacion");
            }

            var datos = new Dictionary<string, object>();
            datos["Entidad"] = entidad;

            var respuesta = await iComunicacion!.Borrar(datos);
            if (respuesta.ContainsKey("Error"))
            {
                throw new Exception(respuesta["Error"].ToString()!);
            }
            entidad = JsonConversor.ConvertirAObjeto<Metodo_pago>(
                JsonConversor.ConvertirAString(respuesta["Entidad"]));
            return entidad;
        }
    }
}