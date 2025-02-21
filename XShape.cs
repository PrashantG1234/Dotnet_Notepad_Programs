using System;
public class XShape{
    public static void Main(){
        // for half hash pattern
        for(int i=0;i<4;i++){
            //for initial space 
            for(int j=0;j<i;j++){
                Console.Write(" ");
            }
            //for initial hashes
            for(int j=0;j<=i;j++){
                Console.Write("#");
            }
            //for secondary spaces
            for(int j=6;j>i*2;j--){
                Console.Write(" ");
            }
            //for opposite secondary spaces
            for(int j=6;j>i*2;j--){
                Console.Write(" ");
            }
            //for opposite hashes
            for(int j=0;j<=i;j++){
                Console.Write("#");
            }
            Console.WriteLine();
        }
        //for another half hash pattern
         for(int i=0;i<4;i++){
            //for initial space 
            for(int j=i-1;j>i;j--){
                Console.Write(" ");
            }
            //for initial hashes
            for(int j=i-1;j>i;j--){
                Console.Write("#");
            }
            //for secondary spaces
            for(int j=2*i;j>0;j--){
                Console.Write(" ");
            }
            //for opposite secondary spaces
            for(int j=2*i;j>0;j--){
                Console.Write(" ");
            }
            //for opposite hashes
            for(int j=4;j>i;j--){
                Console.Write("#");
            }
            Console.WriteLine();
        }   
    }
}