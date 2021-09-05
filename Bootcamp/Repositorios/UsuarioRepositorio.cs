using Bootcamp.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Bootcamp.Repositorios
{
    public class UsuarioRepositorio
    {
        private ICollection<Usuario> Usuarios { get; set; }

        public UsuarioRepositorio()
        {
            Usuarios = new List<Usuario>();
            Usuarios.Add(new Usuario("Joao", "joao@gmail.com","123456","Aluno")); 
            Usuarios.Add(new Usuario("Marcelo", "marcelo@gmail.com", "123456", "Aluno"));
            Usuarios.Add(new Usuario("Maria", "maria@gmail.com", "123456", "Matematico"));
            Usuarios.Add(new Usuario("Roberto", "roberto@gmail.com", "123456", "Matematico"));
        }

        public Usuario ObterUsuario(string email, string senha)
        {
            return Usuarios
                .Where(u => u.Email.ToLower().Contains(email.ToLower()) && u.Senha.ToLower().Contains(senha.ToLower()))
                .SingleOrDefault();
        }
    }
}
