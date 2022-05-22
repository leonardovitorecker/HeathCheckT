namespace HeathCheck1.Models
{
    public class ConsultaModel
    {
        public int id { get; set; }
        public string nomeEspecialista{ get; set; }
        public string nomePaciente { get; set; }

        public string descricaoConsulta { get; set; }
        public DateTime dataAgendamento { get; set; }
       

        public int especialistaid { get; set; }
        public EspecialistaModel especialista { get; set; }

        public int usuarioid { get; set; }
        public UsuarioModel usuario { get; set; }
    }
}
