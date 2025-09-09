using ModelContextProtocol.Server;
using System.ComponentModel;

namespace HotelApiProject.Mcp;

[McpServerToolType]
public static class HelloWorldTool
{
    [McpServerTool, Description("Verilen kelimenin uzunluğunu ölçüyoruz.")]
   public static string CountLetters(string message)
    {
        return $"verlen kelimenin uzunluğu:{message.Length}";
    }



}
