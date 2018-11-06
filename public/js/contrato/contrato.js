
$(document).ready(function(){

    var carpeta = $("#carpeta").val();

    $(".detver").on('click','.icono', function() {

        var idcontrato      = $(this).find('span').attr('name');
        var _token          = $('#token').val();
        $(".ajax-modal").html(""); // se limpia ese contenedor

        $.ajax({
            type    :   "POST",
            url     :   carpeta+"/ajax-modal-contrato",
            data    :   {
                            _token          : _token,
                            idcontrato      : idcontrato,
                                                    
                        },
            success: function (data) {

                $(".ajax-modal").html(data);  // ajax nos pide el sector que se va actualizar en este caso vamos aca

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });

    var today = new Date(new Date().getFullYear(), new Date().getMonth(), new Date().getDate());

        $('#fechainicio').datepicker({
            minDate: today,
            maxDate: function () {
                return $('#fechafin').val();
            }
        });
        $('#fechafin').datepicker({
            minDate: function () {
                return $('#fechainicio').val();
            }
        });


}); 
