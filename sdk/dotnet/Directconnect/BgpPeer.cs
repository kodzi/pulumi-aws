// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DirectConnect
{
    /// <summary>
    /// Provides a Direct Connect BGP peer resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/dx_bgp_peer.html.markdown.
    /// </summary>
    public partial class BgpPeer : Pulumi.CustomResource
    {
        /// <summary>
        /// The address family for the BGP peer. `ipv4 ` or `ipv6`.
        /// </summary>
        [Output("addressFamily")]
        public Output<string> AddressFamily { get; private set; } = null!;

        /// <summary>
        /// The IPv4 CIDR address to use to send traffic to Amazon.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Output("amazonAddress")]
        public Output<string> AmazonAddress { get; private set; } = null!;

        /// <summary>
        /// The Direct Connect endpoint on which the BGP peer terminates.
        /// </summary>
        [Output("awsDevice")]
        public Output<string> AwsDevice { get; private set; } = null!;

        /// <summary>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </summary>
        [Output("bgpAsn")]
        public Output<int> BgpAsn { get; private set; } = null!;

        /// <summary>
        /// The authentication key for BGP configuration.
        /// </summary>
        [Output("bgpAuthKey")]
        public Output<string> BgpAuthKey { get; private set; } = null!;

        /// <summary>
        /// The ID of the BGP peer.
        /// </summary>
        [Output("bgpPeerId")]
        public Output<string> BgpPeerId { get; private set; } = null!;

        /// <summary>
        /// The Up/Down state of the BGP peer.
        /// </summary>
        [Output("bgpStatus")]
        public Output<string> BgpStatus { get; private set; } = null!;

        /// <summary>
        /// The IPv4 CIDR destination address to which Amazon should send traffic.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Output("customerAddress")]
        public Output<string> CustomerAddress { get; private set; } = null!;

        /// <summary>
        /// The ID of the Direct Connect virtual interface on which to create the BGP peer.
        /// </summary>
        [Output("virtualInterfaceId")]
        public Output<string> VirtualInterfaceId { get; private set; } = null!;


        /// <summary>
        /// Create a BgpPeer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BgpPeer(string name, BgpPeerArgs args, CustomResourceOptions? options = null)
            : base("aws:directconnect/bgpPeer:BgpPeer", name, args, MakeResourceOptions(options, ""))
        {
        }

        private BgpPeer(string name, Input<string> id, BgpPeerState? state = null, CustomResourceOptions? options = null)
            : base("aws:directconnect/bgpPeer:BgpPeer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BgpPeer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BgpPeer Get(string name, Input<string> id, BgpPeerState? state = null, CustomResourceOptions? options = null)
        {
            return new BgpPeer(name, id, state, options);
        }
    }

    public sealed class BgpPeerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The address family for the BGP peer. `ipv4 ` or `ipv6`.
        /// </summary>
        [Input("addressFamily", required: true)]
        public Input<string> AddressFamily { get; set; } = null!;

        /// <summary>
        /// The IPv4 CIDR address to use to send traffic to Amazon.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Input("amazonAddress")]
        public Input<string>? AmazonAddress { get; set; }

        /// <summary>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </summary>
        [Input("bgpAsn", required: true)]
        public Input<int> BgpAsn { get; set; } = null!;

        /// <summary>
        /// The authentication key for BGP configuration.
        /// </summary>
        [Input("bgpAuthKey")]
        public Input<string>? BgpAuthKey { get; set; }

        /// <summary>
        /// The IPv4 CIDR destination address to which Amazon should send traffic.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Input("customerAddress")]
        public Input<string>? CustomerAddress { get; set; }

        /// <summary>
        /// The ID of the Direct Connect virtual interface on which to create the BGP peer.
        /// </summary>
        [Input("virtualInterfaceId", required: true)]
        public Input<string> VirtualInterfaceId { get; set; } = null!;

        public BgpPeerArgs()
        {
        }
    }

    public sealed class BgpPeerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The address family for the BGP peer. `ipv4 ` or `ipv6`.
        /// </summary>
        [Input("addressFamily")]
        public Input<string>? AddressFamily { get; set; }

        /// <summary>
        /// The IPv4 CIDR address to use to send traffic to Amazon.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Input("amazonAddress")]
        public Input<string>? AmazonAddress { get; set; }

        /// <summary>
        /// The Direct Connect endpoint on which the BGP peer terminates.
        /// </summary>
        [Input("awsDevice")]
        public Input<string>? AwsDevice { get; set; }

        /// <summary>
        /// The autonomous system (AS) number for Border Gateway Protocol (BGP) configuration.
        /// </summary>
        [Input("bgpAsn")]
        public Input<int>? BgpAsn { get; set; }

        /// <summary>
        /// The authentication key for BGP configuration.
        /// </summary>
        [Input("bgpAuthKey")]
        public Input<string>? BgpAuthKey { get; set; }

        /// <summary>
        /// The ID of the BGP peer.
        /// </summary>
        [Input("bgpPeerId")]
        public Input<string>? BgpPeerId { get; set; }

        /// <summary>
        /// The Up/Down state of the BGP peer.
        /// </summary>
        [Input("bgpStatus")]
        public Input<string>? BgpStatus { get; set; }

        /// <summary>
        /// The IPv4 CIDR destination address to which Amazon should send traffic.
        /// Required for IPv4 BGP peers on public virtual interfaces.
        /// </summary>
        [Input("customerAddress")]
        public Input<string>? CustomerAddress { get; set; }

        /// <summary>
        /// The ID of the Direct Connect virtual interface on which to create the BGP peer.
        /// </summary>
        [Input("virtualInterfaceId")]
        public Input<string>? VirtualInterfaceId { get; set; }

        public BgpPeerState()
        {
        }
    }
}
