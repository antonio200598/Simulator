using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Simulator.Models
{
    [Table("User")]
    public class User
    {
        [Display(Name = "Identificador")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("Name")]
        public string Name { get; set; }

        [Display(Name = "Senha")]
        [Column("Password")]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Column("Email")] 
        public string Email { get; set; }

        [Display(Name = "Data de Criação")]
        [Column("CreationDate")]
        public DateTime CreationDate { get; set; }
    }
}
