// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package batch

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// The Batch Compute Environment data source allows access to details of a specific
// compute environment within AWS Batch.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/batch_compute_environment.html.markdown.
func LookupComputeEnvironment(ctx *pulumi.Context, args *LookupComputeEnvironmentArgs, opts ...pulumi.InvokeOption) (*LookupComputeEnvironmentResult, error) {
	var rv LookupComputeEnvironmentResult
	err := ctx.Invoke("aws:batch/getComputeEnvironment:getComputeEnvironment", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getComputeEnvironment.
type LookupComputeEnvironmentArgs struct {
	// The name of the Batch Compute Environment
	ComputeEnvironmentName string `pulumi:"computeEnvironmentName"`
}


// A collection of values returned by getComputeEnvironment.
type LookupComputeEnvironmentResult struct {
	// The ARN of the compute environment.
	Arn string `pulumi:"arn"`
	ComputeEnvironmentName string `pulumi:"computeEnvironmentName"`
	// The ARN of the underlying Amazon ECS cluster used by the compute environment.
	EcsClusterArn string `pulumi:"ecsClusterArn"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The ARN of the IAM role that allows AWS Batch to make calls to other AWS services on your behalf.
	ServiceRole string `pulumi:"serviceRole"`
	// The state of the compute environment (for example, `ENABLED` or `DISABLED`). If the state is `ENABLED`, then the compute environment accepts jobs from a queue and can scale out automatically based on queues.
	State string `pulumi:"state"`
	// The current status of the compute environment (for example, `CREATING` or `VALID`).
	Status string `pulumi:"status"`
	// A short, human-readable string to provide additional details about the current status of the compute environment.
	StatusReason string `pulumi:"statusReason"`
	// The type of the compute environment (for example, `MANAGED` or `UNMANAGED`).
	Type string `pulumi:"type"`
}

