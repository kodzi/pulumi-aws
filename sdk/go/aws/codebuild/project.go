// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package codebuild

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a CodeBuild Project resource. See also the [`codebuild.Webhook` resource](https://www.terraform.io/docs/providers/aws/r/codebuild_webhook.html), which manages the webhook to the source (e.g. the "rebuild every time a code change is pushed" option in the CodeBuild web console).
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/codebuild_project.html.markdown.
type Project struct {
	pulumi.CustomResourceState

	// The ARN of the CodeBuild project.
	Arn pulumi.StringOutput `pulumi:"arn"`
	// Information about the project's build output artifacts. Artifact blocks are documented below.
	Artifacts ProjectArtifactsOutput `pulumi:"artifacts"`
	// Generates a publicly-accessible URL for the projects build badge. Available as `badgeUrl` attribute when enabled.
	BadgeEnabled pulumi.BoolPtrOutput `pulumi:"badgeEnabled"`
	// The URL of the build badge when `badgeEnabled` is enabled.
	BadgeUrl pulumi.StringOutput `pulumi:"badgeUrl"`
	// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing out any related build that does not get marked as completed. The default is 60 minutes.
	BuildTimeout pulumi.IntPtrOutput `pulumi:"buildTimeout"`
	// Information about the cache storage for the project. Cache blocks are documented below.
	Cache ProjectCachePtrOutput `pulumi:"cache"`
	// A short description of the project.
	Description pulumi.StringOutput `pulumi:"description"`
	// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting the build project's build output artifacts.
	EncryptionKey pulumi.StringOutput `pulumi:"encryptionKey"`
	// Information about the project's build environment. Environment blocks are documented below.
	Environment ProjectEnvironmentOutput `pulumi:"environment"`
	// Configuration for the builds to store log data to CloudWatch or S3.
	LogsConfig ProjectLogsConfigPtrOutput `pulumi:"logsConfig"`
	// The name of the project. If `type` is set to `S3`, this is the name of the output artifact object
	Name pulumi.StringOutput `pulumi:"name"`
	// How long in minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it times out. The default is 8 hours.
	QueuedTimeout pulumi.IntPtrOutput `pulumi:"queuedTimeout"`
	// A set of secondary artifacts to be used inside the build. Secondary artifacts blocks are documented below.
	SecondaryArtifacts ProjectSecondaryArtifactArrayOutput `pulumi:"secondaryArtifacts"`
	// A set of secondary sources to be used inside the build. Secondary sources blocks are documented below.
	SecondarySources ProjectSecondarySourceArrayOutput `pulumi:"secondarySources"`
	// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
	ServiceRole pulumi.StringOutput `pulumi:"serviceRole"`
	// Information about the project's input source code. Source blocks are documented below.
	Source ProjectSourceOutput `pulumi:"source"`
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapOutput `pulumi:"tags"`
	// Configuration for the builds to run inside a VPC. VPC config blocks are documented below.
	VpcConfig ProjectVpcConfigPtrOutput `pulumi:"vpcConfig"`
}

// NewProject registers a new resource with the given unique name, arguments, and options.
func NewProject(ctx *pulumi.Context,
	name string, args *ProjectArgs, opts ...pulumi.ResourceOption) (*Project, error) {
	if args == nil || args.Artifacts == nil {
		return nil, errors.New("missing required argument 'Artifacts'")
	}
	if args == nil || args.Environment == nil {
		return nil, errors.New("missing required argument 'Environment'")
	}
	if args == nil || args.ServiceRole == nil {
		return nil, errors.New("missing required argument 'ServiceRole'")
	}
	if args == nil || args.Source == nil {
		return nil, errors.New("missing required argument 'Source'")
	}
	if args == nil {
		args = &ProjectArgs{}
	}
	var resource Project
	err := ctx.RegisterResource("aws:codebuild/project:Project", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetProject gets an existing Project resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProject(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ProjectState, opts ...pulumi.ResourceOption) (*Project, error) {
	var resource Project
	err := ctx.ReadResource("aws:codebuild/project:Project", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Project resources.
type projectState struct {
	// The ARN of the CodeBuild project.
	Arn *string `pulumi:"arn"`
	// Information about the project's build output artifacts. Artifact blocks are documented below.
	Artifacts *ProjectArtifacts `pulumi:"artifacts"`
	// Generates a publicly-accessible URL for the projects build badge. Available as `badgeUrl` attribute when enabled.
	BadgeEnabled *bool `pulumi:"badgeEnabled"`
	// The URL of the build badge when `badgeEnabled` is enabled.
	BadgeUrl *string `pulumi:"badgeUrl"`
	// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing out any related build that does not get marked as completed. The default is 60 minutes.
	BuildTimeout *int `pulumi:"buildTimeout"`
	// Information about the cache storage for the project. Cache blocks are documented below.
	Cache *ProjectCache `pulumi:"cache"`
	// A short description of the project.
	Description *string `pulumi:"description"`
	// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting the build project's build output artifacts.
	EncryptionKey *string `pulumi:"encryptionKey"`
	// Information about the project's build environment. Environment blocks are documented below.
	Environment *ProjectEnvironment `pulumi:"environment"`
	// Configuration for the builds to store log data to CloudWatch or S3.
	LogsConfig *ProjectLogsConfig `pulumi:"logsConfig"`
	// The name of the project. If `type` is set to `S3`, this is the name of the output artifact object
	Name *string `pulumi:"name"`
	// How long in minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it times out. The default is 8 hours.
	QueuedTimeout *int `pulumi:"queuedTimeout"`
	// A set of secondary artifacts to be used inside the build. Secondary artifacts blocks are documented below.
	SecondaryArtifacts []ProjectSecondaryArtifact `pulumi:"secondaryArtifacts"`
	// A set of secondary sources to be used inside the build. Secondary sources blocks are documented below.
	SecondarySources []ProjectSecondarySource `pulumi:"secondarySources"`
	// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
	ServiceRole *string `pulumi:"serviceRole"`
	// Information about the project's input source code. Source blocks are documented below.
	Source *ProjectSource `pulumi:"source"`
	// A mapping of tags to assign to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
	// Configuration for the builds to run inside a VPC. VPC config blocks are documented below.
	VpcConfig *ProjectVpcConfig `pulumi:"vpcConfig"`
}

type ProjectState struct {
	// The ARN of the CodeBuild project.
	Arn pulumi.StringPtrInput
	// Information about the project's build output artifacts. Artifact blocks are documented below.
	Artifacts ProjectArtifactsPtrInput
	// Generates a publicly-accessible URL for the projects build badge. Available as `badgeUrl` attribute when enabled.
	BadgeEnabled pulumi.BoolPtrInput
	// The URL of the build badge when `badgeEnabled` is enabled.
	BadgeUrl pulumi.StringPtrInput
	// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing out any related build that does not get marked as completed. The default is 60 minutes.
	BuildTimeout pulumi.IntPtrInput
	// Information about the cache storage for the project. Cache blocks are documented below.
	Cache ProjectCachePtrInput
	// A short description of the project.
	Description pulumi.StringPtrInput
	// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting the build project's build output artifacts.
	EncryptionKey pulumi.StringPtrInput
	// Information about the project's build environment. Environment blocks are documented below.
	Environment ProjectEnvironmentPtrInput
	// Configuration for the builds to store log data to CloudWatch or S3.
	LogsConfig ProjectLogsConfigPtrInput
	// The name of the project. If `type` is set to `S3`, this is the name of the output artifact object
	Name pulumi.StringPtrInput
	// How long in minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it times out. The default is 8 hours.
	QueuedTimeout pulumi.IntPtrInput
	// A set of secondary artifacts to be used inside the build. Secondary artifacts blocks are documented below.
	SecondaryArtifacts ProjectSecondaryArtifactArrayInput
	// A set of secondary sources to be used inside the build. Secondary sources blocks are documented below.
	SecondarySources ProjectSecondarySourceArrayInput
	// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
	ServiceRole pulumi.StringPtrInput
	// Information about the project's input source code. Source blocks are documented below.
	Source ProjectSourcePtrInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapInput
	// Configuration for the builds to run inside a VPC. VPC config blocks are documented below.
	VpcConfig ProjectVpcConfigPtrInput
}

func (ProjectState) ElementType() reflect.Type {
	return reflect.TypeOf((*projectState)(nil)).Elem()
}

type projectArgs struct {
	// Information about the project's build output artifacts. Artifact blocks are documented below.
	Artifacts ProjectArtifacts `pulumi:"artifacts"`
	// Generates a publicly-accessible URL for the projects build badge. Available as `badgeUrl` attribute when enabled.
	BadgeEnabled *bool `pulumi:"badgeEnabled"`
	// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing out any related build that does not get marked as completed. The default is 60 minutes.
	BuildTimeout *int `pulumi:"buildTimeout"`
	// Information about the cache storage for the project. Cache blocks are documented below.
	Cache *ProjectCache `pulumi:"cache"`
	// A short description of the project.
	Description *string `pulumi:"description"`
	// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting the build project's build output artifacts.
	EncryptionKey *string `pulumi:"encryptionKey"`
	// Information about the project's build environment. Environment blocks are documented below.
	Environment ProjectEnvironment `pulumi:"environment"`
	// Configuration for the builds to store log data to CloudWatch or S3.
	LogsConfig *ProjectLogsConfig `pulumi:"logsConfig"`
	// The name of the project. If `type` is set to `S3`, this is the name of the output artifact object
	Name *string `pulumi:"name"`
	// How long in minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it times out. The default is 8 hours.
	QueuedTimeout *int `pulumi:"queuedTimeout"`
	// A set of secondary artifacts to be used inside the build. Secondary artifacts blocks are documented below.
	SecondaryArtifacts []ProjectSecondaryArtifact `pulumi:"secondaryArtifacts"`
	// A set of secondary sources to be used inside the build. Secondary sources blocks are documented below.
	SecondarySources []ProjectSecondarySource `pulumi:"secondarySources"`
	// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
	ServiceRole string `pulumi:"serviceRole"`
	// Information about the project's input source code. Source blocks are documented below.
	Source ProjectSource `pulumi:"source"`
	// A mapping of tags to assign to the resource.
	Tags map[string]interface{} `pulumi:"tags"`
	// Configuration for the builds to run inside a VPC. VPC config blocks are documented below.
	VpcConfig *ProjectVpcConfig `pulumi:"vpcConfig"`
}

// The set of arguments for constructing a Project resource.
type ProjectArgs struct {
	// Information about the project's build output artifacts. Artifact blocks are documented below.
	Artifacts ProjectArtifactsInput
	// Generates a publicly-accessible URL for the projects build badge. Available as `badgeUrl` attribute when enabled.
	BadgeEnabled pulumi.BoolPtrInput
	// How long in minutes, from 5 to 480 (8 hours), for AWS CodeBuild to wait until timing out any related build that does not get marked as completed. The default is 60 minutes.
	BuildTimeout pulumi.IntPtrInput
	// Information about the cache storage for the project. Cache blocks are documented below.
	Cache ProjectCachePtrInput
	// A short description of the project.
	Description pulumi.StringPtrInput
	// The AWS Key Management Service (AWS KMS) customer master key (CMK) to be used for encrypting the build project's build output artifacts.
	EncryptionKey pulumi.StringPtrInput
	// Information about the project's build environment. Environment blocks are documented below.
	Environment ProjectEnvironmentInput
	// Configuration for the builds to store log data to CloudWatch or S3.
	LogsConfig ProjectLogsConfigPtrInput
	// The name of the project. If `type` is set to `S3`, this is the name of the output artifact object
	Name pulumi.StringPtrInput
	// How long in minutes, from 5 to 480 (8 hours), a build is allowed to be queued before it times out. The default is 8 hours.
	QueuedTimeout pulumi.IntPtrInput
	// A set of secondary artifacts to be used inside the build. Secondary artifacts blocks are documented below.
	SecondaryArtifacts ProjectSecondaryArtifactArrayInput
	// A set of secondary sources to be used inside the build. Secondary sources blocks are documented below.
	SecondarySources ProjectSecondarySourceArrayInput
	// The Amazon Resource Name (ARN) of the AWS Identity and Access Management (IAM) role that enables AWS CodeBuild to interact with dependent AWS services on behalf of the AWS account.
	ServiceRole pulumi.StringInput
	// Information about the project's input source code. Source blocks are documented below.
	Source ProjectSourceInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.MapInput
	// Configuration for the builds to run inside a VPC. VPC config blocks are documented below.
	VpcConfig ProjectVpcConfigPtrInput
}

func (ProjectArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*projectArgs)(nil)).Elem()
}

