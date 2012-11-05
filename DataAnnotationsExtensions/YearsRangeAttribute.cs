using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions.Resources;

namespace DataAnnotationsExtensions
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class YearsRangeAttribute : RangeAttribute
    {
        public YearsRangeAttribute(int LessYears, int GreaterYears)
            : base(
        typeof(DateTime),
        DateTime.Now.AddYears(LessYears).ToString("yyyy-01-01 00:00:00.000"),      //The min should be yyyy-01-01 00:00:00.000
        DateTime.Now.AddYears(GreaterYears).ToString("yyyy-12-31 23:59:59.999")    //The max should be yyyy-12-31 23:59:59.999
    )
        { }
    }
}
