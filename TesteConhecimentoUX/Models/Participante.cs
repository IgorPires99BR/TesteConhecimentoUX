namespace TesteConhecimentoUX.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Runtime.Serialization;

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
        [IgnoreDataMember]
        public int pacote { get; set; }
        public List<int> atividades { get; set; }
        [IgnoreDataMember]
        public EnumPacote nomePacote { get; set; }
        [IgnoreDataMember]
        public List<EnumAtividade> nomeAtividades { get; set; }


        public enum EnumPacote
        {
            [Description("Pacote Sócio")]
            Socio = 1,

            [Description("Pacote Não Sócio")]
            NaoSocio = 2
        }

        public enum EnumAtividade
        {
            [Description("Backstage")]
            Backstage = 1,

            [Description("Entrada Franca")]
            EntradaFranca = 2,
            [Description("Acesso Bradesco")]
            AcessoBradesco = 3
        }
    }
}
