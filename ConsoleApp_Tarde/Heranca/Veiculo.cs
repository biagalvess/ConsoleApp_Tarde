using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_Tarde.Heranca
{
    public class Veiculo
    {
        public string cor;
        public int quantidadaRodas;
        public int quantidadeAcentos;
        public bool TemMotor;

        public string ExibirDados()
        {
            if (TemMotor)
            {
               return "Tem motor" + cor + " " + quantidadeAcentos + "  " + quantidadaRodas;
            }
            else
            {
                return cor + " " + quantidadeAcentos + "  " + quantidadaRodas;
            }
            
        }

    }

}
