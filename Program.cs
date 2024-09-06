using System;

namespace NoviceChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            // Use the Main method to test your functions.
            // Console.WriteLine(Add(10, 10));
            // Console.WriteLine(MaxOfThree(10, 20, 30));
            // Console.WriteLine(MaxOfThree(10, 30, 20));
            // Console.WriteLine(MaxOfThree(30, 20, 10));
            // Console.WriteLine(StringLength("abcdefghijklmnopqrstuvwxyz"));
            // Console.WriteLine(StartsHello("Hello"));
            // Console.WriteLine(StartsHello("Hello everybody. This is simply a test."));
            // Console.WriteLine(ReverseString("Is today opposite day or something?"));
            Console.WriteLine(Factorial(4));
        }
        // 1. Return the sum of two numbers.
        public static int Add(int a, int b)
        {
            // TODO: Implement this method.
            return a + b;
        }

        // 2. Given an integer, return true if it's even, else return false.
        public static bool IsEven(int number)
        {
            // TODO: Implement this method.
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        // 3. Return the largest of three numbers.
        public static int MaxOfThree(int a, int b, int c)
        {
            // HINT: You might want to use Math.Max function.
            // TODO: Implement this method.
            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            return max;
        }


        // 4. Return the length of the given string.
        public static int StringLength(string s)
        {
            // TODO: Implement this method.
            return s.Length;
        }

        // 5. Return true if the string starts with "Hello", otherwise return false.
        public static bool StartsHello(string s)
        {
            // HINT: Use the string method "StartsWith".
            // TODO: Implement this method.
            if (s.StartsWith("Hello"))
            {
                return true;
            }
            return false;
        }

        // 6. Reverse a given string.
        public static string ReverseString(string s)
        {
            char[] charArray = s.ToCharArray();
            // TODO: Reverse the charArray.
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // 7. Return the factorial of a number.
        public static int Factorial(int n)
        {
            if (n == 0) return 1;
            for(int i=n-1; i>0; i--) {
n=n*i;
            }
            // TODO: Calculate the factorial.
            return n;
        }

        // 8. Check if a number is a prime number.
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0) return true;
            }
            // TODO: Return the correct boolean value.
            return false;
        }

        // 9. Return the nth Fibonacci number.
        public static int Fibonacci(int n)
        {
            if (n <= 1) return n;
            // TODO: Calculate the nth Fibonacci number.
            return Fibonacci(n-1)+Fibonacci(n-2);
        }

        // 10. Given an array of integers, return the largest number.
        public static int LargestInArray(int[] numbers)
        {
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                // TODO: Find the largest number in the array.
                if(numbers[i] > largest) largest=numbers[i];
            }
            return largest;
        }

        // 11. Check if a string is a palindrome (reads the same forward and backward).
        public static bool IsPalindrome(string s)
        {
            // TODO: Determine if the string is a palindrome.
            if(s==ReverseString(s)) return true;
            return false;
        }

        // 12. Given an array of integers, return the sum of its elements.
        public static int ArraySum(int[] numbers)
        {
            int sum = 0;
            // TODO: Calculate the sum of the array's elements.
            for( int i=0; i < numbers.Length; i++) {
sum=sum+numbers[i];
            }
            return sum;
        }

        // 13. Given a string, count how many times a specified character appears in it.
        public static int CharCount(string s, char c)
        {
            int count = 0;
            // TODO: Count how many times character c appears in string s.
            char[] charArray=s.ToCharArray();
            for( int i=0; i < charArray.Length; i++) {
                if(charArray[i] == c) count++;
            }
            return count;
        }

        // 14. Given two strings, return a new string that is the concatenation of the two strings with a space in between.
        public static string ConcatenateStrings(string str1, string str2)
        {
            // TODO: Concatenate the two strings with a space in between.
            return str1+" "+str2;
        }

        // 15. Given a string, return a new string where the first and last characters have been swapped.
        public static string SwapEnds(string s)
        {   
            if (s.Length <= 1) return s;
            char firstChar = s[0];
            char lastChar = s[s.Length - 1];
            // TODO: Swap the first and last characters and return the modified string.
            char[] charArray=s.ToCharArray();
            charArray[0]=lastChar;
            charArray[s.Length-1]=firstChar;
            return new string(charArray);
        }
    }
}