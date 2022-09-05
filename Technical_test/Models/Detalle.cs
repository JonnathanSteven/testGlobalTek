using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Technical_test.Models
{
    public class Detalle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int idDetalle { get; set; }
        /*
        public int idFactura { get; set; }
        [ForeignKey("idFactura")]
        public  Factura Factura { get; set; }

        public int idProducto { get; set; }
        [ForeignKey("idProducto")]
        public Producto Producto { get; set; }*/

        public int Cantidad { get; set; }
        public int PrecioUnitario { get; set; }
    }
}