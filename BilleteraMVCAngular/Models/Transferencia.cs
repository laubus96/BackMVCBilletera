//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BilleteraMVCAngular.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transferencia
    {
        public int idTranferencia { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
        public string Monto { get; set; }
        public int Usuario { get; set; }
        public int Moneda { get; set; }
        public int Destino { get; set; }
    
        public virtual Moneda Moneda1 { get; set; }
        public virtual Usuario Usuario1 { get; set; }
        public virtual Usuario Usuario2 { get; set; }
    }
}
