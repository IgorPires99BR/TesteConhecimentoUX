namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AxParticipanteAtividade")]
    public partial class AxParticipanteAtividade
    {
        [Key]
        public int CodParticipanteAtividade { get; set; }

        public int? CodParticipante { get; set; }

        public int? CodAtividade { get; set; }
    }
}
