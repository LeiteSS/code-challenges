using System.Text.Json;


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

      Console.WriteLine("============== Exercicio 2 ===================");
      Console.WriteLine("Digite um numero:");
      int numero = int.Parse(Console.ReadLine());
      fibonacci(numero);

      Console.WriteLine("============== Exercicio 3 ===================");
      List<Faturamento> faturamentos = new List<Faturamento>();
      List<double> valores = new List<double>();
      string arquivoCaminho = "data/dados.json";
      string json = File.ReadAllText(arquivoCaminho);
      using (JsonDocument documentoJson = JsonDocument.Parse(json)) 
      {
        foreach (var elemento in documentoJson.RootElement.EnumerateArray())
	      {
		      var diaJson = elemento.GetProperty("dia");
          var valorJson = elemento.GetProperty("valor");

          int dia = diaJson.GetInt32();
          double valor = valorJson.GetDouble();

          faturamentos.Add(new Faturamento(dia, valor));
	      }
      }
      
      foreach (var elemento in faturamentos) 
      {
        if (elemento.Valor != 0)
        {
          valores.Add(elemento.Valor);
        }
      }

      // maior numero
      double maiorNumero = valores.Max();
      foreach(var elemento in faturamentos)
      {
        if(elemento.Valor.Equals(maiorNumero))
        {
          Console.WriteLine("O maior valor de faturamento foi: " + maiorNumero + ", no qual ocorreu no dia " + elemento.Dia);
        }
      }
      
      // menor numero
      double menorNumero = valores.Min();
      foreach(var elemento in faturamentos)
      {
        if(elemento.Valor.Equals(menorNumero))
        {
          Console.WriteLine("O menor valor de faturamento foi: " + menorNumero + ", no qual ocorreu no dia " + elemento.Dia);
        }
      }

      // media
      double media = 0;
      double soma = 0;
      int qtdDias = 0;
      foreach(var elemento in valores)
      {
        soma = soma + elemento;
      }

      media = soma / faturamentos.Count();

      foreach(var elemento in faturamentos)
      {
        if(elemento.Valor > media)
        {
          qtdDias++;
        }
      }

      Console.WriteLine("A quantidade de dias que o faturamento superou a média foram: " + qtdDias);
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
