using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOginForm
{
    public class Person
    {

        #region public variables
        //Users ID in the DB
        public int ID { get; set; }
        //User's First name
        public String Fname { get; set; }
        //User's Last Name
        public String Lname { get; set; }
       
        //User's Priority
        //0 : View public pages only
        //1 : View and Add public pages only
        //2 : View and Add secret pages
        public int Priority { get; set; }

        #endregion

        #region Constructor
        public Person(int id, String fname, String lname, int priority)
        {
            ID = id;
            Fname = fname;
            Lname = lname;
            Priority = priority;

        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public Person()
        {
        }

        #endregion
    }
}
