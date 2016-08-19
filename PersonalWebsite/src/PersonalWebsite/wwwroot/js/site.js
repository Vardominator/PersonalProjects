// Write your Javascript code.
(function () {

    var $icon = $("#sidebarToggle i.fa");

    $("#sidebarToggle").click(function () {
        $("#sidebar, #wrapper").toggleClass("hide-sidebar");
        if ($("#sidebar").hasClass("hide-sidebar")) {
            $icon.removeClass("fa-angle-left");
            $icon.addClass("fa-angle-right");
        }
        else {
            $icon.removeClass("fa-angle-right");
            $icon.addClass("fa-angle-left");
        }
    });

})();