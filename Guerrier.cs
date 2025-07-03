using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duel_de_guerrier
{
    internal class Guerrier
    {   // attributs
        private string _nomDuGuerrier;
        private int _pointsDeVie;
        private int _nbDesAttaque;

        // constructor
        public Guerrier(string nomDuGuerrier, int pointsDeVie, int nbDesAttaque)
        {
            _nomDuGuerrier = nomDuGuerrier;
            _pointsDeVie = pointsDeVie;
            _nbDesAttaque = nbDesAttaque;
        }
        
        // méthodes publiques
        public string GetNom()
        {
            return _nomDuGuerrier;
        }
        public int GetPointsDeVie()
        {
            return _pointsDeVie;
        }
        public void SetPointsDeVie(int pointsDeVie)
        {

        }
        public int GetNbDesAttaque() 
        {
            return _nbDesAttaque;
        }
        
        // méthodes essentielles
        public void AfficherInfos() 
        {
            Console.WriteLine($"Nom : {GetNom()}\nHP : {GetPointsDeVie()}\nNombres d'attaques : {GetNbDesAttaque()}");
        }
        public virtual int Attaquer() 
        {
            Random des = new Random();
            int degats = 0;
            for (int i = 0; i < _nbDesAttaque; i++) 
            {
                degats += des.Next(1, 7);
            }
            Console.WriteLine($"{GetNom()} inflige {degats} dégats à l'adversaire");
            return degats;
        }
        public void SubirDegats(int degats)
        {
            _pointsDeVie -= degats;
            if (_pointsDeVie < 0)
            {
                _pointsDeVie = 0;
            } else if (_pointsDeVie <= 0) 
            {
                Console.WriteLine("Game Over..");
                return;
            }
                Console.WriteLine($"{GetNom()} à subis {degats} points de dégats.\nPoints de vie restants : {_pointsDeVie}");
        }
    }
}
