// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// 
// List and loop through










// Array and loop through









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