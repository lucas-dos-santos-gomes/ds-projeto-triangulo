using System;

namespace TriangleProject;

class Program {
  static void Main(string[] args) {
    string continueProgram = "S";
    do {
      Console.Clear();
      Console.WriteLine("== Programa Triângulo ==");
      double side1, side2, side3;

      Console.WriteLine("\nInsira o valor do primeiro lado do triângulo:");
      side1 = double.Parse(Console.ReadLine()!);
      Console.WriteLine("\nInsira o valor do segundo lado do triângulo:");
      side2 = double.Parse(Console.ReadLine()!);
      Console.WriteLine("\nInsira o valor do terceiro lado do triângulo:");
      side3 = double.Parse(Console.ReadLine()!);

      Console.Clear();
      Console.WriteLine("== Programa Triângulo ==");

      Triangle triangle = new(side1, side2, side3);
      if(!triangle.IsTriangle()) {
        Console.WriteLine("\nOs valores inseridos não formam um triângulo");
      } else {
        triangle.Classify();
        Console.WriteLine($"\nLados: {side1} | {side2} | {side3}");
        Console.WriteLine($"Classificação: triângulo {triangle.GetClassification()}");
        Console.WriteLine($"Perímetro: {Math.Round(triangle.GetPerimeter(), 2)}");
        Console.WriteLine($"Área: {Math.Round(triangle.GetArea(), 2)}");
      }
      Console.WriteLine("\nDeseja utilizar o programa novamente? ( 'S' | 'N' )");
      continueProgram = Console.ReadLine()!;
      while(continueProgram.ToUpper() != "S" && continueProgram.ToUpper() != "N") {
        Console.WriteLine("\nInsira uma opção válida: ( 'S' | 'N' )");
        continueProgram = Console.ReadLine()!;
      }
    } while(continueProgram.ToUpper() == "S");
    Console.Clear();
    Console.WriteLine("Programa finalizado!");
  }
}
