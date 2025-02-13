int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 95, 99, 92, 100};
int[] andrewScores = new int[] { 88, 75, 98, 83, 99};
int[] loganScores = new int[] { 65, 70, 75, 69, 70};
int[] sowadScores = new int[] { 100, 94, 99, 95, 96};

string[] studentNames = new string[] {"Sophia", "Andrew", "Logan", "Sowad"};

int[] studentScores = new int[10];

Console.WriteLine("\nStudent\t\tGrade\t\tLetter\n");


foreach (string name in studentNames) 
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
    {
        studentScores = sophiaScores;
    } else if (currentStudent == "Andrew")
    {
        studentScores = andrewScores;
    } else if (currentStudent == "Logan")
    {
        studentScores = loganScores;
    } else if (currentStudent == "Sowad")
    {
        studentScores = sowadScores;
    }
    
    int scoreSum = 0;
    decimal scoreAverage = 0;

   foreach (int score in studentScores)
   {
       scoreSum += score;
   }

    scoreAverage = (decimal)scoreSum / currentAssignments;
    
    string letter = "";

    if (scoreAverage >= 90) 
    {
        letter = "A+";
    } else if (scoreAverage >= 80)
    {
        letter = "A";
    } else if (scoreAverage >= 70)
    {
        letter = "B";
    } else if (scoreAverage >= 60)
    {
        letter = "C";
    }

   Console.WriteLine($"{currentStudent}\t\t{scoreAverage}\t\t{letter}");
}

Console.WriteLine("\nPress Enter to continue......");
Console.ReadLine();
