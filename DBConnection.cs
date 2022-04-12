using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    internal class DBConnection
    {
        public void Connect() {
            Console.WriteLine("Base DB Connection");
        }

        public void Disconnect() { 
        
        }

        public bool InsertData() {
            return true;
        }
    }

    class MongoDBConnection : DBConnection
    {
        public new void Connect() {
            Console.WriteLine("Connected to MongoDB");
        }
    }



    class SqlConnection : DBConnection
    {
        public new void Connect()
        {
            Console.WriteLine("Connected to SqlServer");
        }

    }

    sealed class OracleDBConnection : DBConnection
    {

        
    }


    //class Oracl19GConnection : OracleDBConnection {

    //    void EstablishConnection() { 
        
    //    }
    //}

    class Consumer { 
    
    public void Test()
        {
            SqlConnection con=new SqlConnection();
            con.Connect();
            MongoDBConnection con1=new MongoDBConnection();
            con1.Connect();
            OracleDBConnection con2=new OracleDBConnection();
            con2.Connect();

        }
    }
}
