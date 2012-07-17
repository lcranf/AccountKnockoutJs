/// <reference path="accountmodel.js" />
/// <reference path="knockout-2.1.0.js" />


var AccountIndexViewModel = function () {
    this.accounts = ko.observableArray([]);
    this.selectedAccount = ko.observable();
    this.campaigns = ko.observableArray([]);
    this.selectedCampaign = ko.observable();
}

var viewModel = new AccountIndexViewModel();

ko.applyBindings(viewModel);