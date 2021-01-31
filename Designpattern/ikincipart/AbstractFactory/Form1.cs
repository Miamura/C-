using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbstractFactory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    }
    public class FactoryUtil
    {
        public static DBFactory GetFactory(string db_name)
        {
            if (db_name == "SQL")
            {
                return new SQLFactory();
            }

            if (db_name == "Oracle")
            {
                return new OracleFactory();
            }
            throw new Exception("error");
        }
    }
    // ABSTRACT FACTORY
    public abstract class DBFactory
    {
        public abstract Connection CreateConnection();
        public abstract Command CreateCommand();
    }
    // Concreate Factory'ler

    public class SQLFactory : DBFactory

    {

        public override Command CreateCommand()
        {
            return new SQLCommand();
        }

        public override Connection CreateConnection()
        {
            return new SQLConnection();
        }

    }

    public class OracleFactory : DBFactory
    {
        public override Command CreateCommand()

        {
            return new OracleCommand();
        }

        public override Connection CreateConnection()
        {
            return new OracleConnection();
        }
    }
    //////////////////////////////////////////////////
    // Soyut ürünler
    //////////////////////////////////////////////////
    public abstract class Connection
    {
        public abstract void Connect();
        protected String connectionstring;
        public abstract String Connectionstring
        {

            get;
            set;
        }
    }

    public abstract class Command
    {
        public abstract void Execute();

        protected String query;

        public abstract String Query
        {
            get;

            set;

        }
    }
    //////////////////////////////////////////////////

    // Somut ürünler

    //////////////////////////////////////////////////

    public class SQLConnection : Connection
    {
        public override void Connect()

        {
            Console.WriteLine("SQL’e baglandi");
        }

        public override string ConnectionString
        {
            get
            {
                return base.connectionString;
            }
            set
            {
                base.connectionstring = value;
            }
        }
    }

    public class OracleConnection : Connection
    {
        public override void Connect()
        {
            Console.WriteLine("Oracle’a baglandi");
        }

        public override string Connectionstring
        {
            get
            {
                return base.connectionstring;
            }
            set
            {
                base.connectionstring = value;
            }
        }
    }
    public class SQLCommand : Command

    {
        public override void Execute()
        {
            Console.WriteLine("T_SQL calisti");
        }

        public override string Query
        {
            get
            {
                return base.query;
            }
            set
            {
                base.query = value;
            }
        }
    }
        public class OracleCommand : Command
        {
            public override void Execute()
            {
                Console.WriteLine("PL/SQL calisti");
            }

            public override string Query
            {
                get
                {
                    return base.query;
                }
                set
                {
                    base.query = value;
                }
            }
        }
    //////////////////////////////////////////////////
    // istemci
    //////////////////////////////////////////////////

    public class Client
    {

        public static void Main(String[] args)
        {
            DBFactory db = FactoryUtil.GetFactory("SQL");
            Connection cnn = db.CreateConnection();
            cnn.Connect();
            Command cmd = db.CreateCommand();
            cmd.Query = "Select * from Tablo";
            cmd.Execute();

            db = FactoryUtil.GetFactory("Oracle");
            cnn = db.CreateConnection();

            cnn.Connect();

            cmd = db.CreateCommand();
            cmd.Query = "Select * from Table";

            cmd.Execute();
        }
    }


}
