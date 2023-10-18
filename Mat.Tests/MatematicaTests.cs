using Mat.Console.Services;

namespace Mat.Tests;

public class MatematicaTests
{
    private Matematica _mat = new Matematica();

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(2, 2)]
    [InlineData(3, 6)]
    [InlineData(5, 120)]
    public void DeveInformarUmNumeroInteiroNaoNegativoERetornarSeuFatorial(uint n, int fatorialEsperado)
    {
        //Act
        int fatorial = _mat.CalcularFatorial(n);
        
        //Assert
        Assert.Equal(fatorialEsperado, fatorial);
    }

    [Theory]
    [InlineData(3, 4, 5, "Sim")]
    [InlineData(8, 8, 8, "Sim")]
    [InlineData(9, 9, 7, "Sim")]
    [InlineData(3, 6, 10, "Não")]
    public void DeveInformarTresMedidasInteirasPositivasERetornarSeEhPossivelFormarTrianguloComElas(int medida1, int medida2, int medida3, string resultadoEsperado)
    {
        //Act
        string resultado = _mat.VerificarExistenciaTriangulo(medida1, medida2, medida3);

        //Assert
        Assert.Equal(resultadoEsperado, resultado);
    }
}