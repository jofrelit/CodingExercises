namespace LeetCode._009_Palindrome_Number;

public class PalindromeNumber
{
    public bool PalindromeNumber_FirstTry(int x)
    {
        if (x < 0)
            return false;        
        else if (x >= 0 && x <= 9 )
            return true;
        else if (x % 10 == 0)
            return false;

        bool res = true;
        int numOfDigits = (int)Math.Log10(x) + 1;
        
        for (int i = 1 ; i <= numOfDigits/2 ; i++)
        {
            int rNum = x % (int)Math.Pow(10, i) / (int)Math.Pow(10,i-1) ;
            int lNum = x / (int)Math.Pow(10, numOfDigits - i) % 10 ;
            if (rNum != lNum)
            {
                res = false;
                break;
            }
                
        }
        
        return res;
    }
    
}