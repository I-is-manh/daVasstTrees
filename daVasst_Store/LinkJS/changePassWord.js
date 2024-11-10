const form = document.querySelector(".formLogin");
const tk = document.querySelector(".formLogin__taikhoan__inp")
const pass = document.querySelector(".formLogin__password__inp")
form.onsubmit = (e) => {
    let check = true;
    if (tk.value == "") {
        document.getElementById("errorTk").innerHTML = "Không được bỏ trống"
        check = false;
    }
    else {
        document.getElementById("errorTk").innerHTML = ""
    }
    if (pass.value == "") {
        document.getElementById("errorMk").innerHTML = "Không được bỏ trống"
        check = false;
    }
    else {
        document.getElementById("errorTk").innerHTML = ""
    }
    if (check == true) {
        e.submit()
    }
    else {
        e.preventDefault()
    }
}