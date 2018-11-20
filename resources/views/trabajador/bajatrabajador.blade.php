@extends('template')
@section('style')

    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/datetimepicker/css/bootstrap-datetimepicker.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/select2/css/select2.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/bootstrap-slider/css/bootstrap-slider.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/alfasweb.css')}}"/>

@stop
@section('section')


<div class="be-content">
  <div class="main-content container-fluid">

    <!--Basic forms-->
    <div class="row">
      <div class="col-md-12">
        <div class="panel panel-default panel-border-color panel-border-color-primary">
          <div class="panel-heading panel-heading-divider" >TRABAJADOR<span class="panel-subtitle">Baja a un Trabajador</span></div>
          <div class="panel-body">
            <form method="POST" action="{{ url('/gestion-baja-trabajador/'.$idopcion) }}" style="border-radius: 0px;" class="form-horizontal group-border-dashed">
                  {{ csrf_field() }}

              <div class="col-sm-6">        
                  <div class="form-group">
                    <label class="col-sm-3 control-label labeldni">Dni</label><br>
                    <div class="col-sm-5 input-group dnibaja">
                          <input  type="text"
                            id="dni" name='dni' placeholder="Ingrese Dni"                          
                            autocomplete="off" class="form-control input-sm" data-aw="1"/>

                             <span class="input-group-btn">
                             <button id='buscartrabajadorbaja' type="button" class="btn btn-primary bajatrabajador"><font style="vertical-align: inherit;"><font style="vertical-align: inherit;">Buscar</font></font></button></span>
                      
                    </div>
                  </div>
              </div>

              <div class="col-sm-6">  

                  <div class="form-group">
                    <label class="col-sm-12 control-label labelleft">Estado</label>
                    <div class="col-sm-7">
                      <div class="be-radio has-success inline">
                        <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->activo == 1) checked  @endif @else checked @endif name="activo" id="rad28">
                        <label for="rad28">Activado</label>
                      </div>
                      <div class="be-radio has-danger inline ">
                        <input type="radio" value='0'  @if(isset($trabajador)) @if($trabajador->activo == 0) checked  @endif @endif name="activo" id="rad29">
                        <label for="rad29">Desactivado</label>
                      </div>
                    </div>
                  </div>

              </div>

              <div class="row">
                    <div class="col-md-10 bajatrabajadordatos">

                        <div class="contentestudios" id="contentestudiosid">
                            <div class="panelestudios panel-defaultestudios">
                                <div class="panel-headingestudios">
                                  Datos del Trabajador
                                </div>
                                <div class="panel-bodyestudios">                     
                                  <div class="row">
                                    <div class= 'trabajadorencontradobaja'>

                                      <div class="form-group">
                                          <label class="col-sm-3 control-label">Nombre</label>
                                          <div class="col-sm-5">
                                            <input  type="text"
                                                    id="nombre" name='nombre'  placeholder="Nombre del Trabajador"
                                                    required = ""
                                                    autocomplete="off" class="form-control input-sm" data-aw="1"/>
                                          </div>
                                        
                                          <input  type="hidden" id="trabajador_id" name='trabajador_id'/>
                                      </div>

                                      <div class="form-group">
                                          <label class="col-sm-3 control-label">Apellido Paterno</label>
                                          <div class="col-sm-5">
                                            <input  type="text"
                                                    id="apellidopaterno" name='apellidopaterno'  placeholder="Apellido del Trabajador"
                                                    required = ""
                                                    autocomplete="off" class="form-control input-sm" data-aw="1"/>
                                          </div>                                        
                                          <input  type="hidden" id="trabajador_id" name='trabajador_id'/>
                                      </div>

                                      <div class="form-group">
                                          <label class="col-sm-3 control-label">Apellido Materno</label>
                                          <div class="col-sm-5">
                                            <input  type="text"
                                                    id="apellidomaterno" name='apellidomaterno'  placeholder="Apellido del Trabajador"
                                                    required = ""
                                                    autocomplete="off" class="form-control input-sm" data-aw="1"/>
                                          </div>                                        
                                          <input  type="hidden" id="trabajador_id" name='trabajador_id'/>
                                      </div>

                                    </div>
                                  </div>
                                </div>
                            </div>
                        </div>

                    </div>
              </div>

            </form>
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

    <script type="text/javascript">
      $(document).ready(function(){
        //initialize the javascript
        App.init();
        App.formElements();
        $('form').parsley();
      });
    </script> 

    <script src="{{ asset('public/js/user/user.js') }}" type="text/javascript"></script>
@stop
