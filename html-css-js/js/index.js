
function clickme1() {

}
let clickme2 = function() {

}
const clickme3 = () => {
    let ctrl = document.getElementById("inp");
    let val = ctrl.value;
    let lblCtrl = document.getElementById("lbl");
    lblCtrl.innerHTML = "<h3>"+val+"</h3>";
}