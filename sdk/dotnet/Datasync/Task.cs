// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.DataSync
{
    /// <summary>
    /// Manages an AWS DataSync Task, which represents a configuration for synchronization. Starting an execution of these DataSync Tasks (actually synchronizing files) is performed outside of this resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/datasync_task.html.markdown.
    /// </summary>
    public partial class Task : Pulumi.CustomResource
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Task.
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Output("cloudwatchLogGroupArn")]
        public Output<string?> CloudwatchLogGroupArn { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Output("destinationLocationArn")]
        public Output<string> DestinationLocationArn { get; private set; } = null!;

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Output("options")]
        public Output<Outputs.TaskOptions?> Options { get; private set; } = null!;

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Output("sourceLocationArn")]
        public Output<string> SourceLocationArn { get; private set; } = null!;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Task resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Task(string name, TaskArgs args, CustomResourceOptions? options = null)
            : base("aws:datasync/task:Task", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Task(string name, Input<string> id, TaskState? state = null, CustomResourceOptions? options = null)
            : base("aws:datasync/task:Task", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Task resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Task Get(string name, Input<string> id, TaskState? state = null, CustomResourceOptions? options = null)
        {
            return new Task(name, id, state, options);
        }
    }

    public sealed class TaskArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Input("cloudwatchLogGroupArn")]
        public Input<string>? CloudwatchLogGroupArn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Input("destinationLocationArn", required: true)]
        public Input<string> DestinationLocationArn { get; set; } = null!;

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Input("options")]
        public Input<Inputs.TaskOptionsArgs>? Options { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Input("sourceLocationArn", required: true)]
        public Input<string> SourceLocationArn { get; set; } = null!;

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public TaskArgs()
        {
        }
    }

    public sealed class TaskState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Amazon Resource Name (ARN) of the DataSync Task.
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of the CloudWatch Log Group that is used to monitor and log events in the sync task.
        /// </summary>
        [Input("cloudwatchLogGroupArn")]
        public Input<string>? CloudwatchLogGroupArn { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of destination DataSync Location.
        /// </summary>
        [Input("destinationLocationArn")]
        public Input<string>? DestinationLocationArn { get; set; }

        /// <summary>
        /// Name of the DataSync Task.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Configuration block containing option that controls the default behavior when you start an execution of this DataSync Task. For each individual task execution, you can override these options by specifying an overriding configuration in those executions.
        /// </summary>
        [Input("options")]
        public Input<Inputs.TaskOptionsGetArgs>? Options { get; set; }

        /// <summary>
        /// Amazon Resource Name (ARN) of source DataSync Location.
        /// </summary>
        [Input("sourceLocationArn")]
        public Input<string>? SourceLocationArn { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// Key-value pairs of resource tags to assign to the DataSync Task.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public TaskState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class TaskOptionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to `BEST_EFFORT`, the DataSync Task attempts to preserve the original (that is, the version before sync `PREPARING` phase) `atime` attribute on all source files. Valid values: `BEST_EFFORT`, `NONE`. Default: `BEST_EFFORT`.
        /// </summary>
        [Input("atime")]
        public Input<string>? Atime { get; set; }

        /// <summary>
        /// Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to `1048576`. Value values: `-1` or greater. Default: `-1` (unlimited).
        /// </summary>
        [Input("bytesPerSecond")]
        public Input<int>? BytesPerSecond { get; set; }

        /// <summary>
        /// Group identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        [Input("gid")]
        public Input<string>? Gid { get; set; }

        /// <summary>
        /// A file metadata that indicates the last time a file was modified (written to) before the sync `PREPARING` phase. Value values: `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("mtime")]
        public Input<string>? Mtime { get; set; }

        /// <summary>
        /// Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: `BEST_EFFORT`, `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("posixPermissions")]
        public Input<string>? PosixPermissions { get; set; }

        /// <summary>
        /// Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: `PRESERVE`, `REMOVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("preserveDeletedFiles")]
        public Input<string>? PreserveDeletedFiles { get; set; }

        /// <summary>
        /// Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: `NONE`, `PRESERVE`. Default: `NONE` (ignore special devices).
        /// </summary>
        [Input("preserveDevices")]
        public Input<string>? PreserveDevices { get; set; }

        /// <summary>
        /// User identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        [Input("uid")]
        public Input<string>? Uid { get; set; }

        /// <summary>
        /// Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: `NONE`, `POINT_IN_TIME_CONSISTENT`. Default: `POINT_IN_TIME_CONSISTENT`.
        /// </summary>
        [Input("verifyMode")]
        public Input<string>? VerifyMode { get; set; }

        public TaskOptionsArgs()
        {
        }
    }

    public sealed class TaskOptionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to `BEST_EFFORT`, the DataSync Task attempts to preserve the original (that is, the version before sync `PREPARING` phase) `atime` attribute on all source files. Valid values: `BEST_EFFORT`, `NONE`. Default: `BEST_EFFORT`.
        /// </summary>
        [Input("atime")]
        public Input<string>? Atime { get; set; }

        /// <summary>
        /// Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to `1048576`. Value values: `-1` or greater. Default: `-1` (unlimited).
        /// </summary>
        [Input("bytesPerSecond")]
        public Input<int>? BytesPerSecond { get; set; }

        /// <summary>
        /// Group identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        [Input("gid")]
        public Input<string>? Gid { get; set; }

        /// <summary>
        /// A file metadata that indicates the last time a file was modified (written to) before the sync `PREPARING` phase. Value values: `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("mtime")]
        public Input<string>? Mtime { get; set; }

        /// <summary>
        /// Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: `BEST_EFFORT`, `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("posixPermissions")]
        public Input<string>? PosixPermissions { get; set; }

        /// <summary>
        /// Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: `PRESERVE`, `REMOVE`. Default: `PRESERVE`.
        /// </summary>
        [Input("preserveDeletedFiles")]
        public Input<string>? PreserveDeletedFiles { get; set; }

        /// <summary>
        /// Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: `NONE`, `PRESERVE`. Default: `NONE` (ignore special devices).
        /// </summary>
        [Input("preserveDevices")]
        public Input<string>? PreserveDevices { get; set; }

        /// <summary>
        /// User identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        [Input("uid")]
        public Input<string>? Uid { get; set; }

        /// <summary>
        /// Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: `NONE`, `POINT_IN_TIME_CONSISTENT`. Default: `POINT_IN_TIME_CONSISTENT`.
        /// </summary>
        [Input("verifyMode")]
        public Input<string>? VerifyMode { get; set; }

        public TaskOptionsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class TaskOptions
    {
        /// <summary>
        /// A file metadata that shows the last time a file was accessed (that is when the file was read or written to). If set to `BEST_EFFORT`, the DataSync Task attempts to preserve the original (that is, the version before sync `PREPARING` phase) `atime` attribute on all source files. Valid values: `BEST_EFFORT`, `NONE`. Default: `BEST_EFFORT`.
        /// </summary>
        public readonly string? Atime;
        /// <summary>
        /// Limits the bandwidth utilized. For example, to set a maximum of 1 MB, set this value to `1048576`. Value values: `-1` or greater. Default: `-1` (unlimited).
        /// </summary>
        public readonly int? BytesPerSecond;
        /// <summary>
        /// Group identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        public readonly string? Gid;
        /// <summary>
        /// A file metadata that indicates the last time a file was modified (written to) before the sync `PREPARING` phase. Value values: `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        public readonly string? Mtime;
        /// <summary>
        /// Determines which users or groups can access a file for a specific purpose such as reading, writing, or execution of the file. Valid values: `BEST_EFFORT`, `NONE`, `PRESERVE`. Default: `PRESERVE`.
        /// </summary>
        public readonly string? PosixPermissions;
        /// <summary>
        /// Whether files deleted in the source should be removed or preserved in the destination file system. Valid values: `PRESERVE`, `REMOVE`. Default: `PRESERVE`.
        /// </summary>
        public readonly string? PreserveDeletedFiles;
        /// <summary>
        /// Whether the DataSync Task should preserve the metadata of block and character devices in the source files system, and recreate the files with that device name and metadata on the destination. The DataSync Task can’t sync the actual contents of such devices, because many of the devices are non-terminal and don’t return an end of file (EOF) marker. Valid values: `NONE`, `PRESERVE`. Default: `NONE` (ignore special devices).
        /// </summary>
        public readonly string? PreserveDevices;
        /// <summary>
        /// User identifier of the file's owners. Valid values: `BOTH`, `INT_VALUE`, `NAME`, `NONE`. Default: `INT_VALUE` (preserve integer value of the ID).
        /// </summary>
        public readonly string? Uid;
        /// <summary>
        /// Whether a data integrity verification should be performed at the end of a task execution after all data and metadata have been transferred. Valid values: `NONE`, `POINT_IN_TIME_CONSISTENT`. Default: `POINT_IN_TIME_CONSISTENT`.
        /// </summary>
        public readonly string? VerifyMode;

        [OutputConstructor]
        private TaskOptions(
            string? atime,
            int? bytesPerSecond,
            string? gid,
            string? mtime,
            string? posixPermissions,
            string? preserveDeletedFiles,
            string? preserveDevices,
            string? uid,
            string? verifyMode)
        {
            Atime = atime;
            BytesPerSecond = bytesPerSecond;
            Gid = gid;
            Mtime = mtime;
            PosixPermissions = posixPermissions;
            PreserveDeletedFiles = preserveDeletedFiles;
            PreserveDevices = preserveDevices;
            Uid = uid;
            VerifyMode = verifyMode;
        }
    }
    }
}
