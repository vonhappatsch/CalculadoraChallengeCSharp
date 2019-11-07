using System;
using System.Linq;
using System.Reflection;

namespace Codenation.Challenge
{
    public class FieldCalculator: ICalculateField
    {


        public decimal Addition(object obj)
        {
            decimal result = 0;

            var types = obj.GetType();
            var fields = types.GetRuntimeFields();

            foreach (var field in fields)
            {
                var value = field.GetValue(obj);

                if (value is decimal)
                {
                    object[] isAdd = field.GetCustomAttributes(typeof(AddAttribute), false);

                    foreach (Attribute attr in isAdd)
                    {
                        result += (decimal)value;
                    }
                }
            }

            return result;
        }



        public decimal Subtraction(object obj)
        {
            decimal result = 0;

            var types = obj.GetType();
            var fields = types.GetRuntimeFields();

            foreach (var field in fields)
            {
                var value = field.GetValue(obj);

                if (value is decimal)
                {
                    object[] isSubtract = field.GetCustomAttributes(typeof(SubtractAttribute), false);

                    foreach (Attribute attr in isSubtract)
                    {
                        result -= (decimal)value;
                    }
                }
            }
            return result;
        }


        public decimal Total(object obj)
        {
            decimal total = 0;
            var types = obj.GetType();
            var fields = types.GetRuntimeFields();

            foreach (var field in fields)
            {
                var value = field.GetValue(obj);

                object[] isAdd = field.GetCustomAttributes(typeof(AddAttribute), false);
                foreach (Attribute attr in isAdd)
                {
                    total += (decimal)value;
                }

                object[] isSubtract = field.GetCustomAttributes(typeof(SubtractAttribute), false);
                foreach (Attribute attr in isSubtract)
                {
                    total -= (decimal)value;
                }
            }

            return total;
        }
    }
}
