module Main where

 
fatorial n
  | n > 0 = n*fatorial(n-1)
  | n == 0 = 1
  | n == 1 = 1
  | otherwise = n*2

main = do
  let n = 5
  print (fatorial n)