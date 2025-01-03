﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using lib_entidades.Modelos;

namespace lib_entidades
{
    public class Facturas
    {
        [Key] public int ID_Factura { get; set; }
        public string? Codigo_Factura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal IVA { get; set; }
        public decimal TOTAL { get; set; }
        public int Cliente { get; set; }
        public int Mascota { get; set; }
        public int Servicio { get; set; }
        public int Pago { get; set; }
        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Mascota")] public Mascotas? _Mascota { get; set; }
        [ForeignKey("Servicio")] public Servicios? _Servicio { get; set; }
        [ForeignKey("Pago")] public Metodo_pago? _Pago { get; set; }

        public bool Validar()
        {
            if (string.IsNullOrEmpty(Codigo_Factura))
                return false;
            return true;
        }

    }
}
