using System;
using System.Collections.Generic;

class TrainingTracker
{
    static void Main()
    {
        List<string> trainingSessions = new List<string>();
        int previousDuration = 0; // Speichert die vorherige Trainingsdauer für Leistungsvergleiche

        while (true)
        {
            Console.WriteLine("Training Tracker");
            Console.WriteLine("1. Trainingseintrag hinzufügen");
            Console.WriteLine("2. Gespeicherte Sessions anzeigen");
            Console.WriteLine("3. Neue Ziele ausgeben");
            Console.WriteLine("4. Beenden");

            Console.Write("Auswahl: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTrainingEntry(trainingSessions, ref previousDuration);
                    break;
                case "2":
                    DisplayTrainingSessions(trainingSessions);
                    break;
                case "3":
                    PrintGoals(previousDuration);
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der Optionen aus.");
                    break;
            }
        }
    }

    static void AddTrainingEntry(List<string> sessions, ref int previousDuration)
    {
        Console.Write("Sportart: ");
        string sport = Console.ReadLine();

        Console.Write("Dauer (in Minuten): ");
        int duration;
        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        {
            Console.WriteLine("Ungültige Eingabe. Bitte gib eine positive Ganzzahl ein.");
            Console.Write("Dauer (in Minuten): ");
        }

        string sessionEntry = $"{DateTime.Now}: {sport}, Dauer: {duration} Minuten";
        sessions.Add(sessionEntry);

        // Leistungsvergleich und Lob
        if (previousDuration > 0 && duration > previousDuration)
        {
            Console.WriteLine("Herzlichen Glückwunsch! Du hast dich verbessert. Weiter so!");
        }

        previousDuration = duration;

        Console.WriteLine("Trainingseintrag hinzugefügt:\n" + sessionEntry);
        Console.WriteLine();
    }

    static void DisplayTrainingSessions(List<string> sessions)
    {
        if (sessions.Count == 0)
        {
            Console.WriteLine("Keine Trainingssessions vorhanden.");
        }
        else
        {
            Console.WriteLine("Gespeicherte Trainingssessions:");

            foreach (var session in sessions)
            {
                Console.WriteLine(session);
            }
        }

        Console.WriteLine();
    }

    static void PrintGoals(int previousDuration)
    {
        if (previousDuration == 0)
        {
            Console.WriteLine("Setze zunächst eine Trainingsdauer, um Ziele zu erhalten.");
        }
        else
        {
            int goalPercentage = (int)(previousDuration * 1.1); // Beispiel: 10% Steigerung
            Console.WriteLine($"Dein nächstes Ziel: Trainiere mindestens {goalPercentage} Minuten.");
        }

        Console.WriteLine();
    }
}
