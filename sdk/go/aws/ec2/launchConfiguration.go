// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package ec2

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a resource to create a new launch configuration, used for autoscaling groups.
// 
// ## Block devices
// 
// Each of the `*_block_device` attributes controls a portion of the AWS
// Launch Configuration's "Block Device Mapping". It's a good idea to familiarize yourself with [AWS's Block Device
// Mapping docs](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/block-device-mapping-concepts.html)
// to understand the implications of using these attributes.
// 
// The `rootBlockDevice` mapping supports the following:
// 
// * `volumeType` - (Optional) The type of volume. Can be `"standard"`, `"gp2"`,
//   or `"io1"`. (Default: `"standard"`).
// * `volumeSize` - (Optional) The size of the volume in gigabytes.
// * `iops` - (Optional) The amount of provisioned
//   [IOPS](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-io-characteristics.html).
//   This must be set with a `volumeType` of `"io1"`.
// * `deleteOnTermination` - (Optional) Whether the volume should be destroyed
//   on instance termination (Default: `true`).
// * `encrypted` - (Optional) Whether the volume should be encrypted or not. (Default: `false`).
// 
// Modifying any of the `rootBlockDevice` settings requires resource
// replacement.
// 
// Each `ebsBlockDevice` supports the following:
// 
// * `deviceName` - (Required) The name of the device to mount.
// * `snapshotId` - (Optional) The Snapshot ID to mount.
// * `volumeType` - (Optional) The type of volume. Can be `"standard"`, `"gp2"`,
//   or `"io1"`. (Default: `"standard"`).
// * `volumeSize` - (Optional) The size of the volume in gigabytes.
// * `iops` - (Optional) The amount of provisioned
//   [IOPS](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-io-characteristics.html).
//   This must be set with a `volumeType` of `"io1"`.
// * `deleteOnTermination` - (Optional) Whether the volume should be destroyed
//   on instance termination (Default: `true`).
// * `encrypted` - (Optional) Whether the volume should be encrypted or not. Do not use this option if you are using `snapshotId` as the encrypted flag will be determined by the snapshot. (Default: `false`).
// 
// Modifying any `ebsBlockDevice` currently requires resource replacement.
// 
// Each `ephemeralBlockDevice` supports the following:
// 
// * `deviceName` - The name of the block device to mount on the instance.
// * `virtualName` - The [Instance Store Device
//   Name](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#InstanceStoreDeviceNames)
//   (e.g. `"ephemeral0"`)
// 
// Each AWS Instance type has a different set of Instance Store block devices
// available for attachment. AWS [publishes a
// list](https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html#StorageOnInstanceTypes)
// of which ephemeral devices are available on each type. The devices are always
// identified by the `virtualName` in the format `"ephemeral{0..N}"`.
// 
// > **NOTE:** Changes to `*_block_device` configuration of _existing_ resources
// cannot currently be detected by this provider. After updating to block device
// configuration, resource recreation can be manually triggered by using the
// [`taint` command](https://www.terraform.io/docs/commands/taint.html).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/launch_configuration.html.markdown.
type LaunchConfiguration struct {
	s *pulumi.ResourceState
}

