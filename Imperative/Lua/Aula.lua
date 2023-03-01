-- Printando na tela
print("Digite um valor de x")
-- Variavel local 
local x = 0
-- Leitura e escrita
x = io.read()
print(x)
-- printa o tipo de x, se é string ou numero, por ex.
print(type(x)) -- será string
-- Como x é string, teremos que fazer a conversão:
x = tonumber(x)

-- Decisão
if x > 0 then
  print("x maior que zero")
elseif x < 0 then
  print("x menor que zero")
end


-- Loop
for y = 0,10,1 do
  print(y)
end
