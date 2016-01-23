var phones;

$.ajax({
    type: "GET",
    url: "content.json",
    dataType: "json",
    async: false,
    success: function (data) {
        phones = data.phones;
    }

})

var content = new contentGenerator.Content("phonesContent", phones);
content.generateContent();

$("#sortByName").on("click", function () {

    $("#contentWrapper").children().remove();
    var sortedCollection = _.sortBy(phones, "model");
    var sortContent = new contentGenerator.Content("phonesContent", sortedCollection);
    sortContent.generateContent();

});

$("#sortByPrice").on("click", function () {

    $("#contentWrapper").children().remove();
    var sortedCollection = _.sortBy(phones, function (product) {
        return parseFloat(product.price);
    });
    var sortContent = new contentGenerator.Content("phonesContent", sortedCollection);
    sortContent.generateContent();
});