import java.util.*;

/**
 * Created by Mironovi on 04.10.2015 ã..
 */
public class _11may1504Weightlifting {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);
        int n = scaner.nextInt();
        scaner.nextLine();
        String [] inputLine = new String[n];
        TreeMap<String, TreeMap<String, Long>> theMap = new TreeMap<>(Comparator.<String>naturalOrder());
        for (int i = 0; i < n; i++) {
            inputLine[i] = scaner.nextLine();
        }
        for (int i = 0; i < inputLine.length; i++) {
            String [] inputDetail = inputLine[i].split(" ");
            String name = inputDetail[0];
            String exercise = inputDetail[1];
            long weight = Long.parseLong(inputDetail[2]);
            if (!theMap.containsKey(name)){
                TreeMap<String, Long> details = new TreeMap<>(Comparator.<String>naturalOrder());
                details.put(exercise, weight);
                theMap.put(name, details);
            } else {
                TreeMap<String, Long> details = theMap.get(name);
                if(!details.containsKey(exercise)){
                    details.put(exercise, weight);
                } else {
                    long tempNum = weight + details.get(exercise);
                    details.put(exercise, tempNum);
                }
            }
        }

        Set<String> keys = theMap.keySet();
        for (String name: keys) {
            System.out.print(name + " : ");
            TreeMap<String, Long> output = theMap.get(name);
            Set<String> exercises = output.keySet();
            int counter = 1;
            for (String exercisea : exercises){
                System.out.print(exercisea + " - " + output.get(exercisea) + " kg");
                if(exercises.size()!=counter){
                    System.out.print(", ");
                }
                counter++;

            }
            System.out.println();

        }

    }
}
