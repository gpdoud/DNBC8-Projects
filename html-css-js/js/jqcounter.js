let nbr = 0;

$().ready(function() {

    $("div").css("text-align", "center");
    
    display();

    $(".inc").click(() => {
        nbr++;
        display();
    });
    $(".dec").click(() => {
        nbr--;
        display();
    });


});

const display = () => {
    $(".lbl").text(nbr)
                .css("color", "black")
                .css("font-style", "normal")
                .css("font-weight", "normal");
    if(nbr % 2 == 0) $(".lbl").css("color", "red");
    if(nbr % 3 == 0) $(".lbl").css("font-style", "italic");
    if(nbr % 5 == 0) $(".lbl").css("font-weight", "bold");
}