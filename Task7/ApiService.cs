using System.Net.Http;

namespace AsyncApiDemo
{
    public class ApiService
    {
        HttpClient client = new HttpClient();
        public async Task<string> GetUsers()
        {
            return await client.GetStringAsync("https://jsonplaceholder.typicode.com/users");
        }
        public async Task<string> GetPosts()
        {
            return await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts");
        }

        public async Task<string> GetComments()
        {
            return await client.GetStringAsync("https://jsonplaceholder.typicode.com/comments");
        }
    }
}