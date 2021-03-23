using System;

namespace Guessnumber
{
    class Program
    {
        static void Main(string[] args)
        {   
            
            Console.Write("Hello!!!, please enter your name : \n") ;
            string userIdentity = Console.ReadLine() ;
            Console.WriteLine("Hello "+ userIdentity+ " You up for a guess number games");
            
            //Random Generator
            Random rand = new Random();
            int rndNumber = rand.Next(0 , 10);
            

            start: 
            Console.WriteLine("Now Choose A number");
            
            int win = 1;
            int lose = 1 ;
            int totalgamplay = win+lose ;
            int guess;
            do{
                guess = int.Parse( Console.ReadLine()); 
                //win  ++;
                //lose ++ ;              
                if(guess == rndNumber){
                    Console.WriteLine("true");

                    Console.WriteLine("Do you  wish continue \nYES is (y) or  No is (n)");
                    string chioce = Console.ReadLine();
                    if (chioce.Equals("y")){
                        Console.WriteLine("Continue game");
                        win = 1;
                        win ++;
                        goto start;
                    }
                    else if(chioce.Equals("n")){
                        Console.WriteLine();    
                        break;
                    }else {
                        Console.WriteLine("that wasnt a choice");
                    }
                    goto start ;  
                }
                else{
                    Console.WriteLine("false");
                    Console.WriteLine("Do you  wish continue \nYES is (y) or  No is (n)");
                    string chioce = Console.ReadLine();
                    if (chioce.Equals("y")){
                        Console.WriteLine("Continue game");
                        lose=1;
                        lose++;
                        goto start;
                    }else if(chioce.Equals("n")){
                        break;
                    }
                    goto start ; 
                };
                                        
            }while(guess < 11);
            Console.WriteLine(win);                     
        }
    }
}
