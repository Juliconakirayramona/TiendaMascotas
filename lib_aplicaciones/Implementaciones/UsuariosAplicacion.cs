﻿using lib_aplicaciones.Interfaces;
using System.Linq.Expressions;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;

namespace lib_aplicaciones.Implementaciones
{
    public class UsuariosAplicacion : IUsuariosAplicacion
    {
        private IUsuariosRepositorio? iRepositorio = null;

        public UsuariosAplicacion(IUsuariosRepositorio iRepositorio)
        {
            this.iRepositorio = iRepositorio;
        }

        public void Configurar(string string_conexion)
        {
            this.iRepositorio!.Configurar(string_conexion);
        }

        public Usuarios Borrar(Usuarios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Usuario == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Borrar(entidad);
            return entidad;
        }

        public Usuarios Guardar(Usuarios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Usuario != 0)
                throw new Exception("lbYaSeGuardo");

            entidad = iRepositorio!.Guardar(entidad);
            return entidad;
        }

        public List<Usuarios> Listar()
        {
            return iRepositorio!.Listar();
        }

        public List<Usuarios> Buscar(Usuarios entidad, string tipo)
        {
            Expression<Func<Usuarios, bool>>? condiciones = null;
            switch (tipo.ToUpper())
            {
                case "NOMBRE": condiciones = x => x.Nombre!.Contains(entidad.Nombre!); break;
                default: condiciones = x => x.ID_Usuario == entidad.ID_Usuario; break;
            }
            return this.iRepositorio!.Buscar(condiciones);
        }

        public Usuarios Modificar(Usuarios entidad)
        {
            if (entidad == null || !entidad.Validar())
                throw new Exception("lbFaltaInformacion");

            if (entidad.ID_Usuario == 0)
                throw new Exception("lbNoSeGuardo");

            entidad = iRepositorio!.Modificar(entidad);
            return entidad;
        }
    }
}