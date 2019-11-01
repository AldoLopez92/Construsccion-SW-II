using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Requisito")]
    public partial class Requisito
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Requisito()
        {
            InformacionBachiller = new HashSet<InformacionBachiller>();
            InformacionTitulo = new HashSet<InformacionTitulo>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codigoRequisito { get; set; }

        [Required]
        [StringLength(1)]
        public string nombreRequisito { get; set; }

        [Required]
        [StringLength(1)]
        public string descripcionRequisito { get; set; }

        [StringLength(1)]
        public string tiempoEstimadoRequisito { get; set; }

        public int? costoRequisito { get; set; }

        public virtual Costo Costo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacionBachiller> InformacionBachiller { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InformacionTitulo> InformacionTitulo { get; set; }
    }
}