// NewLaunchConfiguration registers a new resource with the given unique name, arguments, and options.
func NewLaunchConfiguration(ctx *pulumi.Context,
	name string, args *LaunchConfigurationArgs, opts ...pulumi.ResourceOpt) (*LaunchConfiguration, error) {
	if args == nil || args.ImageId == nil {
		return nil, errors.New("missing required argument 'ImageId'")
	}
	if args == nil || args.InstanceType == nil {
		return nil, errors.New("missing required argument 'InstanceType'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["associatePublicIpAddress"] = nil
		inputs["ebsBlockDevices"] = nil
		inputs["ebsOptimized"] = nil
		inputs["enableMonitoring"] = nil
		inputs["ephemeralBlockDevices"] = nil
		inputs["iamInstanceProfile"] = nil
		inputs["imageId"] = nil
		inputs["instanceType"] = nil
		inputs["keyName"] = nil
		inputs["name"] = nil
		inputs["namePrefix"] = nil
		inputs["placementTenancy"] = nil
		inputs["rootBlockDevice"] = nil
		inputs["securityGroups"] = nil
		inputs["spotPrice"] = nil
		inputs["userData"] = nil
		inputs["userDataBase64"] = nil
		inputs["vpcClassicLinkId"] = nil
		inputs["vpcClassicLinkSecurityGroups"] = nil
	} else {
		inputs["associatePublicIpAddress"] = args.AssociatePublicIpAddress
		inputs["ebsBlockDevices"] = args.EbsBlockDevices
		inputs["ebsOptimized"] = args.EbsOptimized
		inputs["enableMonitoring"] = args.EnableMonitoring
		inputs["ephemeralBlockDevices"] = args.EphemeralBlockDevices
		inputs["iamInstanceProfile"] = args.IamInstanceProfile
		inputs["imageId"] = args.ImageId
		inputs["instanceType"] = args.InstanceType
		inputs["keyName"] = args.KeyName
		inputs["name"] = args.Name
		inputs["namePrefix"] = args.NamePrefix
		inputs["placementTenancy"] = args.PlacementTenancy
		inputs["rootBlockDevice"] = args.RootBlockDevice
		inputs["securityGroups"] = args.SecurityGroups
		inputs["spotPrice"] = args.SpotPrice
		inputs["userData"] = args.UserData
		inputs["userDataBase64"] = args.UserDataBase64
		inputs["vpcClassicLinkId"] = args.VpcClassicLinkId
		inputs["vpcClassicLinkSecurityGroups"] = args.VpcClassicLinkSecurityGroups
	}
	s, err := ctx.RegisterResource("aws:ec2/launchConfiguration:LaunchConfiguration", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &LaunchConfiguration{s: s}, nil
}

// GetLaunchConfiguration gets an existing LaunchConfiguration resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetLaunchConfiguration(ctx *pulumi.Context,
	name string, id pulumi.ID, state *LaunchConfigurationState, opts ...pulumi.ResourceOpt) (*LaunchConfiguration, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["associatePublicIpAddress"] = state.AssociatePublicIpAddress
		inputs["ebsBlockDevices"] = state.EbsBlockDevices
		inputs["ebsOptimized"] = state.EbsOptimized
		inputs["enableMonitoring"] = state.EnableMonitoring
		inputs["ephemeralBlockDevices"] = state.EphemeralBlockDevices
		inputs["iamInstanceProfile"] = state.IamInstanceProfile
		inputs["imageId"] = state.ImageId
		inputs["instanceType"] = state.InstanceType
		inputs["keyName"] = state.KeyName
		inputs["name"] = state.Name
		inputs["namePrefix"] = state.NamePrefix
		inputs["placementTenancy"] = state.PlacementTenancy
		inputs["rootBlockDevice"] = state.RootBlockDevice
		inputs["securityGroups"] = state.SecurityGroups
		inputs["spotPrice"] = state.SpotPrice
		inputs["userData"] = state.UserData
		inputs["userDataBase64"] = state.UserDataBase64
		inputs["vpcClassicLinkId"] = state.VpcClassicLinkId
		inputs["vpcClassicLinkSecurityGroups"] = state.VpcClassicLinkSecurityGroups
	}
	s, err := ctx.ReadResource("aws:ec2/launchConfiguration:LaunchConfiguration", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &LaunchConfiguration{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *LaunchConfiguration) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *LaunchConfiguration) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// Associate a public ip address with an instance in a VPC.
func (r *LaunchConfiguration) AssociatePublicIpAddress() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["associatePublicIpAddress"])
}

// Additional EBS block devices to attach to the
// instance.  See Block Devices below for details.
func (r *LaunchConfiguration) EbsBlockDevices() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["ebsBlockDevices"])
}

