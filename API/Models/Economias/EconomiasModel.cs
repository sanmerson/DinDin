using System.Text.Json.Serialization;

namespace API.Models.Economias {
    public class EconomiasModel {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        [JsonIgnore]
        public ICollection<EntradasESaidasModel> EntradaSaida { get; set; } = new List<EntradasESaidasModel>();
        public ICollection<RendimentosModel> Rendimentos { get; set; } = new List<RendimentosModel>();

    }
}
