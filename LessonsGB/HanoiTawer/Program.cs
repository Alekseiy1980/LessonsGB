﻿void Tawers(string with = "1", string on = "3", string some = "2", int count = 3)
{
   if (count > 1) Tawers(with, some, on, count - 1);
   Console.WriteLine($"{with} => {on}");
   if (count > 1) Tawers(some, on, with, count - 1);
}
Tawers();
