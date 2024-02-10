$(document).ready(function () {

});

$('#mediaText').focusout(function () {
    let valoresMedia = $('#mediaText').val();
    if (valoresMedia != "") {
        $('#selectAgenteMedia').removeAttr("disabled");
    } else {
        $('#selectAgenteMedia').attr("disabled");
    }
});

$('#selectAgenteMedia').change(function () {
    let agente = $('#selectAgenteMedia').val();
    let mediaText = $('#mediaText').val();

    switch (agente) {
        case "1":

            $.ajax({
                type: "POST",
                url: 'Default.aspx/MediaAgenteA',
                data: '{ mediaText:'+mediaText+'}',
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log(response); // Manejar la respuesta del servidor
                    $('#resultadoMedia').val(response);
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) { // función que va a ejecutar si hubo algún tipo de error en el pedido
                    var error = eval("(" + XMLHttpRequest.responseText + ")");
                    console.log(error.Message);
                }
            });
            break;
        case "2":
            $.ajax({
                type: "POST",
                url: "Default.aspx/MediaAgenteB",
                data: JSON.stringify({ mediaText: mediaText }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log(response.d); // Manejar la respuesta del servidor
                    $('#resultadoMedia').val(response);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log("Error en la solicitud AJAX: " + errorThrown);
                }
            });
            break;
        case "3":
            $.ajax({
                type: "POST",
                url: "Default.aspx/MediaAgenteC",
                data: JSON.stringify({ mediaText: mediaText }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log(response.d); // Manejar la respuesta del servidor
                    $('#resultadoMedia').val(response);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log("Error en la solicitud AJAX: " + errorThrown);
                }
            });
            break;
        default:
            $('#resultadoMedia').val("");
            break;
    }
});

$('#escaleraValue').focusout(function () {
    let valorNumero = $('#escaleraValue').val();
    if (valorNumero != "") {
        $('#selectAgenteEscalera').removeAttr("disabled");
    } else {
        $('#selectAgenteEscalera').attr("disabled");
    }
});

$('#selectAgenteEscalera').change(function () {
    let agente = $('#selectAgenteEscalera').val();
    let valorNumero = $('#escaleraValue').val();

    switch (agente) {
        case "1":
            $.ajax({
                type: "POST", 
                url: "App_Start/Clases/A.cs/getStaircase",
                data: valorNumero,
                dataType: "int",
                success: function (response) {
                    console.log(response.d); // Manejar la respuesta del servidor
                    $('#resultadoEscalera').val(response);
                },
                error: function (XMLHttpRequest, textStatus, errorThrown) { // función que va a ejecutar si hubo algún tipo de error en el pedido
                    var error = eval("(" + XMLHttpRequest.responseText + ")");
                    console.log(error.Message);
                }
            });
            break;
        case "2":
            $.ajax({
                type: "POST",
                url: "Default.aspx/EscaleraAgenteB",
                data: JSON.stringify({ numero: valorNumero }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log(response.d); // Manejar la respuesta del servidor
                    $('#resultadoEscalera').val(response);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log("Error en la solicitud AJAX: " + errorThrown);
                }
            });
            break;
        case "3":
            $.ajax({
                type: "POST",
                url: "Default.aspx/EscaleraAgenteC",
                data: JSON.stringify({ numero: valorNumero }),
                contentType: "application/json; charset=utf-8",
                dataType: "json",
                success: function (response) {
                    console.log(response.d); // Manejar la respuesta del servidor
                    $('#resultadoEscalera').val(response);
                },
                error: function (xhr, textStatus, errorThrown) {
                    console.log("Error en la solicitud AJAX: " + errorThrown);
                }
            });
            break;
        default:
            $('#resultadoMedia').val("");
            break;
    }
});

