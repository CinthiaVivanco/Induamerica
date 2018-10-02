$(document).ready(function(){



    $(function(){
        $('.btn-circle').on('click',function(){
            $('.btn-circle.btn-info').removeClass('btn-info').addClass('btn-default');
            $(this).addClass('btn-info').removeClass('btn-default').blur();
        });

        $('.next-step, .prev-step').on('click', function (e){
       var $activeTab = $('.tab-pane.active');

       $('.btn-circle.btn-info').removeClass('btn-info').addClass('btn-default');

       if ( $(e.target).hasClass('next-step') )
       {
          var nextTab = $activeTab.next('.tab-pane').attr('id');
          $('[href="#'+ nextTab +'"]').addClass('btn-info').removeClass('btn-default');
          $('[href="#'+ nextTab +'"]').tab('show');
       }
       else
       {
          var prevTab = $activeTab.prev('.tab-pane').attr('id');
          $('[href="#'+ prevTab +'"]').addClass('btn-info').removeClass('btn-default');
          $('[href="#'+ prevTab +'"]').tab('show');
       }
     });
    });


    /* FIN DE LA FICHA TRABAJADOR*/


    $(".editdh").on('click','#btnmodificar', function() {

        
        var id              = $(this).attr('name');
        var idopcion        = $(this).attr('data_opcion');
        var idtrabajador    = $(this).attr('data_trabajador');
        
        var _token          = $('#token').val();


        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-form-derechohabiente",
            data    :   {
                            _token          : _token,
                            id              : id,
                            idopcion        : idopcion,
                            idtrabajador    : idtrabajador                                                       
                        },
            success: function (data) {

                $(".ajaxformdh").html(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });


    $(".editfs").on('click','#btnmodificarfs', function() {

        
        var id              = $(this).attr('name');
        var idopcion        = $(this).attr('data_opcion');
        var idtrabajador    = $(this).attr('data_trabajador');
        
        var _token          = $('#token').val();

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-form-fichasocioeconomica",
            data    :   {
                            _token          : _token,
                            id              : id,
                            idopcion        : idopcion,
                            idtrabajador    : idtrabajador                                                       
                        },
            success: function (data) {

                $(".ajaxformfs").html(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });


    $(".editc").on('click','#btnmodificarc', function() {

        
        var id              = $(this).attr('name');
        var idopcion        = $(this).attr('data_opcion');
        var idtrabajador    = $(this).attr('data_trabajador');
        
        var _token          = $('#token').val();

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-form-contrato",
            data    :   {
                            _token          : _token,
                            id              : id,
                            idopcion        : idopcion,
                            idtrabajador    : idtrabajador                                                       
                        },
            success: function (data) {

                $(".ajaxformc").html(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });
    


    $(".ajaxpersonal").on('change','#regimeninstitucion_id', function() {

        var regimeninstitucion_id = $('#regimeninstitucion_id').val();
        var _token      = $('#token').val();

        $.ajax({

            type    :   "POST",
            url     :   "/induamerica/ajax-select-tipoinstitucion",
            data    :   {
                            _token  : _token,
                            regimeninstitucion_id : regimeninstitucion_id
                        },
            success: function (data) {

                $(".ajaxtipoinstitucion").html(data);
            },
            error: function (data) {

                console.log('Error:', data);
            }
        });
    });


	$(".ajaxpersonal").on('change','#departamentos_id', function() {
		var departamentos_id = $('#departamentos_id').val();
    	var _token 		= $('#token').val();

        $.ajax({
            
            type	: 	"POST",
            url		: 	"/induamerica/ajax-select-provincia",
            data	: 	{
            				_token	: _token,
            				departamentos_id : departamentos_id
            	 		},
            success: function (data) {

            	$(".ajaxprovincia").html(data);
            },
            error: function (data) {

                console.log('Error:', data);
            }
        });
    });


	$(".ajaxpersonal").on('change','#provincia_id', function() {

		var provincia_id = $('#provincia_id').val();

    	var _token 		= $('#token').val();

        $.ajax({

            type	: 	"POST",
            url		: 	"/induamerica/ajax-select-distrito",
            data	: 	{
            				_token	: _token,
            				provincia_id : provincia_id
            	 		},
            success: function (data) {

            	$(".ajaxdistrito").html(data);
            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });

    $(".ajaxpersonal").on('change','#vinculofamiliar_id', function() {
        var vinculofamiliar_id = $('#vinculofamiliar_id').val();
        var _token      = $('#token').val();
        //este es un punto de quiebre debugger
        //debugger;

        $.ajax({
            
            type    :   "POST",
            url     :   "/induamerica/ajax-select-tipodocumentoacredita",
            data    :   {
                            _token  : _token,
                            vinculofamiliar_id : vinculofamiliar_id
                        },
            success: function (data) {

                $(".ajaxtipodocumentoacredita").html(data);
            },
            error: function (data) {

                console.log('Error:', data);
            }
        });
    });






    $(".ajaxpersonal").on('change','#tipoinstitucion_id', function() {

        var tipoinstitucion_id = $('#tipoinstitucion_id').val();

        var _token      = $('#token').val();

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-select-institucion",
            data    :   {
                            _token  : _token,
                            tipoinstitucion_id : tipoinstitucion_id
                        },
            success: function (data) {

                $(".ajaxinstitucion").html(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });


    $(".ajaxpersonal").on('change','#institucion_id', function() {

        var institucion_id = $('#institucion_id').val();
        var _token      = $('#token').val();

        $.ajax({
            type    :   "POST",
            url     :   "/induamerica/ajax-select-carrera",
            data    :   {
                            _token  : _token,
                            institucion_id : institucion_id
                        },
            success: function (data) {

                $(".ajaxcarrera").html(data);

            },
            error: function (data) {

                console.log('Error:', data);
            }
        });

    });



});