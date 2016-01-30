using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EngineWrapper
{
    public class ManagedDllWrapperImp
    {
        private Engine.managedDllWrapper managedWrapper;

        public ManagedDllWrapperImp()
        {
            managedWrapper = new Engine.managedDllWrapper();
        }
        public double AddWrapper(double a, double b)
        {
           return managedWrapper.AddWrapper(a, b);
        }
        public double DivideWrapper(double a, double b)
        {
            try
            {
                return managedWrapper.DivideWrapper(a, b);
            }
            catch (Exception ex)
            {
                throw;
            }         
        }
        public double MultiplyWrapper(double a, double b)
        {
            return managedWrapper.MultiplyWrapper(a, b);
        }
        public double SubtractWrapper(double a, double b)
        {
            return managedWrapper.SubtractWrapper(a, b);
        }
    }
}
