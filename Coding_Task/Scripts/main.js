


jQuery(document).ready(function ($) {

    toastr.options = {    //Intialize toastr plugin
        "closeButton": true,
        "debug": false,
        "positionClass": "toast-top-center",
        "onclick": null,
        "showDuration": "3000",
        "hideDuration": "1000",
        "timeOut": "5000",
        "extendedTimeOut": "1000",
        "showEasing": "swing",
        "hideEasing": "linear",
        "showMethod": "fadeIn",
        "hideMethod": "fadeOut",
        "preventDuplicates": true

    }

    //var offset = 530;
    //var duration = 10;
    //jQuery(window).scroll(function () {
    //    //if (jQuery(this).scrollTop() > offset) {
    //    //    jQuery('#ScrollDiv').fadeIn(duration);
    //    //} else {
    //    //    jQuery('#ScrollDiv').fadeOut(duration);
    //    //}
    //});

    var tabs = $('.cd-tabs');

    tabs.each(function () {
        var tab = $(this),
			tabItems = tab.find('ul.cd-tabs-navigation'),
			tabContentWrapper = tab.children('ul.cd-tabs-content'),
			tabNavigation = tab.find('nav');

        tabItems.on('click', 'a', function (event) {
            event.preventDefault();
            var selectedItem = $(this);
            if (!selectedItem.hasClass('selected')) {
                var selectedTab = selectedItem.data('content'),
					selectedContent = tabContentWrapper.find('li[data-content="' + selectedTab + '"]'),
					slectedContentHeight = selectedContent.innerHeight();

                tabItems.find('a.selected').removeClass('selected');
                selectedItem.addClass('selected');
                selectedContent.addClass('selected').siblings('li').removeClass('selected');
                //animate tabContentWrapper height when content changes 
                tabContentWrapper.animate({
                    'height': slectedContentHeight
                }, 200);
            }
        });

        //hide the .cd-tabs::after element when tabbed navigation has scrolled to the end (mobile version)
        checkScrolling(tabNavigation);
        tabNavigation.on('scroll', function () {
            checkScrolling($(this));
        });
    });

    $(window).on('resize', function () {
        tabs.each(function () {
            var tab = $(this);
            checkScrolling(tab.find('nav'));
            tab.find('.cd-tabs-content').css('height', 'auto');
        });
    });

    function checkScrolling(tabs) {
        var totalTabWidth = parseInt(tabs.children('.cd-tabs-navigation').width()),
		 	tabsViewport = parseInt(tabs.width());
        if (tabs.scrollLeft() >= totalTabWidth - tabsViewport) {
            tabs.parent('.cd-tabs').addClass('is-ended');
        } else {
            tabs.parent('.cd-tabs').removeClass('is-ended');
        }
    }

});

function AjaxCall(Pagepath) {

    var returnData = "";
    try {
        $.ajax({
            type: "POST",
            async: false,
            url: Pagepath,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data.d != null) {
                    returnData = data.d;
                }
            },
            error: function (x, e) {
                alert("The call to the server side failed. " + x.responseText);
            }
        });
    } catch (e) {
        alert(e.ToString());
    }

    return returnData;
}


function AjaxCallWithData(Pagepath, Data) {


    var returnData = "";
    try {
        $.ajax({
            type: "POST",
            async: false,
            url: Pagepath,
            data: "{json : " + Data + "}",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data.d != null) {
                    returnData = data.d;
                }
            },
            error: function (x, e) {
                alert("The call to the server side failed. " + x.responseText);
            }
        });
    } catch (e) {
        alert(e.ToString());
    }

    return returnData;
}

function AjaxCallWithDataGET(Pagepath) {

    var returnData = "";
    try {
        $.ajax({
            type: "GET",
            async: false,
            url: Pagepath,
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (data) {
                if (data != null) {
                    returnData = data;
                }
            },
            error: function (x, e) {
                console.log("The call to the server side failed. " + x.responseText);
            }
        });
    } catch (e) {
        console.log(e.ToString());
    }

    return returnData;
}


function AjaxCallWithDataMVC(Pagepath, Data) {

    var returnData = "";
    
        try {
            $.ajax({
                type: "GET",
                async: false,
                url: Pagepath,
                data: Data,
                contentType: "application/json; charset=utf-8",
                traditional: true,
                success: function (data) {
                    if (data.d == undefined) {
                        returnData = data;
                    }
                    else if (data.d != null) {
                        returnData = data.d;
                    }
                },
                error: function (x, e) {
                    //alert("The call to the server side failed. " + x.responseText);
                }
            });
        } catch (e) {
            //alert(e.ToString());
        }
    return returnData;
}

function AjaxCallWithDataMVC_Async(pagepath, data, callback) {

    try {
        $.ajax({
            type: "GET",
            async: true,
            url: pagepath,
            data: data,
            contentType: "application/json; charset=utf-8",
            traditional: true,
            success: function (data) {
                callback(data);
            },
            error: function (err) {
                callback(err)
            }
        });
    } catch (e) {

    }
}

function AjaxCallWithDataMVCPOST(Pagepath, Data) {

    var returnData = "";
    try {
        $.ajax({
            type: "POST",
            async: false,
            url: Pagepath,
            data: JSON.stringify(Data),
            contentType: "application/json; charset=utf-8",
            traditional: true,
            success: function (data) {
                if (data.d == undefined) {
                    returnData = data;
                }
                else if (data.d != null) {
                    returnData = data.d;
                }
            },
            error: function (x, e) {
                //alert("The call to the server side failed. " + x.responseText);
            }
        });
    } catch (e) {
        //alert(e.ToString());
    }
};
