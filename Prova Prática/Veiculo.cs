using System;
using System.Collections.Generic;
using System.Text;

namespace Prova_Prática
{
    internal abstract class Veiculo
        {
        public required string Indentificacao;
        public int CapacidadeCarga;
        public string TipoCombustivel;
        private string QuantidadeEntrega;
protected abstract string RegistrarEntrega { get; }

}
}