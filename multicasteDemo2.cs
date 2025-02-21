using System;
public delegate int ArithDelegate(int i, int j);
public class DisplayAllReturnValues{
    ArithDelegate ad = (i,j) => i+j;
    ad += (i,j) => i*j;
    ad += (i,j) =>{
        if(i>j) return i-j;
        else return j-i;
    }
    
}
class multicasteDemo2{
   
    static void Main(string []args){
        DisplayAllReturnValues darv = new DisplayAllReturnValues();
        ArithDelegate ad = darv
    }
}