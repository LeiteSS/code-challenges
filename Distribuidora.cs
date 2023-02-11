public class Distribuidora 
{
  public string Uf { get; set; }
  public double Faturamento { get; set; }

  public Distribuidora(string uf, double faturamento)
  {
    this.Uf = uf;
    this.Faturamento = faturamento;
  }
}