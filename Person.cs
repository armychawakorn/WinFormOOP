using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormOOP
{
    public class Person
    {
        private string _Name { get; set; }
        private int Birth_Year { get; set; }
        private float GPA { get; set; }

        public Person SetData(EDataType type, object value)
        {
            try
            {
                switch (type)
                {
                    case EDataType.Name:
                        _Name = value.ToString();
                        break;
                    case EDataType.BirthYear:
                        Birth_Year = int.Parse(value.ToString());
                        break;
                    case EDataType.GPA:
                        GPA = float.Parse(value.ToString());
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                return null;
            }
            return this;
        }
        public Dictionary<string, string> GetData()
        {
            int Age = ((DateTime.Now.Year + 543) - Birth_Year);
            return new Dictionary<string, string>()
            {
                { "Name", this._Name },
                { "BirthYear", this.Birth_Year.ToString() },
                { "Age", Age.ToString() },
                { "GPA", this.GPA.ToString() },
            };
        }
    }
    public enum EDataType
    {
        Name,
        BirthYear,
        GPA
    }
}
