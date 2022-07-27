using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaledMedhatProject
{
    class Login
    {
        string[] name = new string[50];
        string[] pass = new string[50];
        string inputName;
        string inputPass;
        
        public Login() { }
        public Login(string name, string pass)
        {
            this.inputName = name;
            this.inputPass = pass;

        }

        public string InputName
        {
            set { inputName = value; }
            get { return inputName; }

        }
        public string InputPass
        {
            set { inputPass = value; }
            get { return inputPass; }
        }
        public int log_in()
        {
            name[0] = "Jack";
            pass[0] = "123";
            name[1] = "Ramy";
            pass[1] = "321";
            int s = 0;
            for(int i = 0; i < name.Length; i++)
            {
                if (name[i] == InputName && pass[i] == InputPass) { s = 1; break; }
                else { s = 0; }
            }
            return s;
        }


    }
}
