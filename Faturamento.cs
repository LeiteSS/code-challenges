using System;

public class Faturamento
{
  public int Dia { get; set; }
  public double Valor { get; set; }


  public Faturamento(int dia, double valor) {
    this.Dia = dia;
    this.Valor = valor;
  }
}