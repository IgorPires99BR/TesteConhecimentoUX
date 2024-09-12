namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Atividade")]
    public partial class Atividade
    {
        [Key]
        public int CodAtividade { get; set; }

        [StringLength(50)]
        public string DescAtv { get; set; }

        public int? Vagas { get; set; }

        public decimal? Preco { get; set; }
    }
}
