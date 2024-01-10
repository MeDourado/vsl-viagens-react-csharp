using System.ComponentModel.DataAnnotations.Schema;


namespace destinos.Model
{
    public class Destino
    {

        [Column("id")]
        public int Id { get; set; }

        [Column("destino_nome")]
        public string Nome { get; set; } = string.Empty;

        [Column("destino_url")]
        public string Url { get; set; } = string.Empty;

        [Column("destino_preco")]
        public decimal Preco { get; set; }







    }
}