using System.ComponentModel;

namespace SampleApi.Models.Enums
{
    /// <summary>
    /// جنسیت
    /// </summary>
    public enum Gender
    {
        [Description("تعریف نشده")]
        None = 0,

        [Description("مرد")]
        Man,

        [Description("زن")]
        Woman
    }
}