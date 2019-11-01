using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Gammificacion")]
    public partial class Gammificacion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Gammificacion()
        {
            Entregable = new HashSet<Entregable>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short codigoGammificacion { get; set; }

        [Required]
        [StringLength(1)]
        public string nombre { get; set; }

        [Required]
        [StringLength(1)]
        public string imagen { get; set; }

        [Required]
        [StringLength(1)]
        public string descripcion { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Entregable> Entregable { get; set; }
    }
}
