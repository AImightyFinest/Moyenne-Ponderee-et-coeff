using System;

class Program
{
    static void Main()
    {
        Console.Write("Combien de notes voulez-vous saisir ? ");
        int nombreNotes = int.Parse(Console.ReadLine());

        double sommeNotesCoefficients = 0;
        double sommeCoefficients = 0;

        for (int i = 1; i <= nombreNotes; i++)
        {
            Console.Write($"Entrez la note {i} : ");
            double note = double.Parse(Console.ReadLine());

            Console.Write($"Entrez le coefficient de la note {i} : ");
            double coefficient = double.Parse(Console.ReadLine());

            sommeNotesCoefficients += note * coefficient;
            sommeCoefficients += coefficient;
        }

        double moyenne = sommeNotesCoefficients / sommeCoefficients;
        Console.WriteLine($"La moyenne pondérée est : {moyenne:F2}");
    }
}