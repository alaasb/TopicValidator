using System.ComponentModel.DataAnnotations;

namespace TopicValidator
{
    public class TopicAValidator : IValidator<TopicModel>
    {
        public ValidationResult Validate(TopicModel topic)
        {
            if (topic.Name != "a")
            {
                return new ValidationResult("Name must be 'a' when topic is 'A'.");
            }

            if (topic.Description.Length <= 10 || topic.Description.Length >= 100)
            {
                return new ValidationResult("Description must be between 10 and 100 characters when topic is 'A'.");
            }

            return ValidationResult.Success;
        }
    }
}
