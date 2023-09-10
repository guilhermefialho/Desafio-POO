using System;

namespace DesafioPOO.Models
{
    // Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            // Lógica adicional específica ao construtor da classe Iphone, se necessário
        }

        // Sobrescrever o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nome)
        {
            // Lógica específica da classe Nokia para instalação de aplicativos
            Console.WriteLine($"Instalando o aplicativo {nome} em um Nokia.");
        }

        public static Nokia CriarNokia()
        {
            Console.Write("Digite o numero do Nokia: ");
            string numero = Console.ReadLine();
            Console.Write("Digite o modelo do Nokia: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o imei do Nokia: ");
            string imei = Console.ReadLine();
            Console.Write("Digite a memoria do Nokia: ");
            int memoria = int.Parse(Console.ReadLine());

            return new Nokia(numero, modelo, imei, memoria);
        }
    }
}
