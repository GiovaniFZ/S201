class Animal{
  constructor(nome, idade, especie){
    this.nome = nome;
    this.idade = idade;
    this.especie = especie;
  }
  printInfo(){
    console.log("Nome: " + this.nome);
    console.log("Idade: " + this.idade);
    console.log("Especie: " + this.especie);
    console.log("----------------------------");
  }
}

class Cachorro extends Animal{
  constructor(nome, idade, especie, raca){
    super(nome, idade, especie);
    this.raca = raca;
  }
  printInfo(){
    console.log("Nome: " + this.nome);
    console.log("Idade: " + this.idade);
    console.log("Especie: " + this.especie);
    console.log("Raça: " + this.raca);
    console.log("----------------------------");
  }
}

class Gato extends Animal{
  constructor(nome, idade, especie, cores){
    super(nome, idade, especie);
    this.cores = cores;
  }
  printInfo(){
    console.log("Nome: " + this.nome);
    console.log("Idade: " + this.idade);
    console.log("Especie: " + this.especie);
    console.log("Cores: " + this.cores);
    console.log("----------------------------");
  }
}

let animal = new Animal("Ganso", 10, "Passaro");
let gato = new Gato("Tom", 20, "Gato", ["Amarelo", "Verde"]);
let cachorro = new Cachorro("Rex", 12, "Grande", "Buldog");

animal.printInfo();
gato.printInfo();
cachorro.printInfo();