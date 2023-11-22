using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace bucci.sebastian._4i.rubrica
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    internal class Contatto
    {
        private int numero;
        private string nome;
        private string cognome;

        public int Numero { get => numero; set => numero = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cognome { get => cognome; set => cognome = value; }
    }
}
