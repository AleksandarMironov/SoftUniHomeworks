import java.util.Scanner;

/**
 * Created by Mironovi on 27.09.2015 ã..
 */
public class _06me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int a = scaner.nextInt();
        float b = scaner.nextFloat();
        float c = scaner.nextFloat();
        String hex = Integer.toHexString(a).toUpperCase();
        int aToBinary = Integer.parseInt(Integer.toBinaryString(a));
        System.out.printf ("|%1$-10s|%2$010d|%3$10.2f|%4$-10.3f|", hex, aToBinary, b, c);
    }
}
