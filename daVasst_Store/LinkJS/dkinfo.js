const form = document.querySelector(".formSignUp")
const name = document.querySelector("input[name=name]")
const date = document.querySelector("input[name=date]")
const gtnam = document.querySelector("input[id=gtnam]")
const gtnu = document.querySelector("input[id=gtnu]")
const lop = document.querySelector("select[name=lop]")
function checkDate(ngay) {
    const date = new Date(ngay);
    return !isNaN(date.getTime()) &&
        date.toString() !== 'Invalid Date';
}
function checkName (str){
    const maunumber = /[0-9]/
    let number = 0;
    for (let i = 0; i < str.length; i++) {
        if (maunumber.test(str[i])) {
            number++;
        }
    }
    if (number != 0) {
        return false;
    }
    else {
        if (str.length < 8 || str.length > 50) {
            return false;
        }
        else {
            return true;
        }
    }
}
form.onsubmit = (e) => {
    let check = true;
    const arrdate = date.value.split('/')
    
    if (checkName(name.value) == false) {
        document.getElementById("errorname").innerHTML = "hãy nhập tên đúng"
        check = false;
    }
    else {
        document.getElementById("errorname").innerHTML = ""
    }
    if (checkDate(`${arrdate[2]}-${arrdate[1]}-${arrdate[0]}`) == false) {

        document.getElementById("errordate").innerHTML = "hãy nhập ngay đúng"
        check = false;
    }
    else {
        document.getElementById("errordate").innerHTML = ""
    }
    if (check == true) {
        e.submit();
    }
    else {
        e.preventDefault();
    }
}