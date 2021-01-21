using Microsoft.TeamFoundation.WorkItemTracking.WebApi;
using Microsoft.VisualStudio.Services.Client;
using Microsoft.VisualStudio.Services.Common;
using Microsoft.VisualStudio.Services.WebApi;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading;

namespace AzureFunctions
{
    public class Conection
    {
        private readonly WorkItemTrackingHttpClient azureConnection;
        private readonly VssConnection connection;

        //public Conection(Uri collectionUri, string UserToken)
        //{
        //    CultureInfo culture = CultureInfo.CreateSpecificCulture("en-US");

        //    Thread.CurrentThread.CurrentCulture = culture;
        //    Thread.CurrentThread.CurrentUICulture = culture;

        //    VssCredentials creds = new VssBasicCredential(string.Empty, UserToken);

        //    creds.Storage = new VssClientCredentialStorage();

        //    VssClientHttpRequestSettings settings = VssClientHttpRequestSettings.Default.Clone();
        //    settings.MaxRetryRequest = 5;

        //    settings.AcceptLanguages.Remove(CultureInfo.CurrentCulture);

        //    settings.AcceptLanguages.Add(culture);

        //    connection = new VssConnection(collectionUri, creds);

        //    azureConnection = connection.GetClient<WorkItemTrackingHttpClient>();
        //}
    }
}
