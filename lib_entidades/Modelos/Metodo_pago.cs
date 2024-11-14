using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace lib_entidades.Modelos
{
    public class Metodo_pago
    {
        [Key] public int ID_Pago { get; set; }
        public string? Tipo_Pago { get; set; }
        public bool Validar()
        {
            if (string.IsNullOrEmpty(Tipo_Pago))
                return false;
            return true;
        }

    }
}