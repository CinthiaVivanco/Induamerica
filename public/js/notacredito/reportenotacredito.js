$(document).ready(function(){


	var carpeta = $("#carpeta").val();

    $('#buscarreportenotacredito').on('click', function(event){

    	event.preventDefault();
    	var finicio 	= $('#finicio').val();
    	var ffin 		= $('#ffin').val();
    	var _token 		= $('#token').val();
		$(".listatablanotacredito").html("");
		abrircargando();

		
		$(".menu-roles li").removeClass( "active" )
		$(this).parents('li').addClass("active");

        $.ajax({
            type	: 	"POST",
            url		: 	carpeta+"/ajax-reporte-de-notacredito-entrefechas",
            data	: 	{
            				_token	: _token,
            				finicio : finicio,
            				ffin 	: ffin
            	 		},
            success: function (data) {
            	cerrarcargando();
            	$(".listatablanotacredito").html(data);

            },
            error: function (data) {
            	cerrarcargando();
                console.log('Error:', data);
            }
        });

    });	




});