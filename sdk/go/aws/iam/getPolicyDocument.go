// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package iam

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/iam_policy_document.html.markdown.
func GetPolicyDocument(ctx *pulumi.Context, args *GetPolicyDocumentArgs, opts ...pulumi.InvokeOption) (*GetPolicyDocumentResult, error) {
	var rv GetPolicyDocumentResult
	err := ctx.Invoke("aws:iam/getPolicyDocument:getPolicyDocument", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPolicyDocument.
type GetPolicyDocumentArgs struct {
	// An IAM policy document to import and override the
	// current policy document.  Statements with non-blank `sid`s in the override
	// document will overwrite statements with the same `sid` in the current document.
	// Statements without an `sid` cannot be overwritten.
	OverrideJson *string `pulumi:"overrideJson"`
	// An ID for the policy document.
	PolicyId *string `pulumi:"policyId"`
	// An IAM policy document to import as a base for the
	// current policy document.  Statements with non-blank `sid`s in the current
	// policy document will overwrite statements with the same `sid` in the source
	// json.  Statements without an `sid` cannot be overwritten.
	SourceJson *string `pulumi:"sourceJson"`
	// A nested configuration block (described below)
	// configuring one *statement* to be included in the policy document.
	Statements []GetPolicyDocumentStatement `pulumi:"statements"`
	// IAM policy document version. Valid values: `2008-10-17`, `2012-10-17`. Defaults to `2012-10-17`. For more information, see the [AWS IAM User Guide](https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_elements_version.html).
	Version *string `pulumi:"version"`
}


// A collection of values returned by getPolicyDocument.
type GetPolicyDocumentResult struct {
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The above arguments serialized as a standard JSON policy document.
	Json string `pulumi:"json"`
	OverrideJson *string `pulumi:"overrideJson"`
	PolicyId *string `pulumi:"policyId"`
	SourceJson *string `pulumi:"sourceJson"`
	Statements []GetPolicyDocumentStatement `pulumi:"statements"`
	Version *string `pulumi:"version"`
}

