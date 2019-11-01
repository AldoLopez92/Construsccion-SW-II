using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BackEnd.Models
{
    [Table("InformacionBachiller")]
    public partial class InformacionBachiller
    {
        [Required]
        [StringLength(1)]
        public string codigoAlumnoCorrespondenciaInformacionBachiller { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int codigoInformacionBachiller { get; set; }

        [Required]
        [StringLength(1)]
        public string nombreInformacionBachiller { get; set; }

        [StringLength(1)]
        public string descrpcionInformacionBachiller { get; set; }

        public int codigoRequisito { get; set; }

        public virtual Requisito Requisito { get; set; }
    }
}
