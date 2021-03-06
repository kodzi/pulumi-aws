// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * Use this data source to get the access to the effective Account ID, User ID, and ARN in
 * which this provider is authorized.
 * 
 * ## Example Usage
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as aws from "@pulumi/aws";
 * 
 * const current = aws.getCallerIdentity();
 * 
 * export const accountId = current.accountId;
 * export const callerArn = current.arn;
 * export const callerUser = current.userId;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/caller_identity.html.markdown.
 */
export function getCallerIdentity(opts?: pulumi.InvokeOptions): Promise<GetCallerIdentityResult> & GetCallerIdentityResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetCallerIdentityResult> = pulumi.runtime.invoke("aws:index/getCallerIdentity:getCallerIdentity", {
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of values returned by getCallerIdentity.
 */
export interface GetCallerIdentityResult {
    /**
     * The AWS Account ID number of the account that owns or contains the calling entity.
     */
    readonly accountId: string;
    /**
     * The AWS ARN associated with the calling entity.
     */
    readonly arn: string;
    /**
     * The unique identifier of the calling entity.
     */
    readonly userId: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
