using System;
using System.Collections.Generic;
using System.Text;

namespace NLogProjects
{
    public class Math
    {
        Nlog nlog = new Nlog();
        public  double DivideTwoNumbers(int a ,int b)
        {
            try
            {
                nlog.Information("Entered inside DivideTwoNumbers");
                var value= a / b;

                nlog.Information("result of a/b= "+value);
                return value;
            }
            catch (Exception ex)
            {
                nlog.Error(ex.Message);
            }
            return -1;
        }
    }
}
