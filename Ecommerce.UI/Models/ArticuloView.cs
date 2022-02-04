﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Ecommerce.UI.Models
{
    public class ArticuloView
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}