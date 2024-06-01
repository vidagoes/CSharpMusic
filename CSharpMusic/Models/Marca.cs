using System.ComponentModel.DataAnnotations;

namespace CSharpMusic.Models
{
    public class Marca
    {

        public int Marcaid { get; set; }

        [Required]
        public string Nome { get; set; }    


    }
}
