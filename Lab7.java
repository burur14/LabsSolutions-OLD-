import java.util.Random;
import java.util.Scanner;

public class Lab7 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int n = scan.nextInt();
        int p = scan.nextInt();
        int q = scan.nextInt();

        Lab7 Test = new Lab7();

        int[] arr = Test.generateArray(n);
        Test.printArray(arr);
        int maxSquare = Test.findMaxElement(arr);
        Test.replaceElements(arr, maxSquare, p, q);
        Test.printArray(arr);
    }

    int[] generateArray(int n){
        int[] arr = new int[n];
        for (int i = 0; i < n; i++) {
            //get random int between -100 and 100
            arr[i] = new Random().nextInt(200) - 100;
        }
        return arr;
    }

    int findMaxElement(int[] arr){
        int max = arr[0];
        for (int i = 1; i < arr.length; i++) {
            if(max < arr[i]){
                max = arr[i];
            }
        }
        // return square of max element
        return max*max;
    }

    void printArray(int[] arr){
        for (int i = 0; i < arr.length; i++) {
            System.out.print(arr[i] + " ");
        }
        System.out.println();
    }

    void replaceElements(int[] arr, int maxSquare, int p, int q){
        for (int i = 0; i < arr.length; i++) {
            if(Math.abs(arr[i]) % p == q){
                arr[i] = maxSquare;
            }
        }
    }
}
