using InyoPoolsRest.API.Application.Categories;

namespace InyoPoolsRest.API.Application.Aithentication
{
    public interface IChangePasswordService
    {
        Task<AddCategory.Response> ChangePassword(ChangePassword.Request request);
    }
    public class ChangePasswordService : IChangePasswordService
    {
        public Task<AddCategory.Response> ChangePassword(ChangePassword.Request request)
        {
            throw new NotImplementedException();
        }
    }
}
