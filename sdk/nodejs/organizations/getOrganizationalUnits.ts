// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Get all direct child organizational units under a parent organizational unit. This only provides immediate children, not all children.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/d/organizations_organizational_units.html.markdown.
 */
export function getOrganizationalUnits(args: GetOrganizationalUnitsArgs, opts?: pulumi.InvokeOptions): Promise<GetOrganizationalUnitsResult> & GetOrganizationalUnitsResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetOrganizationalUnitsResult> = pulumi.runtime.invoke("aws:organizations/getOrganizationalUnits:getOrganizationalUnits", {
        "parentId": args.parentId,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getOrganizationalUnits.
 */
export interface GetOrganizationalUnitsArgs {
    /**
     * The parent ID of the organizational unit.
     */
    readonly parentId: string;
}

/**
 * A collection of values returned by getOrganizationalUnits.
 */
export interface GetOrganizationalUnitsResult {
    /**
     * List of child organizational units, which have the following attributes:
     */
    readonly childrens: outputs.organizations.GetOrganizationalUnitsChildren[];
    readonly parentId: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
