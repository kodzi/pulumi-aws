// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2TransitGateway
{
    public static partial class Invokes
    {
        /// <summary>
        /// Get information on an EC2 Transit Gateway Route Table.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/ec2_transit_gateway_route_table.html.markdown.
        /// </summary>
        public static Task<GetRouteTableResult> GetRouteTable(GetRouteTableArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRouteTableResult>("aws:ec2transitgateway/getRouteTable:getRouteTable", args, options.WithVersion());
    }

    public sealed class GetRouteTableArgs : Pulumi.ResourceArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetRouteTableFiltersArgs>? _filters;

        /// <summary>
        /// One or more configuration blocks containing name-values filters. Detailed below.
        /// </summary>
        public InputList<Inputs.GetRouteTableFiltersArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetRouteTableFiltersArgs>());
            set => _filters = value;
        }

        /// <summary>
        /// Identifier of the EC2 Transit Gateway Route Table.
        /// </summary>
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public GetRouteTableArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetRouteTableResult
    {
        /// <summary>
        /// Boolean whether this is the default association route table for the EC2 Transit Gateway
        /// </summary>
        public readonly bool DefaultAssociationRouteTable;
        /// <summary>
        /// Boolean whether this is the default propagation route table for the EC2 Transit Gateway
        /// </summary>
        public readonly bool DefaultPropagationRouteTable;
        public readonly ImmutableArray<Outputs.GetRouteTableFiltersResult> Filters;
        /// <summary>
        /// EC2 Transit Gateway Route Table identifier
        /// </summary>
        public readonly string? Id;
        /// <summary>
        /// Key-value tags for the EC2 Transit Gateway Route Table
        /// </summary>
        public readonly ImmutableDictionary<string, object> Tags;
        /// <summary>
        /// EC2 Transit Gateway identifier
        /// </summary>
        public readonly string TransitGatewayId;

        [OutputConstructor]
        private GetRouteTableResult(
            bool defaultAssociationRouteTable,
            bool defaultPropagationRouteTable,
            ImmutableArray<Outputs.GetRouteTableFiltersResult> filters,
            string? id,
            ImmutableDictionary<string, object> tags,
            string transitGatewayId)
        {
            DefaultAssociationRouteTable = defaultAssociationRouteTable;
            DefaultPropagationRouteTable = defaultPropagationRouteTable;
            Filters = filters;
            Id = id;
            Tags = tags;
            TransitGatewayId = transitGatewayId;
        }
    }

    namespace Inputs
    {

    public sealed class GetRouteTableFiltersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the filter.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("values", required: true)]
        private InputList<string>? _values;

        /// <summary>
        /// List of one or more values for the filter.
        /// </summary>
        public InputList<string> Values
        {
            get => _values ?? (_values = new InputList<string>());
            set => _values = value;
        }

        public GetRouteTableFiltersArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetRouteTableFiltersResult
    {
        /// <summary>
        /// Name of the filter.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// List of one or more values for the filter.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private GetRouteTableFiltersResult(
            string name,
            ImmutableArray<string> values)
        {
            Name = name;
            Values = values;
        }
    }
    }
}
