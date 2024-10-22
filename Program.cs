namespace GruppUppgift1;

class Program
{
    static void Main(string[] args)
    {
        /*
        * Grupp 7
        * Uppgift 1
        * Deltagare: Nick, Tim, Noah, Sandra
        * 2024-09-10
        */
        Program.Replacer();
    }
        //#1
        public static void getMaxMin(){
            int[] numbers = new int[6]{14,20,25,12,45,100};
            //bool choice = true;
            int numbMax = numbers.Max();
            int numbMin = numbers.Min();
            Console.WriteLine($"Max: {numbMax}");
            Console.WriteLine($"Max: {numbMin}");
        }

        //#2

        public static void Laster(){
        string hemta = Console.ReadLine();
        string[] skemta = hemta.Split(" ");
        System.Console.WriteLine(skemta.Last());
        }

        public static void FilePrinter1(){
        //#3
        string mcflyText = "Print this damn text to a mcfly file...get it?";
        string fname = Console.ReadLine();
        File.WriteAllText(fname, mcflyText);
        string readTheTxt = File.ReadAllText(fname);
        System.Console.WriteLine(readTheTxt);
        }

        public static void Reverse(){
        //#4
        string Input = "Hejdo";
        char[] oriStr = Input.ToCharArray();
        string revStr = String.Empty;
        for(int i = oriStr.Length - 1; i>-1;i--){
            revStr += oriStr[i];
        }
        }

        public static void Replacer(){
        //#5
        string a = "Hej, jag gillar glass. Vad gillar du?";
        string b = "Jag brukar programmera. Är du en programmerare också?";
        string c = "Du måste handla mat medans jag städar huset.";
        string replacement;
        if(a.Contains("jag") && a.Contains("du")){
            replacement = a.Replace("jag", "tmp").Replace("du", "jag").Replace("tmp", "du");
            System.Console.WriteLine(replacement);
        }

        if(b.Contains("Jag") && b.Contains("du")){
            replacement = b.Replace("Jag", "tmp").Replace("du", "Jag").Replace("tmp", "du");
            System.Console.WriteLine(replacement);
        }

        if(c.Contains("Du") && c.Contains("jag")){
            replacement = b.Replace("Du", "tmp").Replace("Du", "jag").Replace("tmp", "Du");
            System.Console.WriteLine(replacement);
        }

        }
}
