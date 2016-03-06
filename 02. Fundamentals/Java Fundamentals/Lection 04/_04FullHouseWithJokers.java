/**
 * Created by Mironovi on 29.09.2015 ã..
 */
public class _04FullHouseWithJokers {
    public static void main(String[] args) {
        String [] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        String [] sutes = {"?", "\\u2665", "\\u2666", "\\u2663"};
        int counter = 0;
        for (int i = 0; i < sutes.length; i++) {
            for (int j = i+1; j < sutes.length; j++) {
                for (int k = j+1; k < sutes.length; k++) {
                    for (int l = 0; l < sutes.length; l++) {
                        for (int m = l + 1; m <sutes.length; m++) {
                            for (int n = 0; n < faces.length ; n++) {
                                for (int o = 0; o < faces.length; o++) {
                                    if(n!=o && i!=j && j!=k && i!=k && l != m){
                                        System.out.printf("(" + faces [n] + sutes[i] + " " + faces [n] + sutes[j] + " " + faces [n] + sutes[k] + " " + faces [o] + sutes[l] + " " + faces [o] + sutes[m] + ")");
                                        System.out.println();
                                        counter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
