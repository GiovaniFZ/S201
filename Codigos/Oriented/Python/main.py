class Cachorro:
  tipo = "Puddle"
  def __init__(self, idade): # Construtor
    self.idade = idade

a = Cachorro(3)
print(a.idade)