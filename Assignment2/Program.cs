Write a program in C# Sharp to copy the elements one array into another array.
public class Exercisetest
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int i, n;
        Console.Write("Input :");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
            arr2[i] = arr1[i];
        }
        Console.Write("\nThe elements stored in the first array are :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr1[i]);
        }
        Console.Write("\n\nThe elements copied into the second array are :\n");
        for (i = 0; i < n; i++)
        {
            Console.Write("{0}  ", arr2[i]);
        }
        Console.Write("\n\n");
    }
}

Write a program in C# Sharp to merge two arrays of same size sorted in ascending order.
public class test
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[20];
        int s1, s2, s3;
        int i, j, k;
        Console.Write("Input the number of elements to be stored in the first array :");
        s1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input {0} elements in the array :\n", s1);
        for (i = 0; i < s1; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }


        Console.Write("Input the number of elements to be stored in the second array :");
        s2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", s2);
        for (i = 0; i < s2; i++)
        {
            Console.Write("element - {0} : ", i);
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

       
        s3 = s1 + s2;

        for (i = 0; i < s1; i++)
        {
            arr3[i] = arr1[i];
        }
        for (j = 0; j < s2; j++)
        {
            arr3[i] = arr2[j];
            i++;
        }
       
        for (i = 0; i < s3; i++)
        {
            for (k = 0; k < s3 - 1; k++)
            {

                if (arr3[k] >= arr3[k + 1])
                {
                    j = arr3[k + 1];
                    arr3[k + 1] = arr3[k];
                    arr3[k] = j;
                }
            }
        }
       
        Console.Write("\nThe merged array in ascending order is :\n");
        for (i = 0; i < s3; i++)
        {
            Console.Write("{0} ", arr3[i]);
        }
        Console.Write("\n\n");
    }
}

Write a program in C# Sharp to separate odd and even integers in separate arrays.
public class test1
{
    public static void Main()
    {
        int[] arr1 = new int[10];
        int[] arr2 = new int[10];
        int[] arr3 = new int[10];
        int i, j = 0, k = 0, n;
        Console.Write("Input the number of elements to be stored in the array :");
        n = Convert.ToInt32(Console.ReadLine());

        Console.Write("Input {0} elements in the array :\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("element - {0} : ", i);
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i < n; i++)
        {
            if (arr1[i] % 2 == 0)
            {
                arr2[j] = arr1[i];
                j++;
            }
            else
            {
                arr3[k] = arr1[i];
                k++;
            }
        }

        Console.Write("\nThe Even elements are : \n");
        for (i = 0; i < j; i++)
        {
            Console.Write("{0} ", arr2[i]);
        }

        Console.Write("\nThe Odd elements are :\n");
        for (i = 0; i < k; i++)
        {
            Console.Write("{0} ", arr3[i]);
        }
        Console.Write("\n\n");
    }
}

Write a program in C# Sharp to print individual characters of the string in reverse order.
public class test2
{
    public static void Main()
    {
        string str;
        int l = 0;
        Console.Write("Input the string : ");
        str = Console.ReadLine();
        l = str.Length - 1;
        Console.Write("The characters of the string in reverse are : \n");
        while (l >= 0)
        {
            Console.Write("{0} ", str[l]);
            l--;
        }
        Console.Write("\n\n");
    }
}
Write a program in C# Sharp to read a sentence and replace lowercase characters by uppercase and vice-versa.
public class test3
{
    public static void Main()
    {
        string str1;
        char[] arr1;
        int l, i;
        l = 0;
        char ch;
        Console.Write("Input the string : ");
        str1 = Console.ReadLine();
        l = str1.Length;
        arr1 = str1.ToCharArray(0, l); 

        Console.Write("\nAfter conversion, the string is : ");
        for (i = 0; i < l; i++)
        {
            ch = arr1[i];
            if (Char.IsLower(ch)) 
                Console.Write(Char.ToUpper(ch)); 
            else
                Console.Write(Char.ToLower(ch)); 
        }
        Console.Write("\n\n");
    }
}

Write a C# Sharp program to find the length of the longest 
substring without repeating characters from a given string. 
using System;

class test
{
    public static bool areDistinct(string str,int i, int j)
    {

       
        bool[] visited = new bool[26];

        for (int k = i; k <= j; k++)
        {
            if (visited[str[k] - 'a'] == true)
                return false;

            visited[str[k] - 'a'] = true;
        }
        return true;
    }

    public static int longestUniqueSubsttr(string str)
    {
        int n = str.Length;

        
        int res = 0;

        for (int i = 0; i < n; i++)
            for (int j = i; j < n; j++)
                if (areDistinct(str, i, j))
                    res = Math.Max(res, j - i + 1);

        return res;
    }

   
    public static void Main()
    {
        string str = "manasa";
        Console.WriteLine("The input string is " + str);

        int len = longestUniqueSubsttr(str);

        Console.WriteLine("The length substring is " + len);
    }
}