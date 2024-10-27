using System;

namespace MyConsoleCal
{
    class getUsrInput
    {
       public int usrIn1 {  get; private set; }
        public int usrIn2 { get; private set; }
        public string usrOperator { get; private set; }
        public getUsrInput(int input1, string inputOperator, int input2) 
        {
            usrIn1 = input1;
             usrOperator = inputOperator;
             usrIn2 = input2;

            


        }

    }
    class solver
    {
        public int Answer {  get; set; }
        

        public void CheckFormula(getUsrInput input)
        {
            while (true)
            {

                if (input.usrOperator == "+")
                {
                    Answer = input.usrIn1 + input.usrIn2;
                    Console.WriteLine($"Result: {Answer}");
                    break;
                }
                else if (input.usrOperator == "-")
                {
                    Answer = input.usrIn1 - input.usrIn2;
                    Console.WriteLine($"Result: {Answer}");
                    break;
                }
                else if (input.usrOperator == "*")
                {
                    Answer = input.usrIn1 * input.usrIn2;
                    Console.WriteLine($"Result: {Answer}");
                    break;
                }
                else if (input.usrOperator == "/")
                {
                    Answer = input.usrIn1 / input.usrIn2;
                    Console.WriteLine($"Result: {Answer}");
                    break;
                }
                else
                {
                    Console.WriteLine("INVALID SYNTAX");
                    break;
                }
            }
        }
    }
    class outPut
    {
        static void Main(string[] args)
        {
            bool continueCalculating = true;

            while (continueCalculating)
            {
                Console.WriteLine("Enter A Number:");
                int usrIn1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter A Operator");
                string usrOperator = Console.ReadLine();

                Console.WriteLine("Enter A Number;");
                int usrIn2 = Convert.ToInt32(Console.ReadLine());

                getUsrInput userInput = new getUsrInput(usrIn1, usrOperator, usrIn2);
                solver mySolver = new solver();
                mySolver.CheckFormula(userInput);
            }
        }
    }
}