// Copyright 2016-2017, Pulumi Corporation.  All rights reserved.

import * as aws from "@pulumi/aws";
import { Output } from "@pulumi/pulumi";
import { getLinuxAMI } from "./linuxAmi";

let size = aws.ec2.InstanceTypes.T2_Micro;

let group = new aws.ec2.SecurityGroup("web-secgrp-2", {
    description: "Enable HTTP access",
    ingress: [
        { protocol: aws.ec2.TCPProtocol, fromPort: 80, toPort: 80, cidrBlocks: ["0.0.0.0/0"] },
    ],
});

let server = new aws.ec2.Instance("web-server-www", {
    instanceType: size,
    securityGroups: [ group.name ],
    ami: getLinuxAMI(size),
});

export let publicIp = server.publicIp;
export let publicDns = server.publicDns;
