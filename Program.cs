using System;

namespace TriangleProject;

class Program {
  static void Main(string[] args) {
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
    if(triangle.IsTriangle()) {
      Console.WriteLine("\nOs valores inseridos não formam um triângulo");
    } else {
      Console.WriteLine($"\nLados: {side1}, {side2} e {side3}");
      Console.WriteLine($"\nClassificação: {triangle.GetType()}");
      Console.WriteLine($"\nPerímetro: {triangle.GetPerimeter()}");
      Console.WriteLine($"\nÁrea: {triangle.GetArea()}");
    }
  }
}
