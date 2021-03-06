# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Application(pulumi.CustomResource):
    appversion_lifecycle: pulumi.Output[dict]
    arn: pulumi.Output[str]
    """
    The ARN assigned by AWS for this Elastic Beanstalk Application.
    """
    description: pulumi.Output[str]
    """
    Short description of the application
    """
    name: pulumi.Output[str]
    """
    The name of the application, must be unique within your account
    """
    tags: pulumi.Output[dict]
    """
    Key-value mapping of tags for the Elastic Beanstalk Application.
    """
    def __init__(__self__, resource_name, opts=None, appversion_lifecycle=None, description=None, name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an Elastic Beanstalk Application Resource. Elastic Beanstalk allows
        you to deploy and manage applications in the AWS cloud without worrying about
        the infrastructure that runs those applications.
        
        This resource creates an application that has one configuration template named
        `default`, and no application versions
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Short description of the application
        :param pulumi.Input[str] name: The name of the application, must be unique within your account
        :param pulumi.Input[dict] tags: Key-value mapping of tags for the Elastic Beanstalk Application.
        
        The **appversion_lifecycle** object supports the following:
        
          * `deleteSourceFromS3` (`pulumi.Input[bool]`) - Set to `true` to delete a version's source bundle from S3 when the application version is deleted.
          * `maxAgeInDays` (`pulumi.Input[float]`) - The number of days to retain an application version.
          * `maxCount` (`pulumi.Input[float]`) - The maximum number of application versions to retain.
          * `service_role` (`pulumi.Input[str]`) - The ARN of an IAM service role under which the application version is deleted.  Elastic Beanstalk must have permission to assume this role.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elastic_beanstalk_application.html.markdown.
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

            __props__['appversion_lifecycle'] = appversion_lifecycle
            __props__['description'] = description
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['arn'] = None
        super(Application, __self__).__init__(
            'aws:elasticbeanstalk/application:Application',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, appversion_lifecycle=None, arn=None, description=None, name=None, tags=None):
        """
        Get an existing Application resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The ARN assigned by AWS for this Elastic Beanstalk Application.
        :param pulumi.Input[str] description: Short description of the application
        :param pulumi.Input[str] name: The name of the application, must be unique within your account
        :param pulumi.Input[dict] tags: Key-value mapping of tags for the Elastic Beanstalk Application.
        
        The **appversion_lifecycle** object supports the following:
        
          * `deleteSourceFromS3` (`pulumi.Input[bool]`) - Set to `true` to delete a version's source bundle from S3 when the application version is deleted.
          * `maxAgeInDays` (`pulumi.Input[float]`) - The number of days to retain an application version.
          * `maxCount` (`pulumi.Input[float]`) - The maximum number of application versions to retain.
          * `service_role` (`pulumi.Input[str]`) - The ARN of an IAM service role under which the application version is deleted.  Elastic Beanstalk must have permission to assume this role.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elastic_beanstalk_application.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["appversion_lifecycle"] = appversion_lifecycle
        __props__["arn"] = arn
        __props__["description"] = description
        __props__["name"] = name
        __props__["tags"] = tags
        return Application(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

