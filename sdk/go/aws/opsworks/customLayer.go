// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package opsworks

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides an OpsWorks custom layer resource.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/opsworks_custom_layer.html.markdown.
type CustomLayer struct {
	pulumi.CustomResourceState

	// Whether to automatically assign an elastic IP address to the layer's instances.
	AutoAssignElasticIps pulumi.BoolPtrOutput `pulumi:"autoAssignElasticIps"`
	// For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.
	AutoAssignPublicIps pulumi.BoolPtrOutput `pulumi:"autoAssignPublicIps"`
	// Whether to enable auto-healing for the layer.
	AutoHealing pulumi.BoolPtrOutput `pulumi:"autoHealing"`
	CustomConfigureRecipes pulumi.StringArrayOutput `pulumi:"customConfigureRecipes"`
	CustomDeployRecipes pulumi.StringArrayOutput `pulumi:"customDeployRecipes"`
	// The ARN of an IAM profile that will be used for the layer's instances.
	CustomInstanceProfileArn pulumi.StringPtrOutput `pulumi:"customInstanceProfileArn"`
	// Custom JSON attributes to apply to the layer.
	CustomJson pulumi.StringPtrOutput `pulumi:"customJson"`
	// Ids for a set of security groups to apply to the layer's instances.
	CustomSecurityGroupIds pulumi.StringArrayOutput `pulumi:"customSecurityGroupIds"`
	CustomSetupRecipes pulumi.StringArrayOutput `pulumi:"customSetupRecipes"`
	CustomShutdownRecipes pulumi.StringArrayOutput `pulumi:"customShutdownRecipes"`
	CustomUndeployRecipes pulumi.StringArrayOutput `pulumi:"customUndeployRecipes"`
	// Whether to enable Elastic Load Balancing connection draining.
	DrainElbOnShutdown pulumi.BoolPtrOutput `pulumi:"drainElbOnShutdown"`
	// `ebsVolume` blocks, as described below, will each create an EBS volume and connect it to the layer's instances.
	EbsVolumes CustomLayerEbsVolumeArrayOutput `pulumi:"ebsVolumes"`
	// Name of an Elastic Load Balancer to attach to this layer
	ElasticLoadBalancer pulumi.StringPtrOutput `pulumi:"elasticLoadBalancer"`
	// Whether to install OS and package updates on each instance when it boots.
	InstallUpdatesOnBoot pulumi.BoolPtrOutput `pulumi:"installUpdatesOnBoot"`
	// The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.
	InstanceShutdownTimeout pulumi.IntPtrOutput `pulumi:"instanceShutdownTimeout"`
	// A human-readable name for the layer.
	Name pulumi.StringOutput `pulumi:"name"`
	// A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.
	ShortName pulumi.StringOutput `pulumi:"shortName"`
	// The id of the stack the layer will belong to.
	StackId pulumi.StringOutput `pulumi:"stackId"`
	// Names of a set of system packages to install on the layer's instances.
	SystemPackages pulumi.StringArrayOutput `pulumi:"systemPackages"`
	// Whether to use EBS-optimized instances.
	UseEbsOptimizedInstances pulumi.BoolPtrOutput `pulumi:"useEbsOptimizedInstances"`
}

