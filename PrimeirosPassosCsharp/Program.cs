// comentário em uma linha 

/* comentário 
em várias linhas */

/* se eu começar uma variável sem declarar o tipo como, 'var semtipo = 123;' e depois eu tentar mudar 
'var semtipo = 'abc'; vai dar erro. O c# associa a viariável ao primeiro tipo. 
O ideial é sempre por int, float etc para não ter erros.
Mas caso seja preciso, o   dynamic    permite que a variável seja mudada. */

/*
 Uma const não pode ser alterada depois de definida, enquanto uma variável normal pode ser alterada.
 */

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.ReadLine();
        }
    }
}



/*
            string nome = "";
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}! Bem-vindo ao C#!");
 */

/*          
 *          String HelloWorld = "Hello World!";
            int number = 42;
            float pi = 3.14f;
            bool isTrue = true;

            const float Pi = 3.14159f;
            const double Hi = 3.14159;

            Console.WriteLine(Hi);
            Console.WriteLine(Pi);
            Console.WriteLine(HelloWorld);
            Console.WriteLine(number);
            Console.WriteLine(pi);
            Console.WriteLine(isTrue);
*/