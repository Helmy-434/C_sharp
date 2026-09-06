
bool flag = true;
do
{
    Console.Write("Enter your name: ");
    string name = Console.ReadLine();
    Console.Write("Enter your score: ");
    double score = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter your attendance percentage: ");
    double attendance = Convert.ToDouble(Console.ReadLine());

    if (score < 0 || score > 100 || attendance < 0 || attendance > 100)
    {
        Console.WriteLine("Invalid Input: Values must be between 0 and 100.");
        flag = false;
    }
    else if ( attendance < 75){
        Console.WriteLine("Status: Failed - Reason: Low Attendance Rate");
    }
    else
    {
        switch (score)
        {
            case double n when (n >= 90):
                Console.WriteLine("Grade: A (Excellent)");
                break;
            case double n when (n >= 80):
                Console.WriteLine("Grade: B (Very Good)");
                break;
            case double n when (n >= 70):
                Console.WriteLine("Grade: C (Good)");
                break;
            case double n when (n >= 50):
                Console.WriteLine("Grade: D (Pass)");
                break;
            default:
                Console.WriteLine("Grade: F (Fail)");
                break;
        }
    }

}while(flag == false);