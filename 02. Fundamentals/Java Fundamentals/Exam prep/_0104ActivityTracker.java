import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;

/**
 * Created by Mironovi on 03.10.2015 ã..
 */
public class _0104ActivityTracker {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        Integer n = scanner.nextInt();
        scanner.nextLine();
        String [] input = new String[n];
        for (int i = 0; i < n; i++) {
            input[i] = scanner.nextLine();
        }
        TreeMap<Integer, TreeMap<String, Double>> map = new TreeMap<>();
        for (int i = 0; i < n; i++) {
            String [] inputLines = input[i].split(" ");
            String [] date = inputLines[0].split("/");
            Integer month = Integer.parseInt(date[1]);
            Double distance = Double.parseDouble(inputLines[2]);
            if (!map.containsKey(month)){
                TreeMap <String, Double> player = new TreeMap<>();
                player.put(inputLines[1], distance);
                map.put(month, player);
            } else {
                TreeMap <String, Double> player = map.get(month);
                if(!player.containsKey(inputLines[1])){
                    player.put(inputLines[1], distance);
                } else {
                    Double tempDist = player.get(inputLines[1]) + distance;
                    player.put(inputLines[1], tempDist);
                }
                map.put(month, player);
            }

        }
        System.out.println(map);
    }
}
