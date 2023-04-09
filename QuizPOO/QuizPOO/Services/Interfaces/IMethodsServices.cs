namespace QuizPOO.Services.Interfaces
{
    public interface IMethodsServices
    {
        string ShowMenu(List<Models.Quiz> quiz);
        void SetWinxs(int? pont);
    }
}