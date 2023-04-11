using System;
class CachorroPequeno:Cachorro{
  public CachorroPequeno(string nome, int idade):base(nome,idade){
      
  }
  
  public override void showIdade(){
    Console.WriteLine("A idade do cachorro pequeno é: " + Idade);
  }
}