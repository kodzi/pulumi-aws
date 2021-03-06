# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class ApplicationVersion(pulumi.CustomResource):
    application: pulumi.Output[str]
    """
    Name of the Beanstalk Application the version is associated with.
    """
    arn: pulumi.Output[str]
    """
    The ARN assigned by AWS for this Elastic Beanstalk Application.
    """
    bucket: pulumi.Output[str]
    """
    S3 bucket that contains the Application Version source bundle.
    """
    description: pulumi.Output[str]
    """
    Short description of the Application Version.
    """
    force_delete: pulumi.Output[bool]
    """
    On delete, force an Application Version to be deleted when it may be in use
    by multiple Elastic Beanstalk Environments.
    """
    key: pulumi.Output[str]
    """
    S3 object that is the Application Version source bundle.
    """
    name: pulumi.Output[str]
    """
    A unique name for the this Application Version.
    """
    tags: pulumi.Output[dict]
    """
    Key-value mapping of tags for the Elastic Beanstalk Application Version.
    """
    def __init__(__self__, resource_name, opts=None, application=None, bucket=None, description=None, force_delete=None, key=None, name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an Elastic Beanstalk Application Version Resource. Elastic Beanstalk allows
        you to deploy and manage applications in the AWS cloud without worrying about
        the infrastructure that runs those applications.
        
        This resource creates a Beanstalk Application Version that can be deployed to a Beanstalk
        Environment.
        
        > **NOTE on Application Version Resource:**  When using the Application Version resource with multiple 
        Elastic Beanstalk Environments it is possible that an error may be returned
        when attempting to delete an Application Version while it is still in use by a different environment.
        To work around this you can:
        <ol>
        <li>Create each environment in a separate AWS account</li>
        <li>Create your `elasticbeanstalk.ApplicationVersion` resources with a unique names in your 
        Elastic Beanstalk Application. For example &lt;revision&gt;-&lt;environment&gt;.</li>
        </ol>
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application: Name of the Beanstalk Application the version is associated with.
        :param pulumi.Input[str] bucket: S3 bucket that contains the Application Version source bundle.
        :param pulumi.Input[str] description: Short description of the Application Version.
        :param pulumi.Input[bool] force_delete: On delete, force an Application Version to be deleted when it may be in use
               by multiple Elastic Beanstalk Environments.
        :param pulumi.Input[str] key: S3 object that is the Application Version source bundle.
        :param pulumi.Input[str] name: A unique name for the this Application Version.
        :param pulumi.Input[dict] tags: Key-value mapping of tags for the Elastic Beanstalk Application Version.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elastic_beanstalk_application_version.html.markdown.
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

            if application is None:
                raise TypeError("Missing required property 'application'")
            __props__['application'] = application
            if bucket is None:
                raise TypeError("Missing required property 'bucket'")
            __props__['bucket'] = bucket
            __props__['description'] = description
            __props__['force_delete'] = force_delete
            if key is None:
                raise TypeError("Missing required property 'key'")
            __props__['key'] = key
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['arn'] = None
        super(ApplicationVersion, __self__).__init__(
            'aws:elasticbeanstalk/applicationVersion:ApplicationVersion',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, application=None, arn=None, bucket=None, description=None, force_delete=None, key=None, name=None, tags=None):
        """
        Get an existing ApplicationVersion resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application: Name of the Beanstalk Application the version is associated with.
        :param pulumi.Input[str] arn: The ARN assigned by AWS for this Elastic Beanstalk Application.
        :param pulumi.Input[str] bucket: S3 bucket that contains the Application Version source bundle.
        :param pulumi.Input[str] description: Short description of the Application Version.
        :param pulumi.Input[bool] force_delete: On delete, force an Application Version to be deleted when it may be in use
               by multiple Elastic Beanstalk Environments.
        :param pulumi.Input[str] key: S3 object that is the Application Version source bundle.
        :param pulumi.Input[str] name: A unique name for the this Application Version.
        :param pulumi.Input[dict] tags: Key-value mapping of tags for the Elastic Beanstalk Application Version.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/elastic_beanstalk_application_version.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["application"] = application
        __props__["arn"] = arn
        __props__["bucket"] = bucket
        __props__["description"] = description
        __props__["force_delete"] = force_delete
        __props__["key"] = key
        __props__["name"] = name
        __props__["tags"] = tags
        return ApplicationVersion(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

