-- Exercicio 01: Tabuada
print("Digite um valor de x:")
local x = io.read()
-- Calculando tabuada do numero digitado
for i=1,10,1 do
  print(x*i)
end
print("\n")

-- Execicio 2: Criar uma table e preencher os indices 1-100 com valores aleatórios
local a = {}
for i=1,10,1 do
  a[i] = math.random(1,10)
  print (a[i])
end
-- Contando os pares
local nPares = 0
for i=1,10,1 do
  if (a[i]%2) == 0 then
    nPares = nPares + 1
  end
end
print(nPares.." numeros pares")