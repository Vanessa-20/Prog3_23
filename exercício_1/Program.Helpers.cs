
    partial class Program
    {
        static void SectionTitle(string title)
        {
            ConsoleColor previousColor = ForegroundColor;
            ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*");
            Console.WriteLine($"* {title}");
            Console.WriteLine("*");
            ForegroundColor = previousColor;
        }
    } 
