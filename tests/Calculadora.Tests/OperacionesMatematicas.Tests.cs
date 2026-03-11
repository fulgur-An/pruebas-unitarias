using Calculadora;

namespace Calculadora.Tests;

public class OperacionesMatematicasTest
{
  [Fact]
  public void Sumar_DosNumeros_RetornaSuma()
  {
      // Arrange
      var operaciones = new OperacionesMatematicas();
      double a = 5;
      double b = 3;

      // Act
      double resultado = operaciones.Sumar(a, b);

      // Assert
      Assert.Equal(8, resultado);
  }

  [Fact]
  public void Sumar_NegativoMasPositivo_RetornaValorCorrecto()
  {
      // Arrange
      var operaciones = new OperacionesMatematicas();
      double a = -5;
      double b = 3;

      // Act
      double resultado = operaciones.Sumar(a, b);

      // Assert
      Assert.Equal(-2, resultado);
  }

  [Fact]
  public void Sumar_CeroMasCero_RetornaCero()
  {
      // Arrange
      var operaciones = new OperacionesMatematicas();
      double a = 0;
      double b = 0;

      // Act
      double resultado = operaciones.Sumar(a, b);

      // Assert
      Assert.Equal(0, resultado);
  }
}