using MovimentoEstoque.BLL.Entities.Enums;
using MovimentoEstoque.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovimentoEstoque.BLL.Classes
{
    class MovimentoEstoque
    {
        public int Id { get; }
        public DateTime DataMovimentoEstoque { get; set; }
        public Produto Produto { get; set; }        
        public int QuantidadeMovimento { get; set; }
        public int SaldoEstoque { get; set; }
        public TipoMovimento TipoMovimento { get; set; }

    }
}
