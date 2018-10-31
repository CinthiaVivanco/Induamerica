<div class="containertab">
   <div class="row">
      <div class="process">
           <div class="process-row nav nav-tabs">
              <div class="process-step tabmnu1">
                 <button type="button" class="btn btn-info btn-circle" data-toggle="tab" href="#menu1"><i class="fa fa-pencil-square-o fa-2x"></i></button>
                 <p><small>Datos del<br />Contrato</small></p>
                 <div class='errortab'>
                   <i class="fa fa-exclamation" aria-hidden="true"></i> 
                 </div>
                 <div class='bientab'>
                   <i class="fa fa-check" aria-hidden="true"></i> 
                 </div>
              </div>  
              <div class="process-step tabmnu2">
                 <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu2"><i class="fa fa-usd fa-2x"></i></button>
                 <p><small>Datos del<br />Pago</small></p>
                 <div class='errortab'>
                   <i class="fa fa-exclamation" aria-hidden="true"></i> 
                 </div>
                 <div class='bientab'>
                   <i class="fa fa-check" aria-hidden="true"></i> 
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

                            <label class="col-sm-12 control-label labelleft" >Tipo Contrato  <span class="required">*</span> </label>
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
                              Fecha Inicio <span class="required">*</span>
                            </label> 
                            <div class="col-sm-6 abajocaja">
                              <div data-min-view="2" data-date-format="dd-mm-yyyy" data-parsley-min='29-10-2018' class="input-group date datetimepicker">
                                        <input size="16" type="text" 
                                        value="@if(isset($contrato)){{old('fechainicio',$contrato->fechainicio)}}@else{{old('fechainicio')}}@endif" 
                                        placeholder="Fecha Desde"
                                        id='fechainicio' 
                                        name='fechainicio' 
                                        required = ""

                                        class="form-control input-sm ">
                                        <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                              </div>
                            </div>
                          </div>

                          <div class="form-group">
                            <label class="col-sm-12 control-label labelleft">
                              Fecha Fin <span class="required">*</span>
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

                       </div>
              
                    </div>

                    <div class="col-sm-6">

                        <div class="panel-body">
           

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

                          <div class="form-group">
                              <label class="col-sm-12 control-label labelleft">Observación <span class="required">*</span></label>
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
                              <label class="col-sm-12 control-label labelleft">Estado <span class="required">*</span></label>
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

                    
                        </div>

                    </div>
                </div>

             </div>  

             <div id="menu2" class="tab-pane fade" >
                <h3></h3>
                <div class="row" >
                    

                    <div class="col-md-6 col-md-offset-3 centro">
                      <div class="panel-body">

                           <div class="form-group" >

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

                            <div class="form-group" >
                                  <label class="col-sm-12 control-label labelleft">Número Cuenta <span class="required">*</span></label>
                                  <div class="col-sm-7 abajocaja">

                                    <input  type="text"
                                            id="numerocuenta" name='numerocuenta' value="@if(isset($contrato)){{old('numerocuenta',$contrato->numerocuenta)}}@else{{old('numerocuenta')}}@endif" placeholder="Número Cuenta"
                                            required = ""
                                            autocomplete="off" class="form-control input-sm" data-aw="23"/>

                                  </div>
                            </div>

                            <div class="form-group">
                                  <label class="col-sm-12 control-label labelleft">Remuneración <span class="required">*</span></label>
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

                <ul class="list-unstyled list-inline pull-right">
                    <p class="text-center">
                            
                            <li><button type="submit" id='guardarcontrato' class="btn btn-space btn-primary btn btn-success "><i class="fa fa-check"></i>Guardar</button></li>
                                      
                    </p>                
                </ul>
             </div>          

        </div>
   </div>
</div>
