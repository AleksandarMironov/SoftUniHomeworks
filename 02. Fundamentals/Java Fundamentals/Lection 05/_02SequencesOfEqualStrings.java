import java.util.Scanner;

public class _02SequencesOfEqualStrings {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        String inputString = scaner.nextLine();
        String [] mass = inputString.split(" ");
        System.out.print(mass[0] + " ");
        for (int i = 1; i <mass.length ; i++) {
            if (!mass[i-1].equals(mass[i])){
                System.out.println();
            }
            System.out.print(mass[i] + " ");
        }
        scaner.close();
    }
}
