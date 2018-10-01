@extends('template')
@section('style')
    <link rel="stylesheet" type="text/css" href="{{ asset('public/lib/datatables/css/dataTables.bootstrap.min.css') }} "/>
    <link rel="stylesheet" type="text/css" href="{{ asset('public/css/scrollbar/scrollbar.css') }} "/>

@stop
@section('section')






<div class="be-content">
  <div class="main-content container-fluid">
    <div class="row">
      <div class="col-sm-12">
        <!--Dropdowns-->
        <div class="panel panel-default">
          <div class="panel-heading panel-heading-divider">Semanas<span class="panel-subtitle">Lista de semanas para asignar horario (seleccione una semana)</span></div>
          <div class="panel-body">
            <h4 class="xs-mb-20">Semanas</h4>
            <div class="content row dropdown-showcase">
              <!--Basic Dropdown-->
              <div class="demo col-xs-3">

                <div class="dropdown scrollbar-inner">
                  <ul style="display: block; position: relative;" class="dropdown-menu menu-roles ">
                    @foreach($listasemana as $item)
                       <li >
                          <a href="#"  id="{{Hashids::encode(substr($item->id, -12))}}" 
                          class="selectsemana">
                            <span class="icon mdi mdi-time @if ($hoy >= $item->fechainicio &&  $hoy <= $item->fechafin) clockactivo @endif" data='{{$item->numero}}'></span>

                            ({{date_format(date_create($item->fechainicio), 'd/m/Y')}}) - 
                            ({{date_format(date_create($item->fechafin), 'd/m/Y')}})
                          </a>
                       </li>  
                    @endforeach  
                  </ul> 
                </div>

              </div>


              <div class="panel panel-default col-xs-9">
                <div class="listajax panel-body listadohorario">





                </div>
              </div>

            </div>
          </div>
        </div>
      </div>
    </div>
  </div>
</div>




@stop

@section('script')


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
      });
    </script>

    <script src="{{ asset('public/js/horario/horario.js') }}" type="text/javascript"></script> 
@stop