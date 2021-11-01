using System;
namespace Spesa.Models
{
    public class Ingrediente
    {
        public string consistenza;
        public string colore;
        public string orgine;
        private string nome;
        public string conservazione;
   

        public Ingrediente(string n)
        {
            nome = n;
        }
    }
}
