using System.Collections.ObjectModel;
using System.Text.Json.Serialization;

namespace API.Models.Acoes {
    public class AcoesModel {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public DateTime DataAquisicao { get; set; }



        [JsonIgnore]
        public ICollection<PapeisModel> Papeis { get; set; } = new List<PapeisModel>();

        public ICollection<DividendosModel> Dividendos { get; set; } = new List<DividendosModel>();
    }
}
