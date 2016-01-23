/// <reference path="libs/handlebars-v2.0.0.js" />
/// <reference path="libs/underscore.js" />
/// <reference path="libs/jquery-2.1.1.min.js" />

var contentGenerator = (function () {

    function createTemplate(template, post) {

        var postTemplateHtml =$(template).html();
        postTemplate = Handlebars.compile(postTemplateHtml);
        return postTemplate(post);

    }

    function generateConsoles(consoles) {
        var docFragment = $(document.createDocumentFragment());
        $.each(consoles, function () {
            var post = { title: this["product"], bundleName: this["bundleName"], urlSrc: this["url"], price: this["price"] };
            docFragment.append(createTemplate("#console-template", post));
        })

        $("#contentWrapper").append(docFragment);
    }

    function generateTVs(tvs) {
        var docFragment = $(document.createDocumentFragment());
            $.each(tvs, function () {
                var post = { title: this["product"], model: this["model"], urlSrc: this["url"], price: this["price"] };
                docFragment.append(createTemplate("#tv-template", post));
            })
            $("#contentWrapper").append(docFragment);
    }

    function generatePhones(phones) {
        var docFragment = $(document.createDocumentFragment());
        $.each(phones, function () {
            var post = { title: this["product"], model: this["model"], urlSrc: this["url"], price: this["price"] };
            docFragment.append(createTemplate("#phone-template", post));
        })
        $("#contentWrapper").append(docFragment);
    }

    var Content = (function () {

        var Content = function (typeOfContent, data) {
            this.typeofContent = typeOfContent;
            this.data = data;
        }

        Content.prototype.generateContent = function () {

            if (this.typeofContent === "consolesContent") {
                this.generateContent = generateConsoles(this.data);
            } else if (this.typeofContent === "tvsContent") {
                this.generateContent = generateTVs(this.data);
            } else if (this.typeofContent === "phonesContent") {
                this.generateContent = generatePhones(this.data)
            }

        }

        return Content;

    }());

    return {
        Content: Content
    };

}());







