using Calculadora.Models;

Calculo calc = new Calculo();

calc.Somar(10,15);
calc.Subtrair(5,3);
calc.Multiplicar(5,3);
calc.Dividir(10,2);
calc.Pontecia(3,3);
calc.Seno(30);
calc.Coseno(30);
calc.Tangente(30);
calc.RaizQuadrada(9); 


// ------- Laço de repetição For Tabuada ----------

int numero = 10;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
} 


// ------- Laço de repetição While Tabuada ----------

int numero = 10;
int contador = 0;

while(contador <= 10)
{
    Console.WriteLine($"{contador} Execução: {numero} x {contador} = {numero * contador}");
    contador++;
} 


// ------- Laço de repetição Do While Tabuada ----------

int soma = 0, numero = 0;


do
{
    Console.WriteLine("Digite um número: (0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

    soma += numero; 

} while(numero != 0);

    Console.WriteLine($"Total da soma dos números é: {soma}");


    // ------- Menu  ----------

    string opcao;
    bool exebirMenu = true;

    while (exebirMenu)
    {
        Console.Clear();
        Console.WriteLine("Digite sua opção: ");
        Console.WriteLine("1 - Cadastrar um cliente");
        Console.WriteLine("2 - Buscar um cliente");
        Console.WriteLine("3 - Apagar um cliente");
        Console.WriteLine("4 - Encerra");

        opcao = Console.ReadLine();

        switch (opcao)
        {
            case "1":
                Console.WriteLine("Cadastro de cliente");
                break;

            case "2":
                Console.WriteLine("Buscar de cliente");
                break;

            case "3":
                Console.WriteLine("Apagar um cliente");
                break;

            case "4":
                Console.WriteLine("Encerra");
                exebirMenu = false;
                //Environment.Exit(0);   encerra o menu e nao execultar mais nada
                break;  


            default:
                Console.WriteLine("Opção invalida");
                break;
        }
    }

    Console.WriteLine("O programa se encerrou");