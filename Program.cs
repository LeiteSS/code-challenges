using System.Text.Json;


namespace Main
{
  class Program
  {
    public static void Main(string[] args) 
    {
      Console.WriteLine("============== Exercicio 1 ===================");
      int INDICE = 13, SOMA = 0, K = 0;
      while (K < INDICE) 
      {
        K++;
        SOMA = SOMA + K;
      }
      Console.WriteLine(SOMA);
      Console.WriteLine(" ");

      Console.WriteLine("============== Exercicio 2 ===================");
      Console.WriteLine("Digite um numero:");
      int numero = int.Parse(Console.ReadLine());
      Fibonacci(numero);
      Console.WriteLine(" ");

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
      Console.WriteLine(" ");

      Console.WriteLine("============== Exercicio 4 ===================");
      List<Distribuidora> faturamentoDistribuidora = new List<Distribuidora>();
      faturamentoDistribuidora.Add(new Distribuidora("SP", 67.83643)); // SP
      faturamentoDistribuidora.Add(new Distribuidora("RJ", 36.67866)); // RJ
      faturamentoDistribuidora.Add(new Distribuidora("MG", 29.22988)); // MG
      faturamentoDistribuidora.Add(new Distribuidora("ES", 27.16548)); // ES
      faturamentoDistribuidora.Add(new Distribuidora("Outros", 19.84953)); // Outros
      
      double somaDistribuidora = 0;
      foreach(var elemento in faturamentoDistribuidora)
      {
        somaDistribuidora = somaDistribuidora + elemento.Faturamento;
      }

      foreach(var elemento in faturamentoDistribuidora)
      {
        
        Console.WriteLine("O percentual do estado " + elemento.Uf + " é {0:0}%", (elemento.Faturamento /somaDistribuidora)*100);
      }
      Console.WriteLine(" ");
      Console.WriteLine("============== Exercicio 5 ===================");
      Console.WriteLine("Digite uma palavra ou frase:");
      string palavraFrase = Console.ReadLine();

      string revertida = ReverteCaracteresDaString(palavraFrase);

      Console.WriteLine("Palavra original: " + palavraFrase);
      Console.WriteLine("Palavra ou frase revertida: " + revertida);

    }

    public static void Fibonacci(int num) 
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

    public static string ReverteCaracteresDaString(string s)
    {
      char[] arrayDeCaracteres = s.ToCharArray();
      int tamanho = s.Length - 1;
      string stringRevertida = String.Empty;

      for (int i = tamanho; i >= 0; i--)
      {
         stringRevertida += arrayDeCaracteres[i]; 
      }

      return stringRevertida;
    }
  }
}
