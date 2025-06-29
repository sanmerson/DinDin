using System.Text.Json.Serialization;

namespace API.Models.Economias {
    public enum TiposEntradaESaida {
        Entrada = 0,
        Saida = 1,
    }
    public class EntradasESaidasModel {
        public int Id { get; set; }
        public decimal ValorEntradaESaida { get; set; }
        public DateTime DataEntradaESaida { get; set; }

        public int EconomiasId { get; set; }
        public EconomiasModel Economias { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TiposEntradaESaida Tipo { get; set; }
    }
}
