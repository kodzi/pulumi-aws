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
        /// Use this data source to get the id of a VPC Link in
        /// API Gateway. To fetch the VPC Link you must provide a name to match against. 
        /// As there is no unique name constraint on API Gateway VPC Links this data source will 
        /// error if there is more than one match.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/api_gateway_vpc_link.html.markdown.
        /// </summary>
        public static Task<GetVpcLinkResult> GetVpcLink(GetVpcLinkArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetVpcLinkResult>("aws:apigateway/getVpcLink:getVpcLink", args, options.WithVersion());
    }

    public sealed class GetVpcLinkArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Gateway VPC Link to look up. If no API Gateway VPC Link is found with this name, an error will be returned. 
        /// If multiple API Gateway VPC Links are found with this name, an error will be returned.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public GetVpcLinkArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetVpcLinkResult
    {
        /// <summary>
        /// Set to the ID of the found API Gateway VPC Link.
        /// </summary>
        public readonly string Id;
        public readonly string Name;

        [OutputConstructor]
        private GetVpcLinkResult(
            string id,
            string name)
        {
            Id = id;
            Name = name;
        }
    }
}
