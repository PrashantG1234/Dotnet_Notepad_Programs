using System;
public delegate string HD(string str);
class Msg{
    public string show(string str){
        return str;
    }

}
class DelegateDemo2{
    public static void  Main(){
        Msg m = new Msg();
        HD ad1 = new HD(m.show);
        Console.WriteLine(ad1("Hello"));
        HD ad2 = delegate(string str){return str;};
        Console.WriteLine(ad2("Hello"));

        HD ad3 =(str) => {return str;};
                Console.WriteLine(ad3("Hello"));

    }
}
