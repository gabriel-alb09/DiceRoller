using Microsoft.Maui.Controls.PlatformConfiguration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova.Models
{
    public class Dado
    {
    

        public int QtdLados { get; set; }
        public int NumeroSorteado { get; set; }

        public Dado(int quantidadeDeLados) {
            QtdLados = quantidadeDeLados;
        }
    public void Roll()
        {
            NumeroSorteado = new Random().Next(QtdLados) + 1;
        }

    }
}
