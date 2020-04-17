using System;
using System.ServiceModel;

namespace WCFProject
{
    [ServiceContract]
    public interface IEightBall
    {
        // Задайте вопрос, получите ответ!
        [OperationContract]
        String ObtainAnswerToQuestion(String userQuestion);
    }
}
