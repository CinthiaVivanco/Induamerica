<div class="containertab">
 <div class="row">
  <div class="process">
   <div class="process-row nav nav-tabs">

    <div class="process-step tabmenu1">
     <button type="button" class="btn btn-info btn-circle" data-toggle="tab" href="#menu1"><i class="fa fa-file-text fa-2x"></i></button>
     <p><small>Datos <br />Personales</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i> 
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step tabmenu2">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu2"><i class="fa fa-briefcase fa-2x"></i></button>
     <p><small>Datos<br />Laborales</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step  tabmenu3">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu3"><i class="fa fa-graduation-cap fa-2x"></i></button>
     <p><small>Grado<br />Académico</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step tabmenu4">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu4"><i class="fa fa-home fa-2x"></i></button>
     <p><small>Datos<br />Domicilio</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step tabmenu5">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu5"><i class="fa fa-pencil-square-o fa-2x"></i></button>
     <p><small>Contrato y<br />Pago</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step tabmenu6">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu6"><i class="fa fa-user-md fa-2x"></i></button>
     <p><small>Seguridad <br />Social</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
     <div class='bientab'>
       <i class="fa fa-check" aria-hidden="true"></i> 
     </div>
    </div>

    <div class="process-step tabmenu7">
     <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu7"><i class="fa fa-check fa-2x"></i></button>
     <p><small>Guardar<br />Ficha</small></p>
     <div class='errortab'>
       <i class="fa fa-exclamation" aria-hidden="true"></i>
     </div>
    </div>

   </div>
  </div>
  <div class="tab-content">
       <div id="menu1" class="tab-pane fade active in">
        <h3></h3>

        <div class="row">
          <div class="col-sm-6">        
            <div class="panel-body">
              <div class="form-group ">

                <label class="col-sm-12 control-label labelleft" >Tipo Documento  <span class="required">*</span> </label>
                <div class="col-sm-7 abajocaja" >
                  {!! Form::select( 'tipodocumento_id', $combotipodocumento, array(),
                                    [
                                      'class'       => 'form-control control input-sm' ,
                                      'id'          => 'tipodocumentos_id',
                                      'required'    => '',
                                      'data-aw'     => '1'
                                    ]) !!}
                </div>
              </div>



                <div class="form-group">
                  <label class="col-sm-12 control-label labelleft">DNI <span class="required">*</span></label>
                  <div class="col-sm-7 abajocaja">

                    <input  type="text"
                            id="dni" name='dni' value="@if(isset($trabajador)){{old('dni' ,$trabajador->dni)}}@else{{old('dni')}}@endif" placeholder="DNI"
                            required = "" data-parsley-minlength="8" data-parsley-maxlength="8" data-parsley-type="number"
                            autocomplete="off" class="form-control input-sm" data-aw="2"/>

                      @include('error.erroresvalidate', [ 'id' => $errors->has('dni')  , 
                                                          'error' => $errors->first('dni', ':message') , 
                                                          'data' => '2'])

                  </div>
                </div>


                <div class="form-group">
                  <label class="col-sm-12 control-label labelleft">Apellido Paterno <span class="required">*</span></label>
                  <div class="col-sm-7 abajocaja">

                    <input  type="text"
                            id="apellidopaterno" name='apellidopaterno' value="@if(isset($trabajador)){{old('apellidopaterno',$trabajador->apellidopaterno)}}@else{{old('apellidopaterno')}}@endif" placeholder="Apellido Paterno"
                            required = ""
                            autocomplete="off" class="form-control input-sm" data-aw="3"/>

                  </div>
                </div>

                <div class="form-group">
                  <label class="col-sm-12 control-label labelleft">Apellido Materno <span class="required">*</span></label>
                  <div class="col-sm-7 abajocaja">

                    <input  type="text"
                            id="apellidomaterno" name='apellidomaterno' value="@if(isset($trabajador)){{old('apellidomaterno',$trabajador->apellidomaterno)}}@else{{old('apellidomaterno')}}@endif" placeholder="Apellido Materno"
                            required = ""
                            autocomplete="off" class="form-control input-sm" data-aw="4"/>

                  </div>
                </div>

                <div class="form-group">
                <label class="col-sm-12 control-label labelleft">Nombres <span class="required">*</span></label>
                <div class="col-sm-7 abajocaja">

                  <input  type="text"
                          id="nombre" name='nombre' value="@if(isset($trabajador)){{old('nombre',$trabajador->nombres)}}@else{{old('nombre')}}@endif" placeholder="Nombres" required = ""
                          autocomplete="off" class="form-control input-sm" data-aw="5"/>

                </div>
              </div> 

              <div class="form-group">

                <label class="col-sm-12 control-label labelleft">Nacionalidad <span class="required">*</span></label>
                <div class="col-sm-7 abajocaja">
                  {!! Form::select( 'nacionalidad_id', $combonacionalidad, array(),
                                    [
                                      'class'       => 'form-control control input-sm' ,
                                      'id'          => 'nacionalidades_id',
                                      'required'    => '',
                                      'data-aw'     => '9'
                                    ]) !!}
                </div>
              </div>

            

          </div>
      
            </div>

            <div class="col-sm-6">

          <div class="panel-body">



            <div class="form-group">
                <label class="col-sm-12 control-label labelleft">
                  Fec Nacimiento <span class="required">*</span>
                </label> 
                <div class="col-sm-7 abajocaja">
                  <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                            <input size="16" type="text" value="@if(isset($trabajador)){{old('fechanacimiento',$trabajador->fechanacimiento)}}@else{{old('fechanacimiento')}}@endif" placeholder="Fecha Nacimiento"
                            id='fechanacimiento' name='fechanacimiento' 
                            required = ""
                            class="form-control input-sm">
                            <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                  </div>
                </div>
              </div>

             <div class="form-group">
                <label class="col-sm-12 control-label labelleft">Sexo <span class="required">*</span></label>
                <div class="col-sm-7 abajocaja">
                  <div class="be-radio has-success inline">
                    <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->sexo == 1) checked  @endif @else checked @endif name="sexo" id="rad1">
                    <label for="rad1">Masculino</label>
                  </div>
                  <div class="be-radio has-danger inline">
                    <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->sexo == 0) checked  @endif @endif name="sexo" id="rad2">
                    <label for="rad2">Femenino</label>
                  </div>
                </div>
              </div> 



              <div class="form-group">
                <label class="col-sm-12 control-label labelleft">Telefono <span class="required">*</span> </label>
                <div class="col-sm-7 abajocaja">

                  <input  type="text"
                          id="telefono" name='telefono' value="@if(isset($trabajador)){{old('telefono',$trabajador->telefono)}}@else{{old('telefono')}}@endif"placeholder="Telefono"
                          required = "" data-parsley-type="number"
                          autocomplete="off" class="form-control input-sm" data-aw="6"/>

                </div>
              </div>

              <div class="form-group">
                <label class="col-sm-12 control-label labelleft">Email <span class="required">*</span></label>
                <div class="col-sm-7 abajocaja">

                  <input  type="email"
                          id="email" name='email' value="@if(isset($trabajador)){{old('email',$trabajador->email)}}@else{{old('email')}}@endif" placeholder="Correo Electronico"
                          required = "" parsley-type="email"
                          autocomplete="off" class="form-control input-sm" data-aw="7"/>

                    @include('error.erroresvalidate', [ 'id' => $errors->has('email')  , 
                                                        'error' => $errors->first('email', ':message') , 
                                                        'data' => '7'])
                </div>
              </div> 

              
              <div class="form-group">

                <label class="col-sm-12 control-label labelleft">Estado Civil <span class="required">*</span></label>
                <div class="col-sm-7 abajocaja">
                  {!! Form::select( 'estadocivil_id', $comboestadocivil, array(),
                                    [
                                      'class'       => 'form-control control input-sm' ,
                                      'id'          => 'estadocivils_id',
                                      'required'    => '',
                                      'data-aw'     => '8'
                                    ]) !!}
                </div>
              </div>

          </div>

            </div>
        </div>

        <ul class="list-unstyled list-inline pull-right">
         <li><button type="button" class="btn btn-info next-step">Siguiente <i class="fa fa-chevron-right"></i></button></li>
        </ul>
     </div>

     <div id="menu2" class="tab-pane fade">
        <h3></h3>

        <div class="row">

          <div class="col-sm-6">
            <div class="panel-body">

                <div class="form-group">
                    <label class="col-sm-12 control-label labelleft">
                      Fecha Inicio <span class="required">*</span>
                    </label>
                    <div class="col-sm-7 abajocaja">
                      <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                            <input size="16" type="text" value="@if(isset($trabajador)){{old('fechainicio',$trabajador->fechainicio)}}@else{{old('fechafin')}}@endif" placeholder="Fecha Inicio"
                            id='fechainicio' name='fechainicio' 
                            required = ""
                            class="form-control input-sm">
                            <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                      </div>
                    </div>
                </div> 


                <div class="form-group">
                     <label class="col-sm-12 control-label labelleft">
                      Fecha Fin <span class="required">*</span>
                     </label> 
                     <div class="col-sm-7 abajocaja">
                       <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                                <input size="16" type="text" value="@if(isset($trabajador)){{old('fechafin',$trabajador->fechafin)}}@else{{old('fechafin')}}@endif"     placeholder="Fecha Fin"
                                id='fechafin' name='fechafin' 
                                 required = ""
                                 class="form-control input-sm">
                                 <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                        </div>
                     </div>
                </div>

                <div class="form-group">
                     <label class="col-sm-12 control-label labelleft">Tipo Trabajador <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'tipotrabajador_id', $combotipotrabajador, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'tipotrabajador_id',
                                            'required'    => '',
                                            'data-aw'     => '19'
                                          ]) !!}
                      </div>
                </div>


                <div class="form-group">
                     <label class="col-sm-12 control-label labelleft">Regimen Laboral <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'regimenlaboral_id', $comboregimenlaboral, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'regimenlaboral_id',
                                            'required'    => '',
                                            'data-aw'     => '19'
                                          ]) !!}
                      </div>
                </div>


                <div class="form-group">
                     <label class="col-sm-12 control-label labelleft">Categoria Ocupacional <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'categoriaocupacional_id', $combocategoriaocupacional, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'categoriaocupacional_id',
                                            'required'    => '',
                                            'data-aw'     => '19'
                                          ]) !!}
                      </div>
                </div>


                <div class="form-group">
                     <label class="col-sm-12 control-label labelleft">Ocupacion <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'ocupacion_id', $comboocupacion, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'ocupacion_id',
                                            'required'    => '',
                                            'data-aw'     => '19'
                                          ]) !!}
                      </div>
                </div>


                <div class="form-group">
                    <label class="col-sm-12 control-label labelleft">¿Discapacitado? <span class="required">*</span></label>
                    <div class="col-sm-7 abajocaja">
                      <div class="be-radio has-success inline">
                          <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->discapacidad == 1) checked  @endif @else checked @endif name="discapacidad" id="rad3">
                          <label for="rad3">Sí</label>
                      </div>
                      <div class="be-radio has-danger inline">
                          <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->discapacidad == 0) checked  @endif @endif name="discapacidad" id="rad4">
                          <label for="rad4">No</label>
                      </div>
                    </div>
                </div>

          
            </div>
      
          </div>

          <div class="col-sm-6">

                <div class="panel-body">

                   <div class="form-group ">
                      <label class="col-sm-12 control-label labelleft">¿Sindicalizado? <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        <div class="be-radio has-success inline">
                          <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->sindicalizado == 1) checked  @endif @else checked @endif name="sindicalizado" id="rad5">
                          <label for="rad5">Sí</label>
                        </div>
                        <div class="be-radio has-danger inline">
                          <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->sindicalizado == 0) checked  @endif @endif name="sindicalizado" id="rad6">
                          <label for="rad6">No</label>
                        </div>
                      </div>
                    </div>


                    <div class="form-group">

                      <label class="col-sm-12 control-label labelleft">Situación Especial <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'situacionespecial_id', $combosituacionespecial, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'situacionespecial_id',
                                            'required'    => '',
                                            'data-aw'     => '21'
                                          ]) !!}
                      </div>
                    </div>

                    <div class="form-group">

                      <label class="col-sm-12 control-label labelleft">Local <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'local_id', $combolocal, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'local_id',
                                            'required'    => '',
                                            'data-aw'     => '21'
                                          ]) !!}
                      </div>
                    </div>
                    

                    <div class="form-group">

                      <label class="col-sm-12 control-label labelleft">Situación <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'situacion_id', $combosituacion, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'situacion_id',
                                            'required'    => '',
                                            'data-aw'     => '28'
                                          ]) !!}
                      </div>
                    </div>

                    
                    <div class="form-group">

                      <label class="col-sm-12 control-label labelleft">Motivo Baja <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'motivobaja_id', $combomotivobaja, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'motivobaja_id',
                                            'required'    => '',
                                            'data-aw'     => '26'
                                          ]) !!}
                      </div>
                    </div>


                    <div class="form-group">

                      <label class="col-sm-12 control-label labelleft">Entidad Financiera <span class="required">*</span></label>
                      <div class="col-sm-7 abajocaja">
                        {!! Form::select( 'entidadfinanciera_id', $comboentidadfinanciera, array(),
                                          [
                                            'class'       => 'form-control control input-sm' ,
                                            'id'          => 'entidadfinanciera_id',
                                            'required'    => '',
                                            'data-aw'     => '27'
                                          ]) !!}
                      </div>
                    </div>

                </div>

          </div>

        </div>

        
        <ul class="list-unstyled list-inline pull-right">
         <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i> Atrás</button></li>
         <li><button type="button" class="btn btn-info next-step">Siguiente <i class="fa fa-chevron-right"></i></button></li>
        </ul>
     </div>

     <div id="menu3" class="tab-pane fade">
        <h3></h3>
        <div class="row">

                <div class="col-sm-6">
                  <div class="panel-body">

                      <div class="form-group">
                          <label class="col-sm-12 control-label labelleft">Nivel Instruccion <span class="required">*</span></label>
                          <div class="col-sm-5 abajocaja">
                            {!! Form::select( 'situacioneducativa_id', $combosituacioneducativa, array(),
                                          [
                                      'class'       => 'form-control control input-sm' ,
                                      'id'          => 'situacioneducativa_id',
                                      'required'    => '',
                                      'data-aw'     => '28'
                                    ]) !!}
                          </div>
                      </div>

                      
                      <div class="form-group">

                          <label class="col-sm-12 control-label labelleft">¿Estudios en Perú? <span class="required">*</span></label>
                          <div class="col-sm-5 abajocaja">
                            <div class="be-radio has-success inline">
                              <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->estudiosperu == 1) checked  @endif @else checked @endif name="estudiosperu" id="rad20">
                              <label for="rad20">Sí</label>
                            </div>
                            <div class="be-radio has-danger inline">
                              <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->estudiosperu == 0) checked  @endif @endif name="estudiosperu" id="rad21">
                              <label for="rad21">No</label>
                            </div>
                          </div>
                      </div>

                      <div class="form-group">

                            <label class="col-sm-12 control-label labelleft">Regimen Institucion <span class="required">*</span></label>
                            <div class="col-sm-5 abajocaja">
                                {!! Form::select( 'regimeninstitucion_id', $comboregimeninstitucion, array(),
                                                  [
                                                    'class'       => 'form-control control input-sm' ,
                                                    'id'          => 'regimeninstitucion_id',
                                                    'required'    => '',
                                                    'data-aw'     => '10'
                                                  ]) !!}
                            </div>
                      </div>


                      <div class="form-group ajaxtipoinstitucion">

                          <label class="col-sm-12 control-label labelleft">Tipo Institucion <span class="required">*</span></label>
                          <div class="col-sm-5 abajocaja">
                            {!! Form::select( 'tipoinstitucion_id', $combotipoinstitucion, array(),
                                              [
                                                'class'       => 'form-control control input-sm' ,
                                                'id'          => 'tipoinstitucion_id',
                                                'required'    => '',
                                                'data-aw'     => '11'
                                              ]) !!}
                          </div>
                      </div>
          
                  </div>
                </div>

                <div class="col-sm-6">

                    <div class="panel-body">


                            <div class="form-group ajaxinstitucion">
                                  <label class="col-sm-12 control-label labelleft">Institucion<span class="required">*</span></label>
                                  <div class="col-sm-5 abajocaja">
                                    {!! Form::select( 'institucion_id', $comboinstitucion, array(),
                                                      [
                                                        'class'       => 'form-control control input-sm' ,
                                                        'id'          => 'institucion_id',
                                                        'required'    => '',
                                                        'data-aw'     => '12'
                                                      ]) !!}
                                  </div>
                            </div>

                            <div class="form-group ajaxcarrera">
                                  <label class="col-sm-12 control-label labelleft">Carrera <span class="required">*</span></label>
                                  <div class="col-sm-5 abajocaja">
                                    {!! Form::select( 'carrera_id', $combocarrera, array(),
                                                      [
                                                        'class'       => 'form-control control input-sm' ,
                                                        'id'          => 'carrera_id',
                                                        'required'    => '',
                                                        'data-aw'     => '12'
                                                      ]) !!}
                                  </div>
                            </div>

                            <div class="form-group">
                                  <label class="col-sm-12 control-label labelleft">Año Egreso  <span class="required">*</span></label>
                                  <div class="col-sm-5 abajocaja">

                                    <input  type="text"
                                            id="añoegreso" name='añoegreso' value="@if(isset($trabajador)){{old('añoegreso',$trabajador->añoegreso)}}@else{{old('añoegreso')}}@endif" placeholder="Año Egreso"
                                            required = "" data-parsley-minlength="4" data-parsley-maxlength="4"  data-parsley-type="number"
                                            autocomplete="off" class="form-control input-sm" data-aw="6"/>

                                  </div>
                            </div>
                    </div>
                </div>

            </div>

        <ul class="list-unstyled list-inline pull-right">
         <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i>Atrás</button></li>
         <li><button type="button" class="btn btn-info next-step">Siguiente <i class="fa fa-chevron-right"></i></button></li>
        </ul>
     </div>

     <div id="menu4" class="tab-pane fade">
        <h3></h3>


            <div class="row">

              <div class="col-sm-6">
                <div class="panel-body">

                    <div class="form-group">

                        <label class="col-sm-12 control-label labelleft">País <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          {!! Form::select( 'pais_id', $combopais, array(),
                                            [
                                              'class'       => 'form-control control input-sm' ,
                                              'id'          => 'paises_id',
                                              'required'    => '',
                                              'data-aw'     => '9'
                                            ]) !!}
                        </div>
                    </div>

                    <div class="form-group">

                        <label class="col-sm-12 control-label labelleft">Departamento <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          {!! Form::select( 'departamento_id', $combodepartamento, array(),
                                            [
                                              'class'       => 'form-control control input-sm' ,
                                              'id'          => 'departamentos_id',
                                              'required'    => '',
                                              'data-aw'     => '10'
                                            ]) !!}
                        </div>
                    </div>
                    



                    <div class="form-group ajaxprovincia">

                       @include('general.ajax.comboprovincia', ['comboprovincia' => $comboprovincia])

                    </div>

                  <div class="form-group ajaxdistrito">

                        @include('general.ajax.combodistrito', ['combodistrito' => $combodistrito])
                  </div>


                  <div class="form-group">

                        <label class="col-sm-12 control-label labelleft">Tipo Vía <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          {!! Form::select( 'tipovia_id', $combotipovia, array(),
                                            [
                                              'class'       => 'form-control control input-sm' ,
                                              'id'          => 'tipovias_id',
                                              'required'    => '',
                                              'data-aw'     => '11'
                                            ]) !!}
                        </div>
                  </div>

                  <div class="form-group">
                        <label class="col-sm-12 control-label labelleft" >Nombre Vía <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">

                          <input  type="text"
                                  id="nombrevia" name='nombrevia' value="@if(isset($trabajador)){{old('nombrevia',$trabajador->nombrevia)}}@else{{old('nombrevia')}}@endif" placeholder="Nombre Vía"
                                  required = ""
                                  autocomplete="off" class="form-control input-sm" data-aw="12"/>

                        </div>
                  </div>

              
                </div>
          
              </div>

              <div class="col-sm-6">

                    <div class="panel-body">

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">Número Vía <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">

                          <input  type="text"
                                  id="numerovia" name='numerovia' value="@if(isset($trabajador)){{old('numerovia',$trabajador->numerovia)}}@else{{old('numerovia')}}@endif" placeholder="Número Vía"
                                  required = ""
                                  autocomplete="off" class="form-control input-sm" data-aw="13"/>

                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">Interior <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">

                          <input  type="text"
                                  id="interior" name='interior' value="@if(isset($trabajador)){{old('interior',$trabajador->interior)}}@else{{old('interior')}}@endif" placeholder="Interior"
                                  required = ""
                                  autocomplete="off" class="form-control input-sm" data-aw="14"/>

                        </div>
                      </div>


                      <div class="form-group">

                        <label class="col-sm-12 control-label labelleft">Tipo Zona <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          {!! Form::select( 'tipozona_id', $combotipozona, array(),
                                            [
                                              'class'       => 'form-control control input-sm' ,
                                              'id'          => 'tipozonas_id',
                                              'required'    => '',
                                              'data-aw'     => '15'
                                            ]) !!}
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">Nombre Zona <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">

                          <input  type="text"
                                  id="nombrezona" name='nombrezona' value="@if(isset($trabajador)){{old('nombrezona',$trabajador->nombrezona)}}@else{{old('nombrezona')}}@endif" placeholder="Nombre Zona"
                                  required = ""
                                  autocomplete="off" class="form-control input-sm" data-aw="16"/>

                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">Referencia <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">

                          <input  type="text"
                                  id="referencia" name='referencia' value="@if(isset($trabajador)){{old('referencia',$trabajador->referencia)}}@else{{old('referencia')}}@endif" placeholder="Referencia"
                                  required = ""
                                  autocomplete="off" class="form-control input-sm" data-aw="17"/>

                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">Domiciliado <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          <div class="be-radio has-success inline">
                              <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->domiciliado == 1) checked  @endif @else checked @endif name="domiciliado" id="rad17">
                              <label for="rad17">Sí</label>
                          </div>
                          <div class="be-radio has-danger inline">
                              <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->domiciliado == 0) checked  @endif @endif name="domiciliado" id="rad18">
                              <label for="rad18">No</label>
                          </div>
                        </div>
                      </div> 

                    </div>

              </div>
              
            </div>
        <ul class="list-unstyled list-inline pull-right">
         <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i>Atrás</button></li>
         <li><button type="button" class="btn btn-info next-step">Siguiente<i class="fa fa-chevron-right"></i></button></li>
        </ul>
       </div>


     <div id="menu5" class="tab-pane fade">
           <h3></h3>

            <div class="row">

                <div class="col-sm-6">
                  <div class="panel-body">

                      <div class="form-group">
                          <label class="col-sm-12 control-label labelleft">Tipo Contrato <span class="required">*</span></label>
                          <div class="col-sm-7 abajocaja">
                           {!! Form::select( 'tipocontrato_id', $combotipocontrato, array(),
                                              [
                                                'class'       => 'form-control control input-sm' ,
                                                'id'          => 'tipocontrato_id',
                                                'required'    => '',
                                                'data-aw'     => '20'
                                              ]) !!}
                          </div>
                      </div>


                      <div class="form-group ajaxcargo">
                          @include('general.ajax.combocargo', ['combocargo' => $combocargo])
                      </div>

                      
                      <div class="form-group">

                          <label class="col-sm-12 control-label labelleft">Jornada Laboral <span class="required">*</span></label>
                          <div class="col-sm-7 abajocaja">
                            {!! Form::select( 'jornadalaboral_id', $combojornadalaboral, array(),
                                              [
                                                'class'       => 'form-control control input-sm' ,
                                                'id'          => 'jornadalaboral_id',
                                                'required'    => '',
                                                'data-aw'     => '21'
                                              ]) !!}
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
                </div>

                <div class="col-sm-6">

                    <div class="panel-body">



                            <div class="form-group">

                                <label class="col-sm-12 control-label labelleft">Tipo Pago <span class="required">*</span></label>
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

                            <div class="form-group">
                                  <label class="col-sm-12 control-label labelleft">Número Cuenta <span class="required">*</span></label>
                                  <div class="col-sm-7 abajocaja">

                                    <input  type="text"
                                            id="numerocuenta" name='numerocuenta' value="@if(isset($trabajador)){{old('numerocuenta',$trabajador->numerocuenta)}}@else{{old('numerocuenta')}}@endif" placeholder="Número Cuenta"
                                            required = ""
                                            autocomplete="off" class="form-control input-sm" data-aw="23"/>

                                  </div>
                            </div>

                            <div class="form-group">
                                  <label class="col-sm-12 control-label labelleft">Remuneración <span class="required">*</span></label>
                                  <div class="col-sm-7 abajocaja">

                                    <input  type="text"
                                            id="remuneracion" name='remuneracion' value="@if(isset($trabajador)){{old('remuneracion',$trabajador->remuneracion)}}@else{{old('remuneracion')}}@endif" placeholder="Remuneración"
                                            required = "" data-parsley-type="number"
                                            autocomplete="off" class="form-control input-sm" data-aw="25"/>

                                  </div>
                            </div>
                    </div>
                </div>

            </div>
            <ul class="list-unstyled list-inline pull-right">
              <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i>Atrás</button></li>
              <li><button type="button" class="btn btn-info next-step">Siguiente <i class="fa fa-chevron-right"></i></button></li>
            </ul>
            
     </div>
    

     <div id="menu6" class="tab-pane fade">
        <h3></h3>
        <div class="row">

              <div class="col-sm-6">
                <div class="panel-body">

                     <div class="form-group">

                          <label class="col-sm-12 control-label labelleft">Regimen Salud <span class="required">*</span></label>
                          <div class="col-sm-7 abajocaja">
                            {!! Form::select( 'regimensalud_id', $comboregimensalud, array(),
                                              [
                                                'class'       => 'form-control control input-sm' ,
                                                'id'          => 'regimensalud_id',
                                                'required'    => '',
                                                'data-aw'     => '29'
                                              ]) !!}
                          </div>
                     </div>

                     <div class="form-group">

                          <label class="col-sm-12 control-label labelleft">Regimen Pensionario <span class="required">*</span> </label>
                          <div class="col-sm-7 abajocaja">
                            {!! Form::select( 'regimenpensionario_id', $comboregimenpensionario, array(),
                                              [
                                                'class'       => 'form-control control input-sm',
                                                'id'          => 'regimenpensionario_id',
                                                'required'    => '',
                                                'data-aw'     => '30'
                                              ]) !!}
                          </div>
                      </div>

                      <div class="form-group">
                          <label class="col-sm-12 control-label labelleft">CUSSP </label>
                          <div class="col-sm-7 abajocaja">

                            <input  type="text"
                                    id="cussp" name='cussp' value="@if(isset($trabajador)){{old('dni',$trabajador->dni)}}@else{{old('dni')}}@endif" placeholder="Cussp"
                                    required = "" data-parsley-type="number"
                                    autocomplete="off" class="form-control input-sm" data-aw="6"/>

                          </div>
                      </div>

                      <div class="form-group">
                          <label class="col-sm-12 control-label labelleft">ESSALUD <span class="required">*</span></label>
                          <div class="col-sm-7 abajocaja">
                            <div class="be-radio has-success inline">
                              <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->essaludvida == 1) checked  @endif @else checked @endif name="essaludvida" id="rad9">
                              <label for="rad9">Sì</label>
                            </div>
                            <div class="be-radio has-danger inline">
                              <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->essaludvida == 0) checked  @endif @endif name="essaludvida" id="rad10">
                              <label for="rad10">No</label>
                            </div>
                          </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">SENATI <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          <div class="be-radio has-success inline">
                            <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->senati == 1) checked  @endif @else checked @endif name="senati" id="rad11">
                            <label for="rad11">Sí</label>
                          </div>
                          <div class="be-radio has-danger inline">
                            <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->senati == 0) checked  @endif @endif name="senati" id="rad12">
                            <label for="rad12">No </label>
                          </div>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">SCTR Salud <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          <div class="be-radio has-success inline">
                            <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->sctrsalud == 1) checked  @endif @else checked @endif name="sctrsalud" id="rad13">
                            <label for="rad13">Essalud</label>
                          </div>
                          <div class="be-radio has-danger inline">
                            <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->sctrsalud == 0) checked  @endif @endif name="sctrsalud" id="rad14">
                            <label for="rad14">Eps</label>
                          </div>
                        </div>
                      </div>

                      <div class="form-group">
                        <label class="col-sm-12 control-label labelleft">SCTR Pensiones <span class="required">*</span></label>
                        <div class="col-sm-7 abajocaja">
                          <div class="be-radio has-success inline">
                            <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->sctrpensiones == 1) checked  @endif @else checked @endif name="sctrpensiones" id="rad15">
                            <label for="rad15">Onp</label>
                          </div>
                          <div class="be-radio has-danger inline">
                            <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->sctrpensiones == 0) checked  @endif @endif name="sctrpensiones" id="rad16">
                            <label for="rad16">Seguro Privado</label>
                          </div>
                        </div>
                      </div>

              
                </div>
          
              </div>

              <div class="col-sm-6">

                  <div class="panel-body">

                          <div class="form-group">
                                <label class="col-sm-12 control-label labelleft">¿Afiliado a EPS? <span class="required">*</span></label>
                                <div class="col-sm-7 abajocaja">
                                  <div class="be-radio has-success inline">
                                    <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->afiliadoeps == 1) checked  @endif @else checked @endif name="afiliadoeps" id="rad7">
                                    <label for="rad7">Sí</label>
                                  </div>
                                  <div class="be-radio has-danger inline">
                                    <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->afiliadoeps == 0) checked  @endif @endif name="afiliadoeps" id="rad8">
                                    <label for="rad8">No</label>
                                  </div>
                                </div>
                          </div>

                          <div class="form-group">

                                <label class="col-sm-12 control-label labelleft">EPS <span class="required">*</span></label>
                                <div class="col-sm-7 abajocaja">
                                  {!! Form::select( 'codigoeps_id', $combocodigoeps, array(),
                                                    [
                                                      'class'       => 'form-control control input-sm' ,
                                                      'id'          => 'codigoeps_id',
                                                      'required'    => '',
                                                      'data-aw'     => '28'
                                                    ]) !!}
                                </div>
                          </div>

                          <div class="form-group">
                              <label class="col-sm-12 control-label grande labelleft" >¿Otros ingresos?</label>

                              <div class="col-sm-7 abajocaja">
                                <div class="be-radio has-success inline">
                                  <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->rentaquinta == 1) checked  @endif @else checked @endif name="rentaquinta" id="rad22">
                                  <label for="rad22">Sí</label>
                                </div>
                                <div class="be-radio has-danger inline">
                                  <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->rentaquinta == 0) checked  @endif @endif name="rentaquinta" id="rad23">
                                  <label for="rad23">No</label>
                                </div>
                              </div>
                          </div>

                          <div class="form-group">
                            <label class="col-sm-12 control-label labelleft">¿5ta Exonerada?</label>
                            <div class="col-sm-7 abajocaja">
                              <div class="be-radio has-success inline">
                                <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->quintaexonerada == 1) checked  @endif @else checked @endif name="quintaexonerada" id="rad24">
                                <label for="rad24">Sí</label>
                              </div>
                              <div class="be-radio has-danger inline">
                                <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->quintaexonerada == 0) checked  @endif @endif name="quintaexonerada" id="rad25">
                                <label for="rad25">No</label>
                              </div>
                            </div>
                          </div>

                          <div class="form-group">
                            <label class="col-sm-12 control-label labelleft">¿Asignación Familiar? <span class="required">*</span></label>
                            <div class="col-sm-7 abajocaja">
                              <div class="be-radio has-success inline">
                                <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->asignacionfamiliar == 1) checked  @endif @else checked @endif name="asignacionfamiliar" id="rad26">
                                <label for="rad26">Sí</label>
                              </div>
                              <div class="be-radio has-danger inline">
                                <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->asignacionfamiliar == 0) checked  @endif @endif name="asignacionfamiliar" id="rad27">
                                <label for="rad27">No</label>
                              </div>
                            </div>
                          </div>

                          <div class="form-group">
                              <label class="col-sm-12 control-label labelleft">Activo <span class="required">*</span></label>
                              <div class="col-sm-7 abajocaja">
                                <div class="be-radio has-success inline">
                                  <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->activo == 1) checked  @endif @else checked @endif name="activo" id="rad28">
                                  <label for="rad28">Activado</label>
                                </div>
                                <div class="be-radio has-danger inline">
                                  <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->activo == 0) checked  @endif @endif name="activo" id="rad29">
                                  <label for="rad29">Desactivado</label>
                                </div>
                              </div>
                            </div>

                  </div>
              </div>

        </div>

          <ul class="list-unstyled list-inline pull-right">
           <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i> Atrás</button></li>
           <li><button type="button" class="btn btn-info next-step">Siguiente <i class="fa fa-chevron-right"></i></button></li>
          </ul>
     </div>

     <div id="menu7" class="tab-pane fade">
          <h3></h3>
          <center><p>¿Seguro que desea guardar esta ficha?</p></center>

          <ul class="list-unstyled list-inline pull-right">
            <p class="text-center">
                 <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i> Atrás</button></li>
                 <li><button type="submit" id='guardartrabajador' class="btn btn-space btn-primary btn btn-success "><i class="fa fa-check"></i>Guardar</button></li>             
            </p>           
          </ul>
     </div>

  </div>
  </div>
 </div>
</div>