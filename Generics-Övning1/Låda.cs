using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_Övning1
{
    internal class Låda:IEquatable<Låda>
    {

        public int Höjd {  get; set; }
        public int Längd {  get; set; }
        public int Bredd {  get; set; }


        public Låda(int höjd, int längd, int bredd) 
        {
            this.Höjd = höjd;
            this.Längd = längd;
            this.Bredd = bredd;
        }

        public bool Equals(Låda other)
        {
            if(other == null) return false;
            return Höjd == other.Höjd && Längd == other.Längd && Bredd == other.Bredd;

            
        }
    }
}
