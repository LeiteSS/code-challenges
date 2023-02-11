namespace Main
{
  class Program
  {
    static void Main(string[] args) 
    {
      Console.WriteLine("============== Exercicio 1 ===================");
      int INDICE = 13, SOMA = 0, K = 0;
      while (K < INDICE) 
      {
        K++;
        SOMA = SOMA + K;
      }
      Console.WriteLine(SOMA);

      Console.WriteLine("============== Exercicio 1 ===================");
      Console.WriteLine("Digite um numero:");
      int numero = int.Parse(Console.ReadLine());
      fibonacci(numero);
    }

    static void fibonacci(int num) 
    {
      int primeiroNumero = 0;
      int segundoNumero = 1;
      int terceiroNumero = 0;

      for (int i = 0; i < num; ++i)
      {
        terceiroNumero = primeiroNumero + segundoNumero;
        
        if (num == terceiroNumero)
        {
          break;
        }

        primeiroNumero = segundoNumero;
        segundoNumero = terceiroNumero;
      }

      if (num == 0 || num == 1 || num == terceiroNumero)
      {
        Console.WriteLine("O numero " + num + " pertence a sequência Fibonacci");
      } else {
        Console.WriteLine("O numero " + num + " não pertence a sequência Fibonacci");
      }
    }
  }
}
