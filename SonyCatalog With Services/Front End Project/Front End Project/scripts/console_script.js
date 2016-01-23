/// <reference path="content_generator.js" />



var consoles;

$.ajax({
    type:"GET",
    url: "content.json",
    dataType: "json",
    async: false,
    success: function (data) {
        consoles = data.consoles;
    }

})

var content = new contentGenerator.Content("consolesContent", consoles);
content.generateContent();




$("#sortByName").on("click", function () {
   
    $("#contentWrapper").children().remove();        
    var sortedCollection = _.sortBy(consoles, "bundleName");
        var sortContent = new contentGenerator.Content("consolesContent", sortedCollection);
        sortContent.generateContent();
          
});

$("#sortByPrice").on("click", function () {

    $("#contentWrapper").children().remove();
    var sortedCollection = _.sortBy(consoles, function (product) {
        return parseFloat(product.price)
    });
    var sortContent = new contentGenerator.Content("consolesContent", sortedCollection);
    sortContent.generateContent();
});

