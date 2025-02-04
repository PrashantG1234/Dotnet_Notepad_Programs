using System;
internal class LongestVowelWord{
    public static void Main(){
        string line = Console.ReadLine().Trim();
        Console.WriteLine(LongestVowelString(line));

    }
    public static string LongestVowelString(string line){
        if(string.IsNullOrEmpty(line)) return null;
        string[] strArr = line.Split(' ');
        string ans = null;
        int maxCount=0;
        for(int i=0;i<strArr.Length;i++){
            int count = 0;
            foreach(char ch in strArr[i].ToCharArray()){
                if(IsVowel(ch)){
                    count++;
                }
            }
            if(count>maxCount){
                maxCount = count;
                ans = strArr[i];
            }
        }
        return ans;
    }
    public static bool IsVowel(char ch){
        if(ch=='a' || ch=='e' || ch=='i' || ch=='o' ||ch=='u'){
            return true;
        }
        return false;
    }
}