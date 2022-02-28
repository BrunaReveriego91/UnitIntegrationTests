using Moq;
using NSubstitute;
using TesteIntegracao.Domain;
using Xunit;

namespace TesteIntegracao.UnitTests
{
    public class MoqTests
    {
        [Fact(DisplayName = "Mock saque com sucesso NSubstitute")]
        public void Saque_Com_Sucesso_NSUb()
        {
            var caixa = Substitute.For<ICaixa>(); //cria objeto mock
            int valorDoSaque = 50;
            caixa.Saque(valorDoSaque).Returns(new int[] { }); //efetua a simulação do saque e assegura que retorno é int de array
            caixa.Received(1); //confirma que método foi executado uma única vez
        }

        [Fact(DisplayName = "Mock saque com sucesso Moq")]
        public void Saque_Com_Sucesso_Moq()
        {
            var caixa = new Mock<ICaixa>(); // cria objeto mock
            int valorDoSaque = 50;
            caixa.Object.Saque(valorDoSaque); //efetua simulação de saque
            caixa.Verify(r => r.Saque(valorDoSaque), Times.Once); // confirma que método foi executado uma unica vez
        }
    }
}
