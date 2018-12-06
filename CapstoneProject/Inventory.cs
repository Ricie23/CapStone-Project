using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneProject
{
    public class Inventory
    {
        #region FIELDS
        private string _name;
        private bool _canSeeBetter;
        private bool _unlockDoor;
        private bool _useonDrawer;
        private int _Number;
        #endregion

        #region PROPERTIES
        public int Number
        {
            get { return _Number; }
            set { _Number = value; }
        }

        public bool unlockDrawer
        {
            get { return _useonDrawer; }
            set { _useonDrawer = value; }
        }


        public bool CanUnlockDoor
        {
            get { return _unlockDoor; }
            set { _unlockDoor = value; }
        }

        public bool uselight
        {
            get { return _canSeeBetter; }
            set { _canSeeBetter = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        #endregion


        #region CONSTRUCTORS
        public Inventory()
        {

        }

        #endregion


    }


}

