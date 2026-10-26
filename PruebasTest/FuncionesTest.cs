using PruebasTDD;

namespace PruebasTest
{
    [TestClass]
    public sealed class FuncionesTest
    {
        [TestMethod]
        [DataRow(-5, -1L)] // negativo
        [DataRow(-1, -1L)] // negativo (limite)
        [DataRow(0, 1L)] // el factorial de 0 es 1
        [DataRow(1, 1L)]
        [DataRow(5, 120L)]
        [DataRow(10, 3628800L)]
        [DataRow(20, 2432902008176640000L)] // el mayor que cabe en long
        public void CalcularFactorial_VariosCasos(int n, long esperado)
        {
            long result = Funciones.CalcularFactorial(n);
            Assert.AreEqual(esperado, result);
        }
    }
}
