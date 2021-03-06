# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class RolePolicyAttachment(pulumi.CustomResource):
    policy_arn: pulumi.Output[str]
    """
    The ARN of the policy you want to apply
    """
    role: pulumi.Output[str]
    """
    The role the policy should be applied to
    """
    def __init__(__self__, resource_name, opts=None, policy_arn=None, role=None, __props__=None, __name__=None, __opts__=None):
        """
        Attaches a Managed IAM Policy to an IAM role
        
        > **NOTE:** The usage of this resource conflicts with the `iam.PolicyAttachment` resource and will permanently show a difference if both are defined.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] policy_arn: The ARN of the policy you want to apply
        :param pulumi.Input[str] role: The role the policy should be applied to

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/iam_role_policy_attachment.html.markdown.
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

            if policy_arn is None:
                raise TypeError("Missing required property 'policy_arn'")
            __props__['policy_arn'] = policy_arn
            if role is None:
                raise TypeError("Missing required property 'role'")
            __props__['role'] = role
        super(RolePolicyAttachment, __self__).__init__(
            'aws:iam/rolePolicyAttachment:RolePolicyAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, policy_arn=None, role=None):
        """
        Get an existing RolePolicyAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] policy_arn: The ARN of the policy you want to apply
        :param pulumi.Input[str] role: The role the policy should be applied to

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/iam_role_policy_attachment.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["policy_arn"] = policy_arn
        __props__["role"] = role
        return RolePolicyAttachment(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