// If true, the launched EC2 instance will be EBS-optimized.
func (r *LaunchConfiguration) EbsOptimized() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["ebsOptimized"])
}

// Enables/disables detailed monitoring. This is enabled by default.
func (r *LaunchConfiguration) EnableMonitoring() *pulumi.BoolOutput {
	return (*pulumi.BoolOutput)(r.s.State["enableMonitoring"])
}

// Customize Ephemeral (also known as
// "Instance Store") volumes on the instance. See Block Devices below for details.
func (r *LaunchConfiguration) EphemeralBlockDevices() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["ephemeralBlockDevices"])
}

// The name attribute of the IAM instance profile to associate
// with launched instances.
func (r *LaunchConfiguration) IamInstanceProfile() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["iamInstanceProfile"])
}

// The EC2 image ID to launch.
func (r *LaunchConfiguration) ImageId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["imageId"])
}

// The size of instance to launch.
func (r *LaunchConfiguration) InstanceType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["instanceType"])
}

// The key name that should be used for the instance.
func (r *LaunchConfiguration) KeyName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["keyName"])
}

// The name of the launch configuration. If you leave
// this blank, this provider will auto-generate a unique name.
func (r *LaunchConfiguration) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Creates a unique name beginning with the specified
// prefix. Conflicts with `name`.
func (r *LaunchConfiguration) NamePrefix() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["namePrefix"])
}

// The tenancy of the instance. Valid values are
// `"default"` or `"dedicated"`, see [AWS's Create Launch Configuration](http://docs.aws.amazon.com/AutoScaling/latest/APIReference/API_CreateLaunchConfiguration.html)
// for more details
func (r *LaunchConfiguration) PlacementTenancy() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["placementTenancy"])
}

// Customize details about the root block
// device of the instance. See Block Devices below for details.
func (r *LaunchConfiguration) RootBlockDevice() *pulumi.Output {
	return r.s.State["rootBlockDevice"]
}

// A list of associated security group IDS.
func (r *LaunchConfiguration) SecurityGroups() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["securityGroups"])
}

// The maximum price to use for reserving spot instances.
func (r *LaunchConfiguration) SpotPrice() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["spotPrice"])
}

// The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see `userDataBase64` instead.
func (r *LaunchConfiguration) UserData() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["userData"])
}

// Can be used instead of `userData` to pass base64-encoded binary data directly. Use this instead of `userData` whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.
func (r *LaunchConfiguration) UserDataBase64() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["userDataBase64"])
}

// The ID of a ClassicLink-enabled VPC. Only applies to EC2-Classic instances. (eg. `vpc-2730681a`)
func (r *LaunchConfiguration) VpcClassicLinkId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["vpcClassicLinkId"])
}

// The IDs of one or more security groups for the specified ClassicLink-enabled VPC (eg. `sg-46ae3d11`).
func (r *LaunchConfiguration) VpcClassicLinkSecurityGroups() *pulumi.ArrayOutput {
	return (*pulumi.ArrayOutput)(r.s.State["vpcClassicLinkSecurityGroups"])
}

