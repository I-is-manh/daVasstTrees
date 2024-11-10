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
/*const confirmcode = document.querySelector("input[name=maxacnhan]")*/
const hidden = document.getElementById("hidden");
const mau = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/
const maunumber = /[0-9]/
function kiemTraChuoi(chuoi) {
    let demChuHoa = 0;
    let demSo = 0;
    for (let i = 0; i < chuoi.length; i++) {
        if (maunumber.test(chuoi[i])) {
            demSo++;

        }
        else if (chuoi[i].toUpperCase() === chuoi[i]) {
            demChuHoa++;
        }
    }
    return demChuHoa === 3 && demSo === 2;
}

form.onsubmit = (e) => {
    console.log(confirmcode.value)
    let check = true;
    if (mau.test(inpemail.value) == false) {
        inpemail.style.border = "1px solid red";
        labeltk.style.color = "red";
        labelTkError.innerHTML = "Email không đúng định dạng";
        labelTkError.style.color = "red";
        check = false;
    }
    else {
        inpemail.style.border = "1px solid #00B214";
        labeltk.style.color = "#00B214";
        labelTkError.innerHTML = "";
        
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
    else {
        inpmk.style.border = "1px solid #00B214"
        labelmk.style.color = "#00B214";
        labelMkError.innerHTML = "";
        
        
        inpremk.style.border = "1px solid #00B214"
        labelremk.style.color = "#00B214";
        labelRMkError.innerHTML = "";
       
    }
    if (inpmk.value == "" && inpremk.value == "") {
        inpmk.style.border = "1px solid red"
        labelmk.style.color = "red";
        labelMkError.innerHTML = "Hãy nhập mật khẩu";
        labelMkError.style.color = "red";
        check = false;
        inpremk.style.border = "1px solid red"
        labelremk.style.color = "red";
        labelRMkError.innerHTML = "Hãy nhập mật khẩu";
        labelRMkError.style.color = "red";
        check = false;
    }
    //if (kiemTraChuoi(confirmcode.value) == false) {
    //    document.querySelector(".formSignUp__maxacnhan__error").innerHTML = "Mã xác nhận không hợp lệ"
    //    document.querySelector(".formSignUp__maxacnhan__error").style.color = "red";
    //    document.getElementById("maxacnhaninp").style.border = "1px solid red";
    //    document.getElementById("maxacnhanlabel").style.color = "red";
    //    check = false;
    //}
    //else {
    //    document.querySelector(".formSignUp__maxacnhan__error").innerHTML = ""
    //    document.getElementById("maxacnhaninp").style.border = "1px solid #00B214";
    //    document.getElementById("maxacnhanlabel").style.color = "#00B214";
    //}
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