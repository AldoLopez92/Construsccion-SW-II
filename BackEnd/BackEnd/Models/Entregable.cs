using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Entregable")]
    public partial class Entregable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Entregable()
        {
            Tesis = new HashSet<Tesis>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short codigoEntregable { get; set; }

        [Required]
        [StringLength(1)]
        public string archivo { get; set; }

        [StringLength(1)]
        public string medalla { get; set; }

        [StringLength(1)]
        public string comentario { get; set; }

        [StringLength(1)]
        public string estado { get; set; }

        public short? codigoGammificacion { get; set; }

        public virtual Gammificacion Gammificacion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tesis> Tesis { get; set; }
    }
}
