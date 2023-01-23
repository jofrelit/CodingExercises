namespace LeetCode._007_Reverse_Integer;

public class ReverseInteger
{
    
    public int Reverse(int x)
    {
        if (x is >= -9 and <= 9) return x;
        
        int answer = 0;
        
        bool neg = x < 0;
        if (neg) x = x * -1;
        
        int numOfDigits = (int)Math.Log10(x) + 1;

        while (x > 0) 
        {
            int lastDigit = x % 10;
            x = x / 10;
            try
            {
                checked
                {
                    answer = (answer * 10) + lastDigit;
                }
            }
            catch (OverflowException e)
            {
                return 0;
            }
            
        }
        answer = !neg ? answer : answer * -1;
        return answer;

    }
    
}