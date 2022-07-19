function cambiarTab(event) {
    // Mirar el evento donde se ha hecho click
    // console.log(event.target.id);
    let tabPulsada = event.target.id;
    let tab1 = document.getElementById("tab-1");
    let tab2 = document.getElementById("tab-2");
    let tab3 = document.getElementById("tab-3");

    // El switch simplifica un if else encadenado
    switch (tabPulsada) {
        case "boton-1":
            tab1.classList.add("active-tab");
            tab2.classList.remove("active-tab");
            tab3.classList.remove("active-tab");
            break;

        case "boton-2":
            tab1.classList.remove("active-tab");
            tab2.classList.add("active-tab");
            tab3.classList.remove("active-tab");
            break;

        case "boton-3":
            tab1.classList.remove("active-tab");
            tab2.classList.remove("active-tab");
            tab3.classList.add("active-tab");
            break;

        default:
            break;
    }
}