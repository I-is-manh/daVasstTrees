const giamgia = document.querySelector("input[name=giamgia]")
function setCookie(cname, cvalue, exdays) {
    const d = new Date();
    d.setTime(d.getTime() + (exdays * 24 * 60 * 60 * 1000));
    let expires = "expires=" + d.toUTCString();
    document.cookie = cname + "=" + cvalue + ";" + expires + ";path=/";
}
if (giamgia.value == "") {
    setCookie("giamgia", "0%", 5)
}
giamgia.onchange = (e) => {
    setCookie("giamgia", e.target.value, 5)
}