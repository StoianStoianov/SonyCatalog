/// <reference path="libs/jquery-2.1.1.min.js" />



$.ajax({
    type: "GET",
    url: "http://localhost:10117/api/Consoles",
    contentType: "application/json",
    dataType: "json",
    headers: { "'Access-Control-Allow-Origin": "*" },
    crossDomain: true,
    async: false,
    success: function (data) {
        productCollection = data;
        var content = new contentGenerator.Content("Consoles", productCollection, ".random-consoles");
        content.generateRandomCountFromProduct();       
    }

})

$.ajax({
    type: "GET",
    url: "http://localhost:10117/api/Phones",
    contentType:"application/json",
    dataType: "json",
    headers: { "'Access-Control-Allow-Origin": "*" },
    crossDomain: true,
    async: false,
    success: function (data) {
        productCollection = data;
        var content = new contentGenerator.Content("Phones", productCollection, ".random-phones");
        content.generateRandomCountFromProduct();
    }
    
})

$.ajax({
    type: "GET",
    url: "http://localhost:10117/api/Tvs",  
    contentType: "application/json",
    dataType: "json",
    headers: { "'Access-Control-Allow-Origin": "*" },
    crossDomain: true,
    async: false,
    success: function (data) {
        productCollection = data;
        var content = new contentGenerator.Content("Tvs", productCollection, ".random-tvs");
        content.generateRandomCountFromProduct();
    }

})

var typeOfContent;
var productCollection;
$(".main-nav-li").on("click", function () {
    typeOfContent = $(this).text();
    $.ajax({
        type: "GET",
        url: "http://localhost:10117/api/" + typeOfContent,
        dataType: "json",
        async: false,
        success: function (data) {
            productCollection = data;           
            var content = new contentGenerator.Content(typeOfContent, productCollection,".content");
            content.generateContent();
            $(".sortBtnSectionHide").toggleClass("sortBtnSectionHide");
        }

    })

});

$("#sortByName").on("click", function () {

    sortProductByName();

    
});

$("#sortByPrice").on("click", function () {

    sortProductsByPrice(typeOfContent);

});

function sortProductByName() {
    var sortParameter;
    if (typeOfContent == "Consoles") {
        sortParameter = "bundleName"
    } else {
        sortParameter = "model";
    }
    $(".content").children().remove();
    var sortedCollection = productCollection.sort(function (product1, product2) {
        return product1[sortParameter] > product2[sortParameter] ? 1 : -1;
    });
    var sortContent = new contentGenerator.Content(typeOfContent, sortedCollection,".content");
    sortContent.generateContent();

}

function sortProductsByPrice(typeOfContent) {

    $(".content").children().remove();
    var sortedCollection = productCollection.sort(function(product1,product2){
        return product1.price - product2.price;
    });    
    var sortContent = new contentGenerator.Content(typeOfContent, sortedCollection,".content");
    sortContent.generateContent();

}






