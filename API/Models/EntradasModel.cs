namespace API.Models {
    public enum TipoEntrada {
        Salario = 1,
        Beneficio = 2,
        Outro = 3,
    }
    public class EntradasModel {
        public int Id { get; set; }
        public required string Nome { get; set; }
        public float Valor { get; set; }
        public DateTime DataEntrada { get; set; }
        public Boolean Recorrente { get; set; }
        public required TipoEntrada Tipo { get; set; }
    }
}
