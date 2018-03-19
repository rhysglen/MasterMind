using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MasterMind
{
   public class Peg
    {
       public string pegColour;
        Boolean pegExists;
        Boolean pegPosition;

        public Peg(Boolean _pegExists , Boolean _pegPosition, string _pegColour)
        {
            pegColour = _pegColour;
            pegExists = _pegExists;
            pegPosition = _pegPosition;
        }
    }

}
