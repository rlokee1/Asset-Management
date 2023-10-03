package Array360;

public class UniqDupCount {

    public static void main(String[] args) {
        int[] a = {1, 3, 2, 1, 3, 4, 2, 1, 3, 5, 3}; // | 1 | 3 | 2 | 1 | 3 | 4 | 2 | 1 | 3 | 5 | 3 |
                                                     // | 3 | 4 | 2 | -1| -1| 1 | -1| -1| -1| 1 | -1|
        int[] Freq = new int[a.length];

        for(int i=0;i<a.length;i++) {
            int no = a[i];                        //no=a[0]=1
            int count = 1;
            int j;
            for (j = i + 1; j < a.length; j++) {
                if (no == a[j]) {
                    count++;
                    Freq[j] = -1;
                }
            }
            if (Freq[i] != -1) {
                Freq[i] = count;
                System.out.println("The number in the array "+ a[i] + " has repeated " + count + " times ");
            }
        }
            int dupCount = 0;
            int uniqueCount = 0;
            int j=0;
            for(int i=0;i<Freq.length;i++)
            {
                if (Freq[i] != -1) {
                    uniqueCount++;
                }
                else if(Freq[i] == -1)
                    dupCount++;
            }
            System.out.println('\n'+"Unique Count are " + " " + uniqueCount);
            System.out.println('\n'+"Duplicate values are " + " " + dupCount);

    }
}



