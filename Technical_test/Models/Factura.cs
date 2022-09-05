using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Technical_test.Models
{
    public class Factura
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idFactura { get; set; }
        public int NumeroFactura { get; set; }
        public DateTime Fecha { get; set; }
        public string TipodePago { get; set; }
        public int DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public int Subtotal { get; set; }
        public int Descuento { get; set; }
        public int IVA { get; set; }
        public int TotalDescuento { get; set; }
        public int TotalImpuesto { get; set; }
        public int Total { get; set; }
    }
}