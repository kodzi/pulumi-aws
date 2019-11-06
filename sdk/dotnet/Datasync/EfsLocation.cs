// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DataSync
{
    /// <summary>
    /// Manages an AWS DataSync EFS Location.
    /// 
    /// &gt; **NOTE:** The EFS File System must have a mounted EFS Mount Target before creating this resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/datasync_location_efs.html.markdown.
    /// </summary>
    public partial class EfsLocation : Pulumi.CustomResource
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Location.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Configuration block containing EC2 configurations for connecting to the EFS File System.
        /// </summary>
        [Output("ec2Config")]
        public Output<Outputs.EfsLocationEc2Config> Ec2Config { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of EFS File System.
        /// </summary>
        [Output("efsFileSystemArn")]
        public Output<string> EfsFileSystemArn { get; private set; } = null!;

        /// <summary>
        /// Subdirectory to perform actions as source or destination. Default `/`.
        /// </summary>
        [Output("subdirectory")]
        public Output<string?> Subdirectory { get; private set; } = null!;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Location.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;

        [Output("uri")]
        public Output<string> Uri { get; private set; } = null!;


        /// <summary>
        /// Create a EfsLocation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EfsLocation(string name, EfsLocationArgs args, CustomResourceOptions? options = null)
            : base("aws:datasync/efsLocation:EfsLocation", name, args, MakeResourceOptions(options, ""))
        {
        }

        private EfsLocation(string name, Input<string> id, EfsLocationState? state = null, CustomResourceOptions? options = null)
            : base("aws:datasync/efsLocation:EfsLocation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EfsLocation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EfsLocation Get(string name, Input<string> id, EfsLocationState? state = null, CustomResourceOptions? options = null)
        {
            return new EfsLocation(name, id, state, options);
        }
    }

    public sealed class EfsLocationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Configuration block containing EC2 configurations for connecting to the EFS File System.
        /// </summary>
        [Input("ec2Config", required: true)]
        public Input<Inputs.EfsLocationEc2ConfigArgs> Ec2Config { get; set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of EFS File System.
        /// </summary>
        [Input("efsFileSystemArn", required: true)]
        public Input<string> EfsFileSystemArn { get; set; } = null!;

        /// <summary>
        /// Subdirectory to perform actions as source or destination. Default `/`.
        /// </summary>
        [Input("subdirectory")]
        public Input<string>? Subdirectory { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Location.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public EfsLocationArgs()
        {
        }
    }

    public sealed class EfsLocationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Location.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Configuration block containing EC2 configurations for connecting to the EFS File System.
        /// </summary>
        [Input("ec2Config")]
        public Input<Inputs.EfsLocationEc2ConfigGetArgs>? Ec2Config { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of EFS File System.
        /// </summary>
        [Input("efsFileSystemArn")]
        public Input<string>? EfsFileSystemArn { get; set; }

        /// <summary>
        /// Subdirectory to perform actions as source or destination. Default `/`.
        /// </summary>
        [Input("subdirectory")]
        public Input<string>? Subdirectory { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Location.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        [Input("uri")]
        public Input<string>? Uri { get; set; }

        public EfsLocationState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class EfsLocationEc2ConfigArgs : Pulumi.ResourceArgs
    {
        [Input("securityGroupArns", required: true)]
        private InputList<string>? _securityGroupArns;

        /// <summary>
        /// List of Amazon Resource Names (ARNs) of the EC2 Security Groups that are associated with the EFS Mount Target.
        /// </summary>
        public InputList<string> SecurityGroupArns
        {
            get => _securityGroupArns ?? (_securityGroupArns = new InputList<string>());
            set => _securityGroupArns = value;
        }

        /// <summary>
        /// Amazon Resource Name (ARN) of the EC2 Subnet that is associated with the EFS Mount Target.
        /// </summary>
        [Input("subnetArn", required: true)]
        public Input<string> SubnetArn { get; set; } = null!;

        public EfsLocationEc2ConfigArgs()
        {
        }
    }

    public sealed class EfsLocationEc2ConfigGetArgs : Pulumi.ResourceArgs
    {
        [Input("securityGroupArns", required: true)]
        private InputList<string>? _securityGroupArns;

        /// <summary>
        /// List of Amazon Resource Names (ARNs) of the EC2 Security Groups that are associated with the EFS Mount Target.
        /// </summary>
        public InputList<string> SecurityGroupArns
        {
            get => _securityGroupArns ?? (_securityGroupArns = new InputList<string>());
            set => _securityGroupArns = value;
        }

        /// <summary>
        /// Amazon Resource Name (ARN) of the EC2 Subnet that is associated with the EFS Mount Target.
        /// </summary>
        [Input("subnetArn", required: true)]
        public Input<string> SubnetArn { get; set; } = null!;

        public EfsLocationEc2ConfigGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class EfsLocationEc2Config
    {
        /// <summary>
        /// List of Amazon Resource Names (ARNs) of the EC2 Security Groups that are associated with the EFS Mount Target.
        /// </summary>
        public readonly ImmutableArray<string> SecurityGroupArns;
        /// <summary>
        /// Amazon Resource Name (ARN) of the EC2 Subnet that is associated with the EFS Mount Target.
        /// </summary>
        public readonly string SubnetArn;

        [OutputConstructor]
        private EfsLocationEc2Config(
            ImmutableArray<string> securityGroupArns,
            string subnetArn)
        {
            SecurityGroupArns = securityGroupArns;
            SubnetArn = subnetArn;
        }
    }
    }
}
