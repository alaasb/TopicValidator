using System.ComponentModel.DataAnnotations;

namespace TopicValidator
{
    public class TopicValidation
    {
        private readonly IValidator<TopicModel> validator;

        public TopicValidation(string topic)
        {
            if (topic == "A")
            {
                validator = new TopicAValidator();
            }
            else if (topic == "B")
            {
                validator = new TopicBValidator();
            }
            else
            {
                throw new ArgumentException("Invalid topic value.");
            }
        }

        public ValidationResult Validate(TopicModel topicModel)
        {
            return validator.Validate(topicModel);
        }
    }
}
