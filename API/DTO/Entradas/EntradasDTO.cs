using API.Models;
using System.Text.Json.Serialization;

namespace API.DTO.Entradas {
    public class EntradasDTO {
        public int Id { get; set; }
        public string? Nome { get; set; }
        public float? Valor { get; set; }
        public DateTime?  DataEntrada { get; set; }
        public Boolean? Recorrente { get; set; }
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public TipoEntrada? Tipo { get; set; }
    }
}
