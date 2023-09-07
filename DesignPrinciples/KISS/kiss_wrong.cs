
public class MathEngine{
    public static int Fibonacci(int n){
        if(n==0 || n ==1){
            return 0;
        }
        else{
            int a=0, b=1, c=3;
            for( int i=2;i<=n;i++){
                c=a+b;
                a=b;
                b=c;
            }
            return c;
        }
    }
}