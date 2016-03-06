import java.util.Arrays;
import java.util.Scanner;

public class _01SortArrayOfNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n =  scanner.nextInt();
        int [] mass = new int [n];

        //filling mass
        for (int i = 0; i < n; i++) {
            mass[i] = scanner.nextInt();
        }

        //sorting mass
        Arrays.sort(mass);

        //printing mass
        for (int i = 0; i < mass.length; i++) {
            System.out.print(mass[i] + " ");
        }

        scanner.close();
    }
}
