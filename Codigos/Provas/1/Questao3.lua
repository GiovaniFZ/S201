local function preencher(a, n)
for b=0,30,1 do
  a[b] = b*n
  print(a[b])
end
end


print("Digite um numero:")
local n = io.read()

local a = {}
for i=0,30,1 do
  a[i] = 30-i
end

preencher(a,n)