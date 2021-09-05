namespace Bootcamp.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }

        public Usuario(string nome, string email, string senha, string perfil)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
            Perfil = perfil;
        }
    }
}
