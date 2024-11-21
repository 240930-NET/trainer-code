using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.SemanticKernel;
using Microsoft.SemanticKernel.ChatCompletion;
using Microsoft.SemanticKernel.Connectors.OpenAI;
using Microsoft.SemanticKernel.Plugins.Web.Bing;
//
// See https://github.com/dotnet/ai-samples for imformation on the tutorial I plagiarized
//

var config  = new ConfigurationBuilder().AddUserSecrets<Program>().Build();
var gptAPIKEY = config["apiKey"];
var bingAPIKEY = config["bingAPI"];

var builder = Kernel.CreateBuilder();
builder.Services.AddLogging(l => l.AddConsole());

Kernel kernel = builder
    .AddOpenAIChatCompletion("gpt-3.5-turbo", gptAPIKEY!)
    .Build();

kernel.ImportPluginFromType<Dates>();

#pragma warning disable SKEXP0050 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
kernel.ImportPluginFromObject(new Microsoft.SemanticKernel.Plugins.Web.WebSearchEnginePlugin(
    new BingConnector(bingAPIKEY!)
));
#pragma warning restore SKEXP0050 // Type is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.

var settings = new OpenAIPromptExecutionSettings() { ToolCallBehavior = ToolCallBehavior.AutoInvokeKernelFunctions};

var chatService = kernel.GetRequiredService<IChatCompletionService>();
ChatHistory chat = new();

while(true)
{
    Console.WriteLine("Q: ");

    var prompt = Console.ReadLine()!;

    chat.AddUserMessage(prompt);
    var r = await chatService.GetChatMessageContentAsync(chat, settings, kernel);
    chat.Add(r);
    Console.WriteLine(r);
    //Console.WriteLine(await kernel.InvokePromptAsync(prompt));
}

class Dates
{
    [KernelFunction]
    public DateOnly GetTodayDate()
    {
        return DateOnly.FromDateTime(DateTime.Now);
    }

    [KernelFunction]
    public DateOnly GetBirthDay(string name)
    {
        if(name.ToLower().Equals("kung"))
        {
            return DateOnly.Parse("10/14/1992");
        }

        return DateOnly.FromDateTime(DateTime.UnixEpoch);
    }
}

