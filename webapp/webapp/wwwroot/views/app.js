var formActivo = "";
document.addEventListener("DOMContentLoaded", e => {
    mnxAcademica.addEventListener("click", event => {
        event.preventDefault();
        abrirVentana(event.target.dataset.form);
    });
});

function abrirVentana(form) {
    let $ventana = $(`#${form}`); //#alumno, #materia, #docente, etc.
    if ($ventana.find("form").length > 0) {
        $ventana.show();
    } else {
        let url = `/views/${form}.html`;
        fetch(url).then(resp => resp.text()).then(vista => {
            $ventana.html(vista).draggable();
            cerrarVentana();
        });
    }
}
function cerrarVentana(){
    $('.btn-close').click(e => {
        console.log(e.target.dataset.form, e.target.dataset);
        $(`#${e.target.dataset.form}`).hide();
    });
}

async function obtenerDatos(buscar = '', form='Alumnos') {
    const respuesta = await fetch(`/api/${form}/buscar?buscar=${buscar}`, {
        method: "GET",
        header: { "Content-Type": "application/json" }
    }),
        datos = await respuesta.json();
    return datos;
}