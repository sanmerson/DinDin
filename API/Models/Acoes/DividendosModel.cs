namespace API.Models.Acoes {
    public class DividendosModel {
        public int Id { get; set; }
        public decimal ValorDividendo { get; set; }
        public DateTime DataDividendo { get; set; }


        public int AcoesId { get; set; }
        public AcoesModel Acao { get; set; }
    }
}
