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
    
    public partial class Factura
    {
        public int idFactura { get; set; }
        public int Monto { get; set; }
        public System.DateTime Fecha { get; set; }
        public int Servicio { get; set; }
    
        public virtual Servicio Servicio1 { get; set; }
    }
}
