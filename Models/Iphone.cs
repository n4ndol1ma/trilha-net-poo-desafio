namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine("Instalando o aplicativo ''Twitter'' no Iphone");
        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        {

        }

        public override void ReceberLigacao()
        {
            base.ReceberLigacao();
            Console.WriteLine("iPhone recebendo ligação....");
        }

    }
}