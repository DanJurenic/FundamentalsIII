// See https://aka.ms/new-console-template for more information
Console.WriteLine(" ");
Console.WriteLine("Hello, World!");
Console.WriteLine(" ");

List<string> games = new List<string>();

games.Add("Overwatch 2");
games.Add("Modern Warfare 2");
games.Add("Warzone 2");
games.Add("World of Warcraft");
games.Add("WWE 2K 22");
games.Add("Diabo III");

List<int> nums = new List<int>();

nums.Add(-1);
nums.Add(0);
nums.Add(007);
nums.Add(2);
nums.Add(42);
nums.Add(83);

int[] numArray = {-1,22,-33,42,600};

Dictionary<string,string> thingsDict = new Dictionary<string,string>();

thingsDict.Add("Soda", "Mtn Dew Code Red");
thingsDict.Add("Candy", "M&M's");
thingsDict.Add("Snack", "Cashews");
thingsDict.Add("Dog", "Rory");
thingsDict.Add("Skateboard", "HoverBoard Beast");

// 1. Iterate and print values
//  Given a List of strings, iterate through the List and print out all the values.
//  Bonus: How many different ways can you find to print out the contents of a List?
//  (There are at least 3! Check Google!)
static void PrintList(List<string> MyList)
{
    Console.WriteLine("Iterate and Print Values:");
    foreach (string item in MyList)
    {
        Console.WriteLine(" - " + item);
    }
    Console.WriteLine(" ");
}

PrintList(games);

// 2. Print Sum
//  Given a List of integers, calculate and print the sum of the values.
static void SumOfNumbers(List<int> IntList)
{
    int sum = 0;

    foreach (int item in IntList)
    {
        sum += item;
    }
    Console.WriteLine(" ");
    Console.WriteLine("SumOfNumbers output: " + sum);
    Console.WriteLine(" ");
}

SumOfNumbers(nums);

// 3. Find Max
//  Given a List of integers, find and return the largest value in the List.
static int FindMax(List<int> IntList)
{
    int maxNum = 0;
    for (int i = 0 ; i < IntList.Count ; i++ )
    {
        if (IntList[i] > maxNum){
            maxNum = IntList[i];
        }
    }
    return maxNum;
}

Console.WriteLine(" ");
Console.WriteLine("FindMax Results:");
Console.WriteLine(FindMax(nums));
Console.WriteLine(" ");

// 4. Square the Values
//  Given a List of integers, return the List with all the values squared.
//  (Hint: use your PrintList method to check that it worked!)
static List<int> SquareValues(List<int> IntList)
{
    for( int i = 0; i < IntList.Count ; i++)
    {
        IntList[i] *= IntList[i];
    }

    return IntList;
}

static void PrintIntList(List<int> MyList)
{
    Console.WriteLine("Iterate and Print Int Values for SquareValues:");
    foreach (int item in MyList)
    {
        Console.WriteLine(" - " + item);
    }
    Console.WriteLine(" ");
}

PrintIntList(SquareValues(nums));

// 5. Replace Negative Numbers with 0
//  Given an array of integers, return the array with all values below 0 replaced with 0.
static int[] NonNegatives(int[] IntArray)
{
    for (int idx = 0; idx < IntArray.Length; idx++)
    {
    if (IntArray[idx] < 0)
        {
            IntArray[idx] = 0;
        }
    }
    return IntArray;
}

NonNegatives(numArray);

Console.WriteLine("NonNegatives function results:");
for (int idx = 0; idx < numArray.Length; idx++)
{
    Console.WriteLine(numArray[idx]);
}
Console.WriteLine(" ");

// 6. Print Dictionary
//  Given a dictionary, print the contents of the said dictionary.
static void PrintDictionary(Dictionary<string,string> MyDictionary)
{
    Console.WriteLine(" ");
    Console.WriteLine("PrintDictionary results:");
    foreach(KeyValuePair<string,string> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
    Console.WriteLine(" ");
}

PrintDictionary(thingsDict);

// 7. Find Key
//  Given a search term, return true or false whether
//   the given term is a key in a dictionary.
static bool FindKey(Dictionary<string,string> MyDictionary, string SearchTerm)
{
    bool isItHere = false;

    foreach(KeyValuePair<string,string> entry in MyDictionary)
    {
        if (entry.Key == SearchTerm)
        {
            isItHere = true;
        }
    }

    return isItHere;
}

// This one should return true
Console.WriteLine("Searching for Skateboard should be true");
Console.WriteLine(FindKey(thingsDict, "Skateboard"));
// This one shuold return false
Console.WriteLine("Searching for Waffles should be false");
Console.WriteLine(FindKey(thingsDict, "Waffles"));

// 8. Generate a Dictionary
//  Given a List of names and a List of integers, create a dictionary where the key
//   is a name from the List of names and the value is a number from the List of numbers.
//   Assume that the two Lists will be of the same length.
//   Don't forget to print your results to make sure it worked.
// Ex: Given ["Julie", "Harold", "James", "Monica"] and [6,12,7,10], return a dictionary
// {
//	"Julie": 6,
//	"Harold": 12,
//	"James": 7,
//	"Monica": 10
// } 
static Dictionary<string,int> GenerateDictionary(List<string> Names, List<int> Numbers)
{
    Dictionary<string,int> newDict = new Dictionary<string,int>();

    for (int i = 0 ; i < Names.Count ; i++ )
    {
        newDict.Add(Names[i], Numbers[i]);
    }

    return newDict;
}

static void PrintMixedDictionary(Dictionary<string,int> MyDictionary)
{
    Console.WriteLine(" ");
    Console.WriteLine("PrintMixedDictionary / GenerateDictionary results:");
    foreach(KeyValuePair<string,int> entry in MyDictionary)
    {
        Console.WriteLine($"{entry.Key} - {entry.Value}");
    }
    Console.WriteLine(" ");
}

PrintMixedDictionary(GenerateDictionary(games, nums));