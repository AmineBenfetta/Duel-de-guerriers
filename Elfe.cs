using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel_de_guerrier
{
    internal class Elfe : Guerrier
    {
        public Elfe(string nomDuGuerrier, int pointsDeVie, int nbDesAttaque) : base(nomDuGuerrier, pointsDeVie, nbDesAttaque)
        {
        }
        public override int Attaquer()
        {
            Random des = new Random();
            int degats = 0;
            for (int i = 0; i < _nbDesAttaque; i++)
            {
                degats += des.Next(1, 7);
            }
            if (_pointsDeVie == 0)
            {
                Console.WriteLine($"Attaque impossible, {GetNom()} est mort au combat.");
                return 0;
            } else if (degats < 7) 
            {
                degats = 7;
            }

                Console.WriteLine($"{GetNom()} inflige {degats} dégats à l'adversaire");
            return degats;
        }
    }
}
