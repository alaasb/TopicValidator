using System.ComponentModel.DataAnnotations;

namespace TopicValidator
{
    public interface IValidator<T>
    {
        ValidationResult Validate(T obj);
    }
}
