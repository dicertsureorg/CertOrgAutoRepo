﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CertsureWebAndLoadTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.WebTesting;
    using Microsoft.VisualStudio.TestTools.WebTesting.Rules;
    using TestPlugins;

    public class LoginGocertV1Coded : WebTest
    {

        public LoginGocertV1Coded()
        {
            this.PreAuthenticate = true;
            this.Proxy = "default";

            AuthorizationHeaderTokenPlugin myFilterPlugin = new AuthorizationHeaderTokenPlugin(); 
            this.PreRequest += new EventHandler<PreRequestEventArgs>(myFilterPlugin.PreRequest);
        }

        public override IEnumerator<WebTestRequest> GetRequestEnumerator()
        {
            // Initialize validation rules that apply to all requests in the WebTest
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidateResponseUrl validationRule1 = new ValidateResponseUrl();
                this.ValidateResponse += new EventHandler<ValidationEventArgs>(validationRule1.Validate);
            }
            if ((this.Context.ValidationLevel >= Microsoft.VisualStudio.TestTools.WebTesting.ValidationLevel.Low))
            {
                ValidationRuleResponseTimeGoal validationRule2 = new ValidationRuleResponseTimeGoal();
                validationRule2.Tolerance = 0D;
                this.ValidateResponseOnPageComplete += new EventHandler<ValidationEventArgs>(validationRule2.Validate);
            }

            WebTestRequest request1 = new WebTestRequest("http://uat.niceiconline.com/");
            WebTestRequest request1Dependent1 = new WebTestRequest("http://uat.niceiconline.com/static/css/fonts/OpenSans-Light.woff");
            request1Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            request1.DependentRequests.Add(request1Dependent1);
            WebTestRequest request1Dependent2 = new WebTestRequest("http://uat.niceiconline.com/static/css/fonts/OpenSans.woff");
            request1Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            request1.DependentRequests.Add(request1Dependent2);
            WebTestRequest request1Dependent3 = new WebTestRequest("http://uat.niceiconline.com/static/css/fonts/OpenSans-SemiBold.woff");
            request1Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            request1.DependentRequests.Add(request1Dependent3);
            WebTestRequest request1Dependent4 = new WebTestRequest("http://uat.niceiconline.com/static/css/fonts/OpenSans-Bold.woff");
            request1Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            request1.DependentRequests.Add(request1Dependent4);
            WebTestRequest request1Dependent5 = new WebTestRequest("http://uat.niceiconline.com/static/css/fonts/OpenSans-ExtraBold.woff");
            request1Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            request1.DependentRequests.Add(request1Dependent5);
            yield return request1;
            request1 = null;

            WebTestRequest request2 = new WebTestRequest("http://uat.niceiconline.com/login");
            request2.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/"));
            ExtractHiddenFields extractionRule1 = new ExtractHiddenFields();
            extractionRule1.Required = true;
            extractionRule1.HtmlDecode = true;
            extractionRule1.ContextParameterName = "1";
            request2.ExtractValues += new EventHandler<ExtractionEventArgs>(extractionRule1.Extract);
            yield return request2;
            request2 = null;

            WebTestRequest request3 = new WebTestRequest("http://uat.niceiconline.com/login_check");
            request3.ExpectedResponseUrl = "http://uat.niceiconline.com/dashboard";
            FormPostHttpBody request3Body = new FormPostHttpBody();
            request3Body.FormPostParameters.Add("_username", "paulcollins1");
            request3Body.FormPostParameters.Add("_password", "warwick");
            request3Body.FormPostParameters.Add("_target_path", this.Context["$HIDDEN1._target_path"].ToString());
            request3.Body = request3Body;
            request3.Method = "POST";

            WebTestRequest request3Dependent1 = new WebTestRequest("http://uat.niceiconline.com/widgets/quickLinks");
            request3Dependent1.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent1.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent1);
            WebTestRequest request3Dependent2 = new WebTestRequest("http://uat.niceiconline.com/widgets/niceicNews");
            request3Dependent2.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent2.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent2.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent2);
            WebTestRequest request3Dependent3 = new WebTestRequest("http://uat.niceiconline.com/widgets/recentNotifications");
            request3Dependent3.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent3.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent3.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent3);
            WebTestRequest request3Dependent4 = new WebTestRequest("http://uat.niceiconline.com/widgets/niceicOffers");
            request3Dependent4.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent4.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent4.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent4);
            WebTestRequest request3Dependent5 = new WebTestRequest("http://uat.niceiconline.com/widgets/accountBalance");
            request3Dependent5.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent5.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent5.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent5);
            WebTestRequest request3Dependent6 = new WebTestRequest("http://uat.niceiconline.com/widgets/recentActivity");
            request3Dependent6.Headers.Add(new WebTestRequestHeader("Accept", "text/html, */*; q=0.01"));
            request3Dependent6.Headers.Add(new WebTestRequestHeader("X-Requested-With", "XMLHttpRequest"));
            request3Dependent6.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3.DependentRequests.Add(request3Dependent6);
            WebTestRequest request3Dependent7 = new WebTestRequest("http://uat.niceiconline.com/css/generated/fonts/nocs.eot");
            request3Dependent7.ThinkTime = 1;
            request3Dependent7.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            request3Dependent7.QueryStringParameters.Add("", "6339153", false, false);
            request3.DependentRequests.Add(request3Dependent7);
            yield return request3;
            request3 = null;

            WebTestRequest request4 = new WebTestRequest("http://uat.niceiconline.com/login_check");
            request4.Method = "POST";
            request4.ExpectedResponseUrl = "http://uat.niceiconline.com/dashboard";
            request4.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/login"));
            FormPostHttpBody request4Body = new FormPostHttpBody();
            request4Body.FormPostParameters.Add("_username", "paulcollins1");
            request4Body.FormPostParameters.Add("_password", "warwick");
            request4Body.FormPostParameters.Add("_target_path", this.Context["$HIDDEN1._target_path"].ToString()); //http://uat.niceiconline.com/dashboard
            request4.Body = request4Body;
            yield return request4;
            request4 = null;

            WebTestRequest request5 = new WebTestRequest("http://uat.niceiconline.com/certificate/list");
            request5.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/dashboard"));
            WebTestRequest request5Dependent1 = new WebTestRequest("http://uat.niceiconline.com/css/generated/fonts/nocs.eot");
            request5Dependent1.Headers.Add(new WebTestRequestHeader("Referer", "http://uat.niceiconline.com/certificate/list"));
            request5Dependent1.QueryStringParameters.Add("", "6339153", false, false);
            request5.DependentRequests.Add(request5Dependent1);
            yield return request5;
            request5 = null;

            // End of V1
            this.AddCommentToResult("End of V1");
        }
    }
}