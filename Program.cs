// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


// Create an integer array with the values 0 through 9 inside.

int[] NumArray = new int [] {0,1,2,3,4,5,6,7,8,9};

for (int i = 0; i < NumArray.Length; i++)
{
    
Console.WriteLine(NumArray[i]);
}

// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".

string[] NameArray = new string [] {"Tim", "Martin", "Nikki", "Sara"};

foreach (string names in NameArray)
{
    Console.WriteLine(names);
}

// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true.

bool[] BooleanArray = new bool [10];
BooleanArray[0] = true;
BooleanArray[1] = false;
BooleanArray[2] = true;
BooleanArray[3] = false;
BooleanArray[4] = true;
BooleanArray[5] = false;
BooleanArray[6] = true;
BooleanArray[7] = false;
BooleanArray[8] = true;
BooleanArray[9] = false;

foreach (bool val in BooleanArray)
{
    Console.WriteLine(val);
}


// Create a string List of ice cream flavors that holds at least 5 different flavors. (Feel free to add more than 5!)
List<string> flavorsList = new List <string>() {"vanilla", "chocolate", "strawberry", "cookie dough", "birthday cake"};

// Output the length of the List after you added the flavors.
Console.WriteLine(flavorsList.Count);

// Output the third flavor in the List.
Console.WriteLine(flavorsList[2]);

// Now remove the third flavor using its index location.
flavorsList.Remove("strawberry");
Console.WriteLine(flavorsList[2]);

// Output the length of the List again. It should now be one fewer.
Console.WriteLine(flavorsList.Count);

// Create a dictionary that will store string keys and string values.
Dictionary<string,string> dict = new Dictionary<string,string>();

// Add key/value pairs to the dictionary where:
    // Each key is a name from your names array (this can be done by hand or using logic)
    // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)

for(int i = 0; i < NameArray.Length; i++)
{
    Random randomNum = new Random(); 
    dict.Add(NameArray[i], flavorsList[randomNum.Next(0,4)]);
}

// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
foreach (KeyValuePair<string,string> entry in dict )
{
    
    Console.WriteLine(entry);
}