using MyToDo.Shared.Contact;
using MyToDo.Shared.Dtos;

namespace MyToDoList.Service
{
    public interface ILoginService
    {
        Task<ApiResponse> Login(UserDto user);

        Task<ApiResponse> Resgiter(UserDto user);
    }
}
