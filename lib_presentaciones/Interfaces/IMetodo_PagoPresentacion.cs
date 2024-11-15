using lib_entidades;
using lib_entidades.Modelos;

namespace lib_presentaciones.Interfaces
{
    public interface IMetodo_pagopresentacion
    {
        Task<List<Metodo_pago>> Listar();
        Task<List<Metodo_pago>> Buscar(Metodo_pago entidad, string tipo);
        Task<Metodo_pago> Guardar(Metodo_pago entidad);
        Task<Metodo_pago> Modificar(Metodo_pago entidad);
        Task<Metodo_pago> Borrar(Metodo_pago entidad);
    }
}

