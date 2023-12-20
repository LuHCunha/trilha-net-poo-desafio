namespace DesafioPOO.Models
{
    public class Nokia : Smartphone


    {
        public Nokia(string numero, string Modelo, string Imei, int Memoria) : base(numero)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine(nomeApp);
        }
    }
}