using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace Ecommerce.Entidades
{
    public partial class ARTICULOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTICULOS()
        {
            CARRITOS = new HashSet<CARRITOS>();
        }

        public int ID { get; set; }

        [Required]
        [StringLength(4)]
        public string CODIGO { get; set; }

        [Required]
        [StringLength(100)]
        public string NOMBRE { get; set; }

        [Required]
        [StringLength(500)]
        public string DESCRIPCION { get; set; }

        [Column(TypeName = "money")]
        public decimal PRECIO { get; set; }

        public int STOCK { get; set; }

        [StringLength(1000)]
        public string IMG_URL { get; set; }

        [StringLength(1000)]
        public string IMG_URL2 { get; set; }

        public int? ID_TALLE { get; set; }

        public int? ID_CATEGORIA { get; set; }

        public int? ID_MARCA { get; set; }

        public bool ESTADO { get; set; }

        public virtual CATEGORIAS CATEGORIAS { get; set; }

        public virtual MARCAS MARCAS { get; set; }

        public virtual TALLES TALLES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CARRITOS> CARRITOS { get; set; }
    }
}
