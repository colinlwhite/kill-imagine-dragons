using System;
using System.Collections.Generic;
using System.Linq;

namespace linq
{
    class Song
    {
       // Properties
      public string Artist { get; set; }
      public string Name { get; set; }

      // Contrustor Method
      public Song(string artist, string name)
      {
          // Setting the properties above 
          Artist = artist;
          Name = name;
      }
    }
}