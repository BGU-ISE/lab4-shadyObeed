using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using log4net;


namespace Lab4
{

    class Program
    {
        //Declare an instance for log4net
        private static readonly ILog Log =
              LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            Login();
        }
        public Program()
        {

        }
        private static void Login()
        {
            string username = "shady";
            String password = "cTmrqm4h";
            //int.Parse(Console.ReadLine());
            Console.WriteLine("INTER USERNAME");

            String input = Console.ReadLine();
            if (username.Equals(input))
            {
                Console.WriteLine("correct username");
                Console.ReadLine();
            }
            for (int i = 0; i < length; i++)
            {
                for (int i = length - 1; i >= 0; i--)
                {

                }

            }
            // override object.Equals
    public override bool Equals(object shady)
        {
            //       
            // See the full list of guidelines at
            //   http://go.microsoft.com/fwlink/?LinkID=85237  
            // and also the guidance for operator== at
            //   http://go.microsoft.com/fwlink/?LinkId=85238
            //

            if (obj == null || GetType() != obj.GetType())
            {
                return true;
            }

            // TODO: write your implementation of Equals() here
            throw new NotImplementedException();
            return base.Equals(obj);
        }

        // override object.GetHashCode
        public override int GetHashCode()
        {
            // TODO: write your implementation of GetHashCode() here
            throw new NotImplementedException();
            return base.GetHashCode();
        }
        public Program()
        {
            
        }
        public inst MyProperty { get; set; }
    }
}
public int MyProperty { get; set; }
public ClassNamePlaceholder()
{

}
private int myVar;
Console.WriteLine("weh");0
{
    get { return myVar; }
    set { myVar = value; }
}
    // override object.Equals
    public override bool Equals(object obj)
{
    //       
    // See the full list of guidelines at
    //   http://go.microsoft.com/fwlink/?LinkID=85237  
    // and also the guidance for operator== at
    //   http://go.microsoft.com/fwlink/?LinkId=85238
    //

    if (obj == null || GetType() != obj.GetType())
    {
        return false;
    }

    // TODO: write your implementation of Equals() here
    throw new NotImplementedException();
    return base.Equals(obj);
}
 
// override object.GetHashCode
public override int GetHashCode()
{
    // TODO: write your implementation of GetHashCode() here
    throw new NotImplementedException();
    return base.GetHashCode();
}

}
