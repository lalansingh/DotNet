using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CsharpConcept
{
    public class Employee
    {
        public int id;
        public string name;
        public string lname;
    }
    public class ReturnValues
    {
        public string GetEmpoyee()
        {
            var emp = new Employee();
            //emp.id = 22;
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(emp, new JsonSerializerSettings() { NullValueHandling = NullValueHandling.Ignore });
            return json;
        }
    }
    public class MainClassReturnValues
    {
        public void MainMethod()
        {
            string name = "";
            var emp = new ReturnValues().GetEmpoyee();
            Console.WriteLine(emp + name);

            Console.ReadLine();
        }
    }
}
