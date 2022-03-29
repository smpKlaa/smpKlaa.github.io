let ostoskori = []


Storage.prototype.setObj = function(key, obj) {
    return this.setItem(key, JSON.stringify(obj))
}
Storage.prototype.getObj = function(key) {
    return JSON.parse(this.getItem(key))
}

const menu = {
    "salami" : 8.50,
    "mexicana" : 10,
    "kolmenjuuston" : 10.50,
    "opera" : 8.50,
    "dillinger" : 10.50,
    "italia" : 9.50,
}



//NavBar Fade alkaa
window.addEventListener("scroll", function() {
    if (window.scrollY < 50) {
        $('nav').removeClass('navbar');
        $('nav').addClass('navbar-up');
    } else {
        $('nav').removeClass('navbar-up');
        $('nav').addClass('navbar');
    }
}, false);
//NavBar fade loppuu

function lisaatuote(pizza, täytteet, koko, pohja, monta, cost) {
    var _koko = $((":radio[name="+koko+"]:checked")).val();
    var _pohja = $((":radio[name="+pohja+"]:checked")).val();
    var _monta = document.getElementById(monta).value;
    var _cost = cost * _monta;
    console.log(pizza, täytteet, _koko, _pohja, _monta);

    var _pizza = kokoaobj(pizza, täytteet, _koko, _pohja, _monta, _cost)
    console.log("piz", _pizza)
    if(pohja == "gluteeniton"){
        hinta = hinta + 2;
    }
    if(localStorage.getItem("ostoskori") === null) {
        let ostoskori = [];
        ostoskori.push(_pizza);
        localStorage.setItem("ostoskori", JSON.stringify(ostoskori));
    }else {
        let fostoskori = localStorage.getObj("ostoskori");
        fostoskori.push(_pizza);
        localStorage.setObj("ostoskori", fostoskori);
    }
}


function kokoaobj(pizza, täytteet, _koko, _pohja, _monta, cost) {
    return obj = {
        'nimi' : pizza,
        'cost' : cost,
        'täytteet' : täytteet,
        'koko' :_koko,
        'pohja' :_pohja,
        'monta' :_monta
    };
}

function palautet() {
    var palauteNimi = document.getElementById("palaute-nimi").value;
    alert("Kiitos palautteesta " + palauteNimi+ "!");
}
