using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Persona")]
    public partial class Persona
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Persona()
        {
            Alumno = new HashSet<Alumno>();
            Docente = new HashSet<Docente>();
        }

        [Key]
        [StringLength(1)]
        public string codigoPersona { get; set; }

        [Required]
        [StringLength(8)]
        public string dniPersona { get; set; }

        [StringLength(1)]
        public string nombrePersona { get; set; }

        [StringLength(1)]
        public string apellidoPersona { get; set; }

        [Column(TypeName = "date")]
        public DateTime? fechaNacimientoPersona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Alumno> Alumno { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Docente> Docente { get; set; }
    }
}
