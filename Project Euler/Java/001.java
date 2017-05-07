import java.util.IntSummaryStatistics;
import java.util.stream.Collectors;
import java.util.Map;

//using both java 7 & 8 
public class Solution_001{
    public static void main(String args[]){
	//Before Java 8
	int sum =0;
	for(int i =0; i!= 1000; i++){
	    if(i%3 ==0  || i%5 ==0) sum+=i;
	}
	System.out.println("Sum of prime numbers who multiples of 3 & 5 : " + sum);
	
	//Java 8
	sum = IntStream.range(0,1000)
		       .filter(i -> i%3 == 0 || i%5 ==0)
		       .sum();
	System.out.println("New sum using Java 8 is : "+ sum);
      }
}
