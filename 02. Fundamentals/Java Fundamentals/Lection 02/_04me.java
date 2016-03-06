import java.util.DoubleSummaryStatistics;
import java.util.Scanner;

/**
 * Created by Mironovi on 24.09.2015 ã..
 */
public class _04me {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        Double a = Double.parseDouble(scaner.next());
        Double b = Double.parseDouble(scaner.next());
        Double c = Double.parseDouble(scaner.next());

        if (a < b && a<c){
            System.out.println(a);
        } else if (b < a && b<c){
            System.out.println(a);
        } else if (c < b && c<a){
            System.out.println(a);
        } else {
            System.out.println("They are equal");
        }


    }
}
