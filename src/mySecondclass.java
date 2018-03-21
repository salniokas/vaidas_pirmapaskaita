import com.sun.tools.doclets.formats.html.SourceToHTMLConverter;

import java.util.Scanner;

public class mySecondclass {
    private static final int MAX_NUMB=100;
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("iveskite kiek skaiciu noresite uzpildyti");
        int kiek =scanner.nextInt();
        int [] mas = new int[kiek];

        for (int i=0; i<kiek; i++){
            System.out.println("iveskite" + i +"skaicius");
            mas[i]=scanner.nextInt();
        }
        printMas(mas);
    }
    private static void printMas(int[]skMas){
        for(Integer sk : skMas){
            if (sk > MAX_NUMB){
                System.out.println(sk);
            }
        }
    }
}
