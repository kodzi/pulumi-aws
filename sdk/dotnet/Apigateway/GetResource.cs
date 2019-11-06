// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to get the id of a Resource in API Gateway. 
        /// To fetch the Resource, you must provide the REST API id as well as the full path.  
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/api_gateway_resource.html.markdown.
        /// </summary>
        public static Task<GetResourceResult> GetResource(GetResourceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourceResult>("aws:apigateway/getResource:getResource", args, options.WithVersion());
    }

    public sealed class GetResourceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The full path of the resource.  If no path is found, an error will be returned.
        /// </summary>
        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        /// <summary>
        /// The REST API id that owns the resource. If no REST API is found, an error will be returned.
        /// </summary>
        [Input("restApiId", required: true)]
        public Input<string> RestApiId { get; set; } = null!;

        public GetResourceArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetResourceResult
    {
        /// <summary>
        /// Set to the ID of the parent Resource.
        /// </summary>
        public readonly string ParentId;
        public readonly string Path;
        /// <summary>
        /// Set to the path relative to the parent Resource.
        /// </summary>
        public readonly string PathPart;
        public readonly string RestApiId;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetResourceResult(
            string parentId,
            string path,
            string pathPart,
            string restApiId,
            string id)
        {
            ParentId = parentId;
            Path = path;
            PathPart = pathPart;
            RestApiId = restApiId;
            Id = id;
        }
    }
}
