use std::io;

fn main() {
    let mut num1 = String::new();
    let mut num2 = String::new();
    let mut op = String::new();
    let mut res: i32 = 0;
    let bool = true;
    while bool {
        println!("Digite o valor de num1: ");
        io::stdin()
            .read_line(&mut num1)
            .expect("failed to read line");
        println!("Digite o valor de num2: ");
        io::stdin()
            .read_line(&mut num2)
            .expect("failed to read line!");
        println!("Digite 1 para somar ou 2 para multiplicar");
        io::stdin().read_line(&mut op).expect("failed to read line");
        // Convertendo para int
        let num1i: i32 = num1.trim().parse().unwrap();
        let num2i: i32 = num2.trim().parse().unwrap();
        if op.trim() == "1" {
            res = num1i + num2i;
        } else {
            if op.trim() == "2" {
                res = num1i * num2i;
            } else {
                println!("Opção invalida!");
            }
        }
        println!("valor de res: {}", res);
    }
}
