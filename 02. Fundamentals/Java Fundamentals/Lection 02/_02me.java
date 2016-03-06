import java.util.Scanner;

/**
 * Created by Mironovi on 24.09.2015 ã..
 */
public class _02me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);

        int ax = scaner.nextInt();
        int ay = scaner.nextInt();
        scaner.nextLine();
        int bx = scaner.nextInt();
        int by = scaner.nextInt();
        scaner.nextLine();
        int cx = scaner.nextInt();
        int cy = scaner.nextInt();

        Double area = Math.abs(ax*(by-cy) + bx*(cy-ay) + cx*(ay- by))/2.0;

        System.out.println(area);


    }
}
