using System;

class Program {
  public static void Main (string[] args) {
    double[] faturamento = new double[30] {22174.1664, 24537.6698, 26139.6134, 0.0, 0.0, 26742.6612, 0.0, 42889.2258, 46251.174, 11191.4722, 0.0, 0.0, 3847.4823, 373.7838, 2659.7563, 48924.2448, 18419.2614, 0.0, 0.0, 35240.1826, 43829.1667, 18235.6852, 4355.0662, 13327.1025, 0.0, 0.0, 25681.8318, 1718.1221, 13220.495, 8414.61};
    double mediaMensal = 0, somaMensal = 0, menorValor = 0, maiorValor = 0;
    int diaMaior = 0, diaMenor = 0, diasMaiores = 0, diasMedia = 0;

    menorValor = faturamento[0];
    maiorValor = faturamento[0];

    for(int j = 0; j < 30; j ++){
      if(faturamento[j] > 0.0){
        somaMensal += faturamento[j];
        diasMedia += 1;
      }
    }
    mediaMensal = somaMensal / diasMedia;

    for(int i = 0; i < 30; i ++){
      if(faturamento[i] > 0.0){
        if(faturamento[i] > maiorValor){
          diaMaior = i+1;
          maiorValor = faturamento[i];
        }
        if(faturamento[i] <= menorValor){
          diaMenor = i+1;
          menorValor = faturamento[i];
        }
        if(faturamento[i] > mediaMensal){
          diasMaiores += 1;
        }
      }
    }

    Console.WriteLine("Menor Faturamento:\nDia: " + diaMenor + "\nFaturamento: " + menorValor);
    Console.WriteLine();
    Console.WriteLine("Maior Faturamento:\nDia: " + diaMaior + "\nFaturamento: " + maiorValor);
    Console.WriteLine();
    Console.WriteLine("Média de Faturamento Mensal: " + mediaMensal);
    Console.WriteLine();
    Console.WriteLine("Durante " + diasMaiores + " dia(s) o Faturamento Diário foi superior à Média Mensal");
  }
}