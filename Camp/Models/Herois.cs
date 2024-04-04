namespace Camp.Models;
    public class Herois
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
         public string Descricao { get; set; }
        public string Especie { get; set; }
        public List<string> Funcao { get; set; } = [];
        public List<string> Rota { get; set; }
        public string Imagem { get; set; }
    }
