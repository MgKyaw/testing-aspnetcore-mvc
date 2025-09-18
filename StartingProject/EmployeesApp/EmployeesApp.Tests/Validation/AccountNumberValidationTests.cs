using EmployeesApp.Validation;

namespace EmployeesApp.Tests.Validation;

public class AccountNumberValidationTests
{
    private readonly AccountNumberValidation _validation;

    public AccountNumberValidationTests() => _validation = new AccountNumberValidation();

    [Fact]
    public void IsValid_ValidAccountNumber_ReturnsTrue()
        => Assert.True(_validation.IsValid("123-4543234576-23"));

    [Fact]
    public void IsValid_AccountNumberFirstPartWrong_ReturnsFalse()
    => Assert.False(_validation.IsValid("1234-3454565676-23"));
}