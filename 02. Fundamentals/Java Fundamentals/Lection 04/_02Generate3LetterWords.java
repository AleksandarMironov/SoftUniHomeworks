import java.util.Scanner;

/**
 * Created by Mironovi on 27.09.2015 ã..
 */
public class _02Generate3LetterWords {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        char [] letters = scaner.next().toString().toCharArray();
        for (int i = 0; i < letters.length; i++) {
            for (int j = 0; j < letters.length; j++) {
                for (int k = 0; k < letters.length ; k++) {
                    System.out.print(letters[i]);
                    System.out.print(letters[j]);
                    System.out.print(letters[k]);
                    System.out.print(" ");

                }
            }
        }
    }
}
