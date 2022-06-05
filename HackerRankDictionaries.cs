using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        Dictionary<string,string> dict = new Dictionary<string,string>();
        List<string> values = new List<string>();
        for(int i=0;i<n;i++){
            string input = Console.ReadLine();
            string[] pairs = input.Split(" ");      
            dict.Add(pairs[0],pairs[1]);          
        }
        string input2;
        while ((input2=Console.ReadLine()) != null){
            if(dict.ContainsKey(input2)){
                Console.WriteLine(input2+"="+dict[input2]);
            }
            else{
                Console.WriteLine("Not found");

                
            }
        }

        
    }
}
