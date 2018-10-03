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


              <div class="process-step">
                 <button type="button" class="btn btn-default btn-circle" data-toggle="tab" href="#menu2"><i class="fa fa-check fa-2x"></i></button>
                 <p><small>Guardar<br />Contrato</small></p>
              </div>

           </div>
        </div>
        <div class="tab-content">
             <div id="menu1" class="tab-pane fade active in">
                <h3></h3>
                <div class="row">
                    <div class="col-sm-6">
                    <div class="panel-body">
                         <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Fec Desde <span class="required">*</span>
                            </label> 
                            <div class="col-sm-7">
                              <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                                        <input size="16" type="text" value="@if(isset($contrato)){{old('fechainicio',$contrato->fechainicio)}}@else{{old('fechainicio')}}@endif" placeholder="Fecha Desde"
                                        id='fechainicio' name='fechainicio' 
                                        required = ""
                                        class="form-control input-sm">
                                        <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                              </div>
                            </div>
                          </div>

                          <div class="form-group">
                            <label class="col-sm-3 control-label">
                              Fecha Hasta <span class="required">*</span>
                            </label> 
                            <div class="col-sm-7">
                              <div data-min-view="2" data-date-format="dd-mm-yyyy"  class="input-group date datetimepicker">
                                        <input size="16" type="text" value="@if(isset($contrato)){{old('fechafin',$contrato->fechafin)}}@else{{old('fechafin')}}@endif" placeholder="Fecha Hasta"
                                        id='fechafin' name='fechafin' 
                                        required = ""
                                        class="form-control input-sm">
                                        <span class="input-group-addon btn btn-primary"><i class="icon-th mdi mdi-calendar"></i></span>
                              </div>
                            </div>
                          </div>

                          <div class="form-group">
                              <label class="col-sm-3 control-label">Empresa <span class="required">*</span></label>
                              <div class="col-sm-7">

                                <input  type="text"
                                        id="empresa" name='empresa' value="@if(isset($contrato)){{old('empresa',$contrato->empresa)}}@else{{old('empresa')}}@endif" placeholder="Empresa"
                                        required = ""
                                        autocomplete="off" class="form-control input-sm" data-aw="3"/>
                                        @include('error.erroresvalidate', [ 'id' => $errors->has('empresa')  , 
                                                                    'error' => $errors->first('empresa', ':message') , 
                                                                    'data' => '2'])

                              </div>
                          </div>



                          
                      </div>
              
                    </div>

                    <div class="col-sm-6">

                        <div class="panel-body">

                          <div class="form-group">
                              <label class="col-sm-3 control-label">Observación <span class="required">*</span></label>
                              <div class="col-sm-7">

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
                              <label class="col-sm-3 control-label">Estado <span class="required">*</span></label>
                              <div class="col-sm-7">
                                <div class="be-radio has-success inline">
                                  <input type="radio" value='1' @if(isset($trabajador)) @if($trabajador->estado == 1) checked  @endif @else checked @endif name="estado" id="rad1">
                                  <label for="rad1">Pendiente</label>
                                </div>
                                <div class="be-radio has-danger inline">
                                  <input type="radio" value='0' @if(isset($trabajador)) @if($trabajador->estado == 0) checked  @endif @endif name="estado" id="rad2">
                                  <label for="rad2">Concluido</label>
                                </div>
                              </div>
                          </div>  

                          <div class="form-group ">

                            <label class="col-sm-3 control-label" >Tipo Contrato  <span class="required">*</span> </label>
                            <div class="col-sm-7" >
                              {!! Form::select( 'tipocontratotrabajador_id', $combotipocontratotrabajador, array(),
                                                [
                                                  'class'       => 'form-control control input-sm' ,
                                                  'id'          => 'tipocontratotrabajador_id',
                                                  'required'    => '',
                                                  'data-aw'     => '1'
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
                <center><p>¿Seguro que desea guardar el Contrato?</p></center>

                <ul class="list-unstyled list-inline pull-right">
                    <p class="text-center">
                            <li><button type="button" class="btn btn-default prev-step"><i class="fa fa-chevron-left"></i> Atrás</button></li>
                            <li><button type="submit" id='guardarcontrato' class="btn btn-space btn-primary btn btn-success "><i class="fa fa-check"></i>Guardar</button></li>
                                      
                    </p>                
                </ul>
             </div>

        </div>
   </div>
</div>
