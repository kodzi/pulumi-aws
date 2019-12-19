// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package accessanalyzer

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Access Analyzer Analyzer. More information can be found in the [Access Analyzer User Guide](https://docs.aws.amazon.com/IAM/latest/UserGuide/what-is-access-analyzer.html).
//
// > This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/accessanalyzer_analyzer.html.markdown.
type Analyzer struct {
	s *pulumi.ResourceState
}

// NewAnalyzer registers a new resource with the given unique name, arguments, and options.
func NewAnalyzer(ctx *pulumi.Context,
	name string, args *AnalyzerArgs, opts ...pulumi.ResourceOpt) (*Analyzer, error) {
	if args == nil || args.AnalyzerName == nil {
		return nil, errors.New("missing required argument 'AnalyzerName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["analyzerName"] = nil
		inputs["tags"] = nil
		inputs["type"] = nil
	} else {
		inputs["analyzerName"] = args.AnalyzerName
		inputs["tags"] = args.Tags
		inputs["type"] = args.Type
	}
	inputs["arn"] = nil
	s, err := ctx.RegisterResource("aws:accessanalyzer/analyzer:Analyzer", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Analyzer{s: s}, nil
}

// GetAnalyzer gets an existing Analyzer resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetAnalyzer(ctx *pulumi.Context,
	name string, id pulumi.ID, state *AnalyzerState, opts ...pulumi.ResourceOpt) (*Analyzer, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["analyzerName"] = state.AnalyzerName
		inputs["arn"] = state.Arn
		inputs["tags"] = state.Tags
		inputs["type"] = state.Type
	}
	s, err := ctx.ReadResource("aws:accessanalyzer/analyzer:Analyzer", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Analyzer{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Analyzer) URN() pulumi.URNOutput {
	return r.s.URN()
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Analyzer) ID() pulumi.IDOutput {
	return r.s.ID()
}

// Name of the Analyzer.
func (r *Analyzer) AnalyzerName() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["analyzerName"])
}

func (r *Analyzer) Arn() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["arn"])
}

// Key-value mapping of resource tags.
func (r *Analyzer) Tags() pulumi.MapOutput {
	return (pulumi.MapOutput)(r.s.State["tags"])
}

// Type of Analyzer. Valid value is currently only `ACCOUNT`. Defaults to `ACCOUNT`.
func (r *Analyzer) Type() pulumi.StringOutput {
	return (pulumi.StringOutput)(r.s.State["type"])
}

// Input properties used for looking up and filtering Analyzer resources.
type AnalyzerState struct {
	// Name of the Analyzer.
	AnalyzerName interface{}
	Arn interface{}
	// Key-value mapping of resource tags.
	Tags interface{}
	// Type of Analyzer. Valid value is currently only `ACCOUNT`. Defaults to `ACCOUNT`.
	Type interface{}
}

// The set of arguments for constructing a Analyzer resource.
type AnalyzerArgs struct {
	// Name of the Analyzer.
	AnalyzerName interface{}
	// Key-value mapping of resource tags.
	Tags interface{}
	// Type of Analyzer. Valid value is currently only `ACCOUNT`. Defaults to `ACCOUNT`.
	Type interface{}
}
