using System;

class Program {
  public static void Main (string[] args) {
    int numeroDesejado;
    int termo1 = 0, termo2 = 1, soma = 0;

    do{
      Console.Write("Informe um número: ");
      numeroDesejado = int.Parse(Console.ReadLine());
    }
    while(numeroDesejado < 0);

    Console.Write("\nSequência Fibonacci:\n0, 1, ");
    
    while(numeroDesejado > soma){
      soma = termo1 + termo2;
      Console.Write(soma + ", ");
      termo1 = termo2;
      termo2 = soma;
    };

    Console.WriteLine("\n");

    if(numeroDesejado == 0){
      Console.Write("O Número " + numeroDesejado + " pertence a sequência Fibonacci");
    }
    else{
      if(numeroDesejado == soma){
        Console.Write("O Número " + numeroDesejado + " pertence a sequência Fibonacci");
      }
      else{
        Console.Write("O Número não " + numeroDesejado + " pertence a sequência Fibonacci");
      }
    }
  }
}