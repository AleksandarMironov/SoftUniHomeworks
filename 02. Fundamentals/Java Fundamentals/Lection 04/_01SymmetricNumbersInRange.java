import java.util.Scanner;

/**
 * Created by Mironovi on 27.09.2015 ã..
 */
public class _01SymmetricNumbersInRange {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int start = scaner.nextInt();
        int end = scaner.nextInt();
        for (int i = start; i <= end ; i++) {
            if (i<0 || i > 999) {
                System.out.println("Out of range");
                break;
            }
            if (i < 10){
                System.out.print(i + " ");
            }
            if (10 <= i && i < 100){
                if (i/10 == i%10) {
                    System.out.print(i + " ");
                }
            }
            if (100 <= i && i < 1000){
                if (i/100 == i%10) {
                    System.out.print(i + " ");
                }
            }
        }
    }
}
