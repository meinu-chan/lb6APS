using System;

namespace lbAPS6Console
{ 
    class Program
    {
        static void Main(string[] args)
        {
            AskMe askName = new AskMe("Hey beauty, what is your name\n My name is ","Oh, your name, so sweet. ");
            askName.talk = new ConsoleTell();
            askName.Ask();
            AskMe askMyAge = new AskMe("How old are you ?\n Enter your age: ", "Fell old yet? XD");
            askMyAge.talk = new ConsoleTell();
            askMyAge.Ask();
        }
    }
}
