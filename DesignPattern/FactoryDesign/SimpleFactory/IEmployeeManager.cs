using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.FactoryDesign.SimpleFactory
{
   public interface IEmployeeManager
   {
       decimal GetBonus();
       decimal GetPay();
   }
}
