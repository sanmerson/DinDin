using System.Text.Json.Serialization;

namespace API.Models.Acoes {
    public enum TipoPapel {
        Compra = 0,
        Venda = 1,
    }
    public class PapeisModel {
        public int Id { get; set; }
        public decimal PrecoPapel {  get; set; }
        public int QuantidadePapel { get; set; }
        public DateTime DataCompraOuVenda {  get; set; }

        public int AcoesId { get; set; }
        public AcoesModel Acao { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipoPapel TipoPapel { get; set; }
    }
}
