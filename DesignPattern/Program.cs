using System;
using System.Collections;
using static System.Console;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using DesignPattern.asyncWait;
using DesignPattern.FactoryDesign;
using DesignPattern.OopsPractice;
using TestAssembly;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {

            //WriteLine("");
            //var obj = new Factory();
            //obj.GetName();
            //Console.WriteLine("HI");
            //Console.ReadLine();

            //string name = "sandeep";
            //char[] values = { 's', 'a', 'n', 'd', 'e', 'e', 'p' };
            //string myName = new string(values);
            //Console.WriteLine(myName);
            //Console.WriteLine("== operator result is {0}", name == myName);
            //Console.WriteLine("Equals method result is {0}", myName.Equals(name));

            //DelegateAnonymous.GetNumber  getNumbers=  delegate(int x, int y)
            //{
            //    return x + y;
            //};

            //getNumbers = new DelegateAnonymous.GetNumber(Calculator.Subtract);

            //var num = getNumbers(3, 5);

            //var obj = new Calculator();
            //var rest = Calculator.Subtract(4, 2);

            //var obj = new IndexerClass<string>
            //{
            //    [0] = "lsjkflsjd",
            //    [2] = "singh"
            //};

            //string firstName = "Lalan";
            //string lastName = "Singh";

            //string fullName = $"{firstName} {lastName}";

            //int a = 10;
            //string b = "100";

            //var slkd = a + b;

            //var res = AddNumber(4, 5);

            //obj.Items[0] = "lalan";
            //obj.Items[1] = "singh";

            //obj.Price[0] = 12;
            //obj.Price[1] = 11;

            //var rest = obj.Items;

            //var obj = new Pclass1();
            //obj.Sub();

            //ICustomer objCust = new CustomerA();
            //objCust.GetCustomerAddress();

            //FactoryMethod objFactoryMethod = new FactoryClass();
            //ICustomer oCustomer = objFactoryMethod.GetFactoryMethod("A");

            //oCustomer.GetCustomerAddress();

            //    string str = "kincenvizh";
            //    var strLength = str.Length;
            //    var count = 0;

            //    for (var i = 0; i < 10; i++)
            //    {
            //        for (var j = 0; j < (strLength - i); j++)
            //        {

            //            //if (!(i == 8 && (strLength - i) == 2))
            //            //{
            //                count++;
            //                WriteLine("{0} - {1}", count, str.Substring(i, (strLength - i) - j));
            //            //}
            //        }
            //    }

            //    WriteLine(count);

            //    int num = 1288;
            //    int[] zeroHoles = { 1, 2, 3, 5 };
            //    int[] oneHoles = { 0, 4, 6, 9 };
            //    int[] twoHoles = { 8 };
            //    int result = 0;
            //    List<int> holeNumbers = new List<int>();
            //    while (num > 0)
            //    {
            //        holeNumbers.Add(num % 10);
            //        num = num / 10;
            //    }
            //   // holeNumbers.Reverse();
            //    //var holeNumbers = listOfInts.ToArray();

            //    foreach (var numb in holeNumbers)
            //    {
            //        if (zeroHoles.Contains(numb))
            //            result += 0;
            //        if (oneHoles.Contains(numb))
            //            result += 1;
            //        if (twoHoles.Contains(numb))
            //            result += 2;
            //    }

            //var obj = new Employee();
            //var rest = obj.GetEmployeeName();

            //string alpha = "AAFGRXTDS9JH4CD66";

            //alpha = Regex.Replace(alpha, @"[\d-]", string.Empty);


            //WriteLine(alpha.Length);


            //var xmlDocument = Convert.FromBase64String("0x4C5A34426C6F636B262D040000EA1100007A492605F8530A5A0801120D7573696E672053797374656D3B1A283736303964393764396230633238663633626366313033346636643766346536383061333764346522166C616C616E2E73696E676840746176616E742E636F6D28E0E1F9C6872C0A6E080212215C00FF052E436F6C6C656374696F6E732E47656E65726963700038595F0803121270004F4C696E7161003A1B0461004F54657874610038596A0805121DC200FF00546872656164696E672E5461736B736C00385263080612166C00EF42757373696E65737341636365736500395F6C0807121F6500028F2E436F6E747261633F01395272080812256E004244617461CE00BF2E5265706F7369746F7279740041565D0809121074005F4D6F64656CA601385257080A120A5F002F4D6FCC02395259080B120C59004F58756E698701395F4D080C1200470437F00D6B080D121E6E616D65737061636520556E697454657374436173652E09003F42414C6D00376F4E080E12017B500037F0136E080F1221202020207075626C696320636C6173732056616C696461746555736572C3000F70003750520810120570000FC40038505B0811120E54000002006F5B466163745DB10037507A0812122D590000020003250170766F696420506195041C672B012F28297C003750560813120978000002000F310138608301081412365500040200F009766172206D6F636B44616C203D206E6577204D6F636B3C49010206A0043F3E28293B043864A301081512568200000200038200E82E53657475702863203D3E20632E6101FE062849742E4973416E793C737472696E673E28292C2014001F298401386098010816124B9E00080200902E52657475726E73282B01002501015805802829207B456D61694401322268697E08406B72406714006F2E636F6D227D4101394E83010817C7011562C30101980074616E61676572285B016F4F626A6563748600396889010818123C1D01004D02CA726573756C74203D2062616CC3011122170140222C2022D6092F68228C00393F4D0819DA0539688C01081A123FDB00DF4173736572742E457175616C28E30103132CFC00112E0A020FDE00393656081B0F041F7D670437304D081C3601FF1932636134353530316439386461316461613331303964613936313838353233373730326133353363570B065098EEB0A5888F051E1D8F050F5D00353F7A081E8F05034F4661696C8F05040F7C00353656081F80011F7B5800374E83010820C80303B2030F8F050E0FDE00354FA30108218F05470FA60035689A010822124D93030002000F8F0507112086030F900506112091050F9D00354E83010823C9010F9105150F8600354F8901082491052D0F8C00353F4D08255B0439608E0108261241F201040200039105394E6F7494050A76070E93050FE000353656082713041F7D58003732520828270B0FE705385F4E08291201500038304D082ADC010F8E112F50E1F9C6872C4C5A34426C6F636B16000000000000000000000000");
            //var nmlsXmlResponse = XmlToObject<string>(Encoding.UTF8.GetString(xmlDocument));

            //string name = "1101";
            //var res = CheckName(name, 0, name.Length-1);


            //OperatorCalculation();



            //var str = "lalan";
            //var len = str.Length-1;
            //var rev = "";

            //var revj = str.Reverse();
            //var revjr = string.Join("", revj);

            //var rv = str.ToCharArray();
            //Array.Reverse(rv);

            //var sld = new string(rv);


            //while (len >= 0)
            //{
            //    rev += str[len];
            //    len--;
            //}

            //.Reverse<char>();

            //var mj = GetMajorityElement(1, 2, 3, 4, 5, 2, 2, 2, 2);
            //TwoNumberWithoutTemVar();
            //ArmstrongNumbers();
            //MergeToList();
            //var obj = new MainClass();
            //obj.MainFunction();
            //float flt = 123456789.123456f;
            //double dbl = 1234567891011;
            //decimal dcml= 1234567891011;

            //var result = flt + dbl + dcml;
            // TestExam();
            //ThreadEx();
            //ClientMain obj=new ClientMain();
            //obj.MainMethodFactory();

            AsyncWait obj = new AsyncWait();
            Console.WriteLine(obj.GetTotalEmployee().Result);
            Console.WriteLine(obj.GetTotalDepartment());

            ReadKey();
        }

        public static void ThreadEx()
        {
            Thread thrd1 = new Thread(Test1);
            // Thread thrd2 = new Thread(Test2);
            //Thread.Sleep(1000);
            //var slk =Thread.CurrentThread;
            //Console.WriteLine(slk);
            thrd1.Start();
            //thrd2.Start();
            //thrd2.Join();
            Console.WriteLine("Main Method end");
        }

        public static void Test1()
        {
            var list = new List<int>();
            list.Add(2);
            list.Add(2);

            IEnumerable enumrbl = list.AsEnumerable();
            var lk = enumrbl.GetEnumerator();

            //var icol = new ICollection()

            //int[] arr = new int[2]{1,2};

            //for (int i = 0; i < enumrbl; i++)
            //{
            //    enumrbl[i] = 34;
            //    //Console.WriteLine(lst);
            //}

            //foreach (var lst in enumrbl)
            //{

            //    Console.WriteLine(lst);
            //}

            Console.WriteLine("test 1");
        }

        public static void Test2()
        {
            Console.WriteLine("test 2");
        }

        public static void TestExam()
        {
            string s = "zzraa";
            var query = (from l in s
                         group l by l into g
                         where g.Count() > 1
                         orderby g.Key ascending
                         select g.Key).Take(1).FirstOrDefault();



            Console.WriteLine(query);
            Console.ReadLine();
        }

        public static void ArmstrongNumbers()
        {
            int num = 153;//1634;
            int len = num.ToString().Length;
            int rem;
            double sum = 0;

            for (int i = num; i > 0; i = i / 10)
            {
                rem = i % 10;
                sum += Math.Pow(rem, len);
            }
            if (num == (int)sum)
                WriteLine("ArmstrongNumbers");
            else
                WriteLine("Not ArmstrongNumbers");

        }

        public static void MergeToList()
        {
            var list1 = new List<string> { "a", "b", "c", "d", "e" };
            var list2 = new List<string> { "1", "2", "3", "4", "5" };
            var list1Enumerator = list1.GetEnumerator();
            var list2Enumerator = list2.GetEnumerator();

            var result = list1.SelectMany((f, i) => new List<string> { f, list2[i] });

            var result1 = list1.Zip(list2, (f, s) => new[] { f, s })
                .SelectMany(f => f);

            while (list1Enumerator.MoveNext() || list2Enumerator.MoveNext())
            {
                WriteLine(list1Enumerator.Current);
                WriteLine(list2Enumerator.Current);
            }
        }

        public static void TwoNumberWithoutTemVar()
        {
            int a = 6;
            int b = 9;
            a = a ^ b;
            b = b ^ a;
            a = a ^ b;

            ReadKey();

        }

        //Ex. {1,2,3,4,5,2,2,2,2}, 2 is the majority element because it accounts for more than 50% of the array
        public static int GetMajorityElement(params int[] x)
        {
            Dictionary<int, int> d = new Dictionary<int, int>();
            int majority = x.Length / 2;

            //Stores the number of occcurences of each item in the passed array in a dictionary
            foreach (int i in x)
                if (d.ContainsKey(i))
                {
                    d[i]++;
                    //Checks if element just added is the majority element
                    if (d[i] > majority)
                        return i;
                }
                else
                    d.Add(i, 1);
            //No majority element
            throw new Exception("No majority element in array");
        }

        static bool CheckName(string tmpName, int i, int j)
        {
            bool isSame = false;
            if (i <= tmpName.Length / 2)
            {
                isSame = tmpName[i] == tmpName[j] ? true : false;
                if (isSame)
                {
                    CheckName(tmpName, i + 1, j - 1);
                }

            }
            return isSame;
        }


        public static void OperatorCalculation()
        {
            int x = 8, y = 4;
            //var a = 4 / 8;
            x -= y /= x * y;
            Console.WriteLine("x = {0} and y = {1}", x, y);
        }
        //private static T XmlToObject<T>(string xml)
        //{
        //    StringReader strReader = null;
        //    XmlTextReader xmlReader = null;
        //    object obj = null;
        //    try
        //    {
        //        strReader = new StringReader(xml);
        //        var serializer = new XmlSerializer(typeof(T));
        //        xmlReader = new XmlTextReader(strReader);
        //        obj = serializer.Deserialize(xmlReader);
        //    }
        //    catch (Exception ex)
        //    {

        //        //Handle Exception Code
        //    }
        //    finally
        //    {
        //        xmlReader?.Close();
        //        strReader?.Close();
        //    }
        //    return (T)obj;
        //}


        private static int AddNumber(int a, int b) => a + b;

    }


    public class AutoProperties
    {
        public int Id { get; set; } = 30;
    }
}
