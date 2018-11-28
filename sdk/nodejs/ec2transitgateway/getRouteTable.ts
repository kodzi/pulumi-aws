// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Get information on an EC2 Transit Gateway Route Table.
 */
export function getRouteTable(args?: GetRouteTableArgs, opts?: pulumi.InvokeOptions): Promise<GetRouteTableResult> {
    args = args || {};
    return pulumi.runtime.invoke("aws:ec2transitgateway/getRouteTable:getRouteTable", {
        "filters": args.filters,
        "id": args.id,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getRouteTable.
 */
export interface GetRouteTableArgs {
    /**
     * One or more configuration blocks containing name-values filters. Detailed below.
     */
    readonly filters?: { name: string, values: string[] }[];
    /**
     * Identifier of the EC2 Transit Gateway Route Table.
     */
    readonly id?: string;
    readonly tags?: {[key: string]: any};
}

/**
 * A collection of values returned by getRouteTable.
 */
export interface GetRouteTableResult {
    /**
     * Boolean whether this is the default association route table for the EC2 Transit Gateway
     */
    readonly defaultAssociationRouteTable: boolean;
    /**
     * Boolean whether this is the default propagation route table for the EC2 Transit Gateway
     */
    readonly defaultPropagationRouteTable: boolean;
    /**
     * Key-value tags for the EC2 Transit Gateway Route Table
     */
    readonly tags: {[key: string]: any};
    /**
     * EC2 Transit Gateway identifier
     */
    readonly transitGatewayId: string;
}
