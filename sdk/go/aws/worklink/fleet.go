// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package worklink

import (
	"reflect"

	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

type Fleet struct {
	pulumi.CustomResourceState

	// The ARN of the created WorkLink Fleet.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// The ARN of the Amazon Kinesis data stream that receives the audit events.
	AuditStreamArn pulumi.StringPtrOutput `pulumi:"auditStreamArn"`
	// The identifier used by users to sign in to the Amazon WorkLink app.
	CompanyCode pulumi.StringOutput `pulumi:"companyCode"`
	// The time that the fleet was created.
	CreatedTime pulumi.StringOutput `pulumi:"createdTime"`
	// The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
	DeviceCaCertificate pulumi.StringPtrOutput `pulumi:"deviceCaCertificate"`
	// The name of the fleet.
	DisplayName pulumi.StringPtrOutput `pulumi:"displayName"`
	// Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
	IdentityProvider FleetIdentityProviderPtrOutput `pulumi:"identityProvider"`
	// The time that the fleet was last updated.
	LastUpdatedTime pulumi.StringOutput `pulumi:"lastUpdatedTime"`
	// A region-unique name for the AMI.
	Name pulumi.StringOutput `pulumi:"name"`
	// Provide this to allow manage the company network configuration for the fleet. Fields documented below.
	Network FleetNetworkPtrOutput `pulumi:"network"`
	// The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
	OptimizeForEndUserLocation pulumi.BoolPtrOutput `pulumi:"optimizeForEndUserLocation"`
}

// NewFleet registers a new resource with the given unique name, arguments, and options.
func NewFleet(ctx *pulumi.Context,
	name string, args *FleetArgs, opts ...pulumi.ResourceOption) (*Fleet, error) {
	if args == nil {
		args = &FleetArgs{}
	}
	var resource Fleet
	err := ctx.RegisterResource("aws:worklink/fleet:Fleet", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetFleet gets an existing Fleet resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetFleet(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *FleetState, opts ...pulumi.ResourceOption) (*Fleet, error) {
	var resource Fleet
	err := ctx.ReadResource("aws:worklink/fleet:Fleet", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Fleet resources.
type fleetState struct {
	// The ARN of the created WorkLink Fleet.
	Arn *string `pulumi:"arn"`
	// The ARN of the Amazon Kinesis data stream that receives the audit events.
	AuditStreamArn *string `pulumi:"auditStreamArn"`
	// The identifier used by users to sign in to the Amazon WorkLink app.
	CompanyCode *string `pulumi:"companyCode"`
	// The time that the fleet was created.
	CreatedTime *string `pulumi:"createdTime"`
	// The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
	DeviceCaCertificate *string `pulumi:"deviceCaCertificate"`
	// The name of the fleet.
	DisplayName *string `pulumi:"displayName"`
	// Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
	IdentityProvider *FleetIdentityProvider `pulumi:"identityProvider"`
	// The time that the fleet was last updated.
	LastUpdatedTime *string `pulumi:"lastUpdatedTime"`
	// A region-unique name for the AMI.
	Name *string `pulumi:"name"`
	// Provide this to allow manage the company network configuration for the fleet. Fields documented below.
	Network *FleetNetwork `pulumi:"network"`
	// The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
	OptimizeForEndUserLocation *bool `pulumi:"optimizeForEndUserLocation"`
}

type FleetState struct {
	// The ARN of the created WorkLink Fleet.
	Arn pulumi.StringPtrInput
	// The ARN of the Amazon Kinesis data stream that receives the audit events.
	AuditStreamArn pulumi.StringPtrInput
	// The identifier used by users to sign in to the Amazon WorkLink app.
	CompanyCode pulumi.StringPtrInput
	// The time that the fleet was created.
	CreatedTime pulumi.StringPtrInput
	// The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
	DeviceCaCertificate pulumi.StringPtrInput
	// The name of the fleet.
	DisplayName pulumi.StringPtrInput
	// Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
	IdentityProvider FleetIdentityProviderPtrInput
	// The time that the fleet was last updated.
	LastUpdatedTime pulumi.StringPtrInput
	// A region-unique name for the AMI.
	Name pulumi.StringPtrInput
	// Provide this to allow manage the company network configuration for the fleet. Fields documented below.
	Network FleetNetworkPtrInput
	// The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
	OptimizeForEndUserLocation pulumi.BoolPtrInput
}

func (FleetState) ElementType() reflect.Type {
	return reflect.TypeOf((*fleetState)(nil)).Elem()
}

type fleetArgs struct {
	// The ARN of the Amazon Kinesis data stream that receives the audit events.
	AuditStreamArn *string `pulumi:"auditStreamArn"`
	// The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
	DeviceCaCertificate *string `pulumi:"deviceCaCertificate"`
	// The name of the fleet.
	DisplayName *string `pulumi:"displayName"`
	// Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
	IdentityProvider *FleetIdentityProvider `pulumi:"identityProvider"`
	// A region-unique name for the AMI.
	Name *string `pulumi:"name"`
	// Provide this to allow manage the company network configuration for the fleet. Fields documented below.
	Network *FleetNetwork `pulumi:"network"`
	// The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
	OptimizeForEndUserLocation *bool `pulumi:"optimizeForEndUserLocation"`
}

// The set of arguments for constructing a Fleet resource.
type FleetArgs struct {
	// The ARN of the Amazon Kinesis data stream that receives the audit events.
	AuditStreamArn pulumi.StringPtrInput
	// The certificate chain, including intermediate certificates and the root certificate authority certificate used to issue device certificates.
	DeviceCaCertificate pulumi.StringPtrInput
	// The name of the fleet.
	DisplayName pulumi.StringPtrInput
	// Provide this to allow manage the identity provider configuration for the fleet. Fields documented below.
	IdentityProvider FleetIdentityProviderPtrInput
	// A region-unique name for the AMI.
	Name pulumi.StringPtrInput
	// Provide this to allow manage the company network configuration for the fleet. Fields documented below.
	Network FleetNetworkPtrInput
	// The option to optimize for better performance by routing traffic through the closest AWS Region to users, which may be outside of your home Region. Defaults to `true`.
	OptimizeForEndUserLocation pulumi.BoolPtrInput
}

func (FleetArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*fleetArgs)(nil)).Elem()
}

