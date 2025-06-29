namespace API.Models.Economias {
    public class RendimentosModel {
        public int Id { get; set; }
        public decimal ValorRendimento { get; set; }
        public DateTime DataRendimento { get; set; }

        public int EconomiasId { get; set; }
        public EconomiasModel Economias { get; set; }
    }
}
