// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package pinpoint

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides a Pinpoint SMS Channel resource.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/pinpoint_email_channel.html.markdown.
type EmailChannel struct {
	pulumi.CustomResourceState

	// The application ID.
	ApplicationId pulumi.StringOutput `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrOutput `pulumi:"enabled"`
	// The email address used to send emails from.
	FromAddress pulumi.StringOutput `pulumi:"fromAddress"`
	// The ARN of an identity verified with SES.
	Identity pulumi.StringOutput `pulumi:"identity"`
	// Messages per second that can be sent.
	MessagesPerSecond pulumi.IntOutput `pulumi:"messagesPerSecond"`
	// The ARN of an IAM Role used to submit events to Mobile Analytics' event ingestion service.
	RoleArn pulumi.StringOutput `pulumi:"roleArn"`
}

// NewEmailChannel registers a new resource with the given unique name, arguments, and options.
func NewEmailChannel(ctx *pulumi.Context,
	name string, args *EmailChannelArgs, opts ...pulumi.ResourceOption) (*EmailChannel, error) {
	if args == nil || args.ApplicationId == nil {
		return nil, errors.New("missing required argument 'ApplicationId'")
	}
	if args == nil || args.FromAddress == nil {
		return nil, errors.New("missing required argument 'FromAddress'")
	}
	if args == nil || args.Identity == nil {
		return nil, errors.New("missing required argument 'Identity'")
	}
	if args == nil || args.RoleArn == nil {
		return nil, errors.New("missing required argument 'RoleArn'")
	}
	if args == nil {
		args = &EmailChannelArgs{}
	}
	var resource EmailChannel
	err := ctx.RegisterResource("aws:pinpoint/emailChannel:EmailChannel", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetEmailChannel gets an existing EmailChannel resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetEmailChannel(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *EmailChannelState, opts ...pulumi.ResourceOption) (*EmailChannel, error) {
	var resource EmailChannel
	err := ctx.ReadResource("aws:pinpoint/emailChannel:EmailChannel", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering EmailChannel resources.
type emailChannelState struct {
	// The application ID.
	ApplicationId *string `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// The email address used to send emails from.
	FromAddress *string `pulumi:"fromAddress"`
	// The ARN of an identity verified with SES.
	Identity *string `pulumi:"identity"`
	// Messages per second that can be sent.
	MessagesPerSecond *int `pulumi:"messagesPerSecond"`
	// The ARN of an IAM Role used to submit events to Mobile Analytics' event ingestion service.
	RoleArn *string `pulumi:"roleArn"`
}

type EmailChannelState struct {
	// The application ID.
	ApplicationId pulumi.StringPtrInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// The email address used to send emails from.
	FromAddress pulumi.StringPtrInput
	// The ARN of an identity verified with SES.
	Identity pulumi.StringPtrInput
	// Messages per second that can be sent.
	MessagesPerSecond pulumi.IntPtrInput
	// The ARN of an IAM Role used to submit events to Mobile Analytics' event ingestion service.
	RoleArn pulumi.StringPtrInput
}

func (EmailChannelState) ElementType() reflect.Type {
	return reflect.TypeOf((*emailChannelState)(nil)).Elem()
}

type emailChannelArgs struct {
	// The application ID.
	ApplicationId string `pulumi:"applicationId"`
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled *bool `pulumi:"enabled"`
	// The email address used to send emails from.
	FromAddress string `pulumi:"fromAddress"`
	// The ARN of an identity verified with SES.
	Identity string `pulumi:"identity"`
	// The ARN of an IAM Role used to submit events to Mobile Analytics' event ingestion service.
	RoleArn string `pulumi:"roleArn"`
}

// The set of arguments for constructing a EmailChannel resource.
type EmailChannelArgs struct {
	// The application ID.
	ApplicationId pulumi.StringInput
	// Whether the channel is enabled or disabled. Defaults to `true`.
	Enabled pulumi.BoolPtrInput
	// The email address used to send emails from.
	FromAddress pulumi.StringInput
	// The ARN of an identity verified with SES.
	Identity pulumi.StringInput
	// The ARN of an IAM Role used to submit events to Mobile Analytics' event ingestion service.
	RoleArn pulumi.StringInput
}

func (EmailChannelArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*emailChannelArgs)(nil)).Elem()
}

