using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
  public partial class Tesis
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codigoTesis { get; set; }

        [Required]
        [StringLength(1)]
        public string nombreTesis { get; set; }

        [Required]
        [StringLength(1)]
        public string codigoAsesor { get; set; }

        [Required]
        [StringLength(1)]
        public string codigoAlumno { get; set; }

        public short? codigoEntregable { get; set; }

        public virtual Alumno Alumno { get; set; }

        public virtual Docente Docente { get; set; }

        public virtual Entregable Entregable { get; set; }
    }
}
