namespace SalarioMinimoColombia.Models
{
    public class SalarioMinimo
    {
        public int Anio { get; set; }
        public double SalarioMinimoMensual { get; set; }
        public double AuxilioDeTransporte { get; set; }
        public string NormatividadDecreto { get; set; }

        public SalarioMinimo(int año, double salarioMinimoMensual, double auxilioDeTransporte, string normatividadDecreto)
        {
            Anio = año;
            SalarioMinimoMensual = salarioMinimoMensual;
            AuxilioDeTransporte = auxilioDeTransporte;
            NormatividadDecreto = normatividadDecreto;
        }
    }
}
