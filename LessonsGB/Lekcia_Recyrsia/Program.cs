// int n = 1;
// void FindWords(string alphabet, char[] word, int length = 0)
// {
//    if (length == word.Length)
//    {
//       Console.WriteLine($"{n++}  {new String(word)}"); return;
//    }
//    for (int i = 0; i < alphabet.Length; i++)
//    {
//       word[length] = alphabet[i];
//       FindWords(alphabet, word, length + 1);
//    }
// }

// FindWords("аисв", new char[2]);


// //Задача2 ходим по папкам 
// string path = "/Users/Aleks/Desktop/Lessons_C/Lekcia_Recyrsia";
// DirectoryInfo dir = new DirectoryInfo(path);
// System.Console.WriteLine(dir.CreationTime);
// FileInfo[] fi = dir.GetFiles();
// for (int i = 0; i < fi.Length; i++)
// {
//    System.Console.WriteLine(fi[i].Name);
// }

//задача 3 Ходим по папкпам с помощью рекурсии
void CatalogInfo(string path, string indent = "")
{
   DirectoryInfo catalog = new DirectoryInfo(path);
   DirectoryInfo[] catalogs = catalog.GetDirectories();
   for (int i = 0; i < catalogs.Length; i++)
   {
      Console.WriteLine($"{indent} {catalogs[i].Name}");
      CatalogInfo(catalogs[i].FullName, indent + " ");
   }

   FileInfo[] files = catalog.GetFiles();
   for (int i = 0; i < files.Length; i++)
   {
      Console.WriteLine($"{indent} {files[i].Name}");
   }
}
string path = @"C:/Users/Aleks/Desktop/Lessons_C";
CatalogInfo(path);