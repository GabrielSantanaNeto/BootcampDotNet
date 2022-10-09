Console.WriteLine("Entre com a quantidade de testes:");
int qt = int.Parse(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
for (int i = 0; i < qt; i++)
{
    Console.WriteLine("Entre com o valor de A e B -separados por espaço");
    string[] v = Console.ReadLine().Split(" ");
    string a = v[0];
    string b = v[1];

    if (a.EndsWith(b))
    {
        Console.WriteLine("encaixa");
    }
    
    else
    {
        Console.WriteLine("nao encaixa");
    }
}
