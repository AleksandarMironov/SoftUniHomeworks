import java.util.Scanner;

public class _04LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        String inputString = scaner.nextLine();
        String [] mass = inputString.split(" ");
        int [] intMass = new int[mass.length];
        System.out.print(mass[0] + " ");
        //filling integer massive
        for (int i = 1; i <mass.length ; i++) {
            intMass[i] = Integer.parseInt(mass[i]);
        }

        int lastNumIndex = 0;
        int longestSec = 0;
        int longestSecTemp = 0;
        System.out.print(intMass[0] + " ");
        for (int i = 1; i < intMass.length; i++) {
            if (intMass[i-1]>=intMass[i]){
                System.out.println();
            }
            if (intMass[i-1] < intMass[i]){
                longestSecTemp++;
            } else {
                longestSecTemp = 0;
            }
            if (longestSecTemp>longestSec){
                longestSec=longestSecTemp;
                lastNumIndex = i;
            }
            System.out.print(intMass[i] + " ");
        }
        System.out.println();

        System.out.print("Longest: ");
        for (int i = lastNumIndex-longestSec; i < lastNumIndex; i++) {
            System.out.print(intMass[i] + " ");
        }
    }
}
