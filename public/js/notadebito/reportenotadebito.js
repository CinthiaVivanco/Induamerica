$(document).ready(function(){


	var carpeta = $("#carpeta").val();

    $('#buscarreportenotadebito').on('click', function(event){

    	event.preventDefault();
    	var finicio 	= $('#finicio').val();
    	var ffin 		= $('#ffin').val();
    	var _token 		= $('#token').val();
		$(".listatablanotadebito").html("");
		abrircargando();

		
		$(".menu-roles li").removeClass( "active" )
		$(this).parents('li').addClass("active");

        $.ajax({
            type	: 	"POST",
            url		: 	carpeta+"/ajax-reporte-de-notadebito-entrefechas",
            data	: 	{
            				_token	: _token,
            				finicio : finicio,
            				ffin 	: ffin
            	 		},
            success: function (data) {
            	cerrarcargando();
            	$(".listatablanotadebito").html(data);

            },
            error: function (data) {
            	cerrarcargando();
                console.log('Error:', data);
            }
        });

    });	




});