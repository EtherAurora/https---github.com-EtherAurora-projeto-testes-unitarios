using Calculadora.Models;
namespace Tests;

public class UnitTest1
{
    public Calculator construirClasse(){
        string data = "02/02/2020";
        Calculator calc = new Calculator("02/02/2020");
        return calc;
    }
    
    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(4, 5, 9)]
    public void Somar(int num1, int num2, int resultadoEsperado)
    {
        Calculator calc = construirClasse();
        int result = calc.Add(num1, num2);
        Assert.Equal(resultadoEsperado, result);
    }

    [Theory]
    [InlineData(1, 2, -1)]
    [InlineData(4, 5, -1)]
    public void Subtrair(int num1, int num2, int resultadoEsperado)
    {
        Calculator calc = construirClasse();
        int result = calc.Subtract(num1, num2);
        Assert.Equal(resultadoEsperado, result);
    }

    [Theory]
    [InlineData(1, 2, 2)]
    [InlineData(4, 5, 20)]
    public void Multiply(int num1, int num2, int resultadoEsperado)
    {
        Calculator calc = construirClasse();
        int result = calc.Multiply(num1, num2);
        Assert.Equal(resultadoEsperado, result);
    }

    [Theory]
    [InlineData(6, 2, 3)]
    [InlineData(5, 5, 1)]
    public void Divide(int num1, int num2, int resultadoEsperado)
    {
        Calculator calc = construirClasse();
        int result = calc.Divide(num1, num2);
        Assert.Equal(resultadoEsperado, result);
    }

    [Fact]
    public void TestarDivisaoPorZero(){
        Calculator calc = construirClasse();

        Assert.Throws<DivideByZeroException>(
            () => calc.Divide(3,0)
        );
    }

    [Fact]
    public void TestarHistorico(){
        Calculator calc = construirClasse();
        
        calc.Add(1,2);
        calc.Add(4,2);
        calc.Add(1,10);
        calc.Add(24,5);

        var lista = calc.History();
        Assert.NotEmpty(lista);
        Assert.Equal(3, lista.Count());
    }
}