$("#copiedText")
    .ready(function () {
        $("#copiedText").hide();
    });

function copyTextToClipboard(text) {
    if (document.execCommand("copy")) {
        var tmpEl = document.createElement("div");
        tmpEl.innerHTML = text;
        tmpEl.style.opacity = 0;
        tmpEl.style.position = "absolute";
        tmpEl.style.pointerEvents = "none";
        tmpEl.style.zIndex = -1;

        document.body.appendChild(tmpEl);

        var range = document.createRange();
        range.selectNode(tmpEl);
        window.getSelection().removeAllRanges();
        window.getSelection().addRange(range);

        document.body.removeChild(tmpEl);
        window.getSelection().removeAllRanges();
        $("#copiedText")
            .fadeIn("fast",
                function() {
                    $("#copiedText").fadeOut(4000);
                });
    }
}
