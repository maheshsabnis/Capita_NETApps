// See https://aka.ms/new-console-template for more information
using CS_RESTClient;
using System.Net.Http.Json;
using System.Runtime.InteropServices.Marshalling;
using System.Text.Json;

Console.WriteLine("DEMO REST CLIENT");
Console.WriteLine("Press a Keu when REST API Is Ready");
Console.ReadLine();
string y = string.Empty;
do
{

	Console.WriteLine("1. Press 1 to Get All Data");
	Console.WriteLine("2. Press 2 to Post Data Data");

	int c = Convert.ToInt32(Console.ReadLine());
	//  https://localhost:7298
	HttpClient client = new HttpClient();
	client.BaseAddress = new Uri(" https://localhost:7298/api/Department");

	switch (c)
	{
		case 1:
			// Get the Data in JSOn Form
			var departments = await client.GetFromJsonAsync<ResponseObject<Department>>("https://localhost:7298/api/Department/get");
			Console.WriteLine($"Received Data : {JsonSerializer.Serialize(departments)}");
			break;
		case 2:
			var dept = new Department()
			{
				DeptNo = 60,
				DeptName = "Dept-60",
				Location = "Mumbai",
				Capacity = 2000
			};
			 
			var result = await client.PostAsJsonAsync<Department>("https://localhost:7298/api/Department/post",dept);
			if (result.IsSuccessStatusCode)
			{
				Console.WriteLine(result.Content.ReadAsStringAsync());
			}
			break;
		default:
			Console.WriteLine("Done Dana Done");
			break;
	}
	Console.WriteLine("Press y to Continue");
	y = Console.ReadLine();
	Console.Clear();
} while (y == "y");






Console.ReadLine();
