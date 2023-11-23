string [] stringArray = new string[5] {"аб", "125", "hello", "world", "123654"};

string [] SecondArray(string [] stringArray)
{
  int count = 0;  
  for (int i = 0; i<stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    count++;
  }
  string [] rez = new string [count];
  int j = 0;
  for (int i = 0; i<stringArray.Length; i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}

void PrintA(string [] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
    if(i < stringArray.Length - 1) Console.Write($"“{stringArray[i]}”, ");
    else Console.Write($"“{stringArray[i]}”");
    }
     Console.Write("]");   
}
      
PrintA(stringArray);
Console.Write(" → ");
PrintA(SecondArray(stringArray));
