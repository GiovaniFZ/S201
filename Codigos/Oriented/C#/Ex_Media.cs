using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine("x:");
    var x = float.Parse(Console.ReadLine());
    Console.WriteLine("y:");
    var y = float.Parse(Console.ReadLine());
    Console.WriteLine("z:");
    var z = float.Parse(Console.ReadLine());
    float soma = x+y+z;
    Console.WriteLine(soma);
    Console.WriteLine(Media(soma));
  }
  public static float Media(float soma){
    float media = soma/3;
    return media;
  }
}