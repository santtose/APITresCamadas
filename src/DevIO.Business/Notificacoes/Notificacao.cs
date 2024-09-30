namespace DevIO.Business.Notificacoes
{
    public class Notificacao
    {
        public Notificacao(string mensagem)
        {
            Mensagem = mensagem;
        }

        // Apenas get pq vai por construtor
        public string? Mensagem { get; set; }
    }
}
