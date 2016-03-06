import java.util.Scanner;

/**
 * Created by Mironovi on 27.09.2015 ã..
 */
public class _05me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int inputNumber = scaner.nextInt();
        String convertedNumberToHex = Integer.toHexString(inputNumber);
        System.out.printf("The hexadecimal representation of %d is %s.", inputNumber, convertedNumberToHex.toUpperCase());
    }
}
