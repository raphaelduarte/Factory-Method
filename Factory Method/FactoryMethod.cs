using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method
{
    public class FactoryMethod
    {
        public IPersonagem Escolher_Personagem(string personagem)
        {
            switch(personagem)
            {
                case "LiuKang": return new LiuKang();
                case "Subzero": return new Subzero();
                case "Scorpion": return new Scorpion();
                default: return null;
            }
        }
    }
}
