document.addEventListener("DOMContentLoaded", Aina)
Storage.prototype.setObj = function(key, obj) {
    return this.setItem(key, JSON.stringify(obj))
}
Storage.prototype.getObj = function(key) {
    return JSON.parse(this.getItem(key))
}

function Aina() {
    tyhjenna();
    localStorage.setItem("pohja","normaali")
    localStorage.setItem("koko","normaali")
    localStorage.setItem("kastike","normaali kastike")
    localStorage.setItem("juusto","normaali juusto")
    localStorage.setItem("monta", 1)
    localStorage.setItem("aines1", "")
    localStorage.setItem("aines2", "")
    localStorage.setItem("aines3", "")
    localStorage.setItem("aines4", "")
    localStorage.setItem("aines5", "")
}

function pohjja(p) {
    if (p === 1) {
            localStorage.setItem("pohja","normaali")        
    } else if (p === 2) {
        localStorage.setItem("pohja","gluteeniton")
    }
    if (localStorage.getItem("pohja") != "") {
        switch (localStorage.getItem("pohja")) {
            case "normaali":
                document.getElementById("normi").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("glut").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-pohja").innerHTML= "normaali";
                break;
            case "gluteeniton":
                document.getElementById("glut").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("normi").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-pohja").innerHTML= "gluteeniton";
        }
    };
    hinta();
}
function koko(koko) {
    if (koko === 1) {
            localStorage.setItem("koko","normaali")        
    } else if (koko === 2) {
        localStorage.setItem("koko","perhe")
    }
    if (localStorage.getItem("koko") != "") {
        switch (localStorage.getItem("koko")) {
            case "normaali":
                document.getElementById("normi3").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("perhe").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-koko").innerHTML= "normaali";
                break;
            case "perhe":
                document.getElementById("perhe").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("normi3").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-koko").innerHTML= "perhe";
        }
    };
    hinta();
}


function kastike(k) {
    if (k === 1) {
        localStorage.setItem("kastike","normaali kastike")
    } else if (k === 2) {
        localStorage.setItem("kastike","valkosipulinen kastike")
    }
    if (localStorage.getItem("kastike") != "") {
        switch (localStorage.getItem("kastike")) {
            case "normaali kastike":
                document.getElementById("normi1").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("valk").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-kastike").innerHTML= "normaali";
                break;
            case "valkosipulinen kastike":
                document.getElementById("valk").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("normi1").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-kastike").innerHTML= "valkosipulinen";
        }
    };
    hinta();
}


function montaf() {
    localStorage.setItem("monta", document.getElementById("monta").value);
    document.getElementById("fcont-monta").innerHTML = localStorage.getItem(`monta`);
    hinta();
}

function tayte(t) {
    var aineet = ["pepperoni","ananas","salami","sipuli","kebabliha","jalopeno","kana","pekoni","jauheliha","kinkku"]
    let id = 1, 
    valittu = aineet[t - 1],
    pituus = localStorage.length - 2,
    jatko = false,
    yli = false
    while (localStorage.getItem(`aines${id}`) !== "") id++
    if (id > 5) {
        for (let i = 1;i <= pituus + 1;i++) {
            if(valittu === localStorage.getItem(`aines${i}`)) {
                localStorage.removeItem(`aines${i}`)
                document.getElementById(valittu).style.boxShadow = "#8d501e 0vh .2vh";
                jatko = true
                yli = true
            }
        }
        if (!yli) {
            alert("Sinulla on jo 5 täytettä")
            jatko = true
        }

    }
    for (let i = 1;i <= pituus;i++) {
        if(valittu === localStorage.getItem(`aines${i}`)) {
            localStorage.removeItem(`aines${i}`)
            document.getElementById(valittu).style.boxShadow = "#8d501e 0vh .2vh";
            jatko = true
        }
    }
    
    if(!jatko) {
        localStorage.setItem(`aines${id}`,valittu)
        document.getElementById(valittu).style.boxShadow = "#8d501e 0vh .2vh";
        document.getElementById("fcont-täytteet").innerHTML += " "+localStorage.getItem(`aines${id}`);
    };
    hinta();
}

