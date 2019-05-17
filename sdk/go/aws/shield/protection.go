// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package shield

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Enables AWS Shield Advanced for a specific AWS resource.
// The resource can be an Amazon CloudFront distribution, Elastic Load Balancing load balancer, AWS Global Accelerator accelerator, Elastic IP Address, or an Amazon Route 53 hosted zone.
type Protection struct {
	s *pulumi.ResourceState
}

// NewProtection registers a new resource with the given unique name, arguments, and options.
func NewProtection(ctx *pulumi.Context,
	name string, args *ProtectionArgs, opts ...pulumi.ResourceOpt) (*Protection, error) {
	if args == nil || args.ResourceArn == nil {
		return nil, errors.New("missing required argument 'ResourceArn'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["name"] = nil
		inputs["resourceArn"] = nil
	} else {
		inputs["name"] = args.Name
		inputs["resourceArn"] = args.ResourceArn
	}
	s, err := ctx.RegisterResource("aws:shield/protection:Protection", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Protection{s: s}, nil
}

// GetProtection gets an existing Protection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProtection(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ProtectionState, opts ...pulumi.ResourceOpt) (*Protection, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["name"] = state.Name
		inputs["resourceArn"] = state.ResourceArn
	}
	s, err := ctx.ReadResource("aws:shield/protection:Protection", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Protection{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Protection) URN() *pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Protection) ID() *pulumi.IDOutput {
	return r.s.ID()
}

// A friendly name for the Protection you are creating.
func (r *Protection) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// The ARN (Amazon Resource Name) of the resource to be protected.
func (r *Protection) ResourceArn() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceArn"])
}

// Input properties used for looking up and filtering Protection resources.
type ProtectionState struct {
	// A friendly name for the Protection you are creating.
	Name interface{}
	// The ARN (Amazon Resource Name) of the resource to be protected.
	ResourceArn interface{}
}

// The set of arguments for constructing a Protection resource.
type ProtectionArgs struct {
	// A friendly name for the Protection you are creating.
	Name interface{}
	// The ARN (Amazon Resource Name) of the resource to be protected.
	ResourceArn interface{}
}