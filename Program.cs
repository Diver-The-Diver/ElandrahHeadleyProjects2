public class MadLib
{

    public static void Main(string[] args)
    {
        //Makes a MadLib object so that we can use the MakeMadLib method
        MadLib ml = new MadLib();

        //creates variables to have a place to store users words
        string adj;
        string noun;
        string propNoun;
        string verb;
        string adVerb;

        //Asks the user for different kinds of words and saves them into their assigned variables
        Console.Write("Give me an adjective:");
        adj = Console.ReadLine();
        Console.Write("Give me an noun:");
        noun = Console.ReadLine();
        Console.Write("Give me an proper noun:");
        propNoun = Console.ReadLine();
        Console.Write("Give me an verb:");
        verb = Console.ReadLine();
        Console.Write("Give me an adverb:");
        adVerb = Console.ReadLine();


        //Writes a mad lib sentance to the console based on the input words
        Console.WriteLine(ml.MakeMadLib(adj, noun, propNoun, verb, adVerb));

    }

    /*
     * Goal: To take inputs and make a mad lib sentance out of them.
     * To Do- Output (return) a mad lib sentance that includes all of the input words
     */
    public string MakeMadLib(string one, string two, string three, string four, string five)
    {
        return ("A purple squid and his friend a " + one + " squid were heading to their next battle when they found a " + two + " they were both amazed by it even more amazed when it said its name is " + three + " then " + three +  " started to " + four + " the purple squid shouted in horror stop " + four + "ing away " + five + " however " + three + " did not and got crushed by a falling rock");
    } 
}