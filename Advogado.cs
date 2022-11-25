using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvocaciaPrincipal.modelo
{
    public class Advogado
    {
        public int Codigo { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public char Sexo {get; set;}
        
        public bool verificarSeAdvogadoEMaiorIdade()
        {
            if (this.Idade>=18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public List<Advogado> getAllAdvogados()
        {
            return null;
        }
        public bool eExperiente()
        {
            return false;
        }
    }   
}   
