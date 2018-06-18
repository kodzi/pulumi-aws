// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package redshift

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Provides details about a specific redshift cluster.
func LookupCluster(ctx *pulumi.Context, args *GetClusterArgs) (*GetClusterResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["clusterIdentifier"] = args.ClusterIdentifier
		inputs["tags"] = args.Tags
	}
	outputs, err := ctx.Invoke("aws:redshift/getCluster:getCluster", inputs)
	if err != nil {
		return nil, err
	}
	return &GetClusterResult{
		AllowVersionUpgrade: outputs["allowVersionUpgrade"],
		AutomatedSnapshotRetentionPeriod: outputs["automatedSnapshotRetentionPeriod"],
		AvailabilityZone: outputs["availabilityZone"],
		BucketName: outputs["bucketName"],
		ClusterParameterGroupName: outputs["clusterParameterGroupName"],
		ClusterPublicKey: outputs["clusterPublicKey"],
		ClusterRevisionNumber: outputs["clusterRevisionNumber"],
		ClusterSecurityGroups: outputs["clusterSecurityGroups"],
		ClusterSubnetGroupName: outputs["clusterSubnetGroupName"],
		ClusterType: outputs["clusterType"],
		ClusterVersion: outputs["clusterVersion"],
		DatabaseName: outputs["databaseName"],
		ElasticIp: outputs["elasticIp"],
		EnableLogging: outputs["enableLogging"],
		Encrypted: outputs["encrypted"],
		Endpoint: outputs["endpoint"],
		EnhancedVpcRouting: outputs["enhancedVpcRouting"],
		IamRoles: outputs["iamRoles"],
		KmsKeyId: outputs["kmsKeyId"],
		MasterUsername: outputs["masterUsername"],
		NodeType: outputs["nodeType"],
		NumberOfNodes: outputs["numberOfNodes"],
		Port: outputs["port"],
		PreferredMaintenanceWindow: outputs["preferredMaintenanceWindow"],
		PubliclyAccessible: outputs["publiclyAccessible"],
		S3KeyPrefix: outputs["s3KeyPrefix"],
		VpcId: outputs["vpcId"],
		VpcSecurityGroupIds: outputs["vpcSecurityGroupIds"],
	}, nil
}

// A collection of arguments for invoking getCluster.
type GetClusterArgs struct {
	// The cluster identifier
	ClusterIdentifier interface{}
	Tags interface{}
}

// A collection of values returned by getCluster.
type GetClusterResult struct {
	// Whether major version upgrades can be applied during maintenance period
	AllowVersionUpgrade interface{}
	// The backup retention period
	AutomatedSnapshotRetentionPeriod interface{}
	// The availability zone of the cluster
	AvailabilityZone interface{}
	// The name of the S3 bucket where the log files are to be stored
	BucketName interface{}
	// The name of the parameter group to be associated with this cluster
	ClusterParameterGroupName interface{}
	// The public key for the cluster
	ClusterPublicKey interface{}
	// The cluster revision number
	ClusterRevisionNumber interface{}
	// The security groups associated with the cluster
	ClusterSecurityGroups interface{}
	// The name of a cluster subnet group to be associated with this cluster
	ClusterSubnetGroupName interface{}
	// The cluster type
	ClusterType interface{}
	ClusterVersion interface{}
	// The name of the default database in the cluster
	DatabaseName interface{}
	// The Elastic IP of the cluster
	ElasticIp interface{}
	// Whether cluster logging is enabled
	EnableLogging interface{}
	// Whether the cluster data is encrypted
	Encrypted interface{}
	// The cluster endpoint
	Endpoint interface{}
	// Whether enhanced VPC routing is enabled
	EnhancedVpcRouting interface{}
	// The IAM roles associated to the cluster
	IamRoles interface{}
	// The KMS encryption key associated to the cluster
	KmsKeyId interface{}
	// Username for the master DB user
	MasterUsername interface{}
	// The cluster node type
	NodeType interface{}
	// The number of nodes in the cluster
	NumberOfNodes interface{}
	// The port the cluster responds on
	Port interface{}
	// The maintenance window
	PreferredMaintenanceWindow interface{}
	// Whether the cluster is publicly accessible
	PubliclyAccessible interface{}
	// The folder inside the S3 bucket where the log files are stored
	S3KeyPrefix interface{}
	// The VPC Id associated with the cluster
	VpcId interface{}
	// The VPC security group Ids associated with the cluster
	VpcSecurityGroupIds interface{}
}