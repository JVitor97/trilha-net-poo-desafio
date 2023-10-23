namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string _numero, string _modelo, string imei, int _memoria)
        {
            Numero = _numero;
            Modelo = _modelo;
            Imei = imei;
            Memoria = _memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");

        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}