using SampleApi.Models.Enums;

namespace SampleApi.Models.Requests
{
    public class AddPerson
    {
        /// <summary>
        /// نام
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// نام خانوادگی
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// سن
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// جنسیت
        /// </summary>
        public Gender Gender { get; set; }
    }
}