object Main {
  def main(args: Array[String]): Unit = {
      val v = new Veiculo("v1", "VG", "VGC", 90);
      val c = new Carro("Fiesta", "Ford", "Ford E", 12.3, 100);
      val a = new Aviao("Av1", "Tesla", "Tesla C", 203, 1000);
// Metodos
      v.printInfo();
      v.printInfo("v1");
      a.printInfo();
      a.printInfo("Av1");
      a.setVelocidade(10299);
      a.getVelocidade();
      c.printInfo();
      c.printInfo("Fiesta");
    }
  }

class Veiculo(nome: String, marca: String, fabricante: String, gasolina:Double){
  def printInfo(): Unit={
    println("Nome: " + nome);
    println("Marca: " + marca);
  }
  def printInfo(nome: String): Unit={
    println(fabricante);
    println(gasolina);
  }
}

class Aviao(nome: String, marca: String, fabricante: String, gasolina:Double, private var velocidade: Double) extends Veiculo(nome, marca, fabricante, gasolina){

  override def printInfo(): Unit ={
    println("Marca: " + marca);
    println("Fabricante: " + fabricante);
  }
  def setVelocidade(velocidade: Double): Unit={
    this.velocidade = velocidade;
  }
  def getVelocidade(): Double={
    return velocidade;
  }
}

class Carro(nome: String, marca: String, fabricante: String, gasolina:Double, private var velocidade: Double) extends Veiculo(nome, marca, fabricante, gasolina){
  
  def setVelocidade(velocidade: Double): Unit={
    this.velocidade = velocidade;
  }
  def getVelocidade(): Double={
    return velocidade;
  }
  
}