// Input properties used for looking up and filtering LaunchConfiguration resources.
type LaunchConfigurationState struct {
	// Associate a public ip address with an instance in a VPC.
	AssociatePublicIpAddress interface{}
	// Additional EBS block devices to attach to the
	// instance.  See Block Devices below for details.
	EbsBlockDevices interface{}
	// If true, the launched EC2 instance will be EBS-optimized.
	EbsOptimized interface{}
	// Enables/disables detailed monitoring. This is enabled by default.
	EnableMonitoring interface{}
	// Customize Ephemeral (also known as
	// "Instance Store") volumes on the instance. See Block Devices below for details.
	EphemeralBlockDevices interface{}
	// The name attribute of the IAM instance profile to associate
	// with launched instances.
	IamInstanceProfile interface{}
	// The EC2 image ID to launch.
	ImageId interface{}
	// The size of instance to launch.
	InstanceType interface{}
	// The key name that should be used for the instance.
	KeyName interface{}
	// The name of the launch configuration. If you leave
	// this blank, this provider will auto-generate a unique name.
	Name interface{}
	// Creates a unique name beginning with the specified
	// prefix. Conflicts with `name`.
	NamePrefix interface{}
	// The tenancy of the instance. Valid values are
	// `"default"` or `"dedicated"`, see [AWS's Create Launch Configuration](http://docs.aws.amazon.com/AutoScaling/latest/APIReference/API_CreateLaunchConfiguration.html)
	// for more details
	PlacementTenancy interface{}
	// Customize details about the root block
	// device of the instance. See Block Devices below for details.
	RootBlockDevice interface{}
	// A list of associated security group IDS.
	SecurityGroups interface{}
	// The maximum price to use for reserving spot instances.
	SpotPrice interface{}
	// The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see `userDataBase64` instead.
	UserData interface{}
	// Can be used instead of `userData` to pass base64-encoded binary data directly. Use this instead of `userData` whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.
	UserDataBase64 interface{}
	// The ID of a ClassicLink-enabled VPC. Only applies to EC2-Classic instances. (eg. `vpc-2730681a`)
	VpcClassicLinkId interface{}
	// The IDs of one or more security groups for the specified ClassicLink-enabled VPC (eg. `sg-46ae3d11`).
	VpcClassicLinkSecurityGroups interface{}
}

// The set of arguments for constructing a LaunchConfiguration resource.
type LaunchConfigurationArgs struct {
	// Associate a public ip address with an instance in a VPC.
	AssociatePublicIpAddress interface{}
	// Additional EBS block devices to attach to the
	// instance.  See Block Devices below for details.
	EbsBlockDevices interface{}
	// If true, the launched EC2 instance will be EBS-optimized.
	EbsOptimized interface{}
	// Enables/disables detailed monitoring. This is enabled by default.
	EnableMonitoring interface{}
	// Customize Ephemeral (also known as
	// "Instance Store") volumes on the instance. See Block Devices below for details.
	EphemeralBlockDevices interface{}
	// The name attribute of the IAM instance profile to associate
	// with launched instances.
	IamInstanceProfile interface{}
	// The EC2 image ID to launch.
	ImageId interface{}
	// The size of instance to launch.
	InstanceType interface{}
	// The key name that should be used for the instance.
	KeyName interface{}
	// The name of the launch configuration. If you leave
	// this blank, this provider will auto-generate a unique name.
	Name interface{}
	// Creates a unique name beginning with the specified
	// prefix. Conflicts with `name`.
	NamePrefix interface{}
	// The tenancy of the instance. Valid values are
	// `"default"` or `"dedicated"`, see [AWS's Create Launch Configuration](http://docs.aws.amazon.com/AutoScaling/latest/APIReference/API_CreateLaunchConfiguration.html)
	// for more details
	PlacementTenancy interface{}
	// Customize details about the root block
	// device of the instance. See Block Devices below for details.
	RootBlockDevice interface{}
	// A list of associated security group IDS.
	SecurityGroups interface{}
	// The maximum price to use for reserving spot instances.
	SpotPrice interface{}
	// The user data to provide when launching the instance. Do not pass gzip-compressed data via this argument; see `userDataBase64` instead.
	UserData interface{}
	// Can be used instead of `userData` to pass base64-encoded binary data directly. Use this instead of `userData` whenever the value is not a valid UTF-8 string. For example, gzip-encoded user data must be base64-encoded and passed via this argument to avoid corruption.
	UserDataBase64 interface{}
	// The ID of a ClassicLink-enabled VPC. Only applies to EC2-Classic instances. (eg. `vpc-2730681a`)
	VpcClassicLinkId interface{}
	// The IDs of one or more security groups for the specified ClassicLink-enabled VPC (eg. `sg-46ae3d11`).
	VpcClassicLinkSecurityGroups interface{}
}
