using System;
internal class LongestWord{
    public static void Main(){
        string line = Console.ReadLine()?.Trim();
        Console.WriteLine(LongestString(line));

    }
    public static string LongestString(string line){
        if(string.IsNullOrEmpty(line)) return null;
        string[] strArr = line.Split(' ');
        string ans = strArr[0];
        for(int i=1;i<strArr.Length;i++){
            if(strArr[i].Length>ans.Length){
                ans = strArr[i];
            }
        }
        return ans;
    }
}