using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegaty_Zdarzenia_Interfejsy
{
    internal class RandomList : IRandomList
    {
        private List<int> list;
        public int Count 
        { 
            get 
            { 
                return list.Count; 
            } 
        }
        public RandomList(int length, int min, int max)
        {
            list = new List<int>();
            Random rnd = new Random();
            for (int i = 0; i < length; i++)
            {
                list.Add(rnd.Next(min, max+1));
            }

            if(list.Count == 0)
            {
                EmptyList?.Invoke();
            }
        }
    }
}
