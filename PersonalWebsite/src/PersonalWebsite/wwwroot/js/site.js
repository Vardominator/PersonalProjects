// Write your Javascript code.
(function () {


    $("#sidebarToggle").click(function () {
        $("#sidebar, #wrapper").toggleClass("hide-sidebar");
        if ($("#sidebar").hasClass("hide-sidebar")) {
            $(this).text("Show");
        }
        else {
            $(this).text("Hide");
        }
    });

    //$("sidebarToggle").on("click", function () {
    //    $("#sidebar, #wrapper").toggleClass("hide-sidebar");
    //});

})();