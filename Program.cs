string[] array = {"Katya", "Tim", "Margo", "Yura", "Viktor", "Max", "000",  "))1"};
Console.WriteLine($" [{String.Join(",", array)}]");
int count = array.Length;
for( int a = 0; a <= count-1; a++){
      string name = array[a];
      if (name.Length ==3){
            Console.Write($"{name},  ");
      }
}
      