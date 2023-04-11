use std::io;

fn preenche_arr(arr: &mut [i32;10], x:i32){
  let mut j:i32 = 0;
  for i in 0..arr.len(){
    arr[i] = x*j;
    j = j+1;
  }
  for i in 0..arr.len(){
    println!("{}", arr[i]);
  }
}

fn main() {
    let mut n = String::new();
    let mut arr:[i32;10] = [0;10];
    println!("Digite um numero para entrar na função:");
    io::stdin().read_line(&mut n).expect("Failed to read line");
    let x:i32 = n.trim().parse().unwrap();
    preenche_arr(&mut arr, x);
}
