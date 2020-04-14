using System;
using System.ServiceModel;

namespace WCFProject
{
    [ServiceContract(Namespace = "http://MyCompany.com")]
    public interface IEightBall
    {
        // Задайте вопрос, получите ответ!
        [OperationContract]
        String ObtainAnswerToQuestion(String userQuestion);
    }
}
