// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.StorageGateway
{
    /// <summary>
    /// Manages an AWS Storage Gateway file, tape, or volume gateway in the provider region.
    /// 
    /// &gt; NOTE: The Storage Gateway API requires the gateway to be connected to properly return information after activation. If you are receiving `The specified gateway is not connected` errors during resource creation (gateway activation), ensure your gateway instance meets the [Storage Gateway requirements](https://docs.aws.amazon.com/storagegateway/latest/userguide/Requirements.html).
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/storagegateway_gateway.html.markdown.
    /// </summary>
    public partial class Gateway : Pulumi.CustomResource
    {
        /// <summary>
        /// Gateway activation key during resource creation. Conflicts with `gateway_ip_address`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Output("activationKey")]
        public Output<string> ActivationKey { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Identifier of the gateway.
        /// </summary>
        [Output("gatewayId")]
        public Output<string> GatewayId { get; private set; } = null!;

        /// <summary>
        /// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activation_key`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Output("gatewayIpAddress")]
        public Output<string> GatewayIpAddress { get; private set; } = null!;

        /// <summary>
        /// Name of the gateway.
        /// </summary>
        [Output("gatewayName")]
        public Output<string> GatewayName { get; private set; } = null!;

        /// <summary>
        /// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
        /// </summary>
        [Output("gatewayTimezone")]
        public Output<string> GatewayTimezone { get; private set; } = null!;

        /// <summary>
        /// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
        /// </summary>
        [Output("gatewayType")]
        public Output<string?> GatewayType { get; private set; } = null!;

        [Output("mediumChangerType")]
        public Output<string?> MediumChangerType { get; private set; } = null!;

        /// <summary>
        /// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
        /// </summary>
        [Output("smbActiveDirectorySettings")]
        public Output<Outputs.GatewaySmbActiveDirectorySettings?> SmbActiveDirectorySettings { get; private set; } = null!;

        /// <summary>
        /// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
        /// </summary>
        [Output("smbGuestPassword")]
        public Output<string?> SmbGuestPassword { get; private set; } = null!;

        /// <summary>
        /// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
        /// </summary>
        [Output("tapeDriveType")]
        public Output<string?> TapeDriveType { get; private set; } = null!;


        /// <summary>
        /// Create a Gateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Gateway(string name, GatewayArgs args, CustomResourceOptions? options = null)
            : base("aws:storagegateway/gateway:Gateway", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Gateway(string name, Input<string> id, GatewayState? state = null, CustomResourceOptions? options = null)
            : base("aws:storagegateway/gateway:Gateway", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Gateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Gateway Get(string name, Input<string> id, GatewayState? state = null, CustomResourceOptions? options = null)
        {
            return new Gateway(name, id, state, options);
        }
    }

    public sealed class GatewayArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gateway activation key during resource creation. Conflicts with `gateway_ip_address`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Input("activationKey")]
        public Input<string>? ActivationKey { get; set; }

        /// <summary>
        /// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activation_key`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Input("gatewayIpAddress")]
        public Input<string>? GatewayIpAddress { get; set; }

        /// <summary>
        /// Name of the gateway.
        /// </summary>
        [Input("gatewayName", required: true)]
        public Input<string> GatewayName { get; set; } = null!;

        /// <summary>
        /// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
        /// </summary>
        [Input("gatewayTimezone", required: true)]
        public Input<string> GatewayTimezone { get; set; } = null!;

        /// <summary>
        /// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
        /// </summary>
        [Input("gatewayType")]
        public Input<string>? GatewayType { get; set; }

        [Input("mediumChangerType")]
        public Input<string>? MediumChangerType { get; set; }

        /// <summary>
        /// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
        /// </summary>
        [Input("smbActiveDirectorySettings")]
        public Input<Inputs.GatewaySmbActiveDirectorySettingsArgs>? SmbActiveDirectorySettings { get; set; }

        /// <summary>
        /// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
        /// </summary>
        [Input("smbGuestPassword")]
        public Input<string>? SmbGuestPassword { get; set; }

        /// <summary>
        /// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
        /// </summary>
        [Input("tapeDriveType")]
        public Input<string>? TapeDriveType { get; set; }

        public GatewayArgs()
        {
        }
    }

    public sealed class GatewayState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Gateway activation key during resource creation. Conflicts with `gateway_ip_address`. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Input("activationKey")]
        public Input<string>? ActivationKey { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the gateway.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Identifier of the gateway.
        /// </summary>
        [Input("gatewayId")]
        public Input<string>? GatewayId { get; set; }

        /// <summary>
        /// Gateway IP address to retrieve activation key during resource creation. Conflicts with `activation_key`. Gateway must be accessible on port 80 from where this provider is running. Additional information is available in the [Storage Gateway User Guide](https://docs.aws.amazon.com/storagegateway/latest/userguide/get-activation-key.html).
        /// </summary>
        [Input("gatewayIpAddress")]
        public Input<string>? GatewayIpAddress { get; set; }

        /// <summary>
        /// Name of the gateway.
        /// </summary>
        [Input("gatewayName")]
        public Input<string>? GatewayName { get; set; }

        /// <summary>
        /// Time zone for the gateway. The time zone is of the format "GMT", "GMT-hr:mm", or "GMT+hr:mm". For example, `GMT-4:00` indicates the time is 4 hours behind GMT. The time zone is used, for example, for scheduling snapshots and your gateway's maintenance schedule.
        /// </summary>
        [Input("gatewayTimezone")]
        public Input<string>? GatewayTimezone { get; set; }

        /// <summary>
        /// Type of the gateway. The default value is `STORED`. Valid values: `CACHED`, `FILE_S3`, `STORED`, `VTL`.
        /// </summary>
        [Input("gatewayType")]
        public Input<string>? GatewayType { get; set; }

        [Input("mediumChangerType")]
        public Input<string>? MediumChangerType { get; set; }

        /// <summary>
        /// Nested argument with Active Directory domain join information for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `ActiveDirectory` authentication SMB file shares. More details below.
        /// </summary>
        [Input("smbActiveDirectorySettings")]
        public Input<Inputs.GatewaySmbActiveDirectorySettingsGetArgs>? SmbActiveDirectorySettings { get; set; }

        /// <summary>
        /// Guest password for Server Message Block (SMB) file shares. Only valid for `FILE_S3` gateway type. Must be set before creating `GuestAccess` authentication SMB file shares. This provider can only detect drift of the existence of a guest password, not its actual value from the gateway. This provider can however update the password with changing the argument.
        /// </summary>
        [Input("smbGuestPassword")]
        public Input<string>? SmbGuestPassword { get; set; }

        /// <summary>
        /// Type of tape drive to use for tape gateway. This provider cannot detect drift of this argument. Valid values: `IBM-ULT3580-TD5`.
        /// </summary>
        [Input("tapeDriveType")]
        public Input<string>? TapeDriveType { get; set; }

        public GatewayState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class GatewaySmbActiveDirectorySettingsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the domain that you want the gateway to join.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// The password of the user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The user name of user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public GatewaySmbActiveDirectorySettingsArgs()
        {
        }
    }

    public sealed class GatewaySmbActiveDirectorySettingsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the domain that you want the gateway to join.
        /// </summary>
        [Input("domainName", required: true)]
        public Input<string> DomainName { get; set; } = null!;

        /// <summary>
        /// The password of the user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The user name of user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public GatewaySmbActiveDirectorySettingsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GatewaySmbActiveDirectorySettings
    {
        /// <summary>
        /// The name of the domain that you want the gateway to join.
        /// </summary>
        public readonly string DomainName;
        /// <summary>
        /// The password of the user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        public readonly string Password;
        /// <summary>
        /// The user name of user who has permission to add the gateway to the Active Directory domain.
        /// </summary>
        public readonly string Username;

        [OutputConstructor]
        private GatewaySmbActiveDirectorySettings(
            string domainName,
            string password,
            string username)
        {
            DomainName = domainName;
            Password = password;
            Username = username;
        }
    }
    }
}
