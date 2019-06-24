using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.Model
{
    public class Jogo
    {
        [Key]
        public int Id { get; set; }
        public int Jogadas { get; set; }
        public string Jogador1 { get; set; }
        public string Jogador2 { get; set; }
        public DateTime DataInicio { get; set; }
        public string Resultado { get; set; }
        public string JogadaJogador1 { get; set; }
        public string JogadaJogador2 { get; set; }
        public int? VitoriaJogador1 { get; set; }
        public int? VitoriaJogador2 { get; set; }
        public string Status { get; set; }
        public int? RodadaAtual { get; set; }
    }
}
