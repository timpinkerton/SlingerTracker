using System;
using System.Collections.Generic;
using System.Linq;
using SlingerTracker.Models;


namespace SlingerTracker.Data
{
    public class EntriesRepository
    {
        // a list of sample entries
        private static Entry[] _entries = new Entry[]
        {
            new Entry()
            {

                Id = 1,
                Name = "Hammy",
                Email = "ham@hammies.com",
                Date = "Today",
                Location = "Buttery",
                UserReview = "Ohhhhh yeah super good!"
            },
            new Entry()
            {

                Id = 2,
                Name = "Arnie",
                Email = "arnie@hammies.com",
                Date = "Yesterday",
                Location = "Tiffany's",
                UserReview = "Not good."
            },
            new Entry()
            {

                Id = 3,
                Name = "Dusty",
                Email = "dusty@hammies.com",
                Date = "Friday",
                Location = "Big Ed's",
                UserReview = "The. Best."
            }
        };

        //This will return a collection of entries
        public Entry[] GetEntries()
        {
            return _entries; 
        }

        public Entry GetEntry(int id)
        {
            Entry entryToReturn = null;

            foreach (var entry in _entries)
            {
                if (entry.Id == id)
                {
                    entryToReturn = entry;

                    break; 
                }
            }

            return entryToReturn; 
        }
    }
}