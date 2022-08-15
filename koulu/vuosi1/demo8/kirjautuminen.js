document.addEventListener("DOMContentLoaded", onkoKirjautunut);

function onkoKirjautunut() {
    if(localStorage.getItem("kirjautunut") === 'kylla') {
        document.getElementById('tervetuloa-text').textContent += localStorage.getItem("nimi");
        document.getElementById('kirjautumis-lomake').style.display="none";
        document.getElementById('kirjaudu-ulos').style.display="initial";
    }
}

function kirjaudu() {
    localStorage.setItem('nimi', document.getElementById("nimi").value);
    localStorage.setItem("kirjautunut", "kylla");
}

function kirjauduUlos() {
    document.getElementById('kirjaudu-ulos').style.display="none";
    localStorage.clear();
}