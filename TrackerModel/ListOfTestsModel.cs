using System;
using System.Collections.Generic;

namespace TrackerModel
{
    public class ListOfTestsModel<T> : List<T>
    {
        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = this.Count - 1; i >= 1; i--)
            {
                int j = rand.Next(i + 1);
                (this[j], this[i]) = (this[i], this[j]);
            }
        }
    }
}
