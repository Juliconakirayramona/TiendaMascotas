﻿using lib_entidades;
using lib_entidades.Modelos;
using lid_repositorios.Interfaces;
using System.Linq.Expressions;

namespace lib_repositorios.Implementaciones
{
    public class UsuariosRepositorio : IUsuariosRepositorio
    {
        private Conexion? conexion = null;

        public UsuariosRepositorio(Conexion conexion)
        {
            this.conexion = conexion;
        }

        public void Configurar(string string_conexion)
        {
            this.conexion!.StringConnection = string_conexion;
        }

        public List<Usuarios> Listar()
        {
            return conexion!.Listar<Usuarios>();
        }

        public List<Usuarios> Buscar(Expression<Func<Usuarios, bool>> condiciones)
        {
            return conexion!.Buscar(condiciones);
        }

        public Usuarios Guardar(Usuarios entidad)
        {
            conexion!.Guardar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Usuarios Modificar(Usuarios entidad)
        {
            conexion!.Modificar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }

        public Usuarios Borrar(Usuarios entidad)
        {
            conexion!.Borrar(entidad);
            conexion!.GuardarCambios();
            return entidad;
        }
    }
}
