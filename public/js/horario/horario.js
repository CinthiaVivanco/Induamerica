$(document).ready(function(){
	var carpeta = $("#carpeta").val();
    var numero = $('.clockactivo').attr("data");

    jQuery('.scrollbar-inner').scrollbar();
    jQuery('.scrollbar-inner').scrollTop(numero*32.2);


    $('.selectsemana').on('click', function(event){
    	event.preventDefault();
    	var idsemana 			= $(this).attr("id");
    	var _token 				= $('#token').val();
		$(".listadohorario").html("");
		$(".menu-roles li").removeClass( "active" )
		$(this).parents('li').addClass("active");

        $.ajax({
            type	: 	"POST",
            url		: 	"/induamerica/ajax-listado-de-horario",
            data	: 	{
            				_token	 : _token,
            				idsemana : idsemana
            	 		},
            success: function (data) {
            	//console.log(data);
            	$(".listadohorario").html(data);
            },
            error: function (data) {
                console.log('Error:', data);
            }
        });

    });	


    $(".listadohorario").on('click','label', function() {

        var input   = $(this).siblings('input');
        var accion  = $(this).attr('data-atr');
        var name    = $(this).attr('name');
        var _token  = $('#token').val()
        var check   = -1;
        var estado  = -1;
        

        if($(input).is(':checked')){ 
            check   = 0;
            estado  = false;
        }else{
            check = 1;
            estado  = true;
        }

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-activar-horario-trabajador",
            data    :   {
                            _token  : _token,
                            name    : name,
                            check   : check,
                            accion  : accion
                        },
            success: function (data) {
                if(data>=0){
                    alertajax("Realizado con exito");
                }
                //console.log(data);
                
            },
            error: function (data) {
                console.log('Error:', data);
            }
        });

        
    });    



    $(".listadohorario").on('change','#horario_id', function() {

        var horario_id              = $(this).val();
        var idhorariotrabajador     = $(this).attr('data-id');
        var _token                  = $('#token').val();

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-select-horario-trabajador",
            data    :   {
                            _token              : _token,
                            idhorariotrabajador : idhorariotrabajador,
                            horario_id          : horario_id
                        },
            success: function (data) {

                if(data>=0){
                    alertajax("Realizado con exito");
                }
                //console.log(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });




});