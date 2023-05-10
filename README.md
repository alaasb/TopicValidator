# TopicValidator - README

This project implements a topic model validator in .NET Core that validates objects based on specific rules. The solution adheres to the principles of software development, such as SOLID (Single Responsibility Principle), by employing separation of concerns and maintainable code practices.
Rules:
1. If topic == A, then name will be “a”and description will be more than 10 and less than 100 chars.
2. If topic == B, then name will be “x” and description will be less than 40 chars.

## Design Approach

The design approach follows a modular and extensible structure, separating the validation logic into individual classes. Each validation rule is encapsulated within its own validator class, promoting code clarity, reusability, and testability. The main `TopicValidation` class acts as a coordinator, using a factory pattern to instantiate the appropriate validator based on the provided topic value.

## Implementation

The solution is implemented in C# using .NET Core. The core components of the implementation include:

- `TopicModel` class: Represents the object to be validated, consisting of properties such as `Topic`, `Name`, and `Description`.

- `IValidator<T>` interface: Defines the contract for topic validators, ensuring consistent validation behavior across different validation rules.

- `TopicAValidator` and `TopicBValidator` classes: Implement specific validation rules for topic A and topic B, respectively. They validate the `TopicModel` object based on the defined rules.

- `TopicValidation` class: Acts as a factory and coordinator, instantiating the appropriate validator based on the topic value. It delegates the validation to the specific validator instance.

## Unit Tests

The solution includes unit tests using the NUnit testing framework to verify the correctness of the validator implementation. The unit tests cover various scenarios, ensuring that the validation rules are correctly applied and error messages are returned when the object fails validation.

The unit tests are designed to cover:

- Successful validation scenarios for both topic A and topic B.

- Invalid name scenarios for both topics, verifying that the correct error message is returned.

- Invalid description scenarios for both topics, ensuring the appropriate error message is returned.

- Validation of the factory behavior when an invalid topic value is provided, ensuring that an `ArgumentException` is thrown.

The unit tests follow the Arrange-Act-Assert pattern, providing clear separation between setup, execution, and verification stages. They also test the edge cases and boundary conditions to ensure the correctness and robustness of the validation logic.

To run the unit tests, NUnit testing framework is required. Execute the tests using your preferred test runner or IDE that supports NUnit.

## Conclusion

The implemented topic validator demonstrates the application of software development principles, particularly SOLID, by employing modular design, separation of concerns, and test-driven development. The solution provides extensibility and maintainability, allowing easy addition of new validation rules or modification of existing ones.

By following a disciplined software development approach, the codebase remains clean, reusable, and easy to maintain, facilitating collaboration and future enhancements.

## Feedback and Contributions

Your feedback and contributions to this project are highly appreciated. Feel free to open issues, suggest improvements, or submit pull requests. Together, we can enhance the solution and make it even more valuable.

Thank you for your interest and involvement in this project!
