  <label class="col-sm-3 control-label">Carrera</label>
  <div class="col-sm-5">
    {!! Form::select( 'carrera_id', $combocarrera, array(),
                      [
                        'class'       => 'form-control control input-sm' ,
                        'id'          => 'carrera_id',
                        'required'    => '',
                        'data-aw'     => '12'
                      ]) !!}
  </div>