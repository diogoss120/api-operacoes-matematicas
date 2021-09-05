using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Bootcamp.Entities
{
    public class Calculos
    {

        [Display(Name = "Primeiro número")]
        [Required(ErrorMessage = "O primeiro número é obrigatório")]
        public double Numero01 { get; set; }

        [Display(Name = "Segundo número")]
        [Required(ErrorMessage = "O segundo número é obrigatório")]
        public double Numero02 { get; set; }

        public Calculos(double numero01, double numero02)
        {
            Numero01 = numero01;
            Numero02 = numero02;
        }

        public Calculos()
        {
        }

        public double Soma()
        {
            return Numero01 + Numero02;
        }

        public double Multiplicacao()
        {
            return Numero01 * Numero02;
        }

        public double Divisao()
        {
            if (Numero02 == 0)
                throw new ArgumentException("Não é possivel fazer uma divisão por zero");

            return Math.Round((Numero01 / Numero02), 2);
        }
    }
}
