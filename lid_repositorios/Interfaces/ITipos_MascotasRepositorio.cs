﻿using lib_entidades.Modelos;
using System.Linq.Expressions;

namespace lib_repositorios.Interfaces
{
    public interface ITipos_mascotasRepositorio
    {
        void Configurar(string string_conexion);
        List<Tipos_mascotas> Listar();
        Tipos_mascotas Guardar(Tipos_mascotas entidad);
        Tipos_mascotas Modificar(Tipos_mascotas entidad);
        Tipos_mascotas Borrar(Tipos_mascotas entidad);
    }
}