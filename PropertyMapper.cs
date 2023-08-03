using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment22
{
    public class PropertyMapper
    {
        public void MapProperties(object source, object destination)
        {
            Type sourceType = source.GetType();
            Type destinationType = destination.GetType();

            PropertyInfo[] sourceProperties = sourceType.GetProperties();
            PropertyInfo[] destinationProperties = destinationType.GetProperties();

            foreach (var destinationProperty in destinationProperties)
            {
                var sourceProperty = Array.Find(sourceProperties, prop => prop.Name == destinationProperty.Name && prop.PropertyType == destinationProperty.PropertyType);

                if (sourceProperty != null)
                {
                    var value = sourceProperty.GetValue(source);
                    destinationProperty.SetValue(destination, value);
                }
            }
        }
    }
}