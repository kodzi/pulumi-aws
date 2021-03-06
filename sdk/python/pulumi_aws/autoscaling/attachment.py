# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Attachment(pulumi.CustomResource):
    alb_target_group_arn: pulumi.Output[str]
    """
    The ARN of an ALB Target Group.
    """
    autoscaling_group_name: pulumi.Output[str]
    """
    Name of ASG to associate with the ELB.
    """
    elb: pulumi.Output[str]
    """
    The name of the ELB.
    """
    def __init__(__self__, resource_name, opts=None, alb_target_group_arn=None, autoscaling_group_name=None, elb=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an AutoScaling Attachment resource.
        
        > **NOTE on AutoScaling Groups and ASG Attachments:** This provider currently provides
        both a standalone ASG Attachment resource (describing an ASG attached to
        an ELB), and an AutoScaling Group resource with
        `load_balancers` defined in-line. At this time you cannot use an ASG with in-line
        load balancers in conjunction with an ASG Attachment resource. Doing so will cause a
        conflict and will overwrite attachments.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] alb_target_group_arn: The ARN of an ALB Target Group.
        :param pulumi.Input[str] autoscaling_group_name: Name of ASG to associate with the ELB.
        :param pulumi.Input[str] elb: The name of the ELB.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/autoscaling_attachment.html.markdown.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['alb_target_group_arn'] = alb_target_group_arn
            if autoscaling_group_name is None:
                raise TypeError("Missing required property 'autoscaling_group_name'")
            __props__['autoscaling_group_name'] = autoscaling_group_name
            __props__['elb'] = elb
        super(Attachment, __self__).__init__(
            'aws:autoscaling/attachment:Attachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, alb_target_group_arn=None, autoscaling_group_name=None, elb=None):
        """
        Get an existing Attachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] alb_target_group_arn: The ARN of an ALB Target Group.
        :param pulumi.Input[str] autoscaling_group_name: Name of ASG to associate with the ELB.
        :param pulumi.Input[str] elb: The name of the ELB.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/autoscaling_attachment.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["alb_target_group_arn"] = alb_target_group_arn
        __props__["autoscaling_group_name"] = autoscaling_group_name
        __props__["elb"] = elb
        return Attachment(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

