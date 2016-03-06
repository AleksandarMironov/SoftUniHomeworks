import java.util.Scanner;

/**
 * Created by Mironovi on 24.09.2015 ã..
 */
public class _03me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        double x = Double.parseDouble(scaner.next());
        double y = Double.parseDouble(scaner.next());
        if (y>=6 && 13.5>=y) {
            if (y>=6 && 8.5>=y){
                if (x>=12.5 && 22.5>=x){
                    System.out.println("inside");
                } else {
                    System.out.println("outside");
                }
            }
            else {
                if (x>=12.5 && 17.5>=x) {
                    System.out.println("inside");
                } else if (x>=20 && 22.5>=x) {
                    System.out.println("inside");
                } else {
                    System.out.println("outside");
                }
            }
        } else{
            System.out.println("outside");
        }

    }
}
