using JoKenPoAPI.Data.Strategies.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JoKenPoAPI.Data.Strategies
{
    public class Context: IJogo
    {
        private IJogo _jogo;

        public Context(IJogo ijogo)
        {
            _jogo = ijogo;
        }

        public bool Post()
        {
            return _jogo.Post();
        }
    }
}
