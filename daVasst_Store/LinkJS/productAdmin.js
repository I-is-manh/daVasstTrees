const form = document.getElementById("productAdmin")
const inputimg = document.getElementById("inputfile")
const img = document.getElementById("imgavt")
const name = document.getElementById("nameproduct")
const price = document.getElementById("priceproduct")
const discount = document.getElementById("discountproduct")
const quantity = document.getElementById("quantityproduct")
const desc = document.getElementById("descproduct")
const btnOk = document.getElementById("btnOk")
const overlay = document.getElementById("overlay")
form.onsubmit = (e) => {
    let check = true;
    const mauNumber = /[0-9]/
    if (name.value == "") {
        document.getElementById("errorName").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorName").innerHTML = ""
    }
    if (price.value == "") {
        document.getElementById("errorPrice").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorPrice").innerHTML = ""
    }
    if (mauNumber.test(discount.value)==false || discount.value == "") {
        document.getElementById("errorDiscount").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorDiscount").innerHTML = ""
    }
    if (mauNumber.test(quantity.value)==false || quantity.value == "") {
        document.getElementById("errorQuantity").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorQuantity").innerHTML = ""
    }
    if (desc.value == "") {
        document.getElementById("errorDesc").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorDesc").innerHTML = ""
    }
    if (check == false) {
        e.preventDefault();
    }
    else {
        e.submit();
    }
}
function formatCurrency(input) {
    // Lấy giá trị từ ô input
    let value = input.value;

    // Xóa các dấu chấm hoặc ký tự không phải số
    value = value.replace(/\D/g, "");
    // Định dạng lại giá trị thành tiền Việt Nam (VD: 1.000.000)
    input.value = new Intl.NumberFormat('vi-VN').format(value);
}
inputimg.addEventListener('change', (e) => {
    let srcimg = e.target.value;
    let finalLink = "../../Image/" + srcimg.slice(srcimg.lastIndexOf('\\') + 1)
    img.src = finalLink;
})

btnOk.onclick = () => {
    document.getElementById("ContentPlaceHolder1_overlay").style.display = "none";
}
