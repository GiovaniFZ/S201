class Pessoa:
  def __init__(self, nome, idade): # Construtor
    self.nome = nome
    self.idade = idade
  def imprimeNome(self):
    print(f"O nome é: {self.nome}")

class Aluno(Pessoa):
  def __init__(self, nome, idade, matricula):
    super().__init__(nome, idade)
    self.__matricula = matricula
  def imprimeIdade(self):
    print(f"Idade do aluno: {self.idade}")

class Professor(Pessoa):
  def __init__(self, nome, idade): # Construtor
   super().__init__(nome, idade)
  def imprimeIdade(self):
    print(f"Idade do professor: {self.idade}")

pessoa1 = Pessoa("Joao", 15)
pessoa2 = Aluno("Gabriel", 35, 3)
pessoa3 = Professor("Soned", 50)

pessoa1.imprimeNome()
pessoa2.imprimeIdade()
pessoa3.imprimeIdade()