// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Aws.LB
{
    /// <summary>
    /// Provides a Load Balancer Listener Rule resource.
    /// 
    /// &gt; **Note:** `aws.alb.ListenerRule` is known as `aws.lb.ListenerRule`. The functionality is identical.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-aws/blob/master/website/docs/r/lb_listener_rule.html.markdown.
    /// </summary>
    public partial class ListenerRule : Pulumi.CustomResource
    {
        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<Outputs.ListenerRuleActions>> Actions { get; private set; } = null!;

        /// <summary>
        /// The ARN of the rule (matches `id`)
        /// </summary>
        [Output("arn")]
        public Output<string> Arn { get; private set; } = null!;

        /// <summary>
        /// A Condition block. Condition blocks are documented below.
        /// </summary>
        [Output("conditions")]
        public Output<ImmutableArray<Outputs.ListenerRuleConditions>> Conditions { get; private set; } = null!;

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Output("listenerArn")]
        public Output<string> ListenerArn { get; private set; } = null!;

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;


        /// <summary>
        /// Create a ListenerRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ListenerRule(string name, ListenerRuleArgs args, CustomResourceOptions? options = null)
            : base("aws:lb/listenerRule:ListenerRule", name, args, MakeResourceOptions(options, ""))
        {
        }

        private ListenerRule(string name, Input<string> id, ListenerRuleState? state = null, CustomResourceOptions? options = null)
            : base("aws:lb/listenerRule:ListenerRule", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,                Aliases = { new Alias { Type = "aws:elasticloadbalancingv2/listenerRule:ListenerRule" } },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing ListenerRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ListenerRule Get(string name, Input<string> id, ListenerRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new ListenerRule(name, id, state, options);
        }
    }

    public sealed class ListenerRuleArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<Inputs.ListenerRuleActionsArgs>? _actions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleActionsArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.ListenerRuleActionsArgs>());
            set => _actions = value;
        }

        [Input("conditions", required: true)]
        private InputList<Inputs.ListenerRuleConditionsArgs>? _conditions;

        /// <summary>
        /// A Condition block. Condition blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleConditionsArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ListenerRuleConditionsArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Input("listenerArn", required: true)]
        public Input<string> ListenerArn { get; set; } = null!;

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        public ListenerRuleArgs()
        {
        }
    }

    public sealed class ListenerRuleState : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<Inputs.ListenerRuleActionsGetArgs>? _actions;

        /// <summary>
        /// An Action block. Action blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleActionsGetArgs> Actions
        {
            get => _actions ?? (_actions = new InputList<Inputs.ListenerRuleActionsGetArgs>());
            set => _actions = value;
        }

        /// <summary>
        /// The ARN of the rule (matches `id`)
        /// </summary>
        [Input("arn")]
        public Input<string>? Arn { get; set; }

        [Input("conditions")]
        private InputList<Inputs.ListenerRuleConditionsGetArgs>? _conditions;

        /// <summary>
        /// A Condition block. Condition blocks are documented below.
        /// </summary>
        public InputList<Inputs.ListenerRuleConditionsGetArgs> Conditions
        {
            get => _conditions ?? (_conditions = new InputList<Inputs.ListenerRuleConditionsGetArgs>());
            set => _conditions = value;
        }

        /// <summary>
        /// The ARN of the listener to which to attach the rule.
        /// </summary>
        [Input("listenerArn")]
        public Input<string>? ListenerArn { get; set; }

        /// <summary>
        /// The priority for the rule between `1` and `50000`. Leaving it unset will automatically set the rule with next available priority after currently existing highest rule. A listener can't have multiple rules with the same priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        public ListenerRuleState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ListenerRuleActionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information for creating an authenticate action using Cognito. Required if `type` is `authenticate-cognito`.
        /// </summary>
        [Input("authenticateCognito")]
        public Input<ListenerRuleActionsAuthenticateCognitoArgs>? AuthenticateCognito { get; set; }

        /// <summary>
        /// Information for creating an authenticate action using OIDC. Required if `type` is `authenticate-oidc`.
        /// </summary>
        [Input("authenticateOidc")]
        public Input<ListenerRuleActionsAuthenticateOidcArgs>? AuthenticateOidc { get; set; }

        /// <summary>
        /// Information for creating an action that returns a custom HTTP response. Required if `type` is `fixed-response`.
        /// </summary>
        [Input("fixedResponse")]
        public Input<ListenerRuleActionsFixedResponseArgs>? FixedResponse { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        /// <summary>
        /// Information for creating a redirect action. Required if `type` is `redirect`.
        /// </summary>
        [Input("redirect")]
        public Input<ListenerRuleActionsRedirectArgs>? Redirect { get; set; }

        /// <summary>
        /// The ARN of the Target Group to which to route traffic. Required if `type` is `forward`.
        /// </summary>
        [Input("targetGroupArn")]
        public Input<string>? TargetGroupArn { get; set; }

        /// <summary>
        /// The type of routing action. Valid values are `forward`, `redirect`, `fixed-response`, `authenticate-cognito` and `authenticate-oidc`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ListenerRuleActionsArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsAuthenticateCognitoArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationRequestExtraParams")]
        private InputMap<object>? _authenticationRequestExtraParams;

        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public InputMap<object> AuthenticationRequestExtraParams
        {
            get => _authenticationRequestExtraParams ?? (_authenticationRequestExtraParams = new InputMap<object>());
            set => _authenticationRequestExtraParams = value;
        }

        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        [Input("onUnauthenticatedRequest")]
        public Input<string>? OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        [Input("sessionCookieName")]
        public Input<string>? SessionCookieName { get; set; }

        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        [Input("sessionTimeout")]
        public Input<int>? SessionTimeout { get; set; }

        /// <summary>
        /// The ARN of the Cognito user pool.
        /// </summary>
        [Input("userPoolArn", required: true)]
        public Input<string> UserPoolArn { get; set; } = null!;

        /// <summary>
        /// The ID of the Cognito user pool client.
        /// </summary>
        [Input("userPoolClientId", required: true)]
        public Input<string> UserPoolClientId { get; set; } = null!;

        /// <summary>
        /// The domain prefix or fully-qualified domain name of the Cognito user pool.
        /// </summary>
        [Input("userPoolDomain", required: true)]
        public Input<string> UserPoolDomain { get; set; } = null!;

        public ListenerRuleActionsAuthenticateCognitoArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsAuthenticateCognitoGetArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationRequestExtraParams")]
        private InputMap<object>? _authenticationRequestExtraParams;

        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public InputMap<object> AuthenticationRequestExtraParams
        {
            get => _authenticationRequestExtraParams ?? (_authenticationRequestExtraParams = new InputMap<object>());
            set => _authenticationRequestExtraParams = value;
        }

        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        [Input("onUnauthenticatedRequest")]
        public Input<string>? OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        [Input("sessionCookieName")]
        public Input<string>? SessionCookieName { get; set; }

        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        [Input("sessionTimeout")]
        public Input<int>? SessionTimeout { get; set; }

        /// <summary>
        /// The ARN of the Cognito user pool.
        /// </summary>
        [Input("userPoolArn", required: true)]
        public Input<string> UserPoolArn { get; set; } = null!;

        /// <summary>
        /// The ID of the Cognito user pool client.
        /// </summary>
        [Input("userPoolClientId", required: true)]
        public Input<string> UserPoolClientId { get; set; } = null!;

        /// <summary>
        /// The domain prefix or fully-qualified domain name of the Cognito user pool.
        /// </summary>
        [Input("userPoolDomain", required: true)]
        public Input<string> UserPoolDomain { get; set; } = null!;

        public ListenerRuleActionsAuthenticateCognitoGetArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsAuthenticateOidcArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationRequestExtraParams")]
        private InputMap<object>? _authenticationRequestExtraParams;

        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public InputMap<object> AuthenticationRequestExtraParams
        {
            get => _authenticationRequestExtraParams ?? (_authenticationRequestExtraParams = new InputMap<object>());
            set => _authenticationRequestExtraParams = value;
        }

        /// <summary>
        /// The authorization endpoint of the IdP.
        /// </summary>
        [Input("authorizationEndpoint", required: true)]
        public Input<string> AuthorizationEndpoint { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client identifier.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client secret.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        /// <summary>
        /// The OIDC issuer identifier of the IdP.
        /// </summary>
        [Input("issuer", required: true)]
        public Input<string> Issuer { get; set; } = null!;

        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        [Input("onUnauthenticatedRequest")]
        public Input<string>? OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        [Input("sessionCookieName")]
        public Input<string>? SessionCookieName { get; set; }

        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        [Input("sessionTimeout")]
        public Input<int>? SessionTimeout { get; set; }

        /// <summary>
        /// The token endpoint of the IdP.
        /// </summary>
        [Input("tokenEndpoint", required: true)]
        public Input<string> TokenEndpoint { get; set; } = null!;

        /// <summary>
        /// The user info endpoint of the IdP.
        /// </summary>
        [Input("userInfoEndpoint", required: true)]
        public Input<string> UserInfoEndpoint { get; set; } = null!;

        public ListenerRuleActionsAuthenticateOidcArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsAuthenticateOidcGetArgs : Pulumi.ResourceArgs
    {
        [Input("authenticationRequestExtraParams")]
        private InputMap<object>? _authenticationRequestExtraParams;

        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public InputMap<object> AuthenticationRequestExtraParams
        {
            get => _authenticationRequestExtraParams ?? (_authenticationRequestExtraParams = new InputMap<object>());
            set => _authenticationRequestExtraParams = value;
        }

        /// <summary>
        /// The authorization endpoint of the IdP.
        /// </summary>
        [Input("authorizationEndpoint", required: true)]
        public Input<string> AuthorizationEndpoint { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client identifier.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The OAuth 2.0 client secret.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        /// <summary>
        /// The OIDC issuer identifier of the IdP.
        /// </summary>
        [Input("issuer", required: true)]
        public Input<string> Issuer { get; set; } = null!;

        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        [Input("onUnauthenticatedRequest")]
        public Input<string>? OnUnauthenticatedRequest { get; set; }

        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        [Input("sessionCookieName")]
        public Input<string>? SessionCookieName { get; set; }

        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        [Input("sessionTimeout")]
        public Input<int>? SessionTimeout { get; set; }

        /// <summary>
        /// The token endpoint of the IdP.
        /// </summary>
        [Input("tokenEndpoint", required: true)]
        public Input<string> TokenEndpoint { get; set; } = null!;

        /// <summary>
        /// The user info endpoint of the IdP.
        /// </summary>
        [Input("userInfoEndpoint", required: true)]
        public Input<string> UserInfoEndpoint { get; set; } = null!;

        public ListenerRuleActionsAuthenticateOidcGetArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsFixedResponseArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The content type. Valid values are `text/plain`, `text/css`, `text/html`, `application/javascript` and `application/json`.
        /// </summary>
        [Input("contentType", required: true)]
        public Input<string> ContentType { get; set; } = null!;

        /// <summary>
        /// The message body.
        /// </summary>
        [Input("messageBody")]
        public Input<string>? MessageBody { get; set; }

        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        [Input("statusCode")]
        public Input<string>? StatusCode { get; set; }

        public ListenerRuleActionsFixedResponseArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsFixedResponseGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The content type. Valid values are `text/plain`, `text/css`, `text/html`, `application/javascript` and `application/json`.
        /// </summary>
        [Input("contentType", required: true)]
        public Input<string> ContentType { get; set; } = null!;

        /// <summary>
        /// The message body.
        /// </summary>
        [Input("messageBody")]
        public Input<string>? MessageBody { get; set; }

        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        [Input("statusCode")]
        public Input<string>? StatusCode { get; set; }

        public ListenerRuleActionsFixedResponseGetArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Information for creating an authenticate action using Cognito. Required if `type` is `authenticate-cognito`.
        /// </summary>
        [Input("authenticateCognito")]
        public Input<ListenerRuleActionsAuthenticateCognitoGetArgs>? AuthenticateCognito { get; set; }

        /// <summary>
        /// Information for creating an authenticate action using OIDC. Required if `type` is `authenticate-oidc`.
        /// </summary>
        [Input("authenticateOidc")]
        public Input<ListenerRuleActionsAuthenticateOidcGetArgs>? AuthenticateOidc { get; set; }

        /// <summary>
        /// Information for creating an action that returns a custom HTTP response. Required if `type` is `fixed-response`.
        /// </summary>
        [Input("fixedResponse")]
        public Input<ListenerRuleActionsFixedResponseGetArgs>? FixedResponse { get; set; }

        [Input("order")]
        public Input<int>? Order { get; set; }

        /// <summary>
        /// Information for creating a redirect action. Required if `type` is `redirect`.
        /// </summary>
        [Input("redirect")]
        public Input<ListenerRuleActionsRedirectGetArgs>? Redirect { get; set; }

        /// <summary>
        /// The ARN of the Target Group to which to route traffic. Required if `type` is `forward`.
        /// </summary>
        [Input("targetGroupArn")]
        public Input<string>? TargetGroupArn { get; set; }

        /// <summary>
        /// The type of routing action. Valid values are `forward`, `redirect`, `fixed-response`, `authenticate-cognito` and `authenticate-oidc`.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public ListenerRuleActionsGetArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsRedirectArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname. This component is not percent-encoded. The hostname can contain `#{host}`. Defaults to `#{host}`.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to `/#{path}`.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The port. Specify a value from `1` to `65535` or `#{port}`. Defaults to `#{port}`.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        /// <summary>
        /// The protocol. Valid values are `HTTP`, `HTTPS`, or `#{protocol}`. Defaults to `#{protocol}`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to `#{query}`.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        [Input("statusCode", required: true)]
        public Input<string> StatusCode { get; set; } = null!;

        public ListenerRuleActionsRedirectArgs()
        {
        }
    }

    public sealed class ListenerRuleActionsRedirectGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The hostname. This component is not percent-encoded. The hostname can contain `#{host}`. Defaults to `#{host}`.
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to `/#{path}`.
        /// </summary>
        [Input("path")]
        public Input<string>? Path { get; set; }

        /// <summary>
        /// The port. Specify a value from `1` to `65535` or `#{port}`. Defaults to `#{port}`.
        /// </summary>
        [Input("port")]
        public Input<string>? Port { get; set; }

        /// <summary>
        /// The protocol. Valid values are `HTTP`, `HTTPS`, or `#{protocol}`. Defaults to `#{protocol}`.
        /// </summary>
        [Input("protocol")]
        public Input<string>? Protocol { get; set; }

        /// <summary>
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to `#{query}`.
        /// </summary>
        [Input("query")]
        public Input<string>? Query { get; set; }

        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        [Input("statusCode", required: true)]
        public Input<string> StatusCode { get; set; } = null!;

        public ListenerRuleActionsRedirectGetArgs()
        {
        }
    }

    public sealed class ListenerRuleConditionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the field. Must be one of `path-pattern` for path based routing or `host-header` for host based routing.
        /// </summary>
        [Input("field")]
        public Input<string>? Field { get; set; }

        /// <summary>
        /// The path patterns to match. A maximum of 1 can be defined.
        /// </summary>
        [Input("values")]
        public Input<string>? Values { get; set; }

        public ListenerRuleConditionsArgs()
        {
        }
    }

    public sealed class ListenerRuleConditionsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the field. Must be one of `path-pattern` for path based routing or `host-header` for host based routing.
        /// </summary>
        [Input("field")]
        public Input<string>? Field { get; set; }

        /// <summary>
        /// The path patterns to match. A maximum of 1 can be defined.
        /// </summary>
        [Input("values")]
        public Input<string>? Values { get; set; }

        public ListenerRuleConditionsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ListenerRuleActions
    {
        /// <summary>
        /// Information for creating an authenticate action using Cognito. Required if `type` is `authenticate-cognito`.
        /// </summary>
        public readonly ListenerRuleActionsAuthenticateCognito? AuthenticateCognito;
        /// <summary>
        /// Information for creating an authenticate action using OIDC. Required if `type` is `authenticate-oidc`.
        /// </summary>
        public readonly ListenerRuleActionsAuthenticateOidc? AuthenticateOidc;
        /// <summary>
        /// Information for creating an action that returns a custom HTTP response. Required if `type` is `fixed-response`.
        /// </summary>
        public readonly ListenerRuleActionsFixedResponse? FixedResponse;
        public readonly int Order;
        /// <summary>
        /// Information for creating a redirect action. Required if `type` is `redirect`.
        /// </summary>
        public readonly ListenerRuleActionsRedirect? Redirect;
        /// <summary>
        /// The ARN of the Target Group to which to route traffic. Required if `type` is `forward`.
        /// </summary>
        public readonly string? TargetGroupArn;
        /// <summary>
        /// The type of routing action. Valid values are `forward`, `redirect`, `fixed-response`, `authenticate-cognito` and `authenticate-oidc`.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private ListenerRuleActions(
            ListenerRuleActionsAuthenticateCognito? authenticateCognito,
            ListenerRuleActionsAuthenticateOidc? authenticateOidc,
            ListenerRuleActionsFixedResponse? fixedResponse,
            int order,
            ListenerRuleActionsRedirect? redirect,
            string? targetGroupArn,
            string type)
        {
            AuthenticateCognito = authenticateCognito;
            AuthenticateOidc = authenticateOidc;
            FixedResponse = fixedResponse;
            Order = order;
            Redirect = redirect;
            TargetGroupArn = targetGroupArn;
            Type = type;
        }
    }

    [OutputType]
    public sealed class ListenerRuleActionsAuthenticateCognito
    {
        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? AuthenticationRequestExtraParams;
        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        public readonly string OnUnauthenticatedRequest;
        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        public readonly string Scope;
        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        public readonly string SessionCookieName;
        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        public readonly int SessionTimeout;
        /// <summary>
        /// The ARN of the Cognito user pool.
        /// </summary>
        public readonly string UserPoolArn;
        /// <summary>
        /// The ID of the Cognito user pool client.
        /// </summary>
        public readonly string UserPoolClientId;
        /// <summary>
        /// The domain prefix or fully-qualified domain name of the Cognito user pool.
        /// </summary>
        public readonly string UserPoolDomain;

        [OutputConstructor]
        private ListenerRuleActionsAuthenticateCognito(
            ImmutableDictionary<string, object>? authenticationRequestExtraParams,
            string onUnauthenticatedRequest,
            string scope,
            string sessionCookieName,
            int sessionTimeout,
            string userPoolArn,
            string userPoolClientId,
            string userPoolDomain)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            UserPoolArn = userPoolArn;
            UserPoolClientId = userPoolClientId;
            UserPoolDomain = userPoolDomain;
        }
    }

    [OutputType]
    public sealed class ListenerRuleActionsAuthenticateOidc
    {
        /// <summary>
        /// The query parameters to include in the redirect request to the authorization endpoint. Max: 10.
        /// </summary>
        public readonly ImmutableDictionary<string, object>? AuthenticationRequestExtraParams;
        /// <summary>
        /// The authorization endpoint of the IdP.
        /// </summary>
        public readonly string AuthorizationEndpoint;
        /// <summary>
        /// The OAuth 2.0 client identifier.
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// The OAuth 2.0 client secret.
        /// </summary>
        public readonly string ClientSecret;
        /// <summary>
        /// The OIDC issuer identifier of the IdP.
        /// </summary>
        public readonly string Issuer;
        /// <summary>
        /// The behavior if the user is not authenticated. Valid values: `deny`, `allow` and `authenticate`
        /// </summary>
        public readonly string OnUnauthenticatedRequest;
        /// <summary>
        /// The set of user claims to be requested from the IdP.
        /// </summary>
        public readonly string Scope;
        /// <summary>
        /// The name of the cookie used to maintain session information.
        /// </summary>
        public readonly string SessionCookieName;
        /// <summary>
        /// The maximum duration of the authentication session, in seconds.
        /// </summary>
        public readonly int SessionTimeout;
        /// <summary>
        /// The token endpoint of the IdP.
        /// </summary>
        public readonly string TokenEndpoint;
        /// <summary>
        /// The user info endpoint of the IdP.
        /// </summary>
        public readonly string UserInfoEndpoint;

        [OutputConstructor]
        private ListenerRuleActionsAuthenticateOidc(
            ImmutableDictionary<string, object>? authenticationRequestExtraParams,
            string authorizationEndpoint,
            string clientId,
            string clientSecret,
            string issuer,
            string onUnauthenticatedRequest,
            string scope,
            string sessionCookieName,
            int sessionTimeout,
            string tokenEndpoint,
            string userInfoEndpoint)
        {
            AuthenticationRequestExtraParams = authenticationRequestExtraParams;
            AuthorizationEndpoint = authorizationEndpoint;
            ClientId = clientId;
            ClientSecret = clientSecret;
            Issuer = issuer;
            OnUnauthenticatedRequest = onUnauthenticatedRequest;
            Scope = scope;
            SessionCookieName = sessionCookieName;
            SessionTimeout = sessionTimeout;
            TokenEndpoint = tokenEndpoint;
            UserInfoEndpoint = userInfoEndpoint;
        }
    }

    [OutputType]
    public sealed class ListenerRuleActionsFixedResponse
    {
        /// <summary>
        /// The content type. Valid values are `text/plain`, `text/css`, `text/html`, `application/javascript` and `application/json`.
        /// </summary>
        public readonly string ContentType;
        /// <summary>
        /// The message body.
        /// </summary>
        public readonly string? MessageBody;
        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        public readonly string StatusCode;

        [OutputConstructor]
        private ListenerRuleActionsFixedResponse(
            string contentType,
            string? messageBody,
            string statusCode)
        {
            ContentType = contentType;
            MessageBody = messageBody;
            StatusCode = statusCode;
        }
    }

    [OutputType]
    public sealed class ListenerRuleActionsRedirect
    {
        /// <summary>
        /// The hostname. This component is not percent-encoded. The hostname can contain `#{host}`. Defaults to `#{host}`.
        /// </summary>
        public readonly string? Host;
        /// <summary>
        /// The absolute path, starting with the leading "/". This component is not percent-encoded. The path can contain #{host}, #{path}, and #{port}. Defaults to `/#{path}`.
        /// </summary>
        public readonly string? Path;
        /// <summary>
        /// The port. Specify a value from `1` to `65535` or `#{port}`. Defaults to `#{port}`.
        /// </summary>
        public readonly string? Port;
        /// <summary>
        /// The protocol. Valid values are `HTTP`, `HTTPS`, or `#{protocol}`. Defaults to `#{protocol}`.
        /// </summary>
        public readonly string? Protocol;
        /// <summary>
        /// The query parameters, URL-encoded when necessary, but not percent-encoded. Do not include the leading "?". Defaults to `#{query}`.
        /// </summary>
        public readonly string? Query;
        /// <summary>
        /// The HTTP response code. Valid values are `2XX`, `4XX`, or `5XX`.
        /// </summary>
        public readonly string StatusCode;

        [OutputConstructor]
        private ListenerRuleActionsRedirect(
            string? host,
            string? path,
            string? port,
            string? protocol,
            string? query,
            string statusCode)
        {
            Host = host;
            Path = path;
            Port = port;
            Protocol = protocol;
            Query = query;
            StatusCode = statusCode;
        }
    }

    [OutputType]
    public sealed class ListenerRuleConditions
    {
        /// <summary>
        /// The name of the field. Must be one of `path-pattern` for path based routing or `host-header` for host based routing.
        /// </summary>
        public readonly string? Field;
        /// <summary>
        /// The path patterns to match. A maximum of 1 can be defined.
        /// </summary>
        public readonly string? Values;

        [OutputConstructor]
        private ListenerRuleConditions(
            string? field,
            string? values)
        {
            Field = field;
            Values = values;
        }
    }
    }
}
