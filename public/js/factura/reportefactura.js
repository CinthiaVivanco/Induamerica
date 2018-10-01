$(document).ready(function(){


	var carpeta = $("#carpeta").val();

    $('#buscarreportefactura').on('click', function(event){

    	event.preventDefault();
    	var finicio 	= $('#finicio').val();
    	var ffin 		= $('#ffin').val();
    	var _token 		= $('#token').val();
		$(".listatablafactura").html("");
		abrircargando();

		
		$(".menu-roles li").removeClass( "active" )
		$(this).parents('li').addClass("active");

        $.ajax({
            type	: 	"POST",
            url		: 	carpeta+"/ajax-reporte-de-facturas-entrefechas",
            data	: 	{
            				_token	: _token,
            				finicio : finicio,
            				ffin 	: ffin
            	 		},
            success: function (data) {
            	cerrarcargando();
            	$(".listatablafactura").html(data);

            },
            error: function (data) {
            	cerrarcargando();
                console.log('Error:', data);
            }
        });

    });	




});