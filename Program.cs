string[] array = {"Katya", "Tim", "Margo", "Yura", "Viktor", "Max"};
Console.WriteLine($" [{String.Join(",", array)}]");
int count = array.Length;
string[] newArray= {""};
int i =-1;
for( int a = 0; a <= count-1; a++){
      string name = array[a];
      if (name.Length ==3){
            i++;
            newArray[i] = name;
      }


}
Console.WriteLine($" [{String.Join(",", newArray)}]");




/*string[] group = Array.FindAll(Array, Array => Array.Length == 3);
foreach (var Array in group) Console.WriteLine(Array);*/