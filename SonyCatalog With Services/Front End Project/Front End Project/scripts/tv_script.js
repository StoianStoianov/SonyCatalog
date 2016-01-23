/// <reference path="content_generator.js" />
var tvs;

$.ajax({
    type: "GET",
    url: "content.json",
    dataType: "json",
    async: false,
    success: function (data) {
        tvs = data.tvs;
    }

})

var content = new contentGenerator.Content("tvsContent", tvs);
content.generateContent();

$("#sortByName").on("click", function () {

    $("#contentWrapper").children().remove();
    var sortedCollection = _.sortBy(tvs, "model");
    var sortContent = new contentGenerator.Content("tvsContent", sortedCollection);
    sortContent.generateContent();

});

$("#sortByPrice").on("click", function () {

    $("#contentWrapper").children().remove();
    var sortedCollection = _.sortBy(tvs, function (product) {
        return parseFloat(product.price);
    });
    var sortContent = new contentGenerator.Content("tvsContent", sortedCollection);
    sortContent.generateContent();
});