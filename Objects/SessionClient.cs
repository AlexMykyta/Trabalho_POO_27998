namespace Objects
{
    public static class SessionClient
    {
        public static Guid UserId { get; set; }       // Armazena o ID do utilizador
        public static string UserName { get; set; }   // Armazena o nome do utilizador

        // Método para iniciar a sessão do cliente
        public static void StartSession(Guid clientID, string clientName)
        {
            UserId = clientID;
            UserName = clientName;
        }

        // Método para encerrar a sessão do cliente (limpar dados)
        public static void EndSession()
        {
            UserId = Guid.Empty;
            UserName = null;
        }
    }
}