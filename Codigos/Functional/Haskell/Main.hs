module Main where

a = last(reverse(map(*3)[30,29..1]))
main = do
  print a
