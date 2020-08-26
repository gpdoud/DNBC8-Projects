
let ans = 0;

const display = () => {
    var ansCtrl = document.getElementById("ans");
    ansCtrl.value = ans;
    var ansStyle = ansCtrl.style;
    if(ans % 3 == 0) {
        ansStyle.color = "green";
    } else {
        ansStyle.color = "black";
    }
}

const add = () => {
    let val = document.getElementById("inp").value;
    ans += +val;
    display();
}
const sub = () => {
    let val = document.getElementById("inp").value;
    ans -= +val;
    display();
}
const mul = () => {
    let val = document.getElementById("inp").value;
    ans *= +val;
    display();
}
const div = () => {
    let val = document.getElementById("inp").value;
    ans /= +val;
    display();
}
const clr = () => {
    ans = 0;
    display();
}
