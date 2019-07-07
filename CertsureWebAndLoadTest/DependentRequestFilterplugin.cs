using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.WebTesting;

namespace CertsureWebAndLoadTest
{
    public class WebTestDependentFilteryyy : WebTestPlugin
    {
        string m_startsWith = "https://www.google";
        public string FilterDependentRequestsThatStartWith
        {
            get { return m_startsWith; }
            set
            { //m_startsWith = value; 
            }
        }

        public override void PreRequest(object sender, PreRequestEventArgs e) 
        {
            WebTestRequestCollection depsToRemove = new WebTestRequestCollection();

            var y = e.Request;

            foreach (WebTestRequest r in e.Request.DependentRequests)
            {
                if (!string.IsNullOrEmpty(FilterDependentRequestsThatStartWith) && r.Url.Contains(FilterDependentRequestsThatStartWith))
                {
                    depsToRemove.Add(r);
                }
                else
                {
                    var x = r;
                }
            }
            foreach (WebTestRequest r in depsToRemove)
            {
                e.Request.DependentRequests.Remove(r);
            }
        }
    }
}
