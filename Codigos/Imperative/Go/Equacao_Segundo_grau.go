package main

import (
	"fmt"
	"math"
)

func main() {
	var a float64 = 0
	var b float64 = 0
	var c float64 = 0
	var delta float64 = 0
	var res1 float64 = 0
	var res2 float64 = 0
	op := 1

	for op == 1 {
		fmt.Println("Primeiro numero:")
		fmt.Scan(&a)
		fmt.Println("Segundo numero:")
		fmt.Scan(&b)
		fmt.Println("Terceiro numero:")
		fmt.Scan(&c)

		delta = b*b - 4*a*c

		if delta < 0 {
			fmt.Println("Sem raizes reais")
		} else if delta > 0 {
			res1 = (-b + math.Sqrt(delta)) / (2 * a)
			res2 = (-b - math.Sqrt(delta)) / (2 * a)
			fmt.Println("Raiz 1: ", res1)
			fmt.Println("Raiz 2: ", res2)
		} else if delta == 0 {
			res1 = (-b + math.Sqrt(delta)) / (2 * a)
			fmt.Println("Raizes iguais: ", res1)
		}

		fmt.Println("Digite 1 para continuar no programa ou outro para parar.")
		fmt.Scan(&op)
	}

}
