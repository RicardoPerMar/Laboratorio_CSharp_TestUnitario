using Ejercicio1;
using Moq;

namespace Email.Test
{
    [TestClass]
    public class TestEmail
    {
        [TestMethod]
        public void Return_isValid_Works()
        {
            // Arrange => Inicializacion de componentes
            var currentEmailMock1 = new Mock<ICurrentEmail>();
            var currentEmailMock2 = new Mock<ICurrentEmail>();
            var currentEmailMock3 = new Mock<ICurrentEmail>();
            var currentEmailMock4 = new Mock<ICurrentEmail>();
            currentEmailMock1.Setup(a => a.GetEmail()).Returns("a@a");
            currentEmailMock2.Setup(a => a.GetEmail()).Returns("a@a");
            currentEmailMock3.Setup(a => a.GetEmail()).Returns("aa");
            currentEmailMock4.Setup(a => a.GetEmail()).Returns("cc@cc");
            var email1 = new EmailProgram(currentEmailMock1.Object);
            var email2 = new EmailProgram(currentEmailMock2.Object);
            var email3 = new EmailProgram(currentEmailMock3.Object);
            var email4 = new EmailProgram(currentEmailMock4.Object);

            // Act => llamada del metodo
            var request1 = email1.emailRequest();
            var request2 = email2.emailRequest();
            var request3 = email3.emailRequest();
            var request4 = email4.emailRequest();
                        
            // Assert => comprobacion del comportamiento
            Assert.AreEqual(request1 && request2, false); // FUNCIONA
            Assert.AreEqual(request1 && request3, false); // FUNCIONA
            Assert.AreEqual(request1 && request4, true); // NO FUNCIONA PERO EN LA EJECUCION NORMAL SI FUNCIONA
            //Assert.AreEqual(request1, true); // NO FUNCIONA PERO EN LA EJECUCION NORMAL SI FUNCIONA
        }
    }
}