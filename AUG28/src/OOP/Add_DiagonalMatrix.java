package OOP;

class Add_DiagonalMatrix {
    public int diagonalSum(int[][] mat){
        int sum=0;
        int n= mat.length;
        int i=0,j=0;

        while (i<n){
            sum = sum + mat[i][j];
            i++;
            j++;
        }
        while (j>=0){
            sum=sum+mat[i][j];
            i++;
            j--;
        }
        return sum;
    }
}
