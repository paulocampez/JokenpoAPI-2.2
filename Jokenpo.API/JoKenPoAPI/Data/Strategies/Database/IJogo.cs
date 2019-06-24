using Jokenpo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoKenPoAPI.Data.Strategies.Database
{
    public interface IJogo
    {
        bool Post(Jogo jogo);
        List<Jogo> Get();
    }
}
