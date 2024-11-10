const product = document.querySelector(".surro-product")
const arrow = document.querySelector(".arrow")
const list = document.querySelector(".admin-navigation-router-product-list")
const listItem = document.querySelector(".list-item")
const listCategory = document.querySelector(".list-category")
const arrow_item = document.querySelector(".arrow-item")
product.addEventListener('click', (e) => {
    arrow.classList.toggle("arrow-down");
    list.classList.toggle("list-show");
})
listItem.addEventListener('click', () => {
    listCategory.classList.toggle("list-category__show");
    arrow_item.classList.toggle("arrow-down")
})
