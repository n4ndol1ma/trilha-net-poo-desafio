namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; }
        public string Modelo { get; }
        public string Imei { get; }
        public int Memoria { get;}

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public virtual void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public virtual void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}