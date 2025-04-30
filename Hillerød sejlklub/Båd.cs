using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{


    public class Båd
    {
        #region Instance fields

        public int _bådId;
        public string _name;
        public string _description;
        public bool _sailing;
        // Vi skal bruge id, navn og beskrivelse på båd for at finde den, bool er til at se om den er ledig el ej.
        
        #endregion

        #region Constructor

            public Båd(int bådId, string name, string description)
        {
            _bådId = bådId;
            _name = name;
            _description = description;
        }
             
        
        

        
           

        

        #endregion

        #region Properties
        private int bådId 
        { get { return _bådId; } 
          set { _id = value; }
        }
        private string Name 
        { get { return _name; } 
          set { _name = value; }
        
        }
        private string Description 
        { get { return _description; }
          set { _description = value; }
        }
        


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name : {Name} - id : {Id} - description : {Description}";  
        }
        // Metode til at få vores oplysninger
        #endregion
    }

}

