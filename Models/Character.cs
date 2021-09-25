using System;
using System.Collections.Generic;

namespace eternia.Models
{
    public class Character
    {
        public int Id { get; set;}
        public string Name { get; set;}
        public string Role { get; set;}

        public static List<Character> CreateCharacters()
        {
            return new List<Character>
            {
                new Character{Id= 1, Name = "Esqueleto", Role = "Vilão"},
                new Character{Id= 2, Name = "Homem Fera", Role = "Vilão"},
                new Character{Id= 3, Name = "He-Man", Role = "Herói"}
            }; 
        }
    }
}