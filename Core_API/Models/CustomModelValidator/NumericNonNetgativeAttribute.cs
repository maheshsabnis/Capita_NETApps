using System.ComponentModel.DataAnnotations;

namespace Core_API.Models.CustomModelValidator
{
    public class NumericNonNetgativeAttribute : ValidationAttribute
    {
        /// <summary>
        /// The 'Value' is the value set for the Property in Model class where this Validation Attribute class is applied
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public override bool IsValid(object? value)
        {
            if(Convert.ToInt32(value) < 0) return false;
            return true;
        }
    }
}
