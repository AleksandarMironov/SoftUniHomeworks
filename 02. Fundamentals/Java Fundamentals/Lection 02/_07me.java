import java.util.Scanner;

/**
 * Created by Mironovi on 27.09.2015 ã..
 */
public class _07me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int number = scaner.nextInt();
        String bits = Integer.toBinaryString(number);
        int counter = 0;
        char [] a = bits.toCharArray();
        for (int i = 1; i < a.length ; i++) {
            if (a[i] == a[i-1]){
                counter++;
            }
        }
        System.out.println(counter);
    }
}
