# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Function(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) identifying your Lambda Function.
    """
    dead_letter_config: pulumi.Output[dict]
    """
    Nested block to configure the function's *dead letter queue*. See details below.
    
      * `target_arn` (`str`) - The ARN of an SNS topic or SQS queue to notify when an invocation fails. If this
        option is used, the function's IAM role must be granted suitable access to write to the target object,
        which means allowing either the `sns:Publish` or `sqs:SendMessage` action on this ARN, depending on
        which service is targeted.
    """
    description: pulumi.Output[str]
    """
    Description of what your Lambda Function does.
    """
    environment: pulumi.Output[dict]
    """
    The Lambda environment's configuration settings. Fields documented below.
    
      * `variables` (`dict`) - A map that defines environment variables for the Lambda function.
    """
    code: pulumi.Output[pulumi.Archive]
    """
    The path to the function's deployment package within the local filesystem. If defined, The `s3_`-prefixed options cannot be used.
    """
    name: pulumi.Output[str]
    """
    A unique name for your Lambda Function.
    """
    handler: pulumi.Output[str]
    """
    The function [entrypoint][3] in your code.
    """
    invoke_arn: pulumi.Output[str]
    """
    The ARN to be used for invoking Lambda Function from API Gateway - to be used in [`apigateway.Integration`](https://www.terraform.io/docs/providers/aws/r/api_gateway_integration.html)'s `uri`
    """
    kms_key_arn: pulumi.Output[str]
    """
    The ARN for the KMS encryption key.
    """
    last_modified: pulumi.Output[str]
    """
    The date this resource was last modified.
    """
    layers: pulumi.Output[list]
    """
    List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function. See [Lambda Layers][10]
    """
    memory_size: pulumi.Output[float]
    """
    Amount of memory in MB your Lambda Function can use at runtime. Defaults to `128`. See [Limits][5]
    """
    publish: pulumi.Output[bool]
    """
    Whether to publish creation/change as new Lambda Function Version. Defaults to `false`.
    """
    qualified_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) identifying your Lambda Function Version
    (if versioning is enabled via `publish = true`).
    """
    reserved_concurrent_executions: pulumi.Output[float]
    """
    The amount of reserved concurrent executions for this lambda function. A value of `0` disables lambda from being triggered and `-1` removes any concurrency limitations. Defaults to Unreserved Concurrency Limits `-1`. See [Managing Concurrency][9]
    """
    role: pulumi.Output[str]
    """
    IAM role attached to the Lambda Function. This governs both who / what can invoke your Lambda Function, as well as what resources our Lambda Function has access to. See [Lambda Permission Model][4] for more details.
    """
    runtime: pulumi.Output[str]
    """
    See [Runtimes][6] for valid values.
    """
    s3_bucket: pulumi.Output[str]
    """
    The S3 bucket location containing the function's deployment package. Conflicts with `filename`. This bucket must reside in the same AWS region where you are creating the Lambda function.
    """
    s3_key: pulumi.Output[str]
    """
    The S3 key of an object containing the function's deployment package. Conflicts with `filename`.
    """
    s3_object_version: pulumi.Output[str]
    """
    The object version containing the function's deployment package. Conflicts with `filename`.
    """
    source_code_hash: pulumi.Output[str]
    """
    Used to trigger updates. Must be set to a base64-encoded SHA256 hash of the package file specified with either `filename` or `s3_key`. The usual way to set this is `filebase64sha256("file.zip")` (this provider 0.11.12 and later) or `base64sha256(file("file.zip"))` (this provider 0.11.11 and earlier), where "file.zip" is the local filename of the lambda function source archive.
    """
    source_code_size: pulumi.Output[float]
    """
    The size in bytes of the function .zip file.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the object.
    """
    timeout: pulumi.Output[float]
    """
    The amount of time your Lambda Function has to run in seconds. Defaults to `3`. See [Limits][5]
    """
    tracing_config: pulumi.Output[dict]
    version: pulumi.Output[str]
    """
    Latest published version of your Lambda Function.
    """
    vpc_config: pulumi.Output[dict]
    """
    Provide this to allow your function to access your VPC. Fields documented below. See [Lambda in VPC][7]
    
      * `security_group_ids` (`list`) - A list of security group IDs associated with the Lambda function.
      * `subnet_ids` (`list`) - A list of subnet IDs associated with the Lambda function.
      * `vpc_id` (`str`)
    """
    def __init__(__self__, resource_name, opts=None, dead_letter_config=None, description=None, environment=None, code=None, name=None, handler=None, kms_key_arn=None, layers=None, memory_size=None, publish=None, reserved_concurrent_executions=None, role=None, runtime=None, s3_bucket=None, s3_key=None, s3_object_version=None, source_code_hash=None, tags=None, timeout=None, tracing_config=None, vpc_config=None, __props__=None, __name__=None, __opts__=None):
        """
        Create a Function resource with the given unique name, props, and options.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] dead_letter_config: Nested block to configure the function's *dead letter queue*. See details below.
        :param pulumi.Input[str] description: Description of what your Lambda Function does.
        :param pulumi.Input[dict] environment: The Lambda environment's configuration settings. Fields documented below.
        :param pulumi.Input[pulumi.Archive] code: The path to the function's deployment package within the local filesystem. If defined, The `s3_`-prefixed options cannot be used.
        :param pulumi.Input[str] name: A unique name for your Lambda Function.
        :param pulumi.Input[str] handler: The function [entrypoint][3] in your code.
        :param pulumi.Input[str] kms_key_arn: The ARN for the KMS encryption key.
        :param pulumi.Input[list] layers: List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function. See [Lambda Layers][10]
        :param pulumi.Input[float] memory_size: Amount of memory in MB your Lambda Function can use at runtime. Defaults to `128`. See [Limits][5]
        :param pulumi.Input[bool] publish: Whether to publish creation/change as new Lambda Function Version. Defaults to `false`.
        :param pulumi.Input[float] reserved_concurrent_executions: The amount of reserved concurrent executions for this lambda function. A value of `0` disables lambda from being triggered and `-1` removes any concurrency limitations. Defaults to Unreserved Concurrency Limits `-1`. See [Managing Concurrency][9]
        :param pulumi.Input[str] role: IAM role attached to the Lambda Function. This governs both who / what can invoke your Lambda Function, as well as what resources our Lambda Function has access to. See [Lambda Permission Model][4] for more details.
        :param pulumi.Input[str] runtime: See [Runtimes][6] for valid values.
        :param pulumi.Input[str] s3_bucket: The S3 bucket location containing the function's deployment package. Conflicts with `filename`. This bucket must reside in the same AWS region where you are creating the Lambda function.
        :param pulumi.Input[str] s3_key: The S3 key of an object containing the function's deployment package. Conflicts with `filename`.
        :param pulumi.Input[str] s3_object_version: The object version containing the function's deployment package. Conflicts with `filename`.
        :param pulumi.Input[str] source_code_hash: Used to trigger updates. Must be set to a base64-encoded SHA256 hash of the package file specified with either `filename` or `s3_key`. The usual way to set this is `filebase64sha256("file.zip")` (this provider 0.11.12 and later) or `base64sha256(file("file.zip"))` (this provider 0.11.11 and earlier), where "file.zip" is the local filename of the lambda function source archive.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the object.
        :param pulumi.Input[float] timeout: The amount of time your Lambda Function has to run in seconds. Defaults to `3`. See [Limits][5]
        :param pulumi.Input[dict] vpc_config: Provide this to allow your function to access your VPC. Fields documented below. See [Lambda in VPC][7]
        
        The **dead_letter_config** object supports the following:
        
          * `target_arn` (`pulumi.Input[str]`) - The ARN of an SNS topic or SQS queue to notify when an invocation fails. If this
            option is used, the function's IAM role must be granted suitable access to write to the target object,
            which means allowing either the `sns:Publish` or `sqs:SendMessage` action on this ARN, depending on
            which service is targeted.
        
        The **environment** object supports the following:
        
          * `variables` (`pulumi.Input[dict]`) - A map that defines environment variables for the Lambda function.
        
        The **tracing_config** object supports the following:
        
          * `mode` (`pulumi.Input[str]`) - Can be either `PassThrough` or `Active`. If PassThrough, Lambda will only trace
            the request from an upstream service if it contains a tracing header with
            "sampled=1". If Active, Lambda will respect any tracing header it receives
            from an upstream service. If no tracing header is received, Lambda will call
            X-Ray for a tracing decision.
        
        The **vpc_config** object supports the following:
        
          * `security_group_ids` (`pulumi.Input[list]`) - A list of security group IDs associated with the Lambda function.
          * `subnet_ids` (`pulumi.Input[list]`) - A list of subnet IDs associated with the Lambda function.
          * `vpc_id` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/lambda_function.html.markdown.
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

            __props__['dead_letter_config'] = dead_letter_config
            __props__['description'] = description
            __props__['environment'] = environment
            __props__['code'] = code
            __props__['name'] = name
            if handler is None:
                raise TypeError("Missing required property 'handler'")
            __props__['handler'] = handler
            __props__['kms_key_arn'] = kms_key_arn
            __props__['layers'] = layers
            __props__['memory_size'] = memory_size
            __props__['publish'] = publish
            __props__['reserved_concurrent_executions'] = reserved_concurrent_executions
            if role is None:
                raise TypeError("Missing required property 'role'")
            __props__['role'] = role
            if runtime is None:
                raise TypeError("Missing required property 'runtime'")
            __props__['runtime'] = runtime
            __props__['s3_bucket'] = s3_bucket
            __props__['s3_key'] = s3_key
            __props__['s3_object_version'] = s3_object_version
            __props__['source_code_hash'] = source_code_hash
            __props__['tags'] = tags
            __props__['timeout'] = timeout
            __props__['tracing_config'] = tracing_config
            __props__['vpc_config'] = vpc_config
            __props__['arn'] = None
            __props__['invoke_arn'] = None
            __props__['last_modified'] = None
            __props__['qualified_arn'] = None
            __props__['source_code_size'] = None
            __props__['version'] = None
        super(Function, __self__).__init__(
            'aws:lambda/function:Function',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, dead_letter_config=None, description=None, environment=None, code=None, name=None, handler=None, invoke_arn=None, kms_key_arn=None, last_modified=None, layers=None, memory_size=None, publish=None, qualified_arn=None, reserved_concurrent_executions=None, role=None, runtime=None, s3_bucket=None, s3_key=None, s3_object_version=None, source_code_hash=None, source_code_size=None, tags=None, timeout=None, tracing_config=None, version=None, vpc_config=None):
        """
        Get an existing Function resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The Amazon Resource Name (ARN) identifying your Lambda Function.
        :param pulumi.Input[dict] dead_letter_config: Nested block to configure the function's *dead letter queue*. See details below.
        :param pulumi.Input[str] description: Description of what your Lambda Function does.
        :param pulumi.Input[dict] environment: The Lambda environment's configuration settings. Fields documented below.
        :param pulumi.Input[pulumi.Archive] code: The path to the function's deployment package within the local filesystem. If defined, The `s3_`-prefixed options cannot be used.
        :param pulumi.Input[str] name: A unique name for your Lambda Function.
        :param pulumi.Input[str] handler: The function [entrypoint][3] in your code.
        :param pulumi.Input[str] invoke_arn: The ARN to be used for invoking Lambda Function from API Gateway - to be used in [`apigateway.Integration`](https://www.terraform.io/docs/providers/aws/r/api_gateway_integration.html)'s `uri`
        :param pulumi.Input[str] kms_key_arn: The ARN for the KMS encryption key.
        :param pulumi.Input[str] last_modified: The date this resource was last modified.
        :param pulumi.Input[list] layers: List of Lambda Layer Version ARNs (maximum of 5) to attach to your Lambda Function. See [Lambda Layers][10]
        :param pulumi.Input[float] memory_size: Amount of memory in MB your Lambda Function can use at runtime. Defaults to `128`. See [Limits][5]
        :param pulumi.Input[bool] publish: Whether to publish creation/change as new Lambda Function Version. Defaults to `false`.
        :param pulumi.Input[str] qualified_arn: The Amazon Resource Name (ARN) identifying your Lambda Function Version
               (if versioning is enabled via `publish = true`).
        :param pulumi.Input[float] reserved_concurrent_executions: The amount of reserved concurrent executions for this lambda function. A value of `0` disables lambda from being triggered and `-1` removes any concurrency limitations. Defaults to Unreserved Concurrency Limits `-1`. See [Managing Concurrency][9]
        :param pulumi.Input[str] role: IAM role attached to the Lambda Function. This governs both who / what can invoke your Lambda Function, as well as what resources our Lambda Function has access to. See [Lambda Permission Model][4] for more details.
        :param pulumi.Input[str] runtime: See [Runtimes][6] for valid values.
        :param pulumi.Input[str] s3_bucket: The S3 bucket location containing the function's deployment package. Conflicts with `filename`. This bucket must reside in the same AWS region where you are creating the Lambda function.
        :param pulumi.Input[str] s3_key: The S3 key of an object containing the function's deployment package. Conflicts with `filename`.
        :param pulumi.Input[str] s3_object_version: The object version containing the function's deployment package. Conflicts with `filename`.
        :param pulumi.Input[str] source_code_hash: Used to trigger updates. Must be set to a base64-encoded SHA256 hash of the package file specified with either `filename` or `s3_key`. The usual way to set this is `filebase64sha256("file.zip")` (this provider 0.11.12 and later) or `base64sha256(file("file.zip"))` (this provider 0.11.11 and earlier), where "file.zip" is the local filename of the lambda function source archive.
        :param pulumi.Input[float] source_code_size: The size in bytes of the function .zip file.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the object.
        :param pulumi.Input[float] timeout: The amount of time your Lambda Function has to run in seconds. Defaults to `3`. See [Limits][5]
        :param pulumi.Input[str] version: Latest published version of your Lambda Function.
        :param pulumi.Input[dict] vpc_config: Provide this to allow your function to access your VPC. Fields documented below. See [Lambda in VPC][7]
        
        The **dead_letter_config** object supports the following:
        
          * `target_arn` (`pulumi.Input[str]`) - The ARN of an SNS topic or SQS queue to notify when an invocation fails. If this
            option is used, the function's IAM role must be granted suitable access to write to the target object,
            which means allowing either the `sns:Publish` or `sqs:SendMessage` action on this ARN, depending on
            which service is targeted.
        
        The **environment** object supports the following:
        
          * `variables` (`pulumi.Input[dict]`) - A map that defines environment variables for the Lambda function.
        
        The **tracing_config** object supports the following:
        
          * `mode` (`pulumi.Input[str]`) - Can be either `PassThrough` or `Active`. If PassThrough, Lambda will only trace
            the request from an upstream service if it contains a tracing header with
            "sampled=1". If Active, Lambda will respect any tracing header it receives
            from an upstream service. If no tracing header is received, Lambda will call
            X-Ray for a tracing decision.
        
        The **vpc_config** object supports the following:
        
          * `security_group_ids` (`pulumi.Input[list]`) - A list of security group IDs associated with the Lambda function.
          * `subnet_ids` (`pulumi.Input[list]`) - A list of subnet IDs associated with the Lambda function.
          * `vpc_id` (`pulumi.Input[str]`)

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/lambda_function.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["arn"] = arn
        __props__["dead_letter_config"] = dead_letter_config
        __props__["description"] = description
        __props__["environment"] = environment
        __props__["code"] = code
        __props__["name"] = name
        __props__["handler"] = handler
        __props__["invoke_arn"] = invoke_arn
        __props__["kms_key_arn"] = kms_key_arn
        __props__["last_modified"] = last_modified
        __props__["layers"] = layers
        __props__["memory_size"] = memory_size
        __props__["publish"] = publish
        __props__["qualified_arn"] = qualified_arn
        __props__["reserved_concurrent_executions"] = reserved_concurrent_executions
        __props__["role"] = role
        __props__["runtime"] = runtime
        __props__["s3_bucket"] = s3_bucket
        __props__["s3_key"] = s3_key
        __props__["s3_object_version"] = s3_object_version
        __props__["source_code_hash"] = source_code_hash
        __props__["source_code_size"] = source_code_size
        __props__["tags"] = tags
        __props__["timeout"] = timeout
        __props__["tracing_config"] = tracing_config
        __props__["version"] = version
        __props__["vpc_config"] = vpc_config
        return Function(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

