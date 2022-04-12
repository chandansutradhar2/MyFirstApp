using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class AccessDemo
    {
        //public , private , protected, internal
        //public - the code is accessible from all classes
        void TestAccess()
        {
            PublicClass obj=new PublicClass();
            
           
        }
    }

    internal class ProtectedClass { 
    
        void Test() {
            PublicClass ob = new PublicClass();
            ob.pubAttr = "set by protected class";
            ob.internalAttr = 20;
           
        }
    }

    
    
    public class PublicClass {

        private string pvtAttr;
        public string pubAttr;
        private protected int pvtProcAttr;
        internal int internalAttr;
        protected int protectedAttr;


        void Test() {
            this.pvtAttr = "some value";
            this.internalAttr = 10;

        }
    }

    public class DerivedClass : PublicClass {

        public DerivedClass() {
            this.pubAttr="";
            this.pvtProcAttr = 10;
            this.internalAttr = 30;
            this.protectedAttr = 20;
        }
    }
}

namespace TestSpace {

    class TestClass{
        void Test() { 
            MyFirstApp.PublicClass obj=new MyFirstApp.PublicClass();
            obj.pubAttr = "some value";
          obj.internalAttr = 20;
           
           
        }
}
    class TestDerivedClass : MyFirstApp.PublicClass { 
    
        void Test()
        {
            this.pvtProcAttr=10;
            this.internalAttr =20;
            this.protectedAttr = 40;

        }
    }
}





