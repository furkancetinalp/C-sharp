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

class Result
{
    public static string timeConversion(string s)
    {
        bool check = s.Contains("PM");  
        int index=s.IndexOf("M");
        s=s.Remove(index-1,2);
        string value="";
        char c1=s[0];
        char c2=s[1];
        string t = c1.ToString() +c2.ToString();
        int val=Int32.Parse(t);
        if(check){
            if(val<12){
                val+=12;
                t=val.ToString();
            }       
            value=t;
            
        }
        else{
            if(val>12){
                val-=12;
                t="0"+val.ToString();
            }
            if(val==12){
                t="00";
            }
            value=t;
            
            
        }
        s=s.Remove(0,2);
        s=value+s;
        return s;
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        string s = Console.ReadLine();

        string result = Result.timeConversion(s);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
