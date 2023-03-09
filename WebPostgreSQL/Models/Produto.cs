using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPostgreSQL.Models
{
    [Table("Produto")]
    public class Produto
    {
        [Column("Id")]
        [Display(Name ="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        
        public string Nome  { get; set; }

        [Column("Email")]

        public string Email { get; set; }


        [Column("CPF")]
        

        public string CPF { get; set; }


        [Column("RG")]
        public string RG { get; set; }

        //[Column("Nascimento")]
        //public DateTime Nascimento { get; set; }


        [Column("Telefone")]
        
        public string Telefone { get; set; }


        //[Column("DataCadastro")]
        //public DateTime DataCadastro { get; set; }

        [Column("Estado")]
        public string Estado { get; set; }

    }
}
