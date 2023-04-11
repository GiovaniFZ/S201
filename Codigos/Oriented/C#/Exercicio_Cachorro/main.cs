using System;

class Program {
  public static void Main (string[] args) {
  Cachorro c1 = new Cachorro("Raf", 12);
  c1.showNome();
  c1.showIdade();
  CachorroGrande c2 = new CachorroGrande("Dog", 20, 1.8);
  c2.showTamanho();
  
  }
}