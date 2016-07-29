// Self-executing anonymous function
(function () {

    //var ele = $("#username");
    //ele.text = "Varderes Barsegyan";

    //var main = $("#main");
    //main.on("mouseenter", function () {
    //    main.style = "background: #888";
    //});

    //main.on("mouseleave", function () {
    //    main.style = "";
    //});

    //var menuItems = $("ul.menu li a");
    //menuItems.on("click", function () {
    //    var me = $(this);
    //    alert(me.text());
    //});

    var $sidebarAndWrapper = $("#sidebar, #wrapper");

    var $toggleButton = $("#sidebarToggle");
    $toggleButton.text("Hide Sidebar");
    

    $toggleButton.on("click", function () {
        $sidebarAndWrapper.toggleClass("hide-sidebar");
        if ($sidebarAndWrapper.hasClass("hide-sidebar")) {
            $(this).text("Show Sidebar");
        }
        else {
            $(this).text("Hide Sidebar");
        }

    });

})();
