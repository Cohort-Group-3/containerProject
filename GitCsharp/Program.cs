// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 
// List and loop through - Dana
List<string> petsList = new List<string>() {"Buddy", "Bean", "Sunny", "Sergeant Linq"};
//loop through items in list and print them out
foreach(string pet in petsList){
    Console.WriteLine($"This is my pet, {pet}.");
}





// Array and loop through - Emily
string[] dogs = new string[7];
dogs[0] = "Dachshund";
dogs[1] = "German Shepard";
dogs[2] = "Pitbull";
dogs[3] = "Chihuahua";
dogs[4] = "Labrador";
dogs[5] = "Shiba Inu";
dogs[6] = "Golden Retriever";

foreach( string dog in dogs) {
  Console.WriteLine(dog);
}








// Dictionary and loop through

Dictionary<string,int> grades=new Dictionary<string, int>();
grades.Add("Muriel",90 );
grades.Add("Emily",95);
grades.Add("Dana",96 );
grades.Add("enzo",98);
grades.Add("samy",99);

for (int k = 0; k < grades.Count; k++)
        {KeyValuePair<string, int> items=grades.ElementAt(k);
            
         Console.WriteLine($"{items.Key}:{items.Value}");
        }
