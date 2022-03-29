document.addEventListener("DOMContentLoaded", puraOstoskori)

Storage.prototype.setObj = function(key, obj) {
    return this.setItem(key, JSON.stringify(obj))
}
Storage.prototype.getObj = function(key) {
    return JSON.parse(this.getItem(key))
}

function ostoskorireset() {
    localStorage.removeItem('ostoskori'); 
    location.reload;
}

var j = 0;
var array = ['nimi', 'koko', 'pohja', 'täytteet', 'monta', 'cost'];
var taulu = document.getElementById('ostoskori-table');
function puraOstoskori() {
    let ostoskori = localStorage.getObj('ostoskori');
    for(var i = 0; i <= ostoskori.length - 1; i++){
        var ostt = [ostoskori[i]];
        ostt.forEach((element, index) => {
            for(var d = 0;d <= 5; d++){
                if(ostoskori[i][array[d]] === null || ostoskori[i][array[d]] === "null"){
                    document.getElementsByTagName('td')[j].innerHTML = "";
                }else {
                    document.getElementsByTagName('td')[j].innerHTML = ostoskori[i][array[d]];
                };
            
            j++;
            }
        }); 
    }
    console.log(document.getElementsByTagName('td'))
    var yhteensä = parseFloat(document.getElementsByTagName('td')[5].innerHTML) + parseFloat(document.getElementsByTagName('td')[11].innerHTML) + parseFloat(document.getElementsByTagName('td')[17].innerHTML) +parseFloat(document.getElementsByTagName('td')[23].innerHTML)  + parseFloat(document.getElementsByTagName('td')[29].innerHTML);
    document.getElementById('fcont-hinta-yhteensä').innerHTML = yhteensä;
    for(var i = 10;i >= 0; i--){
        if(i > ostoskori.length){
            deleteRow(i);
        };
    }
}

function deleteRow(r) {
    document.getElementById("ostoskori-tablee").deleteRow(r);
};

function kuljetus() {
    
}