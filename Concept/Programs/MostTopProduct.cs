using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpConcept.Programs
{
    class MostTopProduct
    {
        public void topProduct()
        {
            int t = Convert.ToInt32(Console.ReadLine());
            List<KeyValuePair<string, int>> occurence = new List<KeyValuePair<string, int>>();
            Dictionary<string, int> productOrderd = new Dictionary<string, int>();


            for (int c = 0; c < t; c++)
            {
                int tc = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < tc; i++)
                {
                    string[] tokens = Console.ReadLine().Split();
                    if (tokens[0] == "top")
                    {
                        occurence.Add(new KeyValuePair<string, int>("top", 0));
                        //occurence.Add("top", 0);
                    }
                    else
                    {
                        occurence.Add(new KeyValuePair<string, int>(tokens[0], int.Parse(tokens[1])));
                        //occurence.Add(tokens[0], int.Parse(tokens[1]));
                    }
                }
            }
            ///

            foreach (var item in occurence)
            {
                if (item.Key != "top")
                {
                    if (!productOrderd.ContainsKey(item.Key))
                    {
                        productOrderd.Add(item.Key, item.Value);
                    }
                    else
                    {
                        productOrderd[item.Key]++;
                    }
                }
                else
                {
                    var orderedByOcc = productOrderd.OrderByDescending(o => o.Value);
                    var dupOcc = orderedByOcc.GroupBy(x => x.Value).Where(w => w.Count() > 1).FirstOrDefault();
                    var singleOcc = orderedByOcc.GroupBy(x => x.Value).Where(w => w.Count() == 1).FirstOrDefault();
                    Dictionary<string, int> result = new Dictionary<string, int>();

                    if (dupOcc != null)
                    {
                        int value = 0;
                        string key = "";
                        foreach (var occ in dupOcc.OrderBy(o => o.Key))
                        {
                            value = occ.Value;
                            if (key != "")
                            {
                                key += " " + occ.Key;
                            }
                            else
                            {
                                key = occ.Key;
                            }
                        }
                        if (key != "")
                        {
                            result.Add(key, value);
                        }
                    }
                    if (singleOcc != null)
                    {
                        foreach (var occ in singleOcc)
                        {
                            result.Add(occ.Key, occ.Value);
                        }
                    }
                    foreach (var res in result.OrderByDescending(o => o.Value))
                    {
                        Console.WriteLine(res.Key);
                    }
                }
            }
        }
    }
}
