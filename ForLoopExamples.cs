using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Solution
{
    public static void staircase(int n)
    {
        for(int i=0;i<n;i++){
            
            for(int j=1;j<n-i;j++){
                Console.Write(" ");
            }
            for(int k=0;k<=i;k++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
      
    }
    
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        for(int i=1;i<=10;i++){
            Console.WriteLine("{0} x {1} = {2}",n,i,n*i);
        }
        
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Result.staircase(n);
    }
}
