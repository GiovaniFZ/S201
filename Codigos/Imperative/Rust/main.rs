use std::io;

fn main() {
    println!("Hello, world!");
    let y: i8 = 9;
    let mut z = String::new();

    let string1: String = "oi".to_string();
    let string2: String = "oi".to_string();
    let string3: String = format!("{} {}", string1, string2);

    println!("Digite um valor de z:");
    io::stdin().read_line(&mut z).expect("failed to read line");
    let zint: i8 = match z.trim().parse::<i8>() {
        Ok(n) => n,
        Err(_) => {
            print!("Erro!");
            0
        }
    };
    println!("{} + {} = {}", y, zint, zint + y);
    println!("{}", string3)
}
