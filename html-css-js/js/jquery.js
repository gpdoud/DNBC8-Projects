
$().ready(function() {

    console.log("jQuery is ready!");

    $("div").html("<h1>Welcome to jQuery</h1>")
            .css("color", "purple")
            .css("font-family", "Impact")
            .css("font-size", "2rem");

    $("button").click(function() {
        console.warn("The button was clicked");
    });

});