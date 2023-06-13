using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCPRACTICA1._0.Models
{
    public class Product
    {
        [Key]
        public int idProducto { get; set; }
        public string nombre { get; set; }
        public int precio { get; set; }
    }
}