using System;
namespace Basics{
    public enum Days{
        Monday,Tuesday,Wednesday,Thursday,Friday
    }
    public class UnderstandingEnums{
        public static Days MeetingDate {get;set;} = Days.Monday;
        public static void Main(){
            Days d = (Days)1;
            MeetingDate = Days.Friday;
            Console.WriteLine(MeetingDate);
            // foreach(int day in Enum.GetValues(typeof(Days))){
            //     Console.WriteLine((Days)day);
            // }
            // foreach(string day in Enum.GetNames(typeof(Days))){
            //     Console.WriteLine(day);
            // }
            
            // Console.WriteLine(d);

        }
    }
}