function tyhjenna(){
    try{
    for(let i = 1;i <= 5; i++){
        document.getElementById(localStorage.getItem(`aines${i}`)).style.boxShadow = "#8d501e 0vh .4vh";
        localStorage.removeItem(`aines${i}`);
    }
    }
    catch(error){};
}




function juustot(j) {
    if (j === 1) {
        localStorage.setItem("juusto","normaali")
    } else if (j === 2) {
        localStorage.setItem("juusto","laktoositon juusto")
    }

    if (localStorage.getItem("juusto") != "") {
        switch (localStorage.getItem("juusto")) {
            case "normaali":
                document.getElementById("normi2").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("laktoositon").style.boxShadow = "#8d501e 0vh .4vh";
                document.getElementById("fcont-juustot").innerHTML = localStorage.getItem("juusto");
                break;
            case "laktoositon juusto":
                document.getElementById("laktoositon").style.boxShadow = "#8d501e 0vh .2vh";
                document.getElementById("normi2").style.boxShadow = "#8d501e 0vh .4vh";;
                document.getElementById("fcont-juustot").innerHTML = localStorage.getItem("juusto");
        }
    };
    hinta();
}


function hinta(){
    let valitut = 0.50 * (localStorage.length - 4)
    let cost = 2 + valitut;
    if(localStorage.getItem("pohja") === "normi") {cost += 2.00} else {cost += 2.50}
    if(localStorage.getItem("koko") === "normi") {cost += 2.00} else {cost += 4.00}
    if(localStorage.getItem("kastike") === "normi") {cost += 2.00} else {cost +=3.00}
    if(localStorage.getItem("juusto") === "normi") {cost += 2.00} else {cost += 3.00}
    cost = cost * localStorage.getItem("monta");
    document.getElementById("fcont-hinta").innerHTML = cost;
}
function valmis() {
    var varn = 0;
    for(var montako = 0; montako <= 5; montako++){
        if(localStorage.getItem(`aines${montako}`) === ""){
            varn++;
        }
    }
    if (varn >= 3) {
        alert("Valitse vähintään kolme ainesta")
    } else {
    let valitut = 0.50 * (localStorage.length - 4)
    let cost = 2 + valitut;
    if(localStorage.getItem("pohja") === "normi") {cost += 2.00} else {cost += 2.50}
    if(localStorage.getItem("koko") === "normi") {cost += 2.00} else {cost += 4.00}
    if(localStorage.getItem("kastike") === "normi") {cost += 2.00} else {cost +=3.00}
    if(localStorage.getItem("juusto") === "normi") {cost += 2.00} else {cost += 3.00}

    localStorage.setItem("täyttt", localStorage.getItem("aines1")+' '+
    localStorage.getItem("aines2")+' '+
    localStorage.getItem("aines3")+' '+
    localStorage.getItem("aines4")+' '+
    localStorage.getItem("aines5")+' '+
    localStorage.getItem("juusto")+' '+
    localStorage.getItem("kastike"));

    var täyt = localStorage.getItem("täyttt");

    let fantasia = {
        'nimi' : 'Fantasiapizza',
        'koko' : localStorage.getItem("koko"),
        'pohja' : localStorage.getItem("pohja"),
        'monta' : localStorage.getItem("monta"),
        'täytteet' : täyt,
        "cost" : cost,
    }

    localStorage.removeItem("pohja")
    localStorage.removeItem("koko")
    localStorage.removeItem("monta")
    localStorage.removeItem("juusto")
    localStorage.removeItem("kastike")
    localStorage.removeItem("cost")
    localStorage.removeItem("aines1")
    localStorage.removeItem("aines2")
    localStorage.removeItem("aines3")
    localStorage.removeItem("aines4")
    localStorage.removeItem("aines5")
    localStorage.removeItem("täyttt")

    if(localStorage.getItem("ostoskori") === null) {
        let ostoskori = [];
        ostoskori.push(fantasia);
        localStorage.setItem("ostoskori", JSON.stringify(ostoskori));
    }else {
        let fostoskori = JSON.parse(localStorage.getItem("ostoskori"));
        fostoskori.push(fantasia);
        localStorage.setObj("ostoskori", fostoskori);
    }
    }
}


