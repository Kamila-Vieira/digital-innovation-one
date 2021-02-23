package one.digitalinnovation.whiles;

import java.util.stream.IntStream;

public class While {

  public static void main(String[] args) {

    var x = 0;

    //Testa a condição antes
    while (x < 1) {
      //System.out.println("Dentro do while...");
      x++;
    }

    var y = 0;

    //Testa a condição depois
    do {
      //System.out.println("Dentro do do/while...");
    } while (y++ < 1);

    IntStream.of(0, 1, 2, 3, 6).forEach(n -> {
      System.out.println(n);
    });

    IntStream.range(0, 7).forEach(n -> {
     // System.out.println(n);
    });

  }
}
