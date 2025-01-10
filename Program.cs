 using System;
 using System.Collections.Generic;

 // Liste pour stocker les notes et les coefficients
 List<double> notes = new List<double>();
 List<double> coefficients = new List<double>();

 while (true)
 {
     // Demander à l'utilisateur de saisir une note ou de taper 'end' pour arrêter
     Console.Write("Entrez une note (max 20) ou tapez 'end' pour arrêter : ");
     string inputNote = Console.ReadLine();

     // Si l'utilisateur tape 'end', on arrête la boucle
     // ToLower signifie que peut importe la façon dont
     // on écrira "END", il sera converti en minuscule
     if (inputNote.ToLower() == "end")
     {
         break;
     }

     // Essayer de convertir la note en un nombre
     // TryParse = conversion d'une string en int ou float
     if (double.TryParse(inputNote, out double note))
     {
         // Vérifier si la note est supérieure à 20
         if (note > 20)
         {
             Console.WriteLine("La note ne peut pas être supérieure à 20. Essayez à nouveau.");
             continue; // Redemander la note si elle est trop élevée
         }

         // Si la note est valide, demander le coefficient
         Console.Write("Entrez le coefficient pour cette note : ");
         string inputCoefficient = Console.ReadLine();

         // Essayer de convertir le coefficient en un nombre
         if (double.TryParse(inputCoefficient, out double coefficient))
         {
             // Ajouter la note et le coefficient aux listes
             notes.Add(note);
             coefficients.Add(coefficient);
         }
         else
         {
             Console.WriteLine("Le coefficient doit être un nombre valide.");
         }
     }
     else
     {
         Console.WriteLine("La note doit être un nombre valide.");
     }
 }

 // Vérifier si des notes ont été saisies
 if (notes.Count > 0)
 {
     // Afficher les notes et les coefficients saisis dans le terminal
     Console.WriteLine("\nVoici les notes et leurs coefficients :");
     for (int i = 0; i < notes.Count; i++)
     {
         // Afficher la note et le coefficient de chaque entrée
         Console.WriteLine($"Note {i + 1}: {notes[i]} - Coefficient: {coefficients[i]}");
     }

     // Calculer la somme des notes pondérées (note * coefficient)
     double sommePonderee = 0;
     double sommeCoefficients = 0;

     // Calculer les sommes des notes pondérées et des coefficients
     for (int i = 0; i < notes.Count; i++)
     {
         sommePonderee += notes[i] * coefficients[i];
         sommeCoefficients += coefficients[i];
     }

     // Calculer la moyenne pondérée
     double moyennePonderee = sommePonderee / sommeCoefficients;

     // Afficher la moyenne pondérée
     Console.WriteLine("La moyenne pondérée des notes est : " + moyennePonderee);
 }
 else
 {
     Console.WriteLine("Aucune note n'a été saisie.");
 }