// NewCustomLayer registers a new resource with the given unique name, arguments, and options.
func NewCustomLayer(ctx *pulumi.Context,
	name string, args *CustomLayerArgs, opts ...pulumi.ResourceOption) (*CustomLayer, error) {
	if args == nil || args.ShortName == nil {
		return nil, errors.New("missing required argument 'ShortName'")
	}
	if args == nil || args.StackId == nil {
		return nil, errors.New("missing required argument 'StackId'")
	}
	if args == nil {
		args = &CustomLayerArgs{}
	}
	var resource CustomLayer
	err := ctx.RegisterResource("aws:opsworks/customLayer:CustomLayer", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetCustomLayer gets an existing CustomLayer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetCustomLayer(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *CustomLayerState, opts ...pulumi.ResourceOption) (*CustomLayer, error) {
	var resource CustomLayer
	err := ctx.ReadResource("aws:opsworks/customLayer:CustomLayer", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering CustomLayer resources.
type customLayerState struct {
	// Whether to automatically assign an elastic IP address to the layer's instances.
	AutoAssignElasticIps *bool `pulumi:"autoAssignElasticIps"`
	// For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.
	AutoAssignPublicIps *bool `pulumi:"autoAssignPublicIps"`
	// Whether to enable auto-healing for the layer.
	AutoHealing *bool `pulumi:"autoHealing"`
	CustomConfigureRecipes []string `pulumi:"customConfigureRecipes"`
	CustomDeployRecipes []string `pulumi:"customDeployRecipes"`
	// The ARN of an IAM profile that will be used for the layer's instances.
	CustomInstanceProfileArn *string `pulumi:"customInstanceProfileArn"`
	// Custom JSON attributes to apply to the layer.
	CustomJson *string `pulumi:"customJson"`
	// Ids for a set of security groups to apply to the layer's instances.
	CustomSecurityGroupIds []string `pulumi:"customSecurityGroupIds"`
	CustomSetupRecipes []string `pulumi:"customSetupRecipes"`
	CustomShutdownRecipes []string `pulumi:"customShutdownRecipes"`
	CustomUndeployRecipes []string `pulumi:"customUndeployRecipes"`
	// Whether to enable Elastic Load Balancing connection draining.
	DrainElbOnShutdown *bool `pulumi:"drainElbOnShutdown"`
	// `ebsVolume` blocks, as described below, will each create an EBS volume and connect it to the layer's instances.
	EbsVolumes []CustomLayerEbsVolume `pulumi:"ebsVolumes"`
	// Name of an Elastic Load Balancer to attach to this layer
	ElasticLoadBalancer *string `pulumi:"elasticLoadBalancer"`
	// Whether to install OS and package updates on each instance when it boots.
	InstallUpdatesOnBoot *bool `pulumi:"installUpdatesOnBoot"`
	// The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.
	InstanceShutdownTimeout *int `pulumi:"instanceShutdownTimeout"`
	// A human-readable name for the layer.
	Name *string `pulumi:"name"`
	// A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.
	ShortName *string `pulumi:"shortName"`
	// The id of the stack the layer will belong to.
	StackId *string `pulumi:"stackId"`
	// Names of a set of system packages to install on the layer's instances.
	SystemPackages []string `pulumi:"systemPackages"`
	// Whether to use EBS-optimized instances.
	UseEbsOptimizedInstances *bool `pulumi:"useEbsOptimizedInstances"`
}

type CustomLayerState struct {
	// Whether to automatically assign an elastic IP address to the layer's instances.
	AutoAssignElasticIps pulumi.BoolPtrInput
	// For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.
	AutoAssignPublicIps pulumi.BoolPtrInput
	// Whether to enable auto-healing for the layer.
	AutoHealing pulumi.BoolPtrInput
	CustomConfigureRecipes pulumi.StringArrayInput
	CustomDeployRecipes pulumi.StringArrayInput
	// The ARN of an IAM profile that will be used for the layer's instances.
	CustomInstanceProfileArn pulumi.StringPtrInput
	// Custom JSON attributes to apply to the layer.
	CustomJson pulumi.StringPtrInput
	// Ids for a set of security groups to apply to the layer's instances.
	CustomSecurityGroupIds pulumi.StringArrayInput
	CustomSetupRecipes pulumi.StringArrayInput
	CustomShutdownRecipes pulumi.StringArrayInput
	CustomUndeployRecipes pulumi.StringArrayInput
	// Whether to enable Elastic Load Balancing connection draining.
	DrainElbOnShutdown pulumi.BoolPtrInput
	// `ebsVolume` blocks, as described below, will each create an EBS volume and connect it to the layer's instances.
	EbsVolumes CustomLayerEbsVolumeArrayInput
	// Name of an Elastic Load Balancer to attach to this layer
	ElasticLoadBalancer pulumi.StringPtrInput
	// Whether to install OS and package updates on each instance when it boots.
	InstallUpdatesOnBoot pulumi.BoolPtrInput
	// The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.
	InstanceShutdownTimeout pulumi.IntPtrInput
	// A human-readable name for the layer.
	Name pulumi.StringPtrInput
	// A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.
	ShortName pulumi.StringPtrInput
	// The id of the stack the layer will belong to.
	StackId pulumi.StringPtrInput
	// Names of a set of system packages to install on the layer's instances.
	SystemPackages pulumi.StringArrayInput
	// Whether to use EBS-optimized instances.
	UseEbsOptimizedInstances pulumi.BoolPtrInput
}

func (CustomLayerState) ElementType() reflect.Type {
	return reflect.TypeOf((*customLayerState)(nil)).Elem()
}

type customLayerArgs struct {
	// Whether to automatically assign an elastic IP address to the layer's instances.
	AutoAssignElasticIps *bool `pulumi:"autoAssignElasticIps"`
	// For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.
	AutoAssignPublicIps *bool `pulumi:"autoAssignPublicIps"`
	// Whether to enable auto-healing for the layer.
	AutoHealing *bool `pulumi:"autoHealing"`
	CustomConfigureRecipes []string `pulumi:"customConfigureRecipes"`
	CustomDeployRecipes []string `pulumi:"customDeployRecipes"`
	// The ARN of an IAM profile that will be used for the layer's instances.
	CustomInstanceProfileArn *string `pulumi:"customInstanceProfileArn"`
	// Custom JSON attributes to apply to the layer.
	CustomJson *string `pulumi:"customJson"`
	// Ids for a set of security groups to apply to the layer's instances.
	CustomSecurityGroupIds []string `pulumi:"customSecurityGroupIds"`
	CustomSetupRecipes []string `pulumi:"customSetupRecipes"`
	CustomShutdownRecipes []string `pulumi:"customShutdownRecipes"`
	CustomUndeployRecipes []string `pulumi:"customUndeployRecipes"`
	// Whether to enable Elastic Load Balancing connection draining.
	DrainElbOnShutdown *bool `pulumi:"drainElbOnShutdown"`
	// `ebsVolume` blocks, as described below, will each create an EBS volume and connect it to the layer's instances.
	EbsVolumes []CustomLayerEbsVolume `pulumi:"ebsVolumes"`
	// Name of an Elastic Load Balancer to attach to this layer
	ElasticLoadBalancer *string `pulumi:"elasticLoadBalancer"`
	// Whether to install OS and package updates on each instance when it boots.
	InstallUpdatesOnBoot *bool `pulumi:"installUpdatesOnBoot"`
	// The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.
	InstanceShutdownTimeout *int `pulumi:"instanceShutdownTimeout"`
	// A human-readable name for the layer.
	Name *string `pulumi:"name"`
	// A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.
	ShortName string `pulumi:"shortName"`
	// The id of the stack the layer will belong to.
	StackId string `pulumi:"stackId"`
	// Names of a set of system packages to install on the layer's instances.
	SystemPackages []string `pulumi:"systemPackages"`
	// Whether to use EBS-optimized instances.
	UseEbsOptimizedInstances *bool `pulumi:"useEbsOptimizedInstances"`
}

// The set of arguments for constructing a CustomLayer resource.
type CustomLayerArgs struct {
	// Whether to automatically assign an elastic IP address to the layer's instances.
	AutoAssignElasticIps pulumi.BoolPtrInput
	// For stacks belonging to a VPC, whether to automatically assign a public IP address to each of the layer's instances.
	AutoAssignPublicIps pulumi.BoolPtrInput
	// Whether to enable auto-healing for the layer.
	AutoHealing pulumi.BoolPtrInput
	CustomConfigureRecipes pulumi.StringArrayInput
	CustomDeployRecipes pulumi.StringArrayInput
	// The ARN of an IAM profile that will be used for the layer's instances.
	CustomInstanceProfileArn pulumi.StringPtrInput
	// Custom JSON attributes to apply to the layer.
	CustomJson pulumi.StringPtrInput
	// Ids for a set of security groups to apply to the layer's instances.
	CustomSecurityGroupIds pulumi.StringArrayInput
	CustomSetupRecipes pulumi.StringArrayInput
	CustomShutdownRecipes pulumi.StringArrayInput
	CustomUndeployRecipes pulumi.StringArrayInput
	// Whether to enable Elastic Load Balancing connection draining.
	DrainElbOnShutdown pulumi.BoolPtrInput
	// `ebsVolume` blocks, as described below, will each create an EBS volume and connect it to the layer's instances.
	EbsVolumes CustomLayerEbsVolumeArrayInput
	// Name of an Elastic Load Balancer to attach to this layer
	ElasticLoadBalancer pulumi.StringPtrInput
	// Whether to install OS and package updates on each instance when it boots.
	InstallUpdatesOnBoot pulumi.BoolPtrInput
	// The time, in seconds, that OpsWorks will wait for Chef to complete after triggering the Shutdown event.
	InstanceShutdownTimeout pulumi.IntPtrInput
	// A human-readable name for the layer.
	Name pulumi.StringPtrInput
	// A short, machine-readable name for the layer, which will be used to identify it in the Chef node JSON.
	ShortName pulumi.StringInput
	// The id of the stack the layer will belong to.
	StackId pulumi.StringInput
	// Names of a set of system packages to install on the layer's instances.
	SystemPackages pulumi.StringArrayInput
	// Whether to use EBS-optimized instances.
	UseEbsOptimizedInstances pulumi.BoolPtrInput
}

func (CustomLayerArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*customLayerArgs)(nil)).Elem()
}

