$(document).ready(function(){


	var carpeta = $("#carpeta").val();


    $('#buscarboleta').on('click', function(event){

    	event.preventDefault();
    	var ffin 		= $('#ffin').val();
    	var _token 		= $('#token').val();
		$(".listatablaboleta").html("");
		abrircargando();

		
		$(".menu-roles li").removeClass( "active" )
		$(this).parents('li').addClass("active");

        $.ajax({
            type	: 	"POST",
            url		: 	carpeta+"/ajax-listado-de-resumen-boleta-fecha",
            data	: 	{
            				_token	: _token,
            				ffin 	: ffin
            	 		},
            success: function (data) {
            	cerrarcargando();
            	$(".listatablaboleta").html(data);

            },
            error: function (data) {
            	cerrarcargando();
                console.log('Error:', data);
            }
        });

    });	


    $('#enviarboleta').on('click', function(event){
    	event.preventDefault();
    	$('#fechafin').val($('#ffin').val());
    	data = dataenviar();
    	if(data.length<=0){alerterrorajax('Seleccione por lo menos una boleta'); return false;}
    	var datastring = JSON.stringify(data);
    	$('#boleta').val(datastring);
    	abrircargando();
    	$( "#formboleta" ).submit();
    });




	$(".listatablaboleta").on('click','label', function() {

		var input 	= $(this).siblings('input');
		var accion	= $(this).attr('data-atr');

		var name	= $(this).attr('name');
		var check 	= -1;
		var estado 	= -1;
		

		if($(input).is(':checked')){

			check 	= 0;
			estado 	= false;

		}else{

			check 	= 1;
			estado 	= true;

		}

		validarrelleno(accion,name,estado,check);
		
	});


	function dataenviar(){
    	var data = [];
	    $(".listatabla tr").each(function(){
	    	check 	= $(this).find('input');
	    	nombre 	= $(this).find('input').attr('id');
	    	if(nombre != 'todo'){
		    	if($(check).is(':checked')){
				    data.push({id: $(check).attr("id")});
		    	}	    		
			}
    	});
    	return data;
	}


	function validarrelleno(accion,name,estado,check,token){

		if (accion=='todas') {

		    $(".listatabla tr").each(function(){
		    	nombre = $(this).find('input').attr('id');
		    	if(nombre != 'todo'){
		    		$(this).find('input').prop("checked", estado);
		    	}
	    	});
		}else{
			sw = 0;
			if(estado){
				$(".listatabla tr").each(function(){
			    	nombre = $(this).find('input').attr('id');
			    	if(nombre != 'todo'){
						if(!($(this).find('input').is(':checked'))){
							sw = sw + 1;
						}
			    	}
	    		});
	    		if(sw==1){
	    			$("#todo").prop("checked", estado);
	    		}
			}else{
				$("#todo").prop("checked", estado);
			}			
		}
	}




});