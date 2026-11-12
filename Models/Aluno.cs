namespace ProjetoPortfolio.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public string TecnologiasConhecida { get; set; }
        public string SobreAluno { get; set; }
        public string HabilidadesCertificados { get; set; }
        public string Experiencia { get; set; }
        public string FerramentasConhecidas { get; set; }
        public int TurmaId { get; set; }
        public Turma? Turma { get; set; }
    }
}
