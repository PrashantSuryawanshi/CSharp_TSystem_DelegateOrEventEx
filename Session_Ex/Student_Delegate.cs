using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_Ex
{
    public class Student_Delegate
    {
        //Event
        public event DisplayMsg FailEvent;  //Marks less then 40
        public event DisplayMsg PassEvent; //Marks greter then 40
        public void AcceptMarks(int marks)
        {
            if (marks >=40)
            {
                PassEvent(); //call to event or raise an event
            }
            else
            {
                FailEvent();//call to event or raise an event
            }
        }
    }
}
