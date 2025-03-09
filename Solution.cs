using System;
// you can also use other imports, for example:
using System.Collections.Generic;
class Solution {
    public static void Main(){
        Console.WriteLine(solution("22:22:00","22:22:20"));
    }
    public static int solution(string S, string T) {
        // Implement your solution here
        string[] strArr1 = S.Split(':');
        string[] strArr2 = T.Split(':');

        int sSec = int.Parse(strArr1[2]);
        int sMin = int.Parse(strArr1[1]);
        int sHour= int.Parse(strArr1[0]);

        int tSec = int.Parse(strArr2[2]);
        int tMin = int.Parse(strArr2[1]);
        int tHour= int.Parse(strArr2[0]);

        int iCount = 0;
        while(sHour<tHour || (sHour==tHour && sMin<tMin) || (sHour==tHour && sMin==tMin && sSec <= tSec )){
            HashSet<int> unique = new HashSet<int>();
            
            string sHourString = sHour.ToString("D2");
            string sMinString = sMin.ToString("D2");
            string sSecString = sSec.ToString("D2");
            

            unique.Add(sHourString[0]);
            unique.Add(sHourString[1]);
            unique.Add(sMinString[0]);
            unique.Add(sMinString[1]);
            unique.Add(sSecString[0]);
            unique.Add(sSecString[1]);

            if(unique.Count<=2){
                iCount++;
            }
            sSec++;
            if(sSec==60){
                sSec=0;
                sMin++;
                if(sMin==60){
                    sMin = 0;
                    sHour++;
                }
            }
        }
        return iCount;
    }
    public static int SolutionCount(string S, string T) {
        TimeSpan startTime = TimeSpan.Parse(S);
        TimeSpan endTime = TimeSpan.Parse(T);
        int count = 0;

        while (startTime <= endTime) {
            string timeStr = startTime.ToString(@"hh\:mm\:ss");
            HashSet<char> uniqueDigits = new HashSet<char>(timeStr.Replace(":", ""));
            if (uniqueDigits.Count <= 2) {
                count++;
            }
            startTime = startTime.Add(TimeSpan.FromSeconds(1)); // Increment by 1 second
        }

        return count;
    }

}
