using ExemploFundamentos.Common.Models;


int[] arrayInteiros = new int[4]; // Array com 3 posições para serem declaradas

arrayInteiros[0] = 72; // Posição = Valor
arrayInteiros[1] = 64;
arrayInteiros[2] = 50;
arrayInteiros[3] = 1;

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++) // Utilizado com valor do contador
{
     Console.WriteLine($"Posição Nº {contador} - {arrayInteiros[contador]} ");
}


Console.WriteLine("Percorrendo o Array com o FOREACH");

int contadorForeach = 0;
foreach (int valor in arrayInteiros) // Mais simples , porém sem o valor do contador
{
    Console.WriteLine($"Posição Nº {contadorForeach} - {valor}");
    contadorForeach++;
}















// Pessoa pessoa1 = new Pessoa();

// pessoa1.Nome = "Anderson";
// pessoa1.Idade = 34;
// pessoa1.Apresentar();

// string opcao;
// bool exibirMenu = true;

// while (exibirMenu) //Variável sendo falsa não será executada
// {   
//     Console.Clear();
//     Console.WriteLine("Digite a sua opção");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Apagar cliente");
//     Console.WriteLine("4 - Encerrar");

//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//             Console.WriteLine("Cadastro de cliente");
//             break;

//         case "2":
//             Console.WriteLine("Buscar de cliente");
//             break;

//         case "3":
//             Console.WriteLine("Apagar cliente");
//             break;

//         case "4":
//             Console.WriteLine("Encerrar");
//             exibirMenu = false; //Evita que o menu apareça novamente
//             break;

//         default:
//             Console.WriteLine("Opção inválida"); //Caso digitado nenhuma das opções
//             break;

//     }

// }


// Console.WriteLine("O programa se encerrou"); //Encerra o programa