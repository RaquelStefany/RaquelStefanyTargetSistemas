using System;

class Program {
  public static void Main (string[] args) {
    double SP = 67836.43, RJ = 36678.66, MG = 29229.88, ES = 27165.48, Outros = 19849.53;
    double total = 0, porSP = 0, porRJ = 0, porMG = 0, porES = 0, porOutros = 0;

    total = (SP + RJ + MG + ES + Outros);

    porSP = ((SP / total) * 100);
    porRJ = ((RJ / total) * 100);
    porMG = ((MG / total) * 100);
    porES = ((ES / total) * 100);
    porOutros = ((Outros / total) * 100);

    Console.WriteLine("Valor Mensal Total da Distribuidora: " + total.ToString("C") + "\n");

    Console.WriteLine("Percentual SP = " + porSP.ToString("F2") + "%");
    Console.WriteLine("Percentual RJ = " + porRJ.ToString("F2") + "%");
    Console.WriteLine("Percentual MG = " + porMG.ToString("F2") + "%");
    Console.WriteLine("Percentual ES = " + porES.ToString("F2") + "%");
    Console.WriteLine("Percentual Outros = " + porOutros.ToString("F2") + "%");
  }
}