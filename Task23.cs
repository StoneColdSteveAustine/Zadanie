Console.WriteLine("Введите число");
int cube = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
void Cube(int[] Cube){
  int Count = 0;
  int Length = Cube.Length;
  while (Count < Length)
  {
    Cube[Count] = Convert.ToInt32(Math.Pow(Count, 3));
    Count++;
  }
}

void PrintArry(int[] Collection){
  int Count = Collection.Length;
  int index = 1;
  while(index < Count){
        Console.WriteLine(Collection[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArry(array);
