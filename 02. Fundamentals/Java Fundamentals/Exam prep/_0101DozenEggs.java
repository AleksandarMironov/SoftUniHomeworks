import java.util.Scanner;

/**
 * Created by Mironovi on 01.10.2015 ã..
 */
public class _0101DozenEggs {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String tupe = "";
        Integer inNum = 0;
        Integer counter=0;
        for (int i = 0; i < 7; i++) {
            inNum = scanner.nextInt();
            tupe = scanner.next();
            if (tupe.equals("eggs")){
                counter = counter + inNum;
            } else if (tupe.equals("dozens")){
                counter = counter + inNum*12;
            }
        }
        System.out.println(counter / 12 + " dozens + " + counter%12 + " eggs");
    }
}
