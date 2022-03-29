document.addEventListener("DOMContentLoaded", onkokir);


function onkokir(){
    if(localStorage.getItem("kirjautunut") === "kylla") {
        document.getElementById("outputtext").innerHTML += localStorage.getItem("userName");
        document.getElementById("Kbutton").style.display = "none";
        document.getElementById("button1").style.display = "none";
    }
    else {
        document.getElementById("kirjauduUlos_nappi").style.display="none";
        document.getElementById("nametag").style.display = "none";
    }
}
function Rekis() {
    if(document.getElementById("pw1").value === document.getElementById("pw2").value) {
        localStorage.setItem("passwordr", document.getElementById("pw1").value)
        localStorage.setItem('userName', document.getElementById("name1").value);
        localStorage.setItem("kirjautunut", "kylla");
    } else {
        alert("Salasanat eivät täsmää")
    }
}

function testa() {
    if(document.getElementById("username").value === localStorage.getItem("userName")) {
        if(document.getElementById("password").value === localStorage.getItem("passwordr")) {
            localStorage.setItem("kirjautunut", "kylla");
           
            location.reload();         
        }else {
            alert("Väärä salasana.");
        }
    }else {
        alert("Väärä käyttäjänimi.");
    }
}

function ulos(){
    localStorage.removeItem("kirjautunut");
    location.reload();

}
