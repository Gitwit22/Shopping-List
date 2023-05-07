

using System.Diagnostics.Metrics;
using System.Numerics;



//initialize list and dictionaries

Dictionary<string, double> itemsPrice = new Dictionary<string, double>()
{
    { "waffles", 5.00},
    { "apples", 1.00},
    { "milk", 3.50},
    { "bacon", 9.00},
    { "lunch meat", 3.50},
    { "syrup", 4.00},
    { "corn", 1.00},
    { "apple pie", 5.00}
};

List<string> customerList = new List<string>();
{

};

Dictionary<string, double> customerTotal = new Dictionary<string, double>();



// print out initial menu
foreach (KeyValuePair<string,double> kvp in itemsPrice)
{
    Console.WriteLine( kvp.Key);
    Console.WriteLine(kvp.Value);
}

//start user interface
Console.WriteLine($"Would you like to add an item to your personal grocery list? Y/N");

//start loop 
bool addAnother = false;
while (addAnother == false)
{
   
    string item = Console.ReadLine();

    if ( item.ToLower() == "y" )
    {
        Console.WriteLine("Please write item (type done when finished.)");
    }
    else if ( item.ToLower() == "n")
    {
        break;
    }

    item = Console.ReadLine();

    if (item.ToLower() == "done")
    {
        addAnother = true;
        break;
    } else if (!itemsPrice.ContainsKey(item) )
    {

        Console.WriteLine("Not Available...Please enter an item thats on the menu!");
        
        
    }else if (itemsPrice.ContainsKey (item.ToLower()))
    {
        customerList.Add(item);
       
       
    }
    Console.WriteLine("Would you like to add another item? Y/N");


    }

//add new items from list to dictionary with prices

foreach (string b in customerList)
{
    customerTotal.Add(b, itemsPrice[b]);
}

double sum = customerTotal.Values.Sum();
foreach (KeyValuePair<string, double> item in customerTotal)
{
    Console.WriteLine("{0}, {1}", item.Key, item.Value);
    
}

//total

Console.WriteLine("Bringing your total to");
Console.WriteLine(sum);



































