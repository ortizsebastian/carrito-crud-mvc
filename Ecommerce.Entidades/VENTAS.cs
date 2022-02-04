using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ecommerce.Entidades
{
    public partial class VENTAS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VENTAS()
        {
            CARRITOS = new HashSet<CARRITOS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string FORMA { get; set; }

        [Column(TypeName = "money")]
        public decimal MONTO { get; set; }

        public int? CUOTAS { get; set; }

        public int? ID_USUARIO { get; set; }

        public int? ID_CLIENTE { get; set; }

        public bool ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRITOS> CARRITOS { get; set; }

        public virtual CLIENTES CLIENTES { get; set; }

        public virtual USUARIOS USUARIOS { get; set; }
    }
}
