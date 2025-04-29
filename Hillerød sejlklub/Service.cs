using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hillerød_sejlklub
{
    public class Service
    {
        #region Instance fields
        public string _damage;
        public string _id;
        public string _name;
        public string _type;


        #endregion

        #region Constructor
        public Service(string damage, string id, string name, string type)
        {

            _damage = damage;
            _id = id;
            _name = name;
            _type = type;

        }

        #endregion

        #region Properties
        private string damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
            private string id
        { 
            get { return _id; } 
            set {  _id = value; } 
        }
       
       private string name
        { get { return _name; } }

        private string type
        { get { return _type; } }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"damage : {damage}, id : {id}, name : {name}, type : {type}";
        }
        #endregion
    }
}
