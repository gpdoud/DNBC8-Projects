const c2f = () => {
    let c = +(document.getElementById("inp").value);
    document.getElementById("out").innerText = c;
    let f =  (c * 9 / 5) + 32
    document.getElementById("ans").innerText = f;
}
const f2c = () => {
    let f = +(document.getElementById("inp1").value);
    document.getElementById("out1").innerText = f;
    let c =  5 / 9 * (f - 32)
    document.getElementById("ans1").innerText = c;
}
