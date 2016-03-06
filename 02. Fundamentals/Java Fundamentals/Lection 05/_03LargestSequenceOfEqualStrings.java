import java.util.Scanner;

public class _03LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        String inputString = scaner.nextLine();
        String [] mass = inputString.split(" ");
        int lastWordIndex = 0;
        int equalWords = 0;
        int equalWordsTemp = 0;
        for (int i = 1; i <mass.length ; i++) {
            if (mass[i-1].equals(mass[i])){
                equalWordsTemp++;
            } else {
                equalWordsTemp = 0;
            }
            if (equalWordsTemp>equalWords){
                equalWords=equalWordsTemp;
                lastWordIndex = i;
            }
        }
        for (int i = lastWordIndex-equalWords; i <= lastWordIndex ; i++) {
            System.out.print(mass[i] + " ");
        }
        scaner.close();
    }
}
