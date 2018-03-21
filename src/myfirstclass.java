import java.util.Scanner;

public class myfirstclass {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("iveskite skaiciu");

        int numb = sc.nextInt();
        if (numb % 2 == 0) {
            System.out.println(numb + "yra lyginis");
        } else {
            System.out.println(numb + "nelyginis");
        }


    }
}