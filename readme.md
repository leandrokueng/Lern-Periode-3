# Lern-Periode 3

Leandro Küng

9.1.2024 bis 30.1.2024 (☃️ Sportferien)

## Grob-Planung

1. Ich habe gute Noten. Im Modul 319 eine 5 und im Modul 431 eine 5,5. Die Note für das Modul 162 haben wir noch nicht bekommen.
2. Ich habe mir vorgenommen, dass ich effizienter arbeite. Ich nehme mir vor, mehr Pausen einbauen aber die Pausen kürzen. Wenn ich mehr Pausen mache und sie besser einteile, kann ich glaube ich effizienter arbeiten. 
3. Ich nehme mir vor einen Training-Tracker zu programmieren. 

## 9.1.2024

✍️ Heute habe ich geschaut, welches Programmierprojekt ich bearbeiten will und um was es gehen soll. Es passt gut und ich kann es sicher auch gebrauchen weil ich selber sehr oft Sport mache. Es kann mir also im Leben sehrwahrscheinlich weiterhelfen und es hat einen grossen Nutzen. Ich habe mir ebenfalls überlegt wie das Programm etwa aussehen soll und was ich brauche für das Programmieren brauche. 

## 16.1 und 23.1.2024

- [ ] Strings einfügen. Das Programm soll einen String speichern können.
- [ ] String, dass ich die Session eintragen kann, welchen Sport ich gemacht habe und wie lange sie gedauert hat.
- [ ] Das ich eine Liste mache, in der meine Trainingsessions eingetragen werden.
- [ ] Speichern damit ich die Sessions vergleichen kann.


| estfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| -------------- | -------------------- | -------------- | -------------- | -------- |
| 1              |     C# geöffnet      |                |                |    x     |
| 2              |     C# geöffnet      |                |                |    x     |
| 3              |     Strings müssen   |                |                |    x     | 
|                |     geschrieben sein |                |                |          |
| 4              |     Strings müssen   |                |                |    x     | 
|                |     eingegeben sein  |                |                |          |  


✍️ Mit meinem Trainingtracker angefangen und er funktioniert bis jetzt gut. Es ist schon fertig aber ich will die anderen Anforderungen noch in den Trainingtracker einbauen. Ich habe nicht alles allein gemacht und ich habe paar mal im Internet nachegeschaut aber mit dem Internet konnte ich meine Probleme lösen. Ich konnte gut arbeiten, weil ich zuhause in Ruhe an 2 Monitoren gearbeitet habe und ich mich gut auf meine Arbeit konzentrieren konnte. Ich bin sehr voran gekommen.(50-100 Wörter)

☝️ Vergessen Sie nicht, bis zum 16.1 einen ersten Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt
using System;
using System.Collections.Generic;

class TrainingTracker
{
    static void Main()
    {
        List<string> trainingSessions = new List<string>();

        while (true)
        {
            Console.WriteLine("Training Tracker");
            Console.WriteLine("1. Trainingseintrag hinzufügen");
            Console.WriteLine("2. Gespeicherte Sessions anzeigen");
            Console.WriteLine("3. Beenden");

            Console.Write("Auswahl: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    AddTrainingEntry(trainingSessions);
                    break;
                case "2":
                    DisplayTrainingSessions(trainingSessions);
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Ungültige Eingabe. Bitte wähle eine der Optionen aus.");
                    break;
            }
        }
    }

    static void AddTrainingEntry(List<string> sessions)
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
}

## 23.1.2024

- [ ] Der Tracker soll neue Ziele ausgeben können.
- [ ] Der Tracker soll die Leistungen erkennnen.
- [ ] Der Tracker soll ein höheres Ziel herausgeben.
- [ ] Der Tracker soll jemanden Loben wenn man sich verbessert hat.

| Testfall-Nummer | Ausgangslage (Given) | Eingabe (When) | Ausgabe (Then) | Erfüllt? |
| --------------- | -------------------- | -------------- | -------------- | -------- |
| 5               | Die erreichten Ziele |                |                |          |
| 6               | mehrere Leistungen   |                |                |          |
|                 | eingegeben           |                |                |          |                  
| 7               | alten Ziele          |                |                |          |  
| 8               | alle Trainings       |                |                |          |

✍️ Heute am 23.1 habe ich meinen Training Tracker erweitert mit den obenstehenden Anforderungen. Heute bin ich wieder sehr weit gekommen und ich habe wieder nur ein wenig im Internet recherchiert. Es hat sehr gut funktioniert mit dem Programmieren und ich kam sehr gut voran, weil ich mich so gut konzentrieren konnte. (50-100 Wörter)

☝️ Vergessen Sie nicht, bis zum 23.1 Ihren fixfertigen Code auf github hochzuladen, und in der Spalte **Erfüllt?** einzutragen, ob Ihr Code die Test-Fälle erfüllt
using System;
using System.Collections.Generic;

class TrainingTracker
{
    static void Main()
    {
        List<string> trainingSessions = new List<string>();
        int previousDuration = 0; 

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



## Reflexion

In dieser Lernperiode habe ich die Arbeit sehr angemessen gefunden. Es hat sich viel verbessert im gegensatz zu der Lernperiode 2 weil die arbeit angenehmer war. Ich konnte viel zu Hause an meinen zwei Bildschirmen arbeiten und ich kam sehr gut voran. Ich habe neue Begriffe in C# kennengelernt auch mit hilfe vom Internet. Es war nicht immer einfach im Distanzunterricht zu arbeiten, weil man keine Lehrperson hatte die einem helfen konnte, jedoch habe ich meist die Sachen die ich brauche auch im Internet geholfen und ich bin nie wirklich lange angestanden. ich konnte sehr schnell arbeiten und es hat auch gut funktioniert. 
