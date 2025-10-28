namespace DesafioPOO.Models
{
    //  Herda a classe "Smartphone"
    public class Nokia : Smartphone
    {
        //Sobrescrever o método "InstalarAplicativo"
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o Aplicativo {nomeApp} no Nokia");
        }
    }
}