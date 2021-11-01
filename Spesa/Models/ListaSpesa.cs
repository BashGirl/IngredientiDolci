using System;
using System.Collections.Generic;

namespace Spesa
{
    public interface IListaSpesa
    {
        public void Aggiungi(string cosa);
        public void Rimuovi(string cosa);
    }

    public class ListaSpesa : IListaSpesa
    {
        private List<string> spesa = new List<string>()
        {
            "pre esistente 1", "pre esistente 2"
        };

        public void Aggiungi(string cosa)
        {
            if (cosa == "cane")
            {
                throw new Exception("Non puoi mettere un cane");
            }
            spesa.Add(cosa);
        }

        public void Rimuovi(string cosa)
        {
            if (cosa == "acqua")
            {
                throw new Exception("Non puoi rimuovere l'acqua");
            }
            spesa.Remove(cosa);
        }
    }
}
