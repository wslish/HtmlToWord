using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace HtmlToWord.Contract
{
    [ServiceContract(Namespace = "http://example.ExportToWord")]
    public interface IConvert
    {
        [OperationContract]
        [WebInvoke(UriTemplate = "/toword", RequestFormat = WebMessageFormat.Json, Method = "POST",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Wrapped )]
        [return: MessageParameter(Name = "Result")]
        CovertResult ToWord(string html);

        [OperationContract]
        [WebInvoke(UriTemplate = "/to-word-file", RequestFormat = WebMessageFormat.Json, Method = "POST",
            ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Stream ToWordFile(string html);
    }
}