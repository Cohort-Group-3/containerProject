// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// 
// List and loop through - Dana










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








// Dictionary and loop through- Muriel

Dictionary<string,int> grades=new Dictionary<string, int>();
grades.Add("Muriel",90 );
grades.Add("Emily",95);
grades.Add("Dana",96 );
grades.Add("enzo",98);
grades.Add("samy",99);

for (int i = 0; i < grades.Count; i++)
        {KeyValuePair<string, int> items=grades.ElementAt(i);
            
         Console.WriteLine($"{items.Key}:{items.Value}");
        }
