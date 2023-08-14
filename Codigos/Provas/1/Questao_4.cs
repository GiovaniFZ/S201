using System;

class Program
{
    public static void Main(string[] args)
    {
      Cavalo c1 = new Cavalo(10, "Cav1", "Laranja");
      Cavalo c2 = new Cavalo(11, "Cav2", "Dourado");
      Cavalo c3 = new Cavalo(12, "Cav3", "Branco");
      c1.mover();
      c1.mover();
      c1.mover();
      c1.mover();
      c1.mover();
      c1.mover();
      
    }

}

class AnimalCorrida{
  public double Velocidade;
  public string Nome;
  public string Cor;
  
  public AnimalCorrida(double velocidade, string nome, string cor){
    Velocidade = velocidade;
    Nome = nome;
    Cor = cor;
  }
    
}


class Cavalo:AnimalCorrida{
  private double posicao {get;set;}
  public Cavalo(double velocidade, string nome, string cor):base(velocidade, nome,cor){
    posicao = 0;
  }

  public void mover(){
  if(posicao < 200){
    posicao = posicao + (Velocidade*4);
  }else{
    Console.WriteLine(Nome + " terminou a corrida!");
  }
  }
  
}