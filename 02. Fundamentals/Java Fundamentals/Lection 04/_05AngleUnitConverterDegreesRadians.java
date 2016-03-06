import java.util.Scanner;

/**
 * Created by Mironovi on 30.09.2015 ã..
 */
public class _05AngleUnitConverterDegreesRadians {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int n = scaner.nextInt();
        scaner.nextLine();
        String [] input = new String [n*2];
        for (int i = 0; i < n; i++) {
            input [i] = scaner.next();
        }
        for (int i = 0; i < 2*n; i=i+2) {
            System.out.println(convertor(input[i], input[i+1]));
        }

    }

    public static String convertor (String num, String type) {
        String output= "";
        double value = Double.parseDouble(num);
        if (type.equals("rad")){
            value = value * 57.29578;
            output = value + " deg";
        }
        if (type.equals("deg")){
            value = value / 57.29578;
            output = value + " rad";
        }

        return output;
    }
}
