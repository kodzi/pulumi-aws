// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.Ec2ClientVpn
{
    /// <summary>
    /// Provides network associations for AWS Client VPN endpoints. For more information on usage, please see the 
    /// [AWS Client VPN Administrator's Guide](https://docs.aws.amazon.com/vpn/latest/clientvpn-admin/what-is.html).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/ec2_client_vpn_network_association.html.markdown.
    /// </summary>
    public partial class NetworkAssociation : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the Client VPN endpoint.
        /// </summary>
        [Output("clientVpnEndpointId")]
        public Output<string> ClientVpnEndpointId { get; private set; } = null!;

        /// <summary>
        /// The IDs of the security groups applied to the target network association.
        /// </summary>
        [Output("securityGroups")]
        public Output<ImmutableArray<string>> SecurityGroups { get; private set; } = null!;

        /// <summary>
        /// The current state of the target network association.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The ID of the subnet to associate with the Client VPN endpoint.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// The ID of the VPC in which the target network (subnet) is located. 
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkAssociation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkAssociation(string name, NetworkAssociationArgs args, CustomResourceOptions? options = null)
            : base("aws:ec2clientvpn/networkAssociation:NetworkAssociation", name, args, MakeResourceOptions(options, ""))
        {
        }

        private NetworkAssociation(string name, Input<string> id, NetworkAssociationState? state = null, CustomResourceOptions? options = null)
            : base("aws:ec2clientvpn/networkAssociation:NetworkAssociation", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkAssociation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkAssociation Get(string name, Input<string> id, NetworkAssociationState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkAssociation(name, id, state, options);
        }
    }

    public sealed class NetworkAssociationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Client VPN endpoint.
        /// </summary>
        [Input("clientVpnEndpointId", required: true)]
        public Input<string> ClientVpnEndpointId { get; set; } = null!;

        /// <summary>
        /// The ID of the subnet to associate with the Client VPN endpoint.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        public NetworkAssociationArgs()
        {
        }
    }

    public sealed class NetworkAssociationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Client VPN endpoint.
        /// </summary>
        [Input("clientVpnEndpointId")]
        public Input<string>? ClientVpnEndpointId { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// The IDs of the security groups applied to the target network association.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// The current state of the target network association.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        /// <summary>
        /// The ID of the subnet to associate with the Client VPN endpoint.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// The ID of the VPC in which the target network (subnet) is located. 
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public NetworkAssociationState()
        {
        }
    }
}
