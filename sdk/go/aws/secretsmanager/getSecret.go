// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package secretsmanager

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Retrieve metadata information about a Secrets Manager secret. To retrieve a secret value, see the [`secretsmanager.SecretVersion` data source](https://www.terraform.io/docs/providers/aws/d/secretsmanager_secret_version.html).
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/secretsmanager_secret.html.markdown.
func LookupSecret(ctx *pulumi.Context, args *LookupSecretArgs, opts ...pulumi.InvokeOption) (*LookupSecretResult, error) {
	var rv LookupSecretResult
	err := ctx.Invoke("aws:secretsmanager/getSecret:getSecret", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getSecret.
type LookupSecretArgs struct {
	// The Amazon Resource Name (ARN) of the secret to retrieve.
	Arn *string `pulumi:"arn"`
	// The name of the secret to retrieve.
	Name *string `pulumi:"name"`
}


// A collection of values returned by getSecret.
type LookupSecretResult struct {
	// The Amazon Resource Name (ARN) of the secret.
	Arn string `pulumi:"arn"`
	// A description of the secret.
	Description string `pulumi:"description"`
	// id is the provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The Key Management Service (KMS) Customer Master Key (CMK) associated with the secret.
	KmsKeyId string `pulumi:"kmsKeyId"`
	Name string `pulumi:"name"`
	// The resource-based policy document that's attached to the secret.
	Policy string `pulumi:"policy"`
	// Whether rotation is enabled or not.
	RotationEnabled bool `pulumi:"rotationEnabled"`
	// Rotation Lambda function Amazon Resource Name (ARN) if rotation is enabled.
	RotationLambdaArn string `pulumi:"rotationLambdaArn"`
	// Rotation rules if rotation is enabled.
	RotationRules []GetSecretRotationRule `pulumi:"rotationRules"`
	// Tags of the secret.
	Tags map[string]interface{} `pulumi:"tags"`
}

