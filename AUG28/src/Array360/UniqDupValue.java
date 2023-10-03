package Array360;

public class UniqDupValue {

        public static void main(String[] args) {
            int[] a = {1, 3, 2, 1, 3, 4, 2, 1, 3, 5, 3}; // | 1 | 3 | 2 | 1 | 3 | 4 | 2 | 1 | 3 | 5 | 3 |
            int[] dupArray = new int[a.length];          // | 3 | 4 | 2 | -1| -1| 1 | -1| -1| -1| 1 | -1|
            int[] nonDupArray = new int[a.length];
            int[] uniqueArray = new int[a.length];
            int[] Freq = new int[a.length];

            for (int i = 0; i < a.length; i++){
                int no = a[i];                        //no=a[0]=1
                int count = 1;
                int j;
                for (j = i + 1; j < a.length; j++) {
                    if (no == a[j]){
                        count++;
                        Freq[j] = -1;
                    }
                }
                if (Freq[i] != -1) {
                    Freq[i] = count;
                    System.out.println("The number in the array " + a[i] + " has repeated " + count + " times ");
                }
            }
            System.out.println("************************************************************************");
            int j = 0;
            for (int i = 0; i < Freq.length; i++) {
                if (Freq[i] > 1) {
                    dupArray[j]=a[i];
                    j++;
            }
            for (i = 0; i < Freq.length; i++)
                if(Freq[i] == 1){
                    nonDupArray[j]=a[i];
                    j++;
                }
        }

            System.out.println('\n' + "Non Duplicate values in the array : ");
            for (int value : nonDupArray) {
                if (value > 0)
                    System.out.println(value + " ");
            }

            System.out.println("************************************************************************");

            System.out.println('\n' + "Duplicate values in the array : ");
            for (int value : dupArray) {
                if (value > 0)
                    System.out.println(dupArray.length);
                System.out.println(value + " ");
            }

            System.out.println("************************************************************************");
            int k = 0;
            for (int i = 0; i < Freq.length; i++) {
                if (Freq[i] > 0) {
                    uniqueArray[k]=a[i];
                    k++;
                }
            }
            System.out.println('\n' + "Unique values in the array : ");
            for (int value : uniqueArray) {
                if (value > 0)
                    System.out.println(value + " ");
            }
            System.out.println("************************************************************************");
    }
}

