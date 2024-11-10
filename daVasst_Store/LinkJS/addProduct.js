const form = document.getElementById("formaddproduct")
const img = document.getElementById("imgavt")
const inputfile = document.getElementById("inputfile")
const nameproduct = document.getElementById("nameproduct")
const priceproduct = document.getElementById("priceproduct")
const discount = document.getElementById("discountproduct")
const quantity = document.getElementById("quantityproduct")
const descproduct = document.getElementById("descproduct")
const btnOk = document.getElementById("btnOk")

form.onsubmit = (e) => {
    let check = true;
    const mauNumber = /[0-9]/
    if (inputfile.value == "") {
        document.getElementById("errorImg").innerText = "Hãy chọn hình ảnh sản phẩm"
        document.getElementById("errorImg").style.color = "red"
    }
    else {
        document.getElementById("errorImg").innerText = "Hình ảnh sản phẩm";
        document.getElementById("errorImg").style.color = "#00B214"
    }
    if (nameproduct.value == "") {
        document.getElementById("errorName").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorName").innerHTML = ""
    }
    if (priceproduct.value == "") {
        document.getElementById("errorPrice").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorPrice").innerHTML = ""
    }
    if (mauNumber.test(discount.value) == false || discount.value == "") {
        document.getElementById("errorDiscount").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorDiscount").innerHTML = ""
    }
    if (mauNumber.test(quantity.value) == false || quantity.value == "") {
        document.getElementById("errorQuantity").innerHTML = "Hãy nhập đầy đủ và đúng định dạng trường dữ liệu"
        check = false
    }
    else {
        document.getElementById("errorQuantity").innerHTML = ""
    }
    if (descproduct.value == "") {
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
inputfile.addEventListener('change', (e) => {
    let srcimg = e.target.value;
    let finalLink = "../../Image/" + srcimg.slice(srcimg.lastIndexOf('\\') + 1)
    img.src = finalLink;
})

function formatCurrency(input) {
    // Lấy giá trị từ ô input
    let value = input.value;

    // Xóa các dấu chấm hoặc ký tự không phải số
    value = value.replace(/\D/g, "");
    // Định dạng lại giá trị thành tiền Việt Nam (VD: 1.000.000)
    input.value = new Intl.NumberFormat('vi-VN').format(value);
}
btnOk.onclick = () => {
    document.getElementById("ContentPlaceHolder1_overlayaddproduct").style.display = "none";
}