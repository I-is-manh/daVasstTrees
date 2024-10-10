const headerNav = document.querySelector(".headerNav__logobar");
const headerNavList = document.querySelector(".headerNav-list");
const body = document.querySelector("body");
const headerNavSpan = document.querySelectorAll(".headerNav__logobar-item");
const arrSpan = Array.from(headerNavSpan);
const arrHeaderNavList = Array.from(headerNavList.childNodes);
headerNav.onclick = () => {
    headerNav.classList.toggle("nav-click");
    headerNavList.classList.toggle("headerNav-list__responsive");
}
body.onclick = (e) => {
    if (e.target === headerNav || arrSpan.includes(e.target) || arrHeaderNavList.includes(e.target)) {
        return;
    }
    else {
        if (headerNav.classList.contains("nav-click")) {
            headerNav.classList.toggle("nav-click");
            headerNavList.classList.toggle("headerNav-list__responsive");
        }
    }
}
