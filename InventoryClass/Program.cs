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
        private int _SafeCode;
        #endregion

        #region PROPERTIES
        public int SafeCode
        {
            get { return _SafeCode; }
            set { _SafeCode = value; }
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
        #endregion


        #region CONSTRUCTORS
   public Inventory()
        {

        }

        #endregion
     
        
    }  
    
    
}
