# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime

class GetArnResult(object):
    """
    A collection of values returned by getArn.
    """
    def __init__(__self__, account=None, partition=None, region=None, resource=None, service=None):
        if account and not isinstance(account, basestring):
            raise TypeError('Expected argument account to be a basestring')
        __self__.account = account
        """
        The [ID](https://docs.aws.amazon.com/general/latest/gr/acct-identifiers.html) of the AWS account that owns the resource, without the hyphens.
        """
        if partition and not isinstance(partition, basestring):
            raise TypeError('Expected argument partition to be a basestring')
        __self__.partition = partition
        """
        The partition that the resource is in.
        """
        if region and not isinstance(region, basestring):
            raise TypeError('Expected argument region to be a basestring')
        __self__.region = region
        """
        The region the resource resides in.
        Note that the ARNs for some resources do not require a region, so this component might be omitted.
        """
        if resource and not isinstance(resource, basestring):
            raise TypeError('Expected argument resource to be a basestring')
        __self__.resource = resource
        """
        The content of this part of the ARN varies by service.
        It often includes an indicator of the type of resource—for example, an IAM user or Amazon RDS database —followed by a slash (/) or a colon (:), followed by the resource name itself.
        """
        if service and not isinstance(service, basestring):
            raise TypeError('Expected argument service to be a basestring')
        __self__.service = service
        """
        The [service namespace](https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html#genref-aws-service-namespaces) that identifies the AWS product.
        """

def get_arn(arn=None):
    """
    Parses an Amazon Resource Name (ARN) into its constituent parts.
    """
    __args__ = dict()

    __args__['arn'] = arn
    __ret__ = pulumi.runtime.invoke('aws:index/getArn:getArn', __args__)

    return GetArnResult(
        account=__ret__.get('account'),
        partition=__ret__.get('partition'),
        region=__ret__.get('region'),
        resource=__ret__.get('resource'),
        service=__ret__.get('service'))