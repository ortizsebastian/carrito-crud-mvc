using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;


namespace Ecommerce.Entidades
{
    public partial class CARRITOS
    {
        [Key]
        [Column(Order = 0)]
        public int ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID_VENTA { get; set; }

        public int ID_ARTICULO { get; set; }

        public bool ESTADO { get; set; }

        public virtual ARTICULOS ARTICULOS { get; set; }

        public virtual VENTAS VENTAS { get; set; }
    }
}
