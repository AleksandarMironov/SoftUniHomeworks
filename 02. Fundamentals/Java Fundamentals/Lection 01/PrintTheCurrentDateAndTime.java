import java.util.Date;

public class PrintTheCurrentDateAndTime {
	public static void main(String[] args) {
		System.out.printf("%1$tA %1$tH:%1$tM %1$tB-%1$tY.\n",
				new Date());
	}
}
