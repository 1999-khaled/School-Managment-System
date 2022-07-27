using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KhaledMedhatProject
{

    class Gpa : mainprg 

    {
        string[] sname1 = new string[] { "khaled", "medhat", "jack", "engy", "mariam", "sara", "kaya", "ahmed", "mohamed", "zain" };
int[] sid1 = new int[] { 17101227, 17100162, 17100321, 17100534, 17100783, 17100163, 17100847, 17100768, 17100754, 17100935 };
double s1 = 0;
double[] gpa = new double[10] { 3.4, 3.97, 3.1, 3.88, 2.9, 4, 1.7, 3.5, 3.4, 3.33 };
public Gpa() { }
public Gpa(int id, string name) : base(id, name) { }

public override double gpA()
{
    int j;

    for (j = 0; j <= sname1.Length; j++)
    {
        if (sname1[j] == Name && sid1[j] == Id)
        {

            s1 = gpa[j];
            break;
        }
        else { s1 = 0; }
    }
    return s1;
}
public string tostring()
{

    return Convert.ToString(s1);
}


        public double halfload() {
            double s=0;
            int j;

            for (j = 0; j <= sname1.Length; j++)
            {
                if (sname1[j] == Name && sid1[j] == Id)
                {

                    if (gpa[j] < 1.5) { s = 1; }
                    break;
                }
                else { s= 0; }
               
            }
            return s;
        }
    }
   
}


