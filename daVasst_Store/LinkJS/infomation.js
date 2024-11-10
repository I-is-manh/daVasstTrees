const overlay = document.querySelector(".overlay")
const btn = document.querySelector(".overlay-notify__btn")
const overlayNotify = document.querySelector(".overlay-notify")
btn.onclick = (e) => {
    overlay.style.display = "none";
}
