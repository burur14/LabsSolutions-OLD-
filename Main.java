import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();

        System.out.println(new Main().checkIfPerfect(n));
    }

    boolean checkIfPerfect(int n){
        int sum = 1;
        for (int i = 2; i <= n / 2; i++) {
            if(n % i == 0){
                sum += i;
            }
        }
        return sum == n;
    }

}
