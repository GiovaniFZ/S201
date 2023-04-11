package main

import (
	"fmt";
  "math/rand"
)

func main() {
  pares := 0
  a := [100]int{}
  for index,_ := range a{
    a[index] = rand.Intn(100)
}
for index,_ := range a{
  if(a[index] %2 == 0){
      pares++;
    }
  }
fmt.Println("Numero de pares: ", pares);
}
  