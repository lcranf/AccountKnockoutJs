/// <reference path="knockout-2.1.0.js" />

var AccountViewModel = function() {
    this.Id = ko.observable();
    this.Name = ko.observable();
    this.Campaigns = ko.observableArray([]);
}

var CampaignViewModel = function() {
    this.Id = ko.observable();
    this.Name = ko.observable();
    this.Spots = ko.observableArray([]);
}

var SpotViewModel = function() {
    this.Id = ko.observable();
    this.Name = ko.observable();
}