import java.util.Scanner;

/**
 * Created by Mironovi on 02.10.2015 ã..
 */
public class _0102AddingAngles {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer n = scanner.nextInt();
        Integer [] massForEzynes = new Integer[n];
        int counter = 0;
        for (int i = 0; i < n; i++) {
            massForEzynes[i] = scanner.nextInt();
        }
        for (int i = 0; i < n; i++) {
            for (int j = i+1; j < n ; j++) {
                for (int k = j+1; k < n; k++) {
                    Integer sum = massForEzynes[i] + massForEzynes [j] + massForEzynes [k];
                    if ((sum)%360 == 0){
                        counter++;
                        System.out.println(massForEzynes[i] + " + " + massForEzynes[j] + " + " + massForEzynes[k] + " = " + sum + " degrees");
                    }
                }
            }
        }
        if (counter == 0) {
            System.out.println("No");
        }

    }
}
