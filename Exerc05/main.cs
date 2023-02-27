using System;

class Program {
  public static void Main (string[] args) {
    string texto, textoInvertido = "";
    int tamanho = 0;

    Console.Write("Insira um Texto: ");
    texto = Console.ReadLine();
    Console.WriteLine();

    tamanho = texto.Length - 1;

    for(int i = tamanho; i >= 0; i--){
      textoInvertido += texto[i];
    }

    Console.WriteLine("Texto Invertido: " + textoInvertido);
  }
}