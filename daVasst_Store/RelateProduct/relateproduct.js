const relateProductItem = document.querySelectorAll(".relateproduct-item");
const arrRelateProduct = Array.from(relateProductItem);
const btnAddCart = document.querySelectorAll(".relateproduct-item-info__btn");
const arrBtn = Array.from(btnAddCart);
arrRelateProduct.forEach((item) => {
    item.onclick = (e) => {
        if (arrBtn.includes(e.target)) {

            window.location.href = `https://localhost:44321/daVasstTree/cart.aspx?productID=${item.getAttribute("productID")}&categoryID=${item.getAttribute("categoryID")}`
        }
        else window.location.href = `https://localhost:44321/daVasstTree/productDetail.aspx?productID=${item.getAttribute("productID")}&categoryID=${item.getAttribute("categoryID")}`
    }
})
