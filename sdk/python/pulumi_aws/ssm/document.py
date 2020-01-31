# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Document(pulumi.CustomResource):
    arn: pulumi.Output[str]
    attachments_sources: pulumi.Output[list]
    """
    One or more configuration blocks describing attachments sources to a version of a document. Defined below.
    
      * `key` (`str`)
      * `name` (`str`) - The name of the document.
      * `values` (`list`)
    """
    content: pulumi.Output[str]
    """
    The JSON or YAML content of the document.
    """
    created_date: pulumi.Output[str]
    """
    The date the document was created.
    """
    default_version: pulumi.Output[str]
    """
    The default version of the document.
    """
    description: pulumi.Output[str]
    """
    The description of the document.
    """
    document_format: pulumi.Output[str]
    """
    The format of the document. Valid document types include: `JSON` and `YAML`
    """
    document_type: pulumi.Output[str]
    """
    The type of the document. Valid document types include: `Automation`, `Command`, `Package`, `Policy`, and `Session`
    """
    hash: pulumi.Output[str]
    """
    The sha1 or sha256 of the document content
    """
    hash_type: pulumi.Output[str]
    """
    "Sha1" "Sha256". The hashing algorithm used when hashing the content.
    """
    latest_version: pulumi.Output[str]
    """
    The latest version of the document.
    """
    name: pulumi.Output[str]
    """
    The name of the document.
    """
    owner: pulumi.Output[str]
    """
    The AWS user account of the person who created the document.
    """
    parameters: pulumi.Output[list]
    """
    The parameters that are available to this document.
    
      * `default_value` (`str`)
      * `description` (`str`) - The description of the document.
      * `name` (`str`) - The name of the document.
      * `type` (`str`)
    """
    permissions: pulumi.Output[dict]
    """
    Additional Permissions to attach to the document. See Permissions below for details.
    
      * `account_ids` (`str`)
      * `type` (`str`)
    """
    platform_types: pulumi.Output[list]
    """
    A list of OS platforms compatible with this SSM document, either "Windows" or "Linux".
    """
    schema_version: pulumi.Output[str]
    """
    The schema version of the document.
    """
    status: pulumi.Output[str]
    """
    "Creating", "Active" or "Deleting". The current status of the document.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the object.
    """
    target_type: pulumi.Output[str]
    """
    The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS Resource Types Reference (http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html)
    """
    def __init__(__self__, resource_name, opts=None, attachments_sources=None, content=None, document_format=None, document_type=None, name=None, permissions=None, tags=None, target_type=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides an SSM Document resource
        
        > **NOTE on updating SSM documents:** Only documents with a schema version of 2.0
        or greater can update their content once created, see [SSM Schema Features][1]. To update a document with an older
        schema version you must recreate the resource.
        
        ## attachments_source
        
        The `attachments_source` block supports the following:
        
        * `key` - (Required) The key describing the location of an attachment to a document. Valid key types include: `SourceUrl` and `S3FileUrl`
        * `values` - (Required) The value describing the location of an attachment to a document
        * `name` - (Optional) The name of the document attachment file
        
        ## Permissions
        
        The permissions attribute specifies how you want to share the document. If you share a document privately,
        you must specify the AWS user account IDs for those people who can use the document. If you share a document
        publicly, you must specify All as the account ID.
        
        The permissions mapping supports the following:
        
        * `type` - The permission type for the document. The permission type can be `Share`.
        * `account_ids` - The AWS user accounts that should have access to the document. The account IDs can either be a group of account IDs or `All`.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] attachments_sources: One or more configuration blocks describing attachments sources to a version of a document. Defined below.
        :param pulumi.Input[str] content: The JSON or YAML content of the document.
        :param pulumi.Input[str] document_format: The format of the document. Valid document types include: `JSON` and `YAML`
        :param pulumi.Input[str] document_type: The type of the document. Valid document types include: `Automation`, `Command`, `Package`, `Policy`, and `Session`
        :param pulumi.Input[str] name: The name of the document.
        :param pulumi.Input[dict] permissions: Additional Permissions to attach to the document. See Permissions below for details.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the object.
        :param pulumi.Input[str] target_type: The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS Resource Types Reference (http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html)
        
        The **attachments_sources** object supports the following:
        
          * `key` (`pulumi.Input[str]`)
          * `name` (`pulumi.Input[str]`) - The name of the document.
          * `values` (`pulumi.Input[list]`)
        
        The **permissions** object supports the following:
        
          * `account_ids` (`pulumi.Input[str]`)
          * `type` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/ssm_document.html.markdown.
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

            __props__['attachments_sources'] = attachments_sources
            if content is None:
                raise TypeError("Missing required property 'content'")
            __props__['content'] = content
            __props__['document_format'] = document_format
            if document_type is None:
                raise TypeError("Missing required property 'document_type'")
            __props__['document_type'] = document_type
            __props__['name'] = name
            __props__['permissions'] = permissions
            __props__['tags'] = tags
            __props__['target_type'] = target_type
            __props__['arn'] = None
            __props__['created_date'] = None
            __props__['default_version'] = None
            __props__['description'] = None
            __props__['hash'] = None
            __props__['hash_type'] = None
            __props__['latest_version'] = None
            __props__['owner'] = None
            __props__['parameters'] = None
            __props__['platform_types'] = None
            __props__['schema_version'] = None
            __props__['status'] = None
        super(Document, __self__).__init__(
            'aws:ssm/document:Document',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, attachments_sources=None, content=None, created_date=None, default_version=None, description=None, document_format=None, document_type=None, hash=None, hash_type=None, latest_version=None, name=None, owner=None, parameters=None, permissions=None, platform_types=None, schema_version=None, status=None, tags=None, target_type=None):
        """
        Get an existing Document resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] attachments_sources: One or more configuration blocks describing attachments sources to a version of a document. Defined below.
        :param pulumi.Input[str] content: The JSON or YAML content of the document.
        :param pulumi.Input[str] created_date: The date the document was created.
        :param pulumi.Input[str] default_version: The default version of the document.
        :param pulumi.Input[str] description: The description of the document.
        :param pulumi.Input[str] document_format: The format of the document. Valid document types include: `JSON` and `YAML`
        :param pulumi.Input[str] document_type: The type of the document. Valid document types include: `Automation`, `Command`, `Package`, `Policy`, and `Session`
        :param pulumi.Input[str] hash: The sha1 or sha256 of the document content
        :param pulumi.Input[str] hash_type: "Sha1" "Sha256". The hashing algorithm used when hashing the content.
        :param pulumi.Input[str] latest_version: The latest version of the document.
        :param pulumi.Input[str] name: The name of the document.
        :param pulumi.Input[str] owner: The AWS user account of the person who created the document.
        :param pulumi.Input[list] parameters: The parameters that are available to this document.
        :param pulumi.Input[dict] permissions: Additional Permissions to attach to the document. See Permissions below for details.
        :param pulumi.Input[list] platform_types: A list of OS platforms compatible with this SSM document, either "Windows" or "Linux".
        :param pulumi.Input[str] schema_version: The schema version of the document.
        :param pulumi.Input[str] status: "Creating", "Active" or "Deleting". The current status of the document.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the object.
        :param pulumi.Input[str] target_type: The target type which defines the kinds of resources the document can run on. For example, /AWS::EC2::Instance. For a list of valid resource types, see AWS Resource Types Reference (http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-template-resource-type-ref.html)
        
        The **attachments_sources** object supports the following:
        
          * `key` (`pulumi.Input[str]`)
          * `name` (`pulumi.Input[str]`) - The name of the document.
          * `values` (`pulumi.Input[list]`)
        
        The **parameters** object supports the following:
        
          * `default_value` (`pulumi.Input[str]`)
          * `description` (`pulumi.Input[str]`) - The description of the document.
          * `name` (`pulumi.Input[str]`) - The name of the document.
          * `type` (`pulumi.Input[str]`)
        
        The **permissions** object supports the following:
        
          * `account_ids` (`pulumi.Input[str]`)
          * `type` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/ssm_document.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["arn"] = arn
        __props__["attachments_sources"] = attachments_sources
        __props__["content"] = content
        __props__["created_date"] = created_date
        __props__["default_version"] = default_version
        __props__["description"] = description
        __props__["document_format"] = document_format
        __props__["document_type"] = document_type
        __props__["hash"] = hash
        __props__["hash_type"] = hash_type
        __props__["latest_version"] = latest_version
        __props__["name"] = name
        __props__["owner"] = owner
        __props__["parameters"] = parameters
        __props__["permissions"] = permissions
        __props__["platform_types"] = platform_types
        __props__["schema_version"] = schema_version
        __props__["status"] = status
        __props__["tags"] = tags
        __props__["target_type"] = target_type
        return Document(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

