namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Participante")]
    public partial class Participante
    {
        [Key]
        public int codPar { get; set; }

        [StringLength(50)]
        public string Nome { get; set; }

        public DateTime? DataNascimento { get; set; }

        [StringLength(20)]
        public string Telefone { get; set; }
    }
}
