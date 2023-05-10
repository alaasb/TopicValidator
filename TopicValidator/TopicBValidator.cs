using System.ComponentModel.DataAnnotations;

namespace TopicValidator
{
    public class TopicBValidator : IValidator<TopicModel>
    {
        public ValidationResult Validate(TopicModel topic)
        {
            if (topic.Name != "x")
            {
                return new ValidationResult("Name must be 'x' when topic is 'B'.");
            }

            if (topic.Description.Length >= 40)
            {
                return new ValidationResult("Description must be less than 40 characters when topic is 'B'.");
            }

            return ValidationResult.Success;
        }
    }
}
