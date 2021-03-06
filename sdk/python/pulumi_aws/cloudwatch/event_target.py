# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class EventTarget(pulumi.CustomResource):
    arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) associated of the target.
    """
    batch_target: pulumi.Output[dict]
    """
    Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.
    
      * `arraySize` (`float`) - The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.
      * `jobAttempts` (`float`) - The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.
      * `jobDefinition` (`str`) - The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.
      * `jobName` (`str`) - The name to use for this execution of the job, if the target is an AWS Batch job.
    """
    ecs_target: pulumi.Output[dict]
    """
    Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.
    
      * `group` (`str`) - Specifies an ECS task group for the task. The maximum length is 255 characters.
      * `launchType` (`str`) - Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values are EC2 or FARGATE.
      * `networkConfiguration` (`dict`) - Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.
    
        * `assignPublicIp` (`bool`) - Assign a public IP address to the ENI (Fargate launch type only). Valid values are `true` or `false`. Default `false`.
        * `security_groups` (`list`) - The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.
        * `subnets` (`list`) - The subnets associated with the task or service.
    
      * `platformVersion` (`str`) - Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see [AWS Fargate Platform Versions](http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
      * `taskCount` (`float`) - The number of tasks to create based on the TaskDefinition. The default is 1.
      * `taskDefinitionArn` (`str`) - The ARN of the task definition to use if the event target is an Amazon ECS cluster.
    """
    input: pulumi.Output[str]
    """
    Valid JSON text passed to the target.
    """
    input_path: pulumi.Output[str]
    """
    The value of the [JSONPath](http://goessner.net/articles/JsonPath/)
    that is used for extracting part of the matched event when passing it to the target.
    """
    input_transformer: pulumi.Output[dict]
    """
    Parameters used when you are providing a custom input to a target based on certain event data.
    
      * `inputPaths` (`dict`) - Key value pairs specified in the form of JSONPath (for example, time = $.time)
      * `inputTemplate` (`str`) - Structure containing the template body.
    """
    kinesis_target: pulumi.Output[dict]
    """
    Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.
    
      * `partitionKeyPath` (`str`) - The JSON path to be extracted from the event and used as the partition key.
    """
    role_arn: pulumi.Output[str]
    """
    The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if `ecs_target` is used.
    """
    rule: pulumi.Output[str]
    """
    The name of the rule you want to add targets to.
    """
    run_command_targets: pulumi.Output[list]
    """
    Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.
    
      * `key` (`str`) - Can be either `tag:tag-key` or `InstanceIds`.
      * `values` (`list`) - If Key is `tag:tag-key`, Values is a list of tag values. If Key is `InstanceIds`, Values is a list of Amazon EC2 instance IDs.
    """
    sqs_target: pulumi.Output[dict]
    """
    Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.
    
      * `messageGroupId` (`str`) - The FIFO message group ID to use as the target.
    """
    target_id: pulumi.Output[str]
    """
    The unique target assignment ID.  If missing, will generate a random, unique id.
    """
    def __init__(__self__, resource_name, opts=None, arn=None, batch_target=None, ecs_target=None, input=None, input_path=None, input_transformer=None, kinesis_target=None, role_arn=None, rule=None, run_command_targets=None, sqs_target=None, target_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Provides a CloudWatch Event Target resource.
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The Amazon Resource Name (ARN) associated of the target.
        :param pulumi.Input[dict] batch_target: Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[dict] ecs_target: Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] input: Valid JSON text passed to the target.
        :param pulumi.Input[str] input_path: The value of the [JSONPath](http://goessner.net/articles/JsonPath/)
               that is used for extracting part of the matched event when passing it to the target.
        :param pulumi.Input[dict] input_transformer: Parameters used when you are providing a custom input to a target based on certain event data.
        :param pulumi.Input[dict] kinesis_target: Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if `ecs_target` is used.
        :param pulumi.Input[str] rule: The name of the rule you want to add targets to.
        :param pulumi.Input[list] run_command_targets: Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.
        :param pulumi.Input[dict] sqs_target: Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] target_id: The unique target assignment ID.  If missing, will generate a random, unique id.
        
        The **batch_target** object supports the following:
        
          * `arraySize` (`pulumi.Input[float]`) - The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.
          * `jobAttempts` (`pulumi.Input[float]`) - The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.
          * `jobDefinition` (`pulumi.Input[str]`) - The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.
          * `jobName` (`pulumi.Input[str]`) - The name to use for this execution of the job, if the target is an AWS Batch job.
        
        The **ecs_target** object supports the following:
        
          * `group` (`pulumi.Input[str]`) - Specifies an ECS task group for the task. The maximum length is 255 characters.
          * `launchType` (`pulumi.Input[str]`) - Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values are EC2 or FARGATE.
          * `networkConfiguration` (`pulumi.Input[dict]`) - Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.
        
            * `assignPublicIp` (`pulumi.Input[bool]`) - Assign a public IP address to the ENI (Fargate launch type only). Valid values are `true` or `false`. Default `false`.
            * `security_groups` (`pulumi.Input[list]`) - The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.
            * `subnets` (`pulumi.Input[list]`) - The subnets associated with the task or service.
        
          * `platformVersion` (`pulumi.Input[str]`) - Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see [AWS Fargate Platform Versions](http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
          * `taskCount` (`pulumi.Input[float]`) - The number of tasks to create based on the TaskDefinition. The default is 1.
          * `taskDefinitionArn` (`pulumi.Input[str]`) - The ARN of the task definition to use if the event target is an Amazon ECS cluster.
        
        The **input_transformer** object supports the following:
        
          * `inputPaths` (`pulumi.Input[dict]`) - Key value pairs specified in the form of JSONPath (for example, time = $.time)
          * `inputTemplate` (`pulumi.Input[str]`) - Structure containing the template body.
        
        The **kinesis_target** object supports the following:
        
          * `partitionKeyPath` (`pulumi.Input[str]`) - The JSON path to be extracted from the event and used as the partition key.
        
        The **run_command_targets** object supports the following:
        
          * `key` (`pulumi.Input[str]`) - Can be either `tag:tag-key` or `InstanceIds`.
          * `values` (`pulumi.Input[list]`) - If Key is `tag:tag-key`, Values is a list of tag values. If Key is `InstanceIds`, Values is a list of Amazon EC2 instance IDs.
        
        The **sqs_target** object supports the following:
        
          * `messageGroupId` (`pulumi.Input[str]`) - The FIFO message group ID to use as the target.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/cloudwatch_event_target.html.markdown.
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

            if arn is None:
                raise TypeError("Missing required property 'arn'")
            __props__['arn'] = arn
            __props__['batch_target'] = batch_target
            __props__['ecs_target'] = ecs_target
            __props__['input'] = input
            __props__['input_path'] = input_path
            __props__['input_transformer'] = input_transformer
            __props__['kinesis_target'] = kinesis_target
            __props__['role_arn'] = role_arn
            if rule is None:
                raise TypeError("Missing required property 'rule'")
            __props__['rule'] = rule
            __props__['run_command_targets'] = run_command_targets
            __props__['sqs_target'] = sqs_target
            __props__['target_id'] = target_id
        super(EventTarget, __self__).__init__(
            'aws:cloudwatch/eventTarget:EventTarget',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, arn=None, batch_target=None, ecs_target=None, input=None, input_path=None, input_transformer=None, kinesis_target=None, role_arn=None, rule=None, run_command_targets=None, sqs_target=None, target_id=None):
        """
        Get an existing EventTarget resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.
        
        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] arn: The Amazon Resource Name (ARN) associated of the target.
        :param pulumi.Input[dict] batch_target: Parameters used when you are using the rule to invoke an Amazon Batch Job. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[dict] ecs_target: Parameters used when you are using the rule to invoke Amazon ECS Task. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] input: Valid JSON text passed to the target.
        :param pulumi.Input[str] input_path: The value of the [JSONPath](http://goessner.net/articles/JsonPath/)
               that is used for extracting part of the matched event when passing it to the target.
        :param pulumi.Input[dict] input_transformer: Parameters used when you are providing a custom input to a target based on certain event data.
        :param pulumi.Input[dict] kinesis_target: Parameters used when you are using the rule to invoke an Amazon Kinesis Stream. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] role_arn: The Amazon Resource Name (ARN) of the IAM role to be used for this target when the rule is triggered. Required if `ecs_target` is used.
        :param pulumi.Input[str] rule: The name of the rule you want to add targets to.
        :param pulumi.Input[list] run_command_targets: Parameters used when you are using the rule to invoke Amazon EC2 Run Command. Documented below. A maximum of 5 are allowed.
        :param pulumi.Input[dict] sqs_target: Parameters used when you are using the rule to invoke an Amazon SQS Queue. Documented below. A maximum of 1 are allowed.
        :param pulumi.Input[str] target_id: The unique target assignment ID.  If missing, will generate a random, unique id.
        
        The **batch_target** object supports the following:
        
          * `arraySize` (`pulumi.Input[float]`) - The size of the array, if this is an array batch job. Valid values are integers between 2 and 10,000.
          * `jobAttempts` (`pulumi.Input[float]`) - The number of times to attempt to retry, if the job fails. Valid values are 1 to 10.
          * `jobDefinition` (`pulumi.Input[str]`) - The ARN or name of the job definition to use if the event target is an AWS Batch job. This job definition must already exist.
          * `jobName` (`pulumi.Input[str]`) - The name to use for this execution of the job, if the target is an AWS Batch job.
        
        The **ecs_target** object supports the following:
        
          * `group` (`pulumi.Input[str]`) - Specifies an ECS task group for the task. The maximum length is 255 characters.
          * `launchType` (`pulumi.Input[str]`) - Specifies the launch type on which your task is running. The launch type that you specify here must match one of the launch type (compatibilities) of the target task. Valid values are EC2 or FARGATE.
          * `networkConfiguration` (`pulumi.Input[dict]`) - Use this if the ECS task uses the awsvpc network mode. This specifies the VPC subnets and security groups associated with the task, and whether a public IP address is to be used. Required if launch_type is FARGATE because the awsvpc mode is required for Fargate tasks.
        
            * `assignPublicIp` (`pulumi.Input[bool]`) - Assign a public IP address to the ENI (Fargate launch type only). Valid values are `true` or `false`. Default `false`.
            * `security_groups` (`pulumi.Input[list]`) - The security groups associated with the task or service. If you do not specify a security group, the default security group for the VPC is used.
            * `subnets` (`pulumi.Input[list]`) - The subnets associated with the task or service.
        
          * `platformVersion` (`pulumi.Input[str]`) - Specifies the platform version for the task. Specify only the numeric portion of the platform version, such as 1.1.0. This is used only if LaunchType is FARGATE. For more information about valid platform versions, see [AWS Fargate Platform Versions](http://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html).
          * `taskCount` (`pulumi.Input[float]`) - The number of tasks to create based on the TaskDefinition. The default is 1.
          * `taskDefinitionArn` (`pulumi.Input[str]`) - The ARN of the task definition to use if the event target is an Amazon ECS cluster.
        
        The **input_transformer** object supports the following:
        
          * `inputPaths` (`pulumi.Input[dict]`) - Key value pairs specified in the form of JSONPath (for example, time = $.time)
          * `inputTemplate` (`pulumi.Input[str]`) - Structure containing the template body.
        
        The **kinesis_target** object supports the following:
        
          * `partitionKeyPath` (`pulumi.Input[str]`) - The JSON path to be extracted from the event and used as the partition key.
        
        The **run_command_targets** object supports the following:
        
          * `key` (`pulumi.Input[str]`) - Can be either `tag:tag-key` or `InstanceIds`.
          * `values` (`pulumi.Input[list]`) - If Key is `tag:tag-key`, Values is a list of tag values. If Key is `InstanceIds`, Values is a list of Amazon EC2 instance IDs.
        
        The **sqs_target** object supports the following:
        
          * `messageGroupId` (`pulumi.Input[str]`) - The FIFO message group ID to use as the target.

        > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/cloudwatch_event_target.html.markdown.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()
        __props__["arn"] = arn
        __props__["batch_target"] = batch_target
        __props__["ecs_target"] = ecs_target
        __props__["input"] = input
        __props__["input_path"] = input_path
        __props__["input_transformer"] = input_transformer
        __props__["kinesis_target"] = kinesis_target
        __props__["role_arn"] = role_arn
        __props__["rule"] = rule
        __props__["run_command_targets"] = run_command_targets
        __props__["sqs_target"] = sqs_target
        __props__["target_id"] = target_id
        return EventTarget(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

