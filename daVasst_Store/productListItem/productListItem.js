const Arritem = document.querySelectorAll(".listTrees-item");
const btnAdd = document.querySelectorAll(".listTrees-item-info__btn");
const arrItem = Array.from(Arritem);
const arrBtn = Array.from(btnAdd);
arrItem.forEach((item) => {
    item.onclick = (e) => {
        if (arrBtn.includes(e.target)) {
            window.location.href = `https://localhost:44321/daVasstTree/cart.aspx?productID=${item.getAttribute("productID")}&categoryID=${item.getAttribute("categoryID")}`
            return;
        }   
        else window.location.href = `https://localhost:44321/daVasstTree/productDetail.aspx?productID=${item.getAttribute("productID")}&categoryID=${item.getAttribute("categoryID")}`; 
    }
})