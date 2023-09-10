using DesafioPOO.Models;

string app;

bool opcao = true;
int menu;

while (opcao)
{
    Console.WriteLine("Bem vindo ao sistema!");
    Console.WriteLine("---------------------");
    Console.WriteLine("Digite qual é o seu celular:");
    Console.WriteLine("1 - Celular Nokia");
    Console.WriteLine("2 - Celular Iphone");
    Console.WriteLine("3 - Sair");

    menu = int.Parse(Console.ReadLine());

    switch (menu)
    {
        case 1:
            Nokia meuNokia = Nokia.CriarNokia(); // Chama o método estático para criar uma instância de Nokia

            Console.WriteLine("Digite o aplicativo que deseja instalar no Nokia:");
            app = Console.ReadLine();

            meuNokia.InstalarAplicativo(app);
            meuNokia.Ligar();
            meuNokia.ReceberLigacao();
            break;

        case 2:

            Iphone meuIphone = Iphone.CriarIphone(); // Chama o método estático para criar uma instância de Nokia

            Console.WriteLine("Digite o aplicativo que deseja instalar no Iphone:");
            app = Console.ReadLine();

            meuIphone.InstalarAplicativo(app);
            meuIphone.Ligar();
            meuIphone.ReceberLigacao();

            break;

        case 3:
            opcao = false;
            break;
        default:
            break;
    }
}


// Realizando testes com as classes Nokia e Iphone
