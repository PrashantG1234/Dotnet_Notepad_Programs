using System;
public delegate void Notify(string message);
public class Notifications{
    public void EmailNotifications(string msg){
        Console.WriteLine("notification via email "+msg);
    }
    public void SMSNotifications(string msg){
        Console.WriteLine("notification via SMS "+msg);
    }
    public void PushNotifications(string msg){
        Console.WriteLine("notification via Push "+msg);
    }
    
}
class MulticasteDelegates{
   
    static void Main(string []args){
        Notifications nt = new Notifications();
        Notify n1 = nt.EmailNotifications;
        Notify n2 = nt.SMSNotifications;
        Notify n3 = nt.PushNotifications;
        Notify allNotifications = n1+n2+n3;
        allNotifications("You have a new message");
    }
}