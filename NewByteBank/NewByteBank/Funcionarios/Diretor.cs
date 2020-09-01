using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace NewByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
     
        public override double GetBonificacao()
        {
        
            return Salario + base.GetBonificacao();
        }
    }
}
