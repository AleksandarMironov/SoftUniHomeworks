import java.util.Scanner;

/**
 * Created by Mironovi on 04.10.2015 ã..
 */
public class _08feb1503LegoBlocks {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        String [][] mass = new String[2*n][];
        Integer [] fit = new Integer[2*n];
        Integer positions = 0;
        for (int i = 0; i < n * 2; i++) {
            mass [i] = scanner.nextLine().split(" ");
            fit [i] = mass [i].length;
            positions = positions + fit [i];
        }
        Integer checkSum = fit[0] + fit [n];
        boolean fits = true;
        for (int i = 0; i < n; i++) {
            if (checkSum != fit[i] + fit[i+n]){
                fits = false;
                break;
            }
        }
        if (!fits){
            System.out.println("The total number of cells is: " + positions);
        } else {

            for (int i = 0; i < n; i++) {
                System.out.print("[");
                for (int k = 0; k < mass[i].length; k++) {
                    System.out.print(mass[i][k]+", ");

                }
                for (int k = mass[i + n].length-1; k >= 0; k--) {
                    System.out.print(mass[i + n][k]);
                    if(k!=0) {
                        System.out.print(", ");
                    } else {
                        System.out.print("]");
                    }
                }
                System.out.println();

            }

        }
    }

}

