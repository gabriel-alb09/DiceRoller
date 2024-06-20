using CommunityToolkit.Mvvm.ComponentModel;
using Prova.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Prova.ViewModel
{
    public partial class DiceViewModel : ObservableObject
    {
        [ObservableProperty]
        private int quantidadeDelados;

        [ObservableProperty]
        private int numeroSorteado;

        public int Resultado { get; private set; }
        public ICommand RollComand { get; }

        public void Roll()
        {
            Dado dado = new Dado(QuantidadeDelados);
            dado.Roll();
            NumeroSorteado = dado.NumeroSorteado;
        }

        public DiceViewModel()
        {
            RollComand = new Command(Roll);
        }
    }
}
