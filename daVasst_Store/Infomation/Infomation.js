const imgavt = document.getElementById("imgavt");
const inputfile = document.getElementById("inputfile");
const form = document.getElementById("infomation")
const numberPhone = document.getElementById("numberphone")
const email = document.getElementById("email")
const address = document.getElementById("address")
const fullname = document.getElementById("fullname")
console.log(fullname,email,address,numberPhone)
inputfile.onchange = (e) => {
    let srcimg = e.target.value;
    let finalLink = "../../Image/" + srcimg.slice(srcimg.lastIndexOf('\\') + 1)
    imgavt.src = finalLink;
}
form.onsubmit = (e) => {
    const mauEmail = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/
    const mauNumberphone = /^0[1-9]{9}$/
    let check = true;
    if (!mauEmail.test(email.value)) {
        document.getElementById("errorEmail").innerHTML = "Email không đúng định dạng"
        check = false;
    }
    if (!mauNumberphone.test(numberPhone.value)) {
        document.getElementById("errorNumberPhone").innerHTML = "Số điện thoại không đúng định dạng"
        check = false;
    }
    if (fullname.value == "") {
        document.getElementById("errorFullName").innerHTML = "Không nên để trống số họ tên";
        check = false;
    }
    if (address.value == "") {
        document.getElementById("errorAddress").innerHTML = "Không nên để trống địa chỉ giao hàng";
        check = false;
    }
    if (check == true) {
        e.submit();
    }
    else {
        e.preventDefault();
    }
}