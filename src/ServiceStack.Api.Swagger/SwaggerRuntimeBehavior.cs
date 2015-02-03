using System.Web;

namespace ServiceStack.Api.Swagger
{
  public class SwaggerRuntimeBehavior
  {
    public delegate string UseApplicationPathPrefixHandler();
    public delegate bool AllowFullApiHandler(HttpRequest httpRequest);
    public delegate bool ForceUseHttpsHandler(HttpRequest httpRequest);

    public UseApplicationPathPrefixHandler UseApplicationPathPrefix { get; set; }
    public AllowFullApiHandler AllowFullApi { get; set; }
    public ForceUseHttpsHandler ForceUseHttps { get; set; }
  }
}
