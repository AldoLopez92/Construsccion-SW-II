using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("InformacionTitulo")]
    public partial class InformacionTitulo
    {
        [Required]
        [StringLength(1)]
        public string codigoAlumnoCorrespondenciaInformacionTitulo { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codigoInformacionTitulo { get; set; }

        [Required]
        [StringLength(1)]
        public string nombreInformacionTitulo { get; set; }

        [StringLength(1)]
        public string descripcionInformacionTitulo { get; set; }

        public int codigoRequisito { get; set; }

        public virtual Requisito Requisito { get; set; }
    }
}
