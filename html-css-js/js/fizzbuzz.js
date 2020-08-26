const f = "Fizz";
const b = "Buzz"
const fb = f+b;

const fizzbuzz = () => {
    for(let idx = 1; idx <= 100; idx++) {
        if(idx % 3 == 0 && idx % 5 == 0) {
            out(fb);
            continue;
        }
        if(idx % 3 == 0) {
            out(f);
            continue;
        }
        if(idx % 5 == 0) {
            out(b);
            continue;
        }
        out(idx);
    }
}
const out = (output) => {
    let pCtrl = document.getElementById("out");
    let color = "black";
    if(output == fb) { color = "purple"; }
    if(output == f) { color = "red"; }
    if(output == b) { color = "blue"; }
    pCtrl.innerHTML += `<span style="color:${color};">${output}</span>, `;
}
