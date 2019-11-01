using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("Alumno")]
    public partial class Alumno
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Alumno()
        {
            Tesis = new HashSet<Tesis>();
        }

        [Key]
        [StringLength(1)]
        public string codigoAlumno { get; set; }

        [Required]
        [StringLength(20)]
        public string claveAlumno { get; set; }

        [Required]
        [StringLength(8)]
        public string dniPersona { get; set; }

        public bool? estadoMatricula { get; set; }

        [StringLength(1)]
        public string codigoFacultad { get; set; }

        [Required]
        [StringLength(1)]
        public string codigoPersona { get; set; }

        public virtual Facultad Facultad { get; set; }

        public virtual Persona Persona { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Tesis> Tesis { get; set; }
    }
}
