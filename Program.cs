// input (prepare)
int currentAssignments = 5;

int alex1 = 93;
int alex2 = 87;
int alex3 = 98;
int alex4 = 95;
int alex5 = 100;

int lauren1 = 80;
int lauren2 = 83;
int lauren3 = 82;
int lauren4 = 88;
int lauren5 = 85;

int rio1 = 84;
int rio2 = 96;
int rio3 = 73;
int rio4 = 85;
int rio5 = 79;

int rumi1 = 90;
int rumi2 = 92;
int rumi3 = 98;
int rumi4 = 100;
int rumi5 = 97;

// process
int alexSum = alex1 + alex2 + alex3 + alex4 + alex5;
int laurenSum = lauren1 + lauren2 + lauren3 + lauren4 + lauren5;
int rioSum = rio1 + rio2 + rio3 + rio4 + rio5;
int rumiSum = rumi1 + rumi2 + rumi3 + rumi4 + rumi5;

decimal alexScore = (decimal)alexSum / currentAssignments;
decimal laurenScore = (decimal)laurenSum / currentAssignments;
decimal rioScore = (decimal) rioSum / currentAssignments;
decimal rumiScore = (decimal) rumiSum / currentAssignments;

// output
Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Alex:\t\t" + alexScore + "\tA");
Console.WriteLine("Lauren:\t\t" + laurenScore + "\tB");
Console.WriteLine("Rio:\t\t" + rioScore + "\tB");
Console.WriteLine("Rumi:\t\t" + rumiScore + "\tA");