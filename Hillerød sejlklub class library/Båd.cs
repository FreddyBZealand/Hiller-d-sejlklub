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
        public bool _eriSøen;
        // Vi skal bruge id, navn og beskrivelse på båd for at finde den, bool er til at se om den er ledig el ej.

        #endregion

        #region Constructor

        public Båd(int bådId, string name, string description, bool eriSøen)
        {
            _bådId = bådId;
            _name = name;
            _description = description;
            _eriSøen = eriSøen;
        }









        #endregion

        #region Properties
        private int bådId
        { get { return _bådId; }
            set { _bådId = value; }
        }
        private string Name
        { get { return _name; }
            set { _name = value; }

        }
        private string Description
        { get { return _description; }
            set { _description = value; }
        }


        public void SætiSøen()
        {
            _eriSøen = true;
        }

        public void SætpåLand()
        {
            _eriSøen = false;
        }

        //bool metode


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"name : {Name} - id : {bådId} - description : {Description}";  
        }
        public void VisInfo()
        {
            Console.WriteLine($"Name : {Name}");
            Console.WriteLine($"bådId : {bådId}");
            Console.WriteLine($"Description : {Description}");
            Console.WriteLine($"Is sailing : {_eriSøen}");
            Console.WriteLine();
           

        }
       
        // Metode til at få vores oplysninger
        #endregion
    }

}

