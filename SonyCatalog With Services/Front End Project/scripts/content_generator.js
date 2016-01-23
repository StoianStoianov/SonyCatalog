/// <reference path="libs/handlebars-v2.0.0.js" />
/// <reference path="libs/jquery-2.1.1.min.js" />

var contentGenerator = (function () {

    

    function createTemplate(template, post) {

        var postTemplateHtml =$(template).html();
        postTemplate = Handlebars.compile(postTemplateHtml);
        return postTemplate(post);

    }

    function getRandomProducts(products) {      
        var randomProductsCount = 4;       
        var randomProductCollection = [];
        while(randomProductCollection.length < randomProductsCount){
            var randomIndex = Math.floor((Math.random() * products.length));
            if ($.inArray(products[randomIndex], randomProductCollection) == -1) {
                randomProductCollection.push(products[randomIndex]);
            }
        }        
        return randomProductCollection;
    }
   
    function generateRandomProducts(products,typeOfContent) {
        var randomProducts = getRandomProducts(products);
        if (typeOfContent == "Consoles") {
            generateConsoles(randomProducts, ".random-consoles");
        } else if (typeOfContent == "Phones") {
            generatePhones(randomProducts, ".random-phones");
        } else {
            generateTVs(randomProducts, ".random-tvs");
        }
    }
    

    function generateConsoles(consoles,parentNode) {
        var docFragment = $(document.createDocumentFragment());
        $.each(consoles, function () {
            var post = { title: this["ProductCategory"], bundleName: this["BundleName"], urlSrc: this["Url"], price: this["Price"] };
            docFragment.append(createTemplate("#console-template", post));
        })

        $(parentNode).html(docFragment.children());
    }

    function generateTVs(tvs,parentNode) {
        var docFragment = $(document.createDocumentFragment());
            $.each(tvs, function () {
                var post = { title: this["ProductCategory"], model: this["TvModel"], urlSrc: this["Url"], price: this["Price"] };
                docFragment.append(createTemplate("#tv-template", post));
            })
            $(parentNode).html(docFragment.children());
        if ($(window).width() <= 500){ alert("Landscape view!");}
    }

    function generatePhones(phones,parentNode) {
        var docFragment = $(document.createDocumentFragment());
        $.each(phones, function () {
            var post = { title: this["ProductCategory"], model: this["PhoneModel"], urlSrc: this["Url"], price: this["Price"] };
            docFragment.append(createTemplate("#phone-template", post));
        })
        $(parentNode).html(docFragment.children());
    }

    

    var Content = (function () {

        var Content = function (typeOfContent, data,parentNode) {
            this.typeofContent = typeOfContent;
            this.data = data;
            this.parentNode = parentNode;
        }

        Content.prototype.generateRandomCountFromProduct = function () {         
           this.generateRandomCountFromProduct = generateRandomProducts(this.data,this.typeofContent);
        }

        Content.prototype.generateContent = function () {

            if (this.typeofContent === "Consoles") {
                this.generateContent = generateConsoles(this.data,this.parentNode);
            } else if (this.typeofContent === "Tvs") {
                this.generateContent = generateTVs(this.data,this.parentNode);
            } else if (this.typeofContent === "Phones") {
                this.generateContent = generatePhones(this.data,this.parentNode)
            }

        }
        
        return Content;

    }());

    return {
        Content: Content
    };

}());







