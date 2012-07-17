/// <reference path="accountmodel.js" />
/// <reference path="knockout-2.1.0.js" />


var AccountIndexViewModel = function() {
    var self = this;
    this.accounts = ko.observableArray([]);
    this.selectedAccount = ko.observable();
    this.campaigns = ko.observableArray([]);
    this.selectedCampaign = ko.observable();

    this.selectedAccountId = function() {
        return self.selectedAccount() !== null ? self.selectedAccount().Id() : -1;
    };
}

var viewModel = new AccountIndexViewModel();

ko.applyBindings(viewModel);