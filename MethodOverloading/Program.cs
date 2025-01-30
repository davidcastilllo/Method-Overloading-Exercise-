using System.Security.Cryptography.X509Certificates;

namespace MethodOverloading
{
    public class Program
    {

        public static int Add(int num1, int num2)
	    {
	        return num1 + num2;
	    }
	    
	    public static decimal Add(decimal num1, decimal num2)
	    {
	        return num1 + num2;
	    }
	    
	    public static string Add(int num1, int num2, bool check)
	    {
	        var sum = num1 + num2;
	        
	        if(check == true && sum > 1)
	        {
	            return $"{sum} dollars";
	        }
	        else if(check == true && sum == 1)
	        {
	            return $"{sum} dollar";
	        }
	        else if(check == true && sum < 1)
	        {
	            return $"{sum} dollars";
	        }
	        else
	        {
	            return sum.ToString();
	        }
	    }
        static void Main(string[] args)
        { 
          Console.WriteLine(Add(1,2));
          Console.WriteLine(Add(1.81m,2.13m));
          Console.WriteLine(Add(2,5,true));
        }
    }
}
