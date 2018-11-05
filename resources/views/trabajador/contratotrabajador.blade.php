@extends('template')
@section('style')
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/datetimepicker/css/bootstrap-datetimepicker.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/select2/css/select2.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/bootstrap-slider/css/bootstrap-slider.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/personal/contrato.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/select2/css/select2.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/bootsnipp.css') }} "/>

    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/datatables/css/dataTables.bootstrap.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/scrollbar/scrollbar.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/bootstrap-select/css/bootstrap-select.min.css') }} "/>

    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/personal/contrato.css') }} "/>
    <script src="{{ asset('public/js/personal/contrato.js') }}" type="text/javascript"></script>

@stop
@section('section')

<div class="be-content ajaxpersonal">
  <div class="main-content container-fluid">

    <h2 class="panel-heading">Contrato del Trabajador :  {{$trabajador->apellidopaterno}} {{$trabajador->apellidomaterno}} {{$trabajador->nombres}}</h2>
  </div>


  <div class="container">
          <!-- Modal -->
          <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">
               <div class="modal-content">
                  <div class="modal-header">
                     <button type="button" class="close" data-dismiss="modal">×</button>
                     <h4 class="modal-title">Contrato de:  {{$trabajador->apellidopaterno}} {{$trabajador->apellidomaterno}} {{$trabajador->nombres}}</h4>
                  </div>
                  <div class="modal-body">
                      <div class="container">
                          <div class="row">
                              <div class="col-xs-12 col-sm-6 col-md-6">
                                  <div class="">
                                      <div class="row">
                                          <div class="col-sm-6 col-md-6 columna">

                                            <div class="form-group ">
                                                <label class="col-sm-12 control-label labelleft" >Tipo Contrato </label>
                                                <div class="col-sm-6 abajocaja"  >
                                                    {!! Form::select( 'tipocontrato_id', $combotipocontrato, array(),
                                                      [
                                                        'class'       => 'form-control control input-sm' ,
                                                        'id'          => 'tipocontrato_id',
                                                        'required'    => '',
                                                        'data-aw'     => '1'
                                                      ]) !!} 
                                                </div>

                                            </div>

                                            <div class="form-group">
                                              <label class="col-sm-12 control-label labelleft">
                                                Fecha Inicio
                                              </label> 
                                              <div class="col-sm-6 abajocaja">
                                                
                                              </div>
                                            </div>

                                            <div class="form-group">
                                              <label class="col-sm-12 control-label labelleft">
                                                Fecha Fin
                                              </label> 
                                              <div class="col-sm-6 abajocaja">
                                                <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                                                          <input size="16" type="text" value="@if(isset($contrato)){{old('fechafin',$contrato->fechafin)}}@else{{old('fechafin')}}@endif" placeholder="Fecha Hasta"
                                                          id='fechafin' name='fechafin' 
                                                          required = ""
                                                          class="form-control input-sm">
                                                          <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                                                </div>
                                              </div>
                                            </div>

                                            <div class="form-group ajaxcargo">
                                               @include('general.ajax.combocargo', ['combocargo' => $combocargo])
                                            </div>


                                             <div class="form-group">

                                                <label class="col-sm-12 control-label labelleft">Jornada Laboral<span class="required">*</span></label>
                                                <div class="col-sm-6 abajocaja jornada">
                                                  @foreach($jornadalaboral as $key=>$item)  

                                                    <div class="be-checkbox inline">

                                                      <input 
                                                      id="{{$item->id}}" 
                                                      value="{{$item->id}}" 
                                                      name="jornadalaboral[]" 
                                                      type="checkbox"
                                                      data-parsley-multiple="groups-jornada"                   
                                                      data-parsley-errors-container="#error-jornada"
                                                      data-parsley-mincheck="1" 
                                                      @if($key == count($jornadalaboral)-1) 
                                                          required=""  
                                                      @endif 

                                                      @if(isset($contrato))
                                                        @if($item->activo == '1') 
                                                          checked  
                                                        @endif 
                                                      @endif
                                                      >
                                                      <label for="{{$item->id}}">
                                                        <font style="vertical-align: inherit;">
                                                          <font   style="vertical-align: inherit;">{{$item->descripcion}}</font>
                                                        </font>
                                                      </label>
                                                    </div>
                                                  @endforeach
                                                    <div id="error-jornada"></div>
                                                </div>
                                              </div>

                                             <div class="form-group">

                                                  <label class="col-sm-12 control-label labelleft">Periodicidad <span class="required">*</span></label>
                                                  <div class="col-sm-7 abajocaja">
                                                      {!! Form::select( 'periodicidad_id', $comboperiodicidad, array(),
                                                                        [
                                                                          'class'       => 'form-control control input-sm' ,
                                                                          'id'          => 'periodicidad_id',
                                                                          'required'    => '',
                                                                          'data-aw'     => '24'
                                                                        ]) !!}
                                                  </div>
                                             </div>

                                          </div>
                                          <div class="col-sm-6 col-md-6 columna">

                                            <div class="form-group">
                                                <label class="col-sm-12 control-label labelleft">Observación</label>
                                                <div class="col-sm-6 abajocaja">

                                                  <input  type="text"
                                                          id="observacion" name='observacion' value="@if(isset($contrato)){{old('observacion',$contrato->observacion)}}@else{{old('observacion')}}@endif" placeholder="Observación"
                                                          required = ""
                                                          autocomplete="off" class="form-control input-sm" data-aw="3"/>
                                                          @include('error.erroresvalidate', [ 'id' => $errors->has('observacion')  , 
                                                                                      'error' => $errors->first('observacion', ':message') , 
                                                                                      'data' => '2'])

                                                </div>
                                            </div>

                                            <div class="form-group">
                                                <label class="col-sm-12 control-label labelleft">Estado</label>
                                                <div class="col-sm-6 abajocaja">

                                                  <div class="be-radio has-success inline">
                                                    <input type="radio" value="1"  

                                                      @if(isset($contrato)) 
                                                        @if($contrato->estado == 1) 
                                                          checked  
                                                        @endif 
                                                      @endif 
                                                      name="estado" id="rad1">
                                                    <label for="rad1">Activo</label>
                                                  </div>

                                                  <div class="be-radio has-danger inline">
                                                    <input type="radio" value='0'  

                                                      @if(isset($contrato)) 
                                                        @if($contrato->estado == 0) 
                                                          checked  
                                                        @endif 
                                                      @endif 
                                                      name="estado" id="rad2">
                                                    <label for="rad2">Concluido</label>
                                                  </div>
                                                  
                                                </div>
                                            </div> 

                                           <div class="form-group" >

                                                <label class="col-sm-12 control-label labelleft">Tipo Pago</label>
                                                <div class="col-sm-7 abajocaja">
                                                  {!! Form::select( 'tipopago_id', $combotipopago, array(),
                                                                    [
                                                                      'class'       => 'form-control control input-sm' ,
                                                                      'id'          => 'tipopago_id',
                                                                      'required'    => '',
                                                                      'data-aw'     => '22'
                                                                    ]) !!}
                                                </div>
                                            </div>

                                            <div class="form-group" >
                                                  <label class="col-sm-12 control-label labelleft">Número Cuenta</label>
                                                  <div class="col-sm-7 abajocaja">

                                                    <input  type="text"
                                                            id="numerocuenta" name='numerocuenta' value="@if(isset($contrato)){{old('numerocuenta',$contrato->numerocuenta)}}@else{{old('numerocuenta')}}@endif" placeholder="Número Cuenta"
                                                            required = ""
                                                            autocomplete="off" class="form-control input-sm" data-aw="23"/>

                                                  </div>
                                            </div>

                                            <div class="form-group">
                                                  <label class="col-sm-12 control-label labelleft">Remuneración</label>
                                                  <div class="col-sm-7 abajocaja">

                                                    <input  type="text"
                                                            id="remuneracion" name='remuneracion' value="@if(isset($contrato)){{old('remuneracion',$contrato->remuneracion)}}@else{{old('remuneracion')}}@endif" placeholder="Remuneración"
                                                            required = "" data-parsley-type="number"
                                                            autocomplete="off" class="form-control input-sm" data-aw="25"/>

                                                  </div>
                                            </div> 

                                          </div>
                                      </div>
                                  </div>
                              </div>
                          </div>
                      </div>
                      <div class="modal-footer">
                          <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
                      </div>
                  </div>
              </div>
            </div>
          </div>
  </div>



  <div class="main-content container-fluid editc">
    
    <div class="row">

      @foreach($listacontrato as $item)

        <div class="col-sm-4 container listacontrato @if($item->estado == 1) activo @else concluido @endif"">
            <div class="row">
             <div class="cont_princ_lists">
              <div class="col-xs-12 col-sm-6 col-md-4 col-lg-3 estilo ">
                <div class="offer offer-success cont_princ_lists estilo1" >
                  
                  <div class="shape">
                    <div class="shape-text">
                      act            
                    </div>
                  </div>

                  <div class="offer-content">
                    <h3 class="lead">
                     Contrato
                    </h3>           
                    <p>
                     Desde: {{$item->fechainicio}}  Hasta:  {{$item->fechafin}}
                      <br> 
                    </p>
                  </div>

                  <div class="col-sm-2 detver"> 
                      <div class="icon icono">
                            <span
                              data-toggle="modal" 
                              href="" 
                              data-target="#myModal"           
                              class="fa fa-eye" 
                              id='detver'
                              name='{{$item->id}}' 
                              data_opcion='{{$idopcion}}'
                              data_trabajador='{{Hashids::encode(substr($trabajador->id, -12))}}'>
                            </span>
                      </div>
                  </div>

                  <div class="col-sm-2 detmodificar"> 

                          <div class="icon icono"><span 
                                          
                                class="fa fa-pencil" 
                                id='btnmodificarc'
                                name='{{$item->id}}' 
                                data_opcion='{{$idopcion}}'
                                data_trabajador='{{Hashids::encode(substr($trabajador->id, -12))}}'
                                ></span></div>
                  </div>

                <div class="row content ">
                  <div class="col-md-12">
                    <div class="panel-heading">

                      <div class="tools toolsopcion">
                        <a href="{{url('/contrato-trabajador-pdf/'.Hashids::encode(substr($item->id, -12)))}}" target="_blank" data-toggle="tooltip" id="descargarcontrato" data-placement="top" title="">
                            <span class="icon mdi mdi-collection-pdf icono"></span>
                        </a>

                      </div>
                    </div>
                   </div>
                </div>
                  

                </div>
              </div>
            </div>
            </div>
        </div>
                 
    @endforeach

    </div>
  </div>


  <div class="main-content container-fluid">
    <div class="row">
          <div class="col-md-12">
            <div class="panel panel-default panel-border-color panel-border-color-primary">
              <div class="panel-heading panel-heading-divider" >Contrato<span class="panel-subtitle">Crear el Contrato</span></div>
              
              <div class="panel-body">

                <div class="main-content container-fluid ajaxformc">

                  <form method="POST" action="{{ url('/ficha-contrato-trabajador/'.$idopcion.'/'.Hashids::encode(substr($trabajador->id, -12))) }}" style="border-radius: 0px;" class="form-horizontal group-border-dashed"> 
                                    {{ csrf_field() }}
                        @include('trabajador.form.contrato')
                  </form>

                
              </div>
            </div>
          </div>
        </div>
    </div>


   </div>
