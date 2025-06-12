using System.Net;

namespace ClassLibrary1.Execeptions.ExeptionsBase
{
    public abstract class CursoCExeception : SystemException
    {
        public CursoCExeception(string errorMessage) : base(errorMessage) 
        {
            
        }

        public abstract List<string> GetErrors();
        public abstract HttpStatusCode GetHttpStatusCode();
        
    }
}
