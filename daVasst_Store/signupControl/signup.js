const form = document.querySelector(".formSignUp");
const inpemail = document.querySelector(".formSignUp__taikhoan__inp");
const inpmk = document.querySelector(".formSignUp__password__inp")
const inpremk = document.querySelector(".formSignUp__repassword__inp")
const labeltk = document.querySelector(".formSignUp__taikhoan__label");
const labelmk = document.querySelector(".formSignUp__password__label")
const labelremk = document.querySelector(".formSignUp__repassword__label")
const labelTkError = document.querySelector(".formSignUp__taikhoan__error");
const labelMkError = document.querySelector(".formSignUp__password__error");
const labelRMkError = document.querySelector(".formSignUp__repassword__error");
const mau = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/
const hidden = document.getElementById("hidden");
form.onsubmit = (e) => {
    let check = true;
    if (mau.test(inpemail.value) == false) {
        inpemail.style.border = "1px solid red";
        labeltk.style.color = "red";
        labelTkError.innerHTML = "Email không đúng định dạng";
        labelTkError.style.color = "red";
        check = false;
    }
    if (inpmk.value != inpremk.value) {
        inpmk.style.border = "1px solid red"
        labelmk.style.color = "red";
        labelMkError.innerHTML = "Mật khẩu không trùng khớp";
        labelMkError.style.color = "red";
        check = false;
        inpremk.style.border = "1px solid red"
        labelremk.style.color = "red";
        labelRMkError.innerHTML = "Mật khẩu không trùng khớp";
        labelRMkError.style.color = "red";
        check = false;
    }
    if (check == true) {
        e.submit();
    }
    else {
        e.preventDefault();
    }
}
window.onload = () => {
    if (hidden.value == "datontai") {
        inpemail.style.border = "1px solid red";
        labelTkError.innerText = "Email đã tồn tại"
        labeltk.style.color = "red";
        labelTkError.style.color = "red";
        labeltk.style.top = "0px";
        labeltk.style.zIndex = "1";
        labeltk.style.backgroundColor = "#FAFADF";
    }
}