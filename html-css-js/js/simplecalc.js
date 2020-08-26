const add = () => {
    let ctrl1 = document.getElementById("inp1");
    let ctrl2 = document.getElementById("inp2");
    let val1 = ctrl1.value;
    let val2 = ctrl2.value;
    let ansCtrl = document.getElementById("ans");
    ansCtrl.value = +val1 + Number(val2);
}