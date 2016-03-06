import java.util.*;

/**
 * Created by Mironovi on 02.10.2015 ã..
 */
public class _0103Biggest3PrimeNumbers {
    public static void main(String[] args) {
        Scanner scanner =  new Scanner(System.in);
        String input = scanner.nextLine();
        String [] inMass = input.split("[( )]+");
        TreeSet <Integer> allNums = new TreeSet<>(Collections.reverseOrder());
        for (int i = 0; i < inMass.length ; i++) {
            if (!inMass[i].equals("")){
                int num = Integer.parseInt(inMass[i].trim());
                allNums.add(num);
            }
        }
        int numberCounter = 0;
        int sum = 0;
        for (Integer num : allNums){
           if (num>0){
               if(IsPrime(num)) {
                   sum = sum + num;
                   numberCounter++;
               }
           }
            if (numberCounter>=3){
                break;
            }
        }
        if (numberCounter==3){
            System.out.println(sum);
        } else {
            System.out.println("No");
        }

    }

    private static boolean IsPrime (Integer num) {
        boolean isPrime = true;
        for (int i = 2; i < Math.sqrt(num); i++) {
            if (num % i ==0){
                isPrime=false;
            }
        }
        return isPrime;
    }
}
