using System;
using System.Collections;

namespace Indexers
{
    public class Schedule
    {
        private Hashtable schedule = new Hashtable();
        
        public String this[DateTime date]
        {
            get { return (string) schedule[date]; }
            set { schedule[date] = value; }
        }
        
        public String this[String date]
        {
            get { return (string) schedule[Convert.ToDateTime(date)]; }
            set { schedule[date] = value; }
        }
    }
}