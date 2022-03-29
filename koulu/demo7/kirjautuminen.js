document.addEventListener("DOMContentLoaded", onkoKirjautunut);

function onkoKirjautunut() {
    let kirjautunut = 'kylla';
    if(kirjautunut === 'kylla') {
        document.getElementById('tervetuloa-text').textContent += localStorage.getItem("nimi");
    }
}

function kirjaudu() {
    localStorage.setItem('nimi', document.getElementById("nimi").value);
}