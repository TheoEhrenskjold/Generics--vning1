using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Övning1
{
    class LådaCollection : ICollection<Låda>
    {
        private List<Låda> lådor = new List<Låda>();

        public void Add(Låda item) //Lägger till ny lådor till vår lista
        {
            if (!Contains(item))
            {
                lådor.Add(item);
            }
            
        }

        public bool Contains(Låda item)//Letar efter en specifik låda genom angivna mått
        {
            return lådor.Contains(item);
        }

        public bool Remove(Låda item)//Metod för att ta bort lådor med angivna mått
        {
            return lådor.Remove(item);
        }

        public int Count
        {
            get
            {
                return lådor.Count;
            }
        }
        public bool IsReadOnly
        {
            get
            {
                return false;
            }
        }

        public void Clear()//Rensar listan på alla element
        {
            lådor.Clear();
        }

        public void CopyTo(Låda[] array, int arrayIndex)
        {
            lådor.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Låda> GetEnumerator()
        {
            return lådor.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return lådor.GetEnumerator();
        }

        public bool Contains(Låda item, IEqualityComparer<Låda> comparer)//Foreachloopen kollar om det finns några lådor med samma mått, om det för det så returnerar den True.
        {
            foreach (var låda in lådor)
            {
                if (comparer.Equals(låda, item))
                {
                    return true;
                }
            }
            return false;
        }
    }

}
