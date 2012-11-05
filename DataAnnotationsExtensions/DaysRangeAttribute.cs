using System;
using System.ComponentModel.DataAnnotations;
using DataAnnotationsExtensions.Resources;

namespace DataAnnotationsExtensions
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DaysRangeAttribute : RangeAttribute
    {
        public DaysRangeAttribute(int LessDays, int GreaterDays)
            : base(
        typeof(DateTime),
        DateTime.Now.AddDays(LessDays).ToString("yyyy-MM-dd 00:00:00.000"),            //The min should be yyyy-MM-dd 00:00:00.000
        DateTime.Now.AddDays(GreaterDays).ToString("yyyy-MM-dd 23:59:59.999")          //The max should be yyyy-MM-dd 23:59:59.999
    )
        { }
    }
}
