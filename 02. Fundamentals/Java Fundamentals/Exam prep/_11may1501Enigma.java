import java.util.Scanner;

/**
 * Created by Mironovi on 03.10.2015 ã..
 */
public class _11may1501Enigma {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int n = scanner.nextInt();
        scanner.nextLine();
        String [] inputLines = new String[n];
        String [] outputLines = new String[n];
        for (int i = 0; i < n; i++) {
            inputLines[i] = scanner.nextLine();
        }
        for (int i = 0; i < n; i++) {
            String [] tempMass = inputLines[i].split(" ");
            int weight =0;
            for (int j = 0; j < tempMass.length; j++) {
                weight = weight + tempMass[j].length();
            }
            weight = weight/2;
            char [] tempCharMass = inputLines[i].toCharArray();
            char [] outputTempCharMass = new char[tempCharMass.length];
            for (int j = 0; j < tempCharMass.length; j++) {
                if (tempCharMass[j] != ' ') {
                    outputTempCharMass[j] = ((char) ((int) tempCharMass[j] + weight));
                }
                else {
                    outputTempCharMass[j] = ' ';
                }

            }
            System.out.println(outputTempCharMass);

        }

    }
}