</div>

@stop

@section('script')



    <script src="{{ asset('public/lib/jquery-ui/jquery-ui.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/jquery.nestable/jquery.nestable.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/moment.js/min/moment.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datetimepicker/js/bootstrap-datetimepicker.min.js') }}" type="text/javascript"></script>        
    <script src="{{ asset('public/lib/select2/js/select2.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/bootstrap-slider/js/bootstrap-slider.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/js/app-form-elements.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/parsley/parsley.js') }}" type="text/javascript"></script>


    <script src="{{ asset('public/js/general/jquery.scrollbar.js') }}" type="text/javascript"></script> 
    <script src="{{ asset('public/lib/datatables/js/jquery.dataTables.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/js/dataTables.bootstrap.min.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/dataTables.buttons.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/buttons.html5.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/buttons.flash.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/buttons.print.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/buttons.colVis.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/lib/datatables/plugins/buttons/js/buttons.bootstrap.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/js/app-tables-datatables.js') }}" type="text/javascript"></script>


    <script type="text/javascript">
      $(document).ready(function(){  

        //initialize the javascript
        App.init();
        App.dataTables();
        $('[data-toggle="tooltip"]').tooltip();
        App.formElements();
        $('form').parsley();

        $(".ajaxpersonal").on('click','#guardarcontrato', function() {

            var $form = $('form');
            $form.parsley().validate()


            $(".tab-content .tab-pane").each(function(index){


                var error = $(this).find('.filled').html();
                var menu  = $(this).attr('id');

                if (error === undefined || error === null || error === '') {
                    $(".tab"+menu+' .errortab').css("display", "none");
                    $(".tab"+menu+' .bientab').css("display", "block");
                }else{
                    $(".tab"+menu+' .errortab').css("display", "block");
                    $(".tab"+menu+' .bientab').css("display", "none");
                }

            });


        });


      });
    </script> 
    <script src="{{ asset('public/js/personal/personal.js') }}" type="text/javascript"></script>
    <script src="{{ asset('public/js/personal/contrato.js') }}" type="text/javascript"></script>
@stop