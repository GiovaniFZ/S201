using System;

class CachorroGrande:Cachorro{
  private double Tamanho {get; set;}
  
  public CachorroGrande(string nome, int idade, double tamanho):base(nome,idade){
    Tamanho = tamanho;
  }
  
  public override void showIdade(){
    Console.WriteLine("A idade do cachorro grande é: " + Idade);
  }

  public void showTamanho(){
    Console.WriteLine("O tamanho do cachorro é: " + Tamanho);
  }
}