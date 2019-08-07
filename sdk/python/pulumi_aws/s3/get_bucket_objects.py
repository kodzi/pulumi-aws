# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class GetBucketObjectsResult:
    """
    A collection of values returned by getBucketObjects.
    """
    def __init__(__self__, bucket=None, common_prefixes=None, delimiter=None, encoding_type=None, fetch_owner=None, keys=None, max_keys=None, owners=None, prefix=None, start_after=None, id=None):
        if bucket and not isinstance(bucket, str):
            raise TypeError("Expected argument 'bucket' to be a str")
        __self__.bucket = bucket
        if common_prefixes and not isinstance(common_prefixes, list):
            raise TypeError("Expected argument 'common_prefixes' to be a list")
        __self__.common_prefixes = common_prefixes
        """
        List of any keys between `prefix` and the next occurrence of `delimiter` (i.e., similar to subdirectories of the `prefix` "directory"); the list is only returned when you specify `delimiter`
        """
        if delimiter and not isinstance(delimiter, str):
            raise TypeError("Expected argument 'delimiter' to be a str")
        __self__.delimiter = delimiter
        if encoding_type and not isinstance(encoding_type, str):
            raise TypeError("Expected argument 'encoding_type' to be a str")
        __self__.encoding_type = encoding_type
        if fetch_owner and not isinstance(fetch_owner, bool):
            raise TypeError("Expected argument 'fetch_owner' to be a bool")
        __self__.fetch_owner = fetch_owner
        if keys and not isinstance(keys, list):
            raise TypeError("Expected argument 'keys' to be a list")
        __self__.keys = keys
        """
        List of strings representing object keys
        """
        if max_keys and not isinstance(max_keys, float):
            raise TypeError("Expected argument 'max_keys' to be a float")
        __self__.max_keys = max_keys
        if owners and not isinstance(owners, list):
            raise TypeError("Expected argument 'owners' to be a list")
        __self__.owners = owners
        """
        List of strings representing object owner IDs (see `fetch_owner` above)
        """
        if prefix and not isinstance(prefix, str):
            raise TypeError("Expected argument 'prefix' to be a str")
        __self__.prefix = prefix
        if start_after and not isinstance(start_after, str):
            raise TypeError("Expected argument 'start_after' to be a str")
        __self__.start_after = start_after
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """
class AwaitableGetBucketObjectsResult(GetBucketObjectsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetBucketObjectsResult(
            bucket=self.bucket,
            common_prefixes=self.common_prefixes,
            delimiter=self.delimiter,
            encoding_type=self.encoding_type,
            fetch_owner=self.fetch_owner,
            keys=self.keys,
            max_keys=self.max_keys,
            owners=self.owners,
            prefix=self.prefix,
            start_after=self.start_after,
            id=self.id)

def get_bucket_objects(bucket=None,delimiter=None,encoding_type=None,fetch_owner=None,max_keys=None,prefix=None,start_after=None,opts=None):
    """
    > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/s3_bucket_objects.html.markdown.
    """
    __args__ = dict()

    __args__['bucket'] = bucket
    __args__['delimiter'] = delimiter
    __args__['encodingType'] = encoding_type
    __args__['fetchOwner'] = fetch_owner
    __args__['maxKeys'] = max_keys
    __args__['prefix'] = prefix
    __args__['startAfter'] = start_after
    if opts is None:
        opts = pulumi.ResourceOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('aws:s3/getBucketObjects:getBucketObjects', __args__, opts=opts).value

    return AwaitableGetBucketObjectsResult(
        bucket=__ret__.get('bucket'),
        common_prefixes=__ret__.get('commonPrefixes'),
        delimiter=__ret__.get('delimiter'),
        encoding_type=__ret__.get('encodingType'),
        fetch_owner=__ret__.get('fetchOwner'),
        keys=__ret__.get('keys'),
        max_keys=__ret__.get('maxKeys'),
        owners=__ret__.get('owners'),
        prefix=__ret__.get('prefix'),
        start_after=__ret__.get('startAfter'),
        id=__ret__.get('id'))
