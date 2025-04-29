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

        public int _id;
        public string _name;
        public string _description;
        public bool _sailing;

        #endregion

        #region Constructor

            public Båd(int id, string name, string description)
        {
            _id = id;
            _name = name;
            _description = description;
        }
             
        
        

        
           

        

        #endregion

        #region Properties
        private int Id 
        { get { return _id; } }
        private string Name 
        { get { return _name; } }
        private string Description 
        { get { return _description; } }



        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name : {Name} - id : {Id} - description : {Description}";  
        }
        
        #endregion
    }

}

