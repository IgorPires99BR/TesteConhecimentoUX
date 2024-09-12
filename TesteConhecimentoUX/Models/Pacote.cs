namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Pacote")]
    public partial class Pacote
    {
        [Key]
        public int CodPacote { get; set; }

        public decimal? Preco { get; set; }

        [StringLength(200)]
        public string Descricao { get; set; }
    }
}
