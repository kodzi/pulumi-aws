// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.ApiGateway
{
    /// <summary>
    /// Provides a HTTP Method for an API Gateway Resource.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/api_gateway_method.html.markdown.
    /// </summary>
    public partial class Method : Pulumi.CustomResource
    {
        /// <summary>
        /// Specify if the method requires an API key
        /// </summary>
        [Output("apiKeyRequired")]
        public Output<bool?> ApiKeyRequired { get; private set; } = null!;

        /// <summary>
        /// The type of authorization used for the method (`NONE`, `CUSTOM`, `AWS_IAM`, `COGNITO_USER_POOLS`)
        /// </summary>
        [Output("authorization")]
        public Output<string> Authorization { get; private set; } = null!;

        /// <summary>
        /// The authorization scopes used when the authorization is `COGNITO_USER_POOLS`
        /// </summary>
        [Output("authorizationScopes")]
        public Output<ImmutableArray<string>> AuthorizationScopes { get; private set; } = null!;

        /// <summary>
        /// The authorizer id to be used when the authorization is `CUSTOM` or `COGNITO_USER_POOLS`
        /// </summary>
        [Output("authorizerId")]
        public Output<string?> AuthorizerId { get; private set; } = null!;

        /// <summary>
        /// The HTTP Method (`GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `OPTIONS`, `ANY`)
        /// </summary>
        [Output("httpMethod")]
        public Output<string> HttpMethod { get; private set; } = null!;

        /// <summary>
        /// A map of the API models used for the request's content type
        /// where key is the content type (e.g. `application/json`)
        /// and value is either `Error`, `Empty` (built-in models) or `aws.apigateway.Model`'s `name`.
        /// </summary>
        [Output("requestModels")]
        public Output<ImmutableDictionary<string, string>?> RequestModels { get; private set; } = null!;

        /// <summary>
        /// A map of request parameters (from the path, query string and headers) that should be passed to the integration. The boolean value indicates whether the parameter is required (`true`) or optional (`false`).
        /// For example: `request_parameters = {"method.request.header.X-Some-Header" = true "method.request.querystring.some-query-param" = true}` would define that the header `X-Some-Header` and the query string `some-query-param` must be provided in the request.
        /// </summary>
        [Output("requestParameters")]
        public Output<ImmutableDictionary<string, bool>?> RequestParameters { get; private set; } = null!;

        /// <summary>
        /// The ID of a `aws.apigateway.RequestValidator`
        /// </summary>
        [Output("requestValidatorId")]
        public Output<string?> RequestValidatorId { get; private set; } = null!;

        /// <summary>
        /// The API resource ID
        /// </summary>
        [Output("resourceId")]
        public Output<string> ResourceId { get; private set; } = null!;

        /// <summary>
        /// The ID of the associated REST API
        /// </summary>
        [Output("restApi")]
        public Output<string> RestApi { get; private set; } = null!;


        /// <summary>
        /// Create a Method resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Method(string name, MethodArgs args, CustomResourceOptions? options = null)
            : base("aws:apigateway/method:Method", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Method(string name, Input<string> id, MethodState? state = null, CustomResourceOptions? options = null)
            : base("aws:apigateway/method:Method", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Method resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Method Get(string name, Input<string> id, MethodState? state = null, CustomResourceOptions? options = null)
        {
            return new Method(name, id, state, options);
        }
    }

    public sealed class MethodArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify if the method requires an API key
        /// </summary>
        [Input("apiKeyRequired")]
        public Input<bool>? ApiKeyRequired { get; set; }

        /// <summary>
        /// The type of authorization used for the method (`NONE`, `CUSTOM`, `AWS_IAM`, `COGNITO_USER_POOLS`)
        /// </summary>
        [Input("authorization", required: true)]
        public Input<string> Authorization { get; set; } = null!;

        [Input("authorizationScopes")]
        private InputList<string>? _authorizationScopes;

        /// <summary>
        /// The authorization scopes used when the authorization is `COGNITO_USER_POOLS`
        /// </summary>
        public InputList<string> AuthorizationScopes
        {
            get => _authorizationScopes ?? (_authorizationScopes = new InputList<string>());
            set => _authorizationScopes = value;
        }

        /// <summary>
        /// The authorizer id to be used when the authorization is `CUSTOM` or `COGNITO_USER_POOLS`
        /// </summary>
        [Input("authorizerId")]
        public Input<string>? AuthorizerId { get; set; }

        /// <summary>
        /// The HTTP Method (`GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `OPTIONS`, `ANY`)
        /// </summary>
        [Input("httpMethod", required: true)]
        public Input<string> HttpMethod { get; set; } = null!;

        [Input("requestModels")]
        private InputMap<string>? _requestModels;

        /// <summary>
        /// A map of the API models used for the request's content type
        /// where key is the content type (e.g. `application/json`)
        /// and value is either `Error`, `Empty` (built-in models) or `aws.apigateway.Model`'s `name`.
        /// </summary>
        public InputMap<string> RequestModels
        {
            get => _requestModels ?? (_requestModels = new InputMap<string>());
            set => _requestModels = value;
        }

        [Input("requestParameters")]
        private InputMap<bool>? _requestParameters;

        /// <summary>
        /// A map of request parameters (from the path, query string and headers) that should be passed to the integration. The boolean value indicates whether the parameter is required (`true`) or optional (`false`).
        /// For example: `request_parameters = {"method.request.header.X-Some-Header" = true "method.request.querystring.some-query-param" = true}` would define that the header `X-Some-Header` and the query string `some-query-param` must be provided in the request.
        /// </summary>
        public InputMap<bool> RequestParameters
        {
            get => _requestParameters ?? (_requestParameters = new InputMap<bool>());
            set => _requestParameters = value;
        }

        /// <summary>
        /// The ID of a `aws.apigateway.RequestValidator`
        /// </summary>
        [Input("requestValidatorId")]
        public Input<string>? RequestValidatorId { get; set; }

        /// <summary>
        /// The API resource ID
        /// </summary>
        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        /// <summary>
        /// The ID of the associated REST API
        /// </summary>
        [Input("restApi", required: true)]
        public Input<string> RestApi { get; set; } = null!;

        public MethodArgs()
        {
        }
    }

    public sealed class MethodState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specify if the method requires an API key
        /// </summary>
        [Input("apiKeyRequired")]
        public Input<bool>? ApiKeyRequired { get; set; }

        /// <summary>
        /// The type of authorization used for the method (`NONE`, `CUSTOM`, `AWS_IAM`, `COGNITO_USER_POOLS`)
        /// </summary>
        [Input("authorization")]
        public Input<string>? Authorization { get; set; }

        [Input("authorizationScopes")]
        private InputList<string>? _authorizationScopes;

        /// <summary>
        /// The authorization scopes used when the authorization is `COGNITO_USER_POOLS`
        /// </summary>
        public InputList<string> AuthorizationScopes
        {
            get => _authorizationScopes ?? (_authorizationScopes = new InputList<string>());
            set => _authorizationScopes = value;
        }

        /// <summary>
        /// The authorizer id to be used when the authorization is `CUSTOM` or `COGNITO_USER_POOLS`
        /// </summary>
        [Input("authorizerId")]
        public Input<string>? AuthorizerId { get; set; }

        /// <summary>
        /// The HTTP Method (`GET`, `POST`, `PUT`, `DELETE`, `HEAD`, `OPTIONS`, `ANY`)
        /// </summary>
        [Input("httpMethod")]
        public Input<string>? HttpMethod { get; set; }

        [Input("requestModels")]
        private InputMap<string>? _requestModels;

        /// <summary>
        /// A map of the API models used for the request's content type
        /// where key is the content type (e.g. `application/json`)
        /// and value is either `Error`, `Empty` (built-in models) or `aws.apigateway.Model`'s `name`.
        /// </summary>
        public InputMap<string> RequestModels
        {
            get => _requestModels ?? (_requestModels = new InputMap<string>());
            set => _requestModels = value;
        }

        [Input("requestParameters")]
        private InputMap<bool>? _requestParameters;

        /// <summary>
        /// A map of request parameters (from the path, query string and headers) that should be passed to the integration. The boolean value indicates whether the parameter is required (`true`) or optional (`false`).
        /// For example: `request_parameters = {"method.request.header.X-Some-Header" = true "method.request.querystring.some-query-param" = true}` would define that the header `X-Some-Header` and the query string `some-query-param` must be provided in the request.
        /// </summary>
        public InputMap<bool> RequestParameters
        {
            get => _requestParameters ?? (_requestParameters = new InputMap<bool>());
            set => _requestParameters = value;
        }

        /// <summary>
        /// The ID of a `aws.apigateway.RequestValidator`
        /// </summary>
        [Input("requestValidatorId")]
        public Input<string>? RequestValidatorId { get; set; }

        /// <summary>
        /// The API resource ID
        /// </summary>
        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        /// <summary>
        /// The ID of the associated REST API
        /// </summary>
        [Input("restApi")]
        public Input<string>? RestApi { get; set; }

        public MethodState()
        {
        }
    }
}
