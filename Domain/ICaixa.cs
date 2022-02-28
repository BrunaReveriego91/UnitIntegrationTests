using System.Collections.Generic;

namespace TesteIntegracao.Domain
{
    public interface ICaixa
    {
        ICollection<int> Saque(int valor);
        bool ValidaCedulasDisponiveis(int valor);
    }
}
