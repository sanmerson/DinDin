namespace API.Models {
    public class ResponseModel <TGeneric>{
        public TGeneric? Dados { get; set; }
        public string Mensagem { get; set; } = string.Empty;
        public bool Status { get; set; } = true;
    }
}
