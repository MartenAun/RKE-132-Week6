
string hello = "We are the champions?";

int stringLength = hello.Length;


hello = hello.Trim();
char firstLetter = hello[0];
Console.WriteLine(firstLetter);
hello = hello.Replace(hello[0], char.ToUpper(hello[0])).Replace('?', '!');
firstLetter = hello[0];
Console.WriteLine(firstLetter);
Console.WriteLine(hello);


//int wordcounter = 1;

//for (int i = 0; i < hello.Length; i++)
//{
  // if (char.IsWhiteSpace(hello[i]))
  //  {
    //    wordcounter++;
    //}
//}



//Console.WriteLine($"Word count in {hello}: {wordcounter} words.");

