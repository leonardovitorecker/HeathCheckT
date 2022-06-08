namespace HeathCheck1.Models
{
    public class ConsultaModel
    {
        public int id { get; set; }
        public string tipovisita { get; set; }
        public string? nomePaciente { get; set; }
        public string? descricaoConsulta { get; set; }
        public DateTime dataAgendamento { get; set; }     
      

    }
}
