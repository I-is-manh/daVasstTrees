const thapdencao = document.querySelector(".category-filter__radio1")
const caodenthap = document.querySelector(".category-filter__radio2")
const formFilter = document.getElementById("formFilter")
const checkbox = document.querySelector(".category-filter__surro-checkbox")
const formPage = document.getElementById("categoryPage")
const nav = document.getElementById("imgnav")
const listCategory = document.querySelector(".category-surro-list")

thapdencao.onchange = () => {
    const paramerter = new URLSearchParams(window.location.search)
    const id = paramerter.get("id")
    const key = paramerter.get("key")
    if (key != null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?key=${key}&gia=thapdencao&page=1`
        return;
    }
    if (id == null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?gia=thapdencao&page=1`
    }
    if (id != null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?id=${id}&gia=thapdencao&page=1`
    }
    

}
caodenthap.onchange = () => {
    const paramerter = new URLSearchParams(window.location.search)
    const id = paramerter.get("id")
    const key = paramerter.get("key")
    if (key != null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?key=${key}&gia=caodenthap&page=1`
        return;
    }
    if (id == null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?gia=caodenthap&page=1`
    }
    if(id != null) {
        window.location.href = `https://localhost:44321/daVasstTree/productList.aspx?id=${id}&gia=caodenthap&page=1`
    }
}
nav.onclick = () => {
    
    if (listCategory.classList == "showlist") {
        listCategory.classList = "category-surro-list"
    }
    else {
        listCategory.classList = "showlist"
    }
}