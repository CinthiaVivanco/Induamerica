<label class="col-sm-3 control-label">Tipo Institucion</label>
<div class="col-sm-5">
  {!! Form::select( 'tipoinstitucion_id', $combotipoinstitucion, array(),
                    [
                      'class'       => 'form-control control input-sm' ,
                      'id'          => 'tipoinstitucion_id',
                      'required'    => '',
                      'data-aw'     => '11'
                    ]) !!}
</div>