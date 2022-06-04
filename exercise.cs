using System;

class Result
{
    public static int migratoryBirds(List<int> arr)
    {
        arr.Sort();
        int[] inputs = {1,2,3,4,5};
        int most=0;
        int one=0;
        int two=0;
        int three=0;
        int four=0;
        int five=0;
        most=1;
        foreach (int i in arr){
            if(i==inputs[0]){
                one++;
            }
            if(i==inputs[1]){
                two++;
            }
            if(i==inputs[2]){
                three++;
            }
            if(i==inputs[3]){
                four++;
            }
            if(i==inputs[4]){
                five++;
            }
        }
        
        if(one>=two && one >= three && one >=four && one >=five){
            return 1;
        }
        if(two >= three && two >=four && two >=five){

            return 2;
        }
        if(three >=four && three >=five){

            return 3;
        }
        if(four >=five){

            return 4;
        }
        else{
            return 5;
        }
        

    }

}

class Solution
{
    public static void Main(string[] args)
    {
        TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

        int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        int result = Result.migratoryBirds(arr);

        textWriter.WriteLine(result);

        textWriter.Flush();
        textWriter.Close();
    }
}
