object Main {
  def main(args: Array[String]): Unit = {
    var num = scala.io.StdIn.readInt();
    var num2 = scala.io.StdIn.readInt();
    val arr = new Array[Int](20);

    for(i<-0 until arr.length){
      if(i%2 == 0){
        arr(i) = num*i;
      }else{
        arr(i) = num2*i;
      }
    }
    
    for(i<-0 until arr.length){
      println(arr(i));
    }
    }
  }
