namespace API.Models.Saidas {
    public class ParcelasModel {
        public int Id { get; set; }
        public int QuantidadeParcelas { get; set; }
        public decimal ValorParcelas { get; set; }
        public DateTime ParcelamentoInicio { get; set; }
        public DateTime ParcelamentoFim {  get; set; }

        public int SaidasId { get; set; }
        public SaidasModel Saidas { get; set; }
    }
}
