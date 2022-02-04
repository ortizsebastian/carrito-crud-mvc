using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ecommerce.Entidades
{
    public partial class DOMICILIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOMICILIOS()
        {
            CLIENTES = new HashSet<CLIENTES>();
            USUARIOS = new HashSet<USUARIOS>();
        }

        public int ID { get; set; }

        [StringLength(50)]
        public string CALLE { get; set; }

        [StringLength(5)]
        public string NUMERO { get; set; }

        [StringLength(50)]
        public string PROVINCIA { get; set; }

        public bool ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CLIENTES> CLIENTES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIOS> USUARIOS { get; set; }
    }
}
