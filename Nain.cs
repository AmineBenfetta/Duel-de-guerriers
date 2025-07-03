using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Duel_de_guerrier
{
    internal class Nain : Guerrier
    { 
        private bool _armureLourde;
        public Nain(string nomDuGuerrier, int pointsDeVie, int nbDesAttaque, bool armureLourde) : base(nomDuGuerrier, pointsDeVie, nbDesAttaque)
        {
            _armureLourde = armureLourde;
        }
       

        public override void SubirDegats(int degats)
        {
            _pointsDeVie -= degats;
            if (_armureLourde == true)
            {
                degats = degats / 2;
                
            } else if (_pointsDeVie < 0) 
            {
                _pointsDeVie = 0;
            }
                Console.WriteLine($"{GetNom()} à subis {degats} points de dégats.\nPoints de vie restants : {_pointsDeVie}");
        }
    }
}
