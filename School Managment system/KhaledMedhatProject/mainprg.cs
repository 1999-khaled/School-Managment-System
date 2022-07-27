using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaledMedhatProject
{
    class mainprg
    {
      
        string name;
        int id;
        public mainprg() { }
        public mainprg(int id, string name)
        {
            this.name = name;
            this.id = id;
           

        }

        public int Id
        {
            set { id = value; }
            get { return id; }
        }

        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public virtual int attendance()
        {
            return 0;
                
        }

        public virtual double gpA()
        {
            return 0;

        }

        public virtual int Sub()
        {
            return 0;

        }

    }
}
