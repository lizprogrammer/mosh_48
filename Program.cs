using System;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //CountNumbersDivisibleByThree();
            //EnterANumber();
            //Factorial();
            //RandomNumber();
            MaximumNumber();
            
        }

        //1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. 
        //Display the count on the console.
        static int CountNumbersDivisibleByThree()
        {
            for(int i = 3; i < 100; i+=3)
            {
                Console.WriteLine(i);    
            }
            
            return 0;
        }
        
        //2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the 
        //sum of all the previously entered numbers and display it on the console.
        static int EnterANumber()
        {
            int MyInt = 0;
            
            while(true)
            {
                Console.Write("Enter a number or \"ok\" to end: ");
                string MyLine = Console.ReadLine();
                if(MyLine == "ok")
                {
                    Console.WriteLine(MyInt.ToString());
                    return 0;
                }    
                else
                {
                    MyInt += int.Parse(MyLine);
                }
                
            }
            return 0;
        }
        
        //3- Write a program and ask the user to enter a number. Compute the factorial of the number and print 
        //it on the console. For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 
        //and display it as 5! = 120.
        static int Factorial()
        {
            int MyInt = 0;
            int MyAns = 1;
            Console.Write("Enter a number or \"ok\" to end: ");
            string MyLine = Console.ReadLine();
            if(MyLine == "ok")
            {
                Console.WriteLine("Goodbye");
                return 0;
            }  

            MyInt += int.Parse(MyLine);            
            
            for(int i = MyInt; i > 0; i--)
            {
                MyAns = MyAns * i;
                //Console.WriteLine(String.Format("{0}, {1} ", MyAns.ToString(), i.ToString()));
            }
            Console.WriteLine(String.Format("{0} ", MyAns.ToString()));
            return 0;            
        }
        
        // 4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the 
        // number. If the user guesses the number, display â€œYou won"; otherwise, display â€œYou lost". (To make 
        // sure the program is behaving correctly, you can display the secret number on the console first.)        
        static int RandomNumber()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 100);

            Console.WriteLine(randomNumber);    
            
            String MyString = Console.ReadLine();
            while(MyString != randomNumber.ToString())
            {
                MyString = Console.ReadLine();
            }
            
            Console.WriteLine("You guessed it!"); 
            return 0;            
        }

        /*
        5- Write a program and ask the user to enter a series of numbers separated by comma. Find the maximum of 
        the numbers and display it on the console. For example, if the user enters â€œ5, 3, 8, 1, 4", the program 
        should display 8.
        */      
        static int MaximumNumber()
        {
            Console.WriteLine("Enter a list of numbers seperated by commas: ");    
            
            String MyString = Console.ReadLine();
            int biggest = 0;

            string[] splitter = MyString.Split(',');
            
            foreach (string number in splitter)
            {
                
                if(int.Parse(number) > biggest)
                    biggest = int.Parse(number);
            }
            
            Console.WriteLine("The biggest! {0} ", biggest.ToString()); 
            return 0;            
        }        
        
    }

}

