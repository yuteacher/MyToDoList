﻿using MyToDo.Shared.Contact;
using MyToDo.Shared.Dtos;
using MyToDo.Shared.Parameters;

namespace MyToDoList.Service
{
    public class ToDoService : BaseService<ToDoDto>, IToDoService
    {
        private readonly HttpRestClient client;

        public ToDoService(HttpRestClient client) : base(client, "ToDo")
        {
            this.client = client;
        }

        public async Task<ApiResponse<PagedList<ToDoDto>>> GetAllFilterAsync(ToDoParameter parameter)
        {
            BaseRequest request = new BaseRequest();
            request.Method = RestSharp.Method.GET;
            request.Route = $"api/ToDo/GetAll?pageIndex={parameter.PageIndex}" +
                $"&pageSize={parameter.PageSize}" +
                $"&search={parameter.Search}" +
                $"&status={parameter.Status}";
            return await client.ExecuteAsync<PagedList<ToDoDto>>(request);
        }

        public async Task<ApiResponse<SummaryDto>> SummaryAsync()
        {
            BaseRequest request = new BaseRequest();
            request.Route = "api/ToDo/Summary";
            return await client.ExecuteAsync<SummaryDto>(request);
        }
    }
}
