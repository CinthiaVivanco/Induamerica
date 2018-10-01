  <label class="col-sm-3 control-label">Institucion</label>
  <div class="col-sm-5">
    {!! Form::select( 'institucion_id', $comboinstitucion, array(),
                      [
                        'class'       => 'form-control control input-sm' ,
                        'id'          => 'institucion_id',
                        'required'    => '',
                        'data-aw'     => '12'
                      ]) !!}
  </div>