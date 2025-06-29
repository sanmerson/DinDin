using System.Text.Json.Serialization;

namespace API.Models.Saidas {
    public class SaidasModel {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataSaida { get; set; }

        [JsonIgnore]
        public ICollection<ParcelasModel> Parcelas { get; set; } = new List<ParcelasModel>();
    }
}
