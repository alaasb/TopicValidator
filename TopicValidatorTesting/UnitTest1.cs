using System.ComponentModel.DataAnnotations;
using TopicValidator;

namespace TopicValidatorTesting
{
    [TestFixture]
    public class MyTopicValidatorTests
    {
        [Test]
        public void Validate_WithTopicA_ValidatesSuccessfully()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "A",
                Name = "a",
                Description = "Valid description"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result, Is.EqualTo(ValidationResult.Success));
        }

        [Test]
        public void Validate_WithTopicA_InvalidName_ReturnsError()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "A",
                Name = "b",
                Description = "Valid description"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result.ErrorMessage, Is.EqualTo("Name must be 'a' when topic is 'A'."));
        }

        [Test]
        public void Validate_WithTopicA_InvalidDescription_ReturnsError()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "A",
                Name = "a",
                Description = "Invalid"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result.ErrorMessage, Is.EqualTo("Description must be between 10 and 100 characters when topic is 'A'."));
        }

        [Test]
        public void Validate_WithTopicB_ValidatesSuccessfully()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "B",
                Name = "x",
                Description = "Valid description"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result, Is.EqualTo(ValidationResult.Success));
        }

        [Test]
        public void Validate_WithTopicB_InvalidName_ReturnsError()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "B",
                Name = "y",
                Description = "Valid description"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result.ErrorMessage, Is.EqualTo("Name must be 'x' when topic is 'B'."));
        }

        [Test]
        public void Validate_WithTopicB_InvalidDescription_ReturnsError()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "B",
                Name = "x",
                Description = "Invalid description that exceeds the maximum length"
            };

            TopicValidation validator = new TopicValidation(obj.Topic);

            // Act
            ValidationResult result = validator.Validate(obj);

            // Assert
            Assert.That(result.ErrorMessage, Is.EqualTo("Description must be less than 40 characters when topic is 'B'."));
        }

        [Test]
        public void Validate_WithInvalidTopic_ThrowsArgumentException()
        {
            // Arrange
            TopicModel obj = new TopicModel
            {
                Topic = "C",
                Name = "a",
                Description = "Valid description"
            };

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new TopicValidation(obj.Topic));

        }
    }
}