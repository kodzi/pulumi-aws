// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.GuardDuty
{
    /// <summary>
    /// Provides a resource to manage a GuardDuty detector.
    /// 
    /// &gt; **NOTE:** Deleting this resource is equivalent to "disabling" GuardDuty for an AWS region, which removes all existing findings. You can set the `enable` attribute to `false` to instead "suspend" monitoring and feedback reporting while keeping existing data. See the [Suspending or Disabling Amazon GuardDuty documentation](https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_suspend-disable.html) for more information.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/guardduty_detector.html.markdown.
    /// </summary>
    public partial class Detector : Pulumi.CustomResource
    {
        /// <summary>
        /// The AWS account ID of the GuardDuty detector
        /// </summary>
        [Output("accountId")]
        public Output<string> AccountId { get; private set; } = null!;

        /// <summary>
        /// Enable monitoring and feedback reporting. Setting to `false` is equivalent to "suspending" GuardDuty. Defaults to `true`.
        /// </summary>
        [Output("enable")]
        public Output<bool?> Enable { get; private set; } = null!;

        /// <summary>
        /// Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty master account and cannot be modified, otherwise defaults to `SIX_HOURS`. For standalone and GuardDuty master accounts, it must be configured in this provider to enable drift detection. Valid values for standalone and master accounts: `FIFTEEN_MINUTES`, `ONE_HOUR`, `SIX_HOURS`. See [AWS Documentation](https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings_cloudwatch.html#guardduty_findings_cloudwatch_notification_frequency) for more information.
        /// </summary>
        [Output("findingPublishingFrequency")]
        public Output<string> FindingPublishingFrequency { get; private set; } = null!;


        /// <summary>
        /// Create a Detector resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Detector(string name, DetectorArgs? args = null, CustomResourceOptions? options = null)
            : base("aws:guardduty/detector:Detector", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Detector(string name, Input<string> id, DetectorState? state = null, CustomResourceOptions? options = null)
            : base("aws:guardduty/detector:Detector", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Detector resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Detector Get(string name, Input<string> id, DetectorState? state = null, CustomResourceOptions? options = null)
        {
            return new Detector(name, id, state, options);
        }
    }

    public sealed class DetectorArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Enable monitoring and feedback reporting. Setting to `false` is equivalent to "suspending" GuardDuty. Defaults to `true`.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty master account and cannot be modified, otherwise defaults to `SIX_HOURS`. For standalone and GuardDuty master accounts, it must be configured in this provider to enable drift detection. Valid values for standalone and master accounts: `FIFTEEN_MINUTES`, `ONE_HOUR`, `SIX_HOURS`. See [AWS Documentation](https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings_cloudwatch.html#guardduty_findings_cloudwatch_notification_frequency) for more information.
        /// </summary>
        [Input("findingPublishingFrequency")]
        public Input<string>? FindingPublishingFrequency { get; set; }

        public DetectorArgs()
        {
        }
    }

    public sealed class DetectorState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The AWS account ID of the GuardDuty detector
        /// </summary>
        [Input("accountId")]
        public Input<string>? AccountId { get; set; }

        /// <summary>
        /// Enable monitoring and feedback reporting. Setting to `false` is equivalent to "suspending" GuardDuty. Defaults to `true`.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// Specifies the frequency of notifications sent for subsequent finding occurrences. If the detector is a GuardDuty member account, the value is determined by the GuardDuty master account and cannot be modified, otherwise defaults to `SIX_HOURS`. For standalone and GuardDuty master accounts, it must be configured in this provider to enable drift detection. Valid values for standalone and master accounts: `FIFTEEN_MINUTES`, `ONE_HOUR`, `SIX_HOURS`. See [AWS Documentation](https://docs.aws.amazon.com/guardduty/latest/ug/guardduty_findings_cloudwatch.html#guardduty_findings_cloudwatch_notification_frequency) for more information.
        /// </summary>
        [Input("findingPublishingFrequency")]
        public Input<string>? FindingPublishingFrequency { get; set; }

        public DetectorState()
        {
        }
    }
}
