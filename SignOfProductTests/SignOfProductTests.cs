using SignOfProduct;
namespace SignOfProductTests
{
    public class SignOfProductTests
    {
        [Theory]
        [InlineData(5,6,8,'+')]
        [InlineData(9, 21, 33, '+')]
        [InlineData(1, 17, 41, '+')]
        public void GetSignOfProduct_WithCheckingtheSigh_ShouldReturnPositiveSign(double a, double b, double c, char expectedSign)
        {
            char result = SignChecker.GetSignOfProduct(a, b, c);
            Assert.Equal('+', result);
        }
        [Theory]
        [InlineData(-6, 16, 8, '-')]
        [InlineData(-3, 1, 33, '-')]
        [InlineData(-5, 4, 41, '-')]
        public void GetSignOfProduct_WithOneNumberNegative_ShouldReturnNegativeSign(double a, double b, double c, char expectedSign)
        {
            char result = SignChecker.GetSignOfProduct(a, b, c);
            Assert.Equal('-', result);
        }
        [Theory]
        [InlineData(-6, -40, 8, '-')]
        [InlineData(-3, -10, 33, '-')]
        [InlineData(-5, -34, 41, '-')]
        public void GetSignOfProduct_WithTwoNumbersNegative_ShouldReturnNegativeSign(double a, double b, double c, char expectedSign)
        {
            char result = SignChecker.GetSignOfProduct(a, b, c);
            Assert.Equal('+', result);
        }
        [Theory]
        [InlineData(0, 58, 21, '0')]
        [InlineData(0, 8, 16, '0')]
        [InlineData(0, 3, 21, '0')]
        public void GetSignOfProduct_WithOneNumberZero_ShouldReturnZero(double a, double b, double c, char expectedSign)
        {
            char result = SignChecker.GetSignOfProduct(a, b, c);
            Assert.Equal('0', result);
        }
    }
}