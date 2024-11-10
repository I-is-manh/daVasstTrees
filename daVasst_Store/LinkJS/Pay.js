const form = document.getElementById("form1")
const fullname = document.getElementById("fullname")
const address = document.getElementById("address")
const numberphone = document.getElementById("numberphone")
const email = document.getElementById("email")
const more = document.getElementById("more")
const tt = document.getElementById("tt")
const nh = document.getElementById("nh")
form.onsubmit = (e) => {
    const mauEmail = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/
    const mauNumberphone = /^0[1-9]{9}$/
    let check = true
    console.log(fullname.value, address.value, numberphone.value,  email.value)
    if (fullname.value == "") {
        document.getElementById("errorFullname").innerHTML = "Trường này không được bỏ trống"
        fullname.style.border = "1px solid red"
        check = false
    }
    else {
        document.getElementById("errorFullname").innerHTML = ""
        fullname.style.border = "1px solid black"
    }
    if (address.value == "") {
        document.getElementById("errorAddress").innerHTML = "Trường này không được bỏ trống"
        address.style.border = "1px solid red"
        check = false
    }
    else {
        document.getElementById("errorAddress").innerHTML = ""
        address.style.border = "1px solid black"
    }
    if (!mauEmail.test(email.value)) {
        document.getElementById("errorEmail").innerHTML = "Hãy nhập đúng và đủ trường email này"
        email.style.border = "1px solid red";
        check = false;
    } else {
        document.getElementById("errorEmail").innerHTML = ""
        email.style.border = "1px solid black";
    }
    if (!mauNumberphone.test(numberphone.value)) {
        document.getElementById("errorNumberphone").innerHTML = "Hãy nhập đúng và đủ trường số điện thoại này"
        numberphone.style.border = "1px solid red";
        check = false;
    }
    else {
        document.getElementById("errorNumberphone").innerHTML = ""
        numberphone.style.border = "1px solid black";
    }
    if (tt.check == false && nh.check == false) {
        document.getElementById("errorPTTT").innerHTML = "Hãy chọn phương thức thanh toán"
        check = false;
    }
    else {
        document.getElementById("errorPTTT").innerHTML = ""
    }
    if (check == true) {
        e.submit()
    }
    else {
        e.preventDefault()
    }
}