using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ecommerce.Entidades
{
    public partial class TALLES
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TALLES()
        {
            ARTICULOS = new HashSet<ARTICULOS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(3)]
        public string MEDIDA { get; set; }

        public bool ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ARTICULOS> ARTICULOS { get; set; }
    }
}
