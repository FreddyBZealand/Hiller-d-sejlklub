﻿using System;
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
        public int _serviceId;
        public string _name;
        public string _type;

        //Vi skal bruge de forskellige oplysninger for at kende båd og vide hvad der skal laves
        #endregion

        #region Constructor
        public Service(string damage, int serviceId, string name, string type)
        {

            _damage = damage;
            _serviceId = serviceId;
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
            private int serviceId
        { 
            get { return _serviceId; } 
            set {  _serviceId = value; } 
        }
       
       private string name
        { get { return _name; } }

        private string type
        { get { return _type; } }


        #endregion

        #region Methods
        public override string ToString()
        {
            return $"damage : {damage}, id : {serviceId}, name : {name}, type : {type}";
        }
        public void AddService()
        {
            Console.WriteLine($"Damage : {damage}");
            Console.WriteLine($"ServiceId : {serviceId}");
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Type : {type}");
            Console.WriteLine();
        }

        //Oplysninger bliver returneret til os
        #endregion
    }
}
