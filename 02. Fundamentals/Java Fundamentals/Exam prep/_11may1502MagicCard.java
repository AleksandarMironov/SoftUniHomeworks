import java.util.Scanner;

/**
 * Created by Mironovi on 04.10.2015 ã..
 */
public class _11may1502MagicCard {
    public static void main(String[] args) {
        Scanner scaner = new Scanner(System.in);

        String cards = scaner.nextLine();
        String oddEven = scaner.nextLine();
        String magic = scaner.nextLine();
        Integer sum = 0;

        String [] separatedCards = cards.split(" ");

        char [] magicChar = magic.toCharArray();
        char magicFace;
        char magicSuit;
        if (magicChar.length==2){
            magicFace = magicChar[0];
            magicSuit = magicChar[1];
        } else {
            magicFace=magicChar[0];
            magicSuit = magicChar[2];
        }

        if (oddEven.equals("even")){
            for (int i = 0; i <separatedCards.length; i = i+2) {
                Integer multiply = 1;
                Integer cardPoints=0;
                char[] card = separatedCards[i].toCharArray();
                char cardFace = card[0];

                char cardSuits='0';
                if (card.length==2){
                    cardFace = card[0];
                    cardSuits = card[1];
                }
                if (card.length==3){
                    cardFace = card[0];
                    cardSuits = card[2];
                }
                switch (cardFace) {
                    case '2': {
                        cardPoints = 20;
                        break;
                    }
                    case '3': {
                        cardPoints = 30;
                        break;
                    }case '4': {
                        cardPoints = 40;
                        break;
                    }case '5': {
                        cardPoints = 50;
                        break;
                    }case '6': {
                        cardPoints = 60;
                        break;
                    }case '7': {
                        cardPoints = 70;
                        break;
                    }case '8': {
                        cardPoints = 80;
                        break;
                    }case '9': {
                        cardPoints = 90;
                        break;
                    }case '1': {
                        cardPoints = 100;
                        break;
                    }case 'J': {
                        cardPoints = 120;
                        break;
                    }case 'Q': {
                        cardPoints = 130;
                        break;
                    }case 'K': {
                        cardPoints = 140;
                        break;
                    }
                    case 'A': {
                        cardPoints = 150;
                        break;
                    }

                }
                if (cardFace == magicFace){
                    multiply = multiply*3;
                }
                if(cardSuits == magicSuit){
                    multiply = multiply*2;
                }

                sum = sum + cardPoints*multiply;
            }
        } else {
            for (int i = 1; i <separatedCards.length; i = i+2) {
                Integer multiply = 1;
                Integer cardPoints=0;
                char[] card = separatedCards[i].toCharArray();
                char cardFace='0';
                char cardSuits='0';
                if (card.length==2){
                    cardFace = card[0];
                    cardSuits = card[1];
                } else if (card.length==3){
                    cardFace = card[0];
                    cardSuits = card[2];
                }
                switch (cardFace) {
                    case '2': {
                        cardPoints = 20;
                        break;
                    }
                    case '3': {
                        cardPoints = 30;
                        break;
                    }case '4': {
                        cardPoints = 40;
                        break;
                    }case '5': {
                        cardPoints = 50;
                        break;
                    }case '6': {
                        cardPoints = 60;
                        break;
                    }case '7': {
                        cardPoints = 70;
                        break;
                    }case '8': {
                        cardPoints = 80;
                        break;
                    }case '9': {
                        cardPoints = 90;
                        break;
                    }case '1': {
                        cardPoints = 100;
                        break;
                    }case 'J': {
                        cardPoints = 120;
                        break;
                    }case 'Q': {
                        cardPoints = 130;
                        break;
                    }case 'K': {
                        cardPoints = 140;
                        break;
                    }
                    case 'A': {
                        cardPoints = 150;
                        break;
                    }

                }
                if (cardFace == magicFace){
                    multiply = multiply*3;
                }
                if(cardSuits == magicSuit){
                    multiply = multiply*2;
                }

                sum = sum + cardPoints*multiply;
            }
        }
        System.out.println(sum);


    }
}
