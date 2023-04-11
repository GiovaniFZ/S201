using System;

class Cachorro {
  public string Nome;
  public int Idade;
  public Cachorro(string nome, int idade){
    Nome = nome;
    Idade = idade;
  }
  public void showNome(){
    Console.WriteLine("O nome do cachorro é: " + Nome);
  }
  public virtual void showIdade(){
    Console.WriteLine("A idade do cachorro é: " + Idade);
  }
}