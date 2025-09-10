using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using MoqTesting;

namespace UnitTestProjectMoq
{
    [TestClass]
    public class AuthServiceTests
    {
        [TestMethod]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            // Arrange
            Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository
                .Setup(repo => repo.ValidatePassword("user1", "pass123"))
                .Returns(true);

            AuthService authService = new AuthService(mockUserRepository.Object);

            // Act
            bool result = authService.Login("user1", "pass123");

            // Assert
            Assert.IsTrue(result);
            mockUserRepository.Verify(repo => repo.ValidatePassword("user1", "pass123"), Times.Once);
        }

        [TestMethod]
        public void Login_InvalidCredentials_ReturnsFalse()
        {
            // Arrange
            Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            mockUserRepository
                .Setup(repo => repo.ValidatePassword("user1", "wrongpass"))
                .Returns(false);

            AuthService authService = new AuthService(mockUserRepository.Object);

            // Act
            bool result = authService.Login("user1", "wrongpass");

            // Assert
            Assert.IsFalse(result);
            mockUserRepository.Verify(repo => repo.ValidatePassword("user1", "wrongpass"), Times.Once);
        }

        [TestMethod]
        public void Login_EmptyCredentials_ReturnsFalse()
        {
            // Arrange
            Mock<IUserRepository> mockUserRepository = new Mock<IUserRepository>();
            AuthService authService = new AuthService(mockUserRepository.Object);

            // Act
            bool result1 = authService.Login("", "pass123");
            bool result2 = authService.Login("user1", "");
            bool result3 = authService.Login("", "");

            // Assert
            Assert.IsFalse(result1);
            Assert.IsFalse(result2);
            Assert.IsFalse(result3);
            mockUserRepository.Verify(repo => repo.ValidatePassword(It.IsAny<string>(), It.IsAny<string>()), Times.Never);
        }
        /// <summary>
        /// Setup - настраивает поведение mock-объекта
        /// Returns - определяет, что должен возвращать метод
        /// Verify - проверяет, был ли метод вызван и с какими параметрами
        /// </summary>
    }
}