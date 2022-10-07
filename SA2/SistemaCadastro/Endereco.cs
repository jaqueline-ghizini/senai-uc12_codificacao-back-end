using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    public class Endereco
    {
        public string logradouro { get; set; } // get é ver/exibir, e o set é alterar

        public int numero { get; set; }
        
        public string complemento { get; set; }

        public bool enderecoComercial { get; set; }

    }
}