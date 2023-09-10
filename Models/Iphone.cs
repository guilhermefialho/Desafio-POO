namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
            
        }

        public override void InstalarAplicativo(string nome)
        {
            // Lógica específica da classe Nokia para instalação de aplicativos
            Console.WriteLine($"Instalando o aplicativo {nome} em um Iphone.");
        }

        public static Iphone CriarIphone()
        {
            Console.Write("Digite o numero do Iphone: ");
            string numero = Console.ReadLine();
            Console.Write("Digite o modelo do Iphone: ");
            string modelo = Console.ReadLine();
            Console.Write("Digite o imei do Iphone: ");
            string imei = Console.ReadLine();
            Console.Write("Digite a memoria do Iphone: ");
            int memoria = int.Parse(Console.ReadLine());

            return new Iphone(numero, modelo, imei, memoria);
        }
    }
}
