namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AxParticipantePacote")]
    public partial class AxParticipantePacote
    {
        [Key]
        public int CodParticipantePacote { get; set; }

        public int? codParticipante { get; set; }

        public int? codPacote { get; set; }
    }
}
