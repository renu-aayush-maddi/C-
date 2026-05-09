namespace AsyncApiDemo
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            ApiService service = new ApiService();

            try
            {
                Console.WriteLine("Fetching data...\n");

                Task<string> usersTask = service.GetUsers();
                Task<string> postsTask = service.GetPosts();
                Task<string> commentsTask = service.GetComments();

                await Task.WhenAll(usersTask,postsTask,commentsTask);

                Console.WriteLine("Users Data Length: " + usersTask.Result.Length);
                Console.WriteLine("Posts Data Length: " + postsTask.Result.Length);
                Console.WriteLine("Comments Data Length: " + commentsTask.Result.Length);
                Console.WriteLine("\nAll API calls completed");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}