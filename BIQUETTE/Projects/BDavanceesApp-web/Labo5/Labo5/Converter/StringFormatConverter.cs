using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5.Converter
{
    class StringFormatConverter:IvalueConverter
    {
        public object Convert(object value,Type targetType,object parameter,string language)
        {
            if(value == null)
            {
                return null;
            }

            if(parameter == null)
            {
                return null;
            }
            return String.Format((String)parameter, value);

        }

        public object ConverterBack(object value,Type targetType,object parameter,string language)
        {
            return value;
        }
    }
}
