// Copyright (c) 2012, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.42
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.42.
// 
namespace WebsitePanel.EnterpriseServer {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
    using System.Data;
    using WebsitePanel.Providers;
    using WebsitePanel.Providers.Statistics;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="esStatisticsServersSoap", Namespace="http://smbsaas/websitepanel/enterpriseserver")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ServiceProviderItem))]
    public partial class esStatisticsServers : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback GetRawStatisticsSitesPagedOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetStatisticsSitesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetServersOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback AddSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback UpdateSiteOperationCompleted;
        
        private System.Threading.SendOrPostCallback DeleteSiteOperationCompleted;
        
        /// <remarks/>
        public esStatisticsServers() {
            this.Url = "http://localhost/WebsitePanelEnterpriseServer11/esStatisticsServers.asmx";
        }
        
        /// <remarks/>
        public event GetRawStatisticsSitesPagedCompletedEventHandler GetRawStatisticsSitesPagedCompleted;
        
        /// <remarks/>
        public event GetStatisticsSitesCompletedEventHandler GetStatisticsSitesCompleted;
        
        /// <remarks/>
        public event GetServersCompletedEventHandler GetServersCompleted;
        
        /// <remarks/>
        public event GetSiteCompletedEventHandler GetSiteCompleted;
        
        /// <remarks/>
        public event AddSiteCompletedEventHandler AddSiteCompleted;
        
        /// <remarks/>
        public event UpdateSiteCompletedEventHandler UpdateSiteCompleted;
        
        /// <remarks/>
        public event DeleteSiteCompletedEventHandler DeleteSiteCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetRawStatisticsSitesPaged", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet GetRawStatisticsSitesPaged(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows) {
            object[] results = this.Invoke("GetRawStatisticsSitesPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetRawStatisticsSitesPaged(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetRawStatisticsSitesPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows}, callback, asyncState);
        }
        
        /// <remarks/>
        public System.Data.DataSet EndGetRawStatisticsSitesPaged(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void GetRawStatisticsSitesPagedAsync(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows) {
            this.GetRawStatisticsSitesPagedAsync(packageId, filterColumn, filterValue, sortColumn, startRow, maximumRows, null);
        }
        
        /// <remarks/>
        public void GetRawStatisticsSitesPagedAsync(int packageId, string filterColumn, string filterValue, string sortColumn, int startRow, int maximumRows, object userState) {
            if ((this.GetRawStatisticsSitesPagedOperationCompleted == null)) {
                this.GetRawStatisticsSitesPagedOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetRawStatisticsSitesPagedOperationCompleted);
            }
            this.InvokeAsync("GetRawStatisticsSitesPaged", new object[] {
                        packageId,
                        filterColumn,
                        filterValue,
                        sortColumn,
                        startRow,
                        maximumRows}, this.GetRawStatisticsSitesPagedOperationCompleted, userState);
        }
        
        private void OnGetRawStatisticsSitesPagedOperationCompleted(object arg) {
            if ((this.GetRawStatisticsSitesPagedCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetRawStatisticsSitesPagedCompleted(this, new GetRawStatisticsSitesPagedCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetStatisticsSites", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StatsSite[] GetStatisticsSites(int packageId, bool recursive) {
            object[] results = this.Invoke("GetStatisticsSites", new object[] {
                        packageId,
                        recursive});
            return ((StatsSite[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetStatisticsSites(int packageId, bool recursive, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetStatisticsSites", new object[] {
                        packageId,
                        recursive}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsSite[] EndGetStatisticsSites(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsSite[])(results[0]));
        }
        
        /// <remarks/>
        public void GetStatisticsSitesAsync(int packageId, bool recursive) {
            this.GetStatisticsSitesAsync(packageId, recursive, null);
        }
        
        /// <remarks/>
        public void GetStatisticsSitesAsync(int packageId, bool recursive, object userState) {
            if ((this.GetStatisticsSitesOperationCompleted == null)) {
                this.GetStatisticsSitesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetStatisticsSitesOperationCompleted);
            }
            this.InvokeAsync("GetStatisticsSites", new object[] {
                        packageId,
                        recursive}, this.GetStatisticsSitesOperationCompleted, userState);
        }
        
        private void OnGetStatisticsSitesOperationCompleted(object arg) {
            if ((this.GetStatisticsSitesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetStatisticsSitesCompleted(this, new GetStatisticsSitesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetServers", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StatsServer[] GetServers(int serviceId) {
            object[] results = this.Invoke("GetServers", new object[] {
                        serviceId});
            return ((StatsServer[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetServers(int serviceId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetServers", new object[] {
                        serviceId}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsServer[] EndGetServers(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsServer[])(results[0]));
        }
        
        /// <remarks/>
        public void GetServersAsync(int serviceId) {
            this.GetServersAsync(serviceId, null);
        }
        
        /// <remarks/>
        public void GetServersAsync(int serviceId, object userState) {
            if ((this.GetServersOperationCompleted == null)) {
                this.GetServersOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetServersOperationCompleted);
            }
            this.InvokeAsync("GetServers", new object[] {
                        serviceId}, this.GetServersOperationCompleted, userState);
        }
        
        private void OnGetServersOperationCompleted(object arg) {
            if ((this.GetServersCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetServersCompleted(this, new GetServersCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/GetSite", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StatsSite GetSite(int itemId) {
            object[] results = this.Invoke("GetSite", new object[] {
                        itemId});
            return ((StatsSite)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetSite(int itemId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetSite", new object[] {
                        itemId}, callback, asyncState);
        }
        
        /// <remarks/>
        public StatsSite EndGetSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StatsSite)(results[0]));
        }
        
        /// <remarks/>
        public void GetSiteAsync(int itemId) {
            this.GetSiteAsync(itemId, null);
        }
        
        /// <remarks/>
        public void GetSiteAsync(int itemId, object userState) {
            if ((this.GetSiteOperationCompleted == null)) {
                this.GetSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetSiteOperationCompleted);
            }
            this.InvokeAsync("GetSite", new object[] {
                        itemId}, this.GetSiteOperationCompleted, userState);
        }
        
        private void OnGetSiteOperationCompleted(object arg) {
            if ((this.GetSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetSiteCompleted(this, new GetSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/AddSite", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int AddSite(StatsSite item) {
            object[] results = this.Invoke("AddSite", new object[] {
                        item});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginAddSite(StatsSite item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("AddSite", new object[] {
                        item}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndAddSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void AddSiteAsync(StatsSite item) {
            this.AddSiteAsync(item, null);
        }
        
        /// <remarks/>
        public void AddSiteAsync(StatsSite item, object userState) {
            if ((this.AddSiteOperationCompleted == null)) {
                this.AddSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnAddSiteOperationCompleted);
            }
            this.InvokeAsync("AddSite", new object[] {
                        item}, this.AddSiteOperationCompleted, userState);
        }
        
        private void OnAddSiteOperationCompleted(object arg) {
            if ((this.AddSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.AddSiteCompleted(this, new AddSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/UpdateSite", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int UpdateSite(StatsSite item) {
            object[] results = this.Invoke("UpdateSite", new object[] {
                        item});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpdateSite(StatsSite item, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("UpdateSite", new object[] {
                        item}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndUpdateSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void UpdateSiteAsync(StatsSite item) {
            this.UpdateSiteAsync(item, null);
        }
        
        /// <remarks/>
        public void UpdateSiteAsync(StatsSite item, object userState) {
            if ((this.UpdateSiteOperationCompleted == null)) {
                this.UpdateSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnUpdateSiteOperationCompleted);
            }
            this.InvokeAsync("UpdateSite", new object[] {
                        item}, this.UpdateSiteOperationCompleted, userState);
        }
        
        private void OnUpdateSiteOperationCompleted(object arg) {
            if ((this.UpdateSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.UpdateSiteCompleted(this, new UpdateSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://smbsaas/websitepanel/enterpriseserver/DeleteSite", RequestNamespace="http://smbsaas/websitepanel/enterpriseserver", ResponseNamespace="http://smbsaas/websitepanel/enterpriseserver", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int DeleteSite(int itemId) {
            object[] results = this.Invoke("DeleteSite", new object[] {
                        itemId});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDeleteSite(int itemId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("DeleteSite", new object[] {
                        itemId}, callback, asyncState);
        }
        
        /// <remarks/>
        public int EndDeleteSite(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void DeleteSiteAsync(int itemId) {
            this.DeleteSiteAsync(itemId, null);
        }
        
        /// <remarks/>
        public void DeleteSiteAsync(int itemId, object userState) {
            if ((this.DeleteSiteOperationCompleted == null)) {
                this.DeleteSiteOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDeleteSiteOperationCompleted);
            }
            this.InvokeAsync("DeleteSite", new object[] {
                        itemId}, this.DeleteSiteOperationCompleted, userState);
        }
        
        private void OnDeleteSiteOperationCompleted(object arg) {
            if ((this.DeleteSiteCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DeleteSiteCompleted(this, new DeleteSiteCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetRawStatisticsSitesPagedCompletedEventHandler(object sender, GetRawStatisticsSitesPagedCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetRawStatisticsSitesPagedCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetRawStatisticsSitesPagedCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetStatisticsSitesCompletedEventHandler(object sender, GetStatisticsSitesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetStatisticsSitesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetStatisticsSitesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatsSite[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatsSite[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void GetSiteCompletedEventHandler(object sender, GetSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StatsSite Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StatsSite)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void AddSiteCompletedEventHandler(object sender, AddSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class AddSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal AddSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void UpdateSiteCompletedEventHandler(object sender, UpdateSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class UpdateSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal UpdateSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    public delegate void DeleteSiteCompletedEventHandler(object sender, DeleteSiteCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.42")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class DeleteSiteCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal DeleteSiteCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
}
