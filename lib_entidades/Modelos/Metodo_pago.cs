using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lib_entidades.Modelos
{
    public class Metodo_pago
    {
        [Key] public int ID_Pago { get; set; }
        public string? Tipo_Pago { get; set; }

    }
}