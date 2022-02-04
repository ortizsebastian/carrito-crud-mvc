using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ecommerce.Entidades
{
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            VENTAS = new HashSet<VENTAS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string USERNAME { get; set; }

        [Required]
        [StringLength(50)]
        public string PASSWORD { get; set; }

        public bool TIPO { get; set; }

        [StringLength(30)]
        public string NOMBRE { get; set; }

        [StringLength(30)]
        public string APELLIDO { get; set; }

        [Required]
        [StringLength(100)]
        public string EMAIL { get; set; }

        [StringLength(50)]
        public string TELEFONO { get; set; }

        public int? ID_DOMICILIO { get; set; }

        public bool ESTADO { get; set; }

        public virtual DOMICILIOS DOMICILIOS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VENTAS> VENTAS { get; set; }
    }
}
