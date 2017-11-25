using System;
using System.Collections.Generic;
using USA.Models;

namespace USA.Helpers
{
    public static class PresidentHelper
    {
        private static List<President> allPresidents = null;
        private static object allPresidentsLock = new object();

        public static List<President> GetAllPresidents()
        {
            if(allPresidents == null)
            {
                lock(allPresidentsLock)
                {
                    if(allPresidents == null)
                    {
                        allPresidents = new List<President>();
                        allPresidents.Add(new President{ Name = "George Washington"});
                        allPresidents.Add(new President{ Name = "John Adams"});
                        allPresidents.Add(new President{ Name = "Thomas Jefferson"});
                        allPresidents.Add(new President{ Name = "James Madison"});
                        allPresidents.Add(new President{ Name = "James Monroe"});
                        allPresidents.Add(new President{ Name = "John Quincy Adams"});
                        allPresidents.Add(new President{ Name = "Andrew Jackson"});
                        allPresidents.Add(new President{ Name = "Martin Van Buren"});
                        allPresidents.Add(new President{ Name = "William Henry Harrison"});
                        allPresidents.Add(new President{ Name = "John Tyler"});
                        allPresidents.Add(new President{ Name = "James K. Polk"});
                        allPresidents.Add(new President{ Name = "Zachary Taylor"});
                        allPresidents.Add(new President{ Name = "Millard Fillmore"});
                        allPresidents.Add(new President{ Name = "Franklin Pierce"});
                        allPresidents.Add(new President{ Name = "James Buchanan"});
                        allPresidents.Add(new President{ Name = "Abraham Lincoln"});
                        allPresidents.Add(new President{ Name = "Andrew Johnson"});
                        allPresidents.Add(new President{ Name = "Ulysses S. Grant"});
                        allPresidents.Add(new President{ Name = "Rutherford B. Hayes"});
                        allPresidents.Add(new President{ Name = "James A. Garfield"});
                        allPresidents.Add(new President{ Name = "Chester A. Arthur"});
                        allPresidents.Add(new President{ Name = "Grover Cleveland"});
                        allPresidents.Add(new President{ Name = "Benjamin Harrison"});
                        allPresidents.Add(new President{ Name = "Grover Cleveland"});
                        allPresidents.Add(new President{ Name = "William McKinley"});
                        allPresidents.Add(new President{ Name = "Theodore Roosevelt"});
                        allPresidents.Add(new President{ Name = "William Howard Taft"});
                        allPresidents.Add(new President{ Name = "Woodrow Wilson"});
                        allPresidents.Add(new President{ Name = "Warren G. Harding"});
                        allPresidents.Add(new President{ Name = "Calvin Coolidge"});
                        allPresidents.Add(new President{ Name = "Herbert Hoover"});
                        allPresidents.Add(new President{ Name = "Franklin D. Roosevelt"});
                        allPresidents.Add(new President{ Name = "Harry S. Truman"});
                        allPresidents.Add(new President{ Name = "Dwight D. Eisenhower"});
                        allPresidents.Add(new President{ Name = "John F. Kennedy"});
                        allPresidents.Add(new President{ Name = "Lyndon B. Johnson"});
                        allPresidents.Add(new President{ Name = "Richard Nixon"});
                        allPresidents.Add(new President{ Name = "Gerald Ford"});
                        allPresidents.Add(new President{ Name = "Jimmy Carter"});
                        allPresidents.Add(new President{ Name = "Ronald Reagan"});
                        allPresidents.Add(new President{ Name = "George H. W. Bush"});
                        allPresidents.Add(new President{ Name = "Bill Clinton"});
                        allPresidents.Add(new President{ Name = "George W. Bush"});
                        allPresidents.Add(new President{ Name = "Barack Obama"});
                        allPresidents.Add(new President{ Name = "Donald Trump"});
                    }
                }
            }

            return allPresidents;
        }
    }
}